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
    public partial class FBonAct : Form
    {

        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        private int idCda;
        public BindingSource bs1;
        public BindingSource bs2;
        public FBonAct()
        {
            InitializeComponent();
        }

        private void FBonAct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Bon' table. You can move, or remove it, as needed.
            this.bonTableAdapter.Fill(this.dataSet1.Bon);
            // TODO: This line of code loads data into the 'dataSet1.Produse' table. You can move, or remove it, as needed.
            this.produseTableAdapter.Fill(this.dataSet1.Produse);
            // TODO: This line of code loads data into the 'dataSet1.Lucrare' table. You can move, or remove it, as needed.
            this.lucrareTableAdapter.Fill(this.dataSet1.Lucrare);
            A1();

        }

        private void A1()
        {
            // TODO: This line of code loads data into the 'dataSet1.Produse' table. You can move, or remove it, as needed.
            this.produseTableAdapter.Fill(this.dataSet1.Produse);
            // TODO: This line of code loads data into the 'dataSet1.Lucrare' table. You can move, or remove it, as needed.
            this.lucrareTableAdapter.Fill(this.dataSet1.Lucrare);

            // Protectie la modificare
            txtNrFactura.ReadOnly = true;
            txtTotal.ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;
           // dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            if (lblOp.Text == "MODIFICARE BON") completeazaComanda();
            else if (lblOp.Text == "BON NOU") cmbClient.SelectedIndex = -1;

        }

        private void A2()
        {
            if (!validareCampuriObligatorii()) return;
            if (lblOp.Text == "MODIFICARE BON")
            {
                modificaInregistrare();
                stergeContinut();
                adaugaInregistrariComenziContinut();
                this.Close();
            }
            else if (lblOp.Text == "BON NOU")
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
            DataRowView current = (DataRowView)bonContinutManevraBindingSource.Current;
            try
            {
                if (bonContinutManevraBindingSource.Position != null && current != null)
                    current["NrCrt"] = bonContinutManevraBindingSource.Position + 1;
            }
            catch { }
        }

        public void completeazaTitlu(String titlu)
        {
            lblOp.Text = titlu;
        }

        private void A4()
        {
            try
            {
                if (bonBindingSource.Current != null)
                {
                    if (dataGridView1.CurrentCell.ColumnIndex == 3)
                    {                     
                            DataRowView current = (DataRowView)produseBindingSource.Current;

                            dataGridView1.CurrentRow.Cells[6].Value = current["IdProdus"];
                            //dataGridView1.CurrentRow.Cells[4].Value = current["Pret"];
                            //string idProdus = current["IdProdus"].ToString();
                       
                       
                        calcTotal();
                    }

                }
                if (bonBindingSource.Current != null)
                    if (dataGridView1.CurrentCell.ColumnIndex == 4)
                    {
                        DataRowView r = (DataRowView)bonContinutManevraBindingSource.Current;
                        int total2 = 0;
                        total2 = (int)r["Cantitate"] * (int)r["PretProdus"];
                        dataGridView1.CurrentRow.Cells[5].Value = (int)total2;
                        calcTotal();
                        bonContinutManevraBindingSource.EndEdit();

                    }
            }
            catch { }
        }

        private void completeazaComanda() // de modificat
        {
            DataRowView current = (DataRowView)bs1.Current;
            DataSet1.BonContinutManevraRow r1 = dataSet1.BonContinutManevra.NewBonContinutManevraRow();

            idCda = (int)current["IdBon"];
            txtNrFactura.Text = Convert.ToString(current["IdBon"]);

            cmbClient.Text = current["DLucrare"].ToString();
            txtTotal.Text = current["Total"].ToString();


            dateTimePicker1.Value = Convert.ToDateTime(current["DataBonContinut"]);

            bs2.MoveFirst();

            dataSet1.BonContinutManevra.Clear();

            if (cmbClient.SelectedValue != null)

                for (int i = 1; i <= bs2.Count; i++)
                {
                    current = (DataRowView)bs2.Current;
                    DataSet1.BonContinutManevraRow r = dataSet1.BonContinutManevra.NewBonContinutManevraRow();
                    r.NrCrt = Convert.ToString(current["NrCrt"]);
                    r.DProdus = Convert.ToString(current["DProdus"]);
                    r.IdProdus = Convert.ToInt32(current["IdProdus"]);
                    r.PretBon = Convert.ToInt32(current["PretBon"]);
                    r.PretProdus = Convert.ToInt32(current["PretProdus"]);
                    r.Cantitate = Convert.ToInt32(current["Cantitate"]);
                    r.IdBon = Convert.ToString(current["IdBon"]);
                    dataSet1.BonContinutManevra.Rows.Add(r);
                    bs2.MoveNext();
                }
            calcTotal();
        }

        private void calcTotal()
        {
            decimal t = 0;
            foreach (DataRow r in dataSet1.BonContinutManevra)
            {
                if (r["PretBon"] != "0")
                    //r.Total = (int)r["PretIntrare"] * (int)r["Cantitate"];
                    t += (int)r["PretBon"];

            }
            txtTotal.Text = Convert.ToString(t);

        }

        private void generez_nr_cda()
        {
            con.ConnectionString = bonTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "SELECT Max(IdBon) AS NrMax FROM Bon";
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
                MessageBox.Show("Completati Denumirea Lucrarii !");
                cmbClient.Focus();
                return false;
            }
            // Validare completare continut
            if (bonContinutManevraBindingSource.Count == 0)
            {
                MessageBox.Show("Completati continut bon !");
                dataGridView1.Focus();
                return false;
            }


            return true;
        }

        private void cautaInregistrare()
        {
            cmd.CommandText = "SELECT IdBon From Bon Where IdBon = " + txtNrFactura.Text;

            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();

            idCda = rdr.GetInt32(0);
            rdr.Close();
            con.Close();
        }

        private void golireCampuri()
        {
            txtNrFactura.Text = "";
            cmbClient.SelectedIndex = -1;
            txtTotal.Text = "";
            dataSet1.BonContinutManevra.Clear();
        }

        private void stergeContinut()
        {
            cmd.CommandText = "Delete from BonContinut Where IdBon = " + idCda;

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void modificaInregistrare()
        {
            DateTime d1 = dateTimePicker1.Value;
            DataRowView current = (DataRowView)bs1.Current;
            con.ConnectionString = bonTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;

            string clauzaWhere = " Where IdBon = " + idCda;

            string clauzaSet = "Set DataBonContinut = #" + d1.Month + "/"
                               + d1.Day + "/"
                               + d1.Year + "#,"
                               + "IdLucrare = " + cmbClient.SelectedValue + " ,Total = " + txtTotal.Text;

            cmd.CommandText = "Update Bon " + clauzaSet + clauzaWhere;

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void adaugaInregistrariComenziContinut()
        {
            string listaCampuri = "IdBon, NrCrt, IdProdus, Cantitate, Pret";
            string listaValori;



            con.Open();
            foreach (DataRow r in dataSet1.BonContinutManevra)
            {
                listaValori = idCda + "," + r["NrCrt"] + "," + r["IdProdus"] + "," + r["Cantitate"] + "," + r["PretBon"];

                cmd.CommandText = "Insert into BonContinut(" + listaCampuri + ") " + "Select " + listaValori;



                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Bon Continut actualizat cu succes!");
            con.Close();
        }

        private void adaugaInregistrareComenzi()
        {
            string listaCampuri;
            string listaValori;
            DateTime d = dateTimePicker1.Value;

            listaCampuri = "IdBon,NrBonContinut, DataBonContinut, IdLucrare, Total ";
            listaValori = txtNrFactura.Text +","+ txtNrFactura.Text +
                          ",#" + Convert.ToString(d.Month) + "/"
                               + Convert.ToString(d.Day) + "/"
                               + Convert.ToString(d.Year) + "#,"
                               + cmbClient.SelectedValue + ","
                               + txtTotal.Text;

            cmd.CommandText = "Insert into Bon(" + listaCampuri + ") " +
                              "Select " + listaValori;

            MessageBox.Show("Bon Continut adaugat cu succes!");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void bonContinutManevraBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            A3();
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
            lucrareTableAdapter.Fill(dataSet1.Lucrare);
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

        private void A5(DataGridViewRowCancelEventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu,
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) e.Cancel = true;
        }


    }
}
