using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gheorghe_Dumitru_Bogdanel
{
    public partial class FFacturaAct : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        private int idCda;
        public BindingSource bs1;
        public BindingSource bs2;

        public FFacturaAct()
        {
            InitializeComponent();
        }

        private void lb1_Click(object sender, EventArgs e)
        {

        }

        private void FFacturaAct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Facturi' table. You can move, or remove it, as needed.
            this.facturiTableAdapter.Fill(this.dataSet1.Facturi);
            // TODO: This line of code loads data into the 'dataSet1.Facturi' table. You can move, or remove it, as needed.
            this.facturiTableAdapter.Fill(this.dataSet1.Facturi);

            A1();
        }

        private void A1()
        {
            // TODO: This line of code loads data into the 'dataSet1.Produse' table. You can move, or remove it, as needed.
            this.produseTableAdapter.Fill(this.dataSet1.Produse);
            // TODO: This line of code loads data into the 'dataSet1.Furnizori' table. You can move, or remove it, as needed.
            this.furnizoriTableAdapter.Fill(this.dataSet1.Furnizori);

            // Protectie la modificare
            txtNrFactura.ReadOnly = true;
            txtTotal.ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            if (lblOp.Text == "MODIFICARE FACTURA") completeazaComanda();
            else if (lblOp.Text == "FACTURA NOUA") cmbClient.SelectedIndex = -1;

        }

        private void A2()
        {
            if (!validareCampuriObligatorii()) return;
            if (lblOp.Text == "MODIFICARE FACTURA")
            {
                modificaInregistrare();
                stergeContinut();
                adaugaInregistrariComenziContinut();
                this.Close();
            }
            else if (lblOp.Text == "FACTURA NOUA")
            {
                generez_nr_cda();
                adaugaInregistrareComenzi();
                cautaInregistrare();
                adaugaInregistrariComenziContinut();
                golireCampuri();
            }
        }

        private void A3()
        {
            // Generare NrCrt
            DataRowView current = (DataRowView)facturaContinutManevraBindingSource.Current;
            try
            {
                if (facturaContinutManevraBindingSource.Position != null && current != null)
                    current["Nrc"] = facturaContinutManevraBindingSource.Position + 1;
            }
            catch { }
        }

        private void A4()
        {
            try
            {
                if (facturiBindingSource.Current != null)
                {
                    if (dataGridView1.CurrentCell.ColumnIndex == 1)
                    {

                        DataRowView current = (DataRowView)produseBindingSource.Current;
                       
                        dataGridView1.CurrentRow.Cells[2].Value = current["IdProdus"];
                       
                        calcTotal();
                    }
                    
                }
                if (facturiBindingSource.Current != null)
                    if (dataGridView1.CurrentCell.ColumnIndex == 4)
                    {
                        DataRowView r =(DataRowView)facturaContinutManevraBindingSource.Current;
                        int total2 = 0;
                        total2 = (int)r["Cantitate"] * (int)r["PretIntrare"];
                        dataGridView1.CurrentRow.Cells[5].Value = (int)total2;
                        calcTotal();
                        facturaContinutManevraBindingSource.EndEdit();
                        
                    }
            }
            catch { }
        }

        private void A5(DataGridViewRowCancelEventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu,
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) e.Cancel = true;
        }

        public void completeazaTitlu(String titlu)
        {
            lblOp.Text = titlu;
        }

        private void completeazaComanda()
        {
            DataRowView current = (DataRowView)bs1.Current;
            DataSet1.FacturaContinutManevraRow r1 = dataSet1.FacturaContinutManevra.NewFacturaContinutManevraRow();

            idCda = (int)current["IdF"];
            txtNrFactura.Text = Convert.ToString(current["NrF"]);

            cmbClient.Text = current["DFurnizor"].ToString();
            txtTotal.Text = current["Total"].ToString();


            dateTimePicker1.Value = Convert.ToDateTime(current["DataF"]);

            bs2.MoveFirst();

            dataSet1.FacturaContinutManevra.Clear();
           
            if (cmbClient.SelectedValue != null)
                
                for (int i = 1; i <= bs2.Count; i++)
                {
                    current = (DataRowView)bs2.Current;
                    DataSet1.FacturaContinutManevraRow r = dataSet1.FacturaContinutManevra.NewFacturaContinutManevraRow();
                    r.Nrc = Convert.ToString(current["Nrc"]);
                    r.DProdus = Convert.ToString(current["DProdus"]);
                    r.IdProdus = Convert.ToInt32(current["IdProdus"]);
                    r.PretIntrare = Convert.ToInt32(current["PretIntrare"]);
                    r.Cantitate = Convert.ToInt32(current["Cantitate"]);
                    r.NrF = Convert.ToString(current["NrF"]);
                    r.DFurnizor = Convert.ToString(current["DFurnizor"]);                
                    r.Total = (int)r["PretIntrare"]*(int)r["Cantitate"];
                    dataSet1.FacturaContinutManevra.Rows.Add(r);
                    bs2.MoveNext();
                }
            calcTotal();
        }

        private void calcTotal()
        {
            decimal t = 0;
            foreach (DataRow r in dataSet1.FacturaContinutManevra)
            {
                if (r["Total"] !="0")
                //r.Total = (int)r["PretIntrare"] * (int)r["Cantitate"];
                t += (int)r["Total"];
               
            }
            txtTotal.Text = Convert.ToString(t);

        }

        private void generez_nr_cda()
        {
            con.ConnectionString = facturiTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "SELECT Max(IdF) AS NrMax FROM Factura";
            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            txtNrFactura.Text = Convert.ToString(rdr.GetInt32(0) + 1);

            rdr.Close();
            con.Close();
        }

        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campul Client
            if (cmbClient.Text == "")
            {
                MessageBox.Show("Completati Furnizor !");
                cmbClient.Focus();
                return false;
            }
            // Validare completare continut
            if (facturaContinutManevraBindingSource.Count == 0)
            {
                MessageBox.Show("Completati continut factura !");
                dataGridView1.Focus();
                return false;
            }
            return true;
        }

        private void cautaInregistrare()
        {
            cmd.CommandText = "SELECT NrF From Factura Where NrF = " + txtNrFactura.Text;

            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();

            idCda = rdr.GetInt32(0);
            rdr.Close();
            con.Close();
        }

        private void adaugaInregistrareComenzi()
        {
            string listaCampuri;
            string listaValori;
            DateTime d = dateTimePicker1.Value;

            listaCampuri = "NrF, DataF, IdFurnizor, Total ";
            listaValori = txtNrFactura.Text +
                          ",#" + Convert.ToString(d.Month) + "/"
                               + Convert.ToString(d.Day) + "/"
                               + Convert.ToString(d.Year) + "#,"
                               + cmbClient.SelectedValue +","
                               + txtTotal.Text;

            cmd.CommandText = "Insert into Factura(" + listaCampuri + ") " +
                              "Select " + listaValori;

            MessageBox.Show("Factura Continut adaugat cu succes!");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }



        private void adaugaInregistrariComenziContinut()
        {
            string listaCampuri = "IdF, Nrc, IdProdus, Cantitate, PretIntrare";
            string listaValori;



            con.Open();
            foreach (DataRow r in dataSet1.FacturaContinutManevra)
            {
                listaValori = idCda + "," + r["Nrc"] + "," + r["IdProdus"] + "," + r["Cantitate"] + "," + r["PretIntrare"];

                cmd.CommandText = "Insert into FacturaContinut(" + listaCampuri + ") " + "Select " + listaValori;



                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Factura Continut actualizat cu succes!");
            con.Close();
        }

        private void golireCampuri()
        {
            txtNrFactura.Text = "";
            cmbClient.SelectedIndex = -1;
            txtTotal.Text = "";
            dataSet1.FacturaContinutManevra.Clear();
        }


        private void modificaInregistrare()
        {
            DateTime d1 = dateTimePicker1.Value;
            DataRowView current = (DataRowView)bs1.Current;
            con.ConnectionString = facturiTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;

            string clauzaWhere = " Where IdF = " + idCda;

            string clauzaSet = "Set DataF = #" + d1.Month + "/"
                               + d1.Day + "/"
                               + d1.Year + "#,"
                               + "IdFurnizor = " + cmbClient.SelectedValue + " ,Total = " + txtTotal.Text ;

            cmd.CommandText = "Update Factura " + clauzaSet + clauzaWhere;

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void stergeContinut()
        {
            cmd.CommandText = "Delete from FacturaContinut Where IdF = " + idCda;

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void facturaContinutManevraBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            A3();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Format eronat");
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            A5(e);
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            calcTotal();
        }

        public void refreshClienti(int pozitie)
        {
             furnizoriTableAdapter.Fill(dataSet1.Furnizori);
            cmbClient.SelectedIndex = pozitie;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            A4();
        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            A2();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
