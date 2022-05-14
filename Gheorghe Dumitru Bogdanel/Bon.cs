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
    public partial class Bon : Form
    {
        public Bon()
        {
            InitializeComponent();
        }

        private void Bon_Load(object sender, EventArgs e)
        {
            //push
            refreshGrid();
            filtreazaDetaliu();

        }

        private void refreshGrid()
        {
            bonContinutTableAdapter.Fill(dataSet1.BonContinut);
            bonTableAdapter.Fill(dataSet1.Bon);
        }

        private void filtreazaDetaliu()
        {
            try
            {
                bonContinutBindingSource.Filter = "IdBon= " + txtIdBon.Text;

            }
            catch { }

        }

        private void bonBindingSource_PositionChanged(object sender, EventArgs e)
        {
            filtreazaDetaliu();
        }

        private void btnModificareComanda_Click(object sender, EventArgs e)
        {
            FBonAct f = new FBonAct();
            f.completeazaTitlu("MODIFICARE BON");
            f.bs1 = bonBindingSource;
            f.bs2 = bonContinutBindingSource;
            f.ShowDialog();
            refreshGrid();
        }

        private void btnComandaNoua_Click(object sender, EventArgs e)
        {
            FBonAct f = new FBonAct();
            f.completeazaTitlu("BON NOU");
            f.ShowDialog();
            refreshGrid();
        }

        private void btnStergeComanda_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";

            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString = bonTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            // Sterg continut comanda
            cmd.CommandText = "Delete From BonContinut Where IdBon = " + txtIdBon.Text;

            MessageBox.Show("Continutul Bonului cu id-ul " + txtIdBon.Text + "a fost sters!");

            con.Open();

            cmd.ExecuteNonQuery();

            // Sterg comanda
            cmd.CommandText = "Delete From Bon Where IdBon = " + txtIdBon.Text;
            MessageBox.Show(" Bonul cu id-ul " + txtIdBon.Text + "a fost sters!");
            cmd.ExecuteNonQuery();

            con.Close();

            // Refresh grid-uri
            refreshGrid();
            filtreazaDetaliu();
        }
    }
}
