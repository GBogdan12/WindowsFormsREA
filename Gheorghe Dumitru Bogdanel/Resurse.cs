using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gheorghe_Dumitru_Bogdanel
{
    public partial class Resurse : Form
    {

        const int DProdusIndex = 0;
        const int UMIndex = 1;
        const int PretIndex = 2;
        public Resurse()
        {
            InitializeComponent();
        }

        private void Resurse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Produse' table. You can move, or remove it, as needed.
            this.produseTableAdapter.Fill(this.dataSet1.Produse);

            config(true);   

        }

        private void config(bool v)
        {
            dataGridView1.AllowUserToAddRows = !v;
            dataGridView1.AllowUserToDeleteRows = !v;

            //Protectie coloane
           dataGridView1.Columns[DProdusIndex].ReadOnly = v;
            dataGridView1.Columns[UMIndex].ReadOnly = true;
           dataGridView1.Columns[PretIndex].ReadOnly = v;
            
            btnActualizare.Enabled = v;
            btnSalvare.Visible = !v;
            btnRenuntare.Visible = !v;
        }
        private void refresh()
        {
            this.produseTableAdapter.Fill(this.dataSet1.Produse);
        }

        private bool completareCampuri()
        {
            bool raspuns = true;
            
            foreach (DataRow r in this.dataSet1.Produse)
            {
                if (r.RowState == DataRowState.Deleted) continue;
                string umc = "BUC";
                DataRowView current = (DataRowView)produseBindingSource.Current;
                current["UM"] = umc.ToString();
                if (r["DProdus"] == DBNull.Value)
                {
                    MessageBox.Show("Completati Denumirea produsului la linia cu Id " + r["IdProdus"]);
                    raspuns = false;
                }               
                
                if (r["Pret"] == DBNull.Value)
                {
                    MessageBox.Show("Completati Pret la linia cu Id " + r["IdProdus"]);
                    raspuns = false;
                }
            }
            return raspuns;
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            config(false);
           
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            config(true);
            refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalvare_Click_1(object sender, EventArgs e)
        {
            if (!completareCampuri()) return;
            try
            {
                produseTableAdapter.Update(dataSet1.Produse);
                config(true);
                refresh();
            }
            catch (Exception exc)
            {
                string s = exc.Message;

                if (s.IndexOf("duplicate values") > 0)
                    MessageBox.Show("Inregistrare deja existenta !");
                else if (s.IndexOf("cannot be deleted") > 0)
                    MessageBox.Show("Ati sters inregistrari referite in alte tabele !");
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (btnRenuntare.Focused)
            {
                dataGridView1.CancelEdit();
                //A3
                config(true);
                refresh();

                return;
            }
            MessageBox.Show("Format eronat");
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) e.Cancel = true;
        }
    }
}
