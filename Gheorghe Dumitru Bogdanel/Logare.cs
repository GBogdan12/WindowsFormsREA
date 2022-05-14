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
    public partial class Logare : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        public Logare()
        {
            InitializeComponent();
        }

        private void lblTitlu_Click(object sender, EventArgs e)
        {

        }

        private void txtParola_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Log In")
            {
                if (Logare_OK()) A1(false);
            }
            else A1(true);
        }

        private void lblUtilizator_Click(object sender, EventArgs e)
        {

        }

        private void txtUtilizator_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAutor_Click(object sender, EventArgs e)
        {

        }

        private void lblParola_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            A1(true);
        }

        private Boolean Logare_OK()
        {
            if (lblUtilizator.Text == "")
            {
                MessageBox.Show("Completati utilizator !");
                txtUtilizator.Focus();
                return false;
            }
            if (lblParola.Text == "")
            {
                MessageBox.Show("Completati parola !");
                lblParola.Focus();
                return false;
            }

            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" +
                                   "Data Source=E:\\Scoala\\anul 3\\Sem2\\medii de proiectare si programare\\proiect\\Database1.mdb";

            cmd.Connection = con;
            cmd.CommandText = "Select IdUtilizator, Parola from Utilizatori where Nume='" + txtUtilizator.Text + "'";
            con.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                if (txtParola.Text != rdr.GetString(1))
                {
                    MessageBox.Show("Parola eronata");
                    lblParola.Focus();
                    con.Close();
                    return false;
                }
                con.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Utilizator eronat");
                lblUtilizator.Focus();
                con.Close();
                return false;
            }



        }

        public void A1(Boolean v)
        {
            menuStrip1.Visible = !v;
            lblTitlu.Visible = !v;
            lblAutor.Visible = !v;
            lblParola.Visible = v;
            txtParola.Visible = v;
            lblUtilizator.Visible = v;
            txtUtilizator.Visible = v;
            if (v) btnStart.Text = "Log In";
            else btnStart.Text = "Log Out";



        }

        private void clientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Resurse c = new Resurse();
            c.ShowDialog();
        }

        private void propietateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculStoc c = new CalculStoc();
            c.ShowDialog();
        }

        private void furnizoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Furnizori c = new Furnizori();
            c.ShowDialog();
        }

        private void impozitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturi c = new Facturi();
            c.ShowDialog();
        }

        private void lucrareNouaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bon c = new Bon();
            c.ShowDialog();
        }

        private void raportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Incasari c = new Incasari();
            c.ShowDialog();
        }

        private void platiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plati c = new Plati();
            c.ShowDialog();
        }

        private void stocRaportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StocRaport c = new StocRaport();
            c.ShowDialog();
        }
    }
}
