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
    public partial class Furnizori : Form
    {
        static int DenumireIndex = 0;
        public Furnizori()
        {
            InitializeComponent();
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

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            if (!completareCampuri()) return;
            try
            {
                furnizoriTableAdapter.Update(dataSet1.Furnizori);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void config(bool v)
        {
            dataGridView1.AllowUserToAddRows = !v;
            dataGridView1.AllowUserToDeleteRows = !v;

            //Protectie coloane
            dataGridView1.Columns[DenumireIndex].ReadOnly = v;

            btnActualizare.Enabled = v;
            btnSalvare.Visible = !v;
            btnRenuntare.Visible = !v;
        }
        private void refresh()
        {
            this.furnizoriTableAdapter.Fill(this.dataSet1.Furnizori);
        }

        private bool completareCampuri()
        {
            bool raspuns = true;

            foreach (DataRow r in this.dataSet1.Furnizori)
            {
                if (r.RowState == DataRowState.Deleted) continue;        
                if (r["DFurnizor"] == DBNull.Value)
                {
                    MessageBox.Show("Completati Denumirea furnizorului la linia cu Id " + r["IdFurnizor"]);
                    raspuns = false;
                }
            }
            return raspuns;
        }

        private void Furnizori_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Furnizori' table. You can move, or remove it, as needed.
            this.furnizoriTableAdapter.Fill(this.dataSet1.Furnizori);
            config(true);
            refresh();

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
