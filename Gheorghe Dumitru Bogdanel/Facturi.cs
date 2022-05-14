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
    public partial class Facturi : Form
    {
        public Facturi()
        {
            InitializeComponent();
        }

        private void Facturi_Load(object sender, EventArgs e)
        {
            
            refreshGrid();
            filtreazaDetaliu();
        }

        private void refreshGrid()
        {
            facturiContinutTableAdapter.Fill(dataSet1.FacturiContinut);
            facturiTableAdapter.Fill(dataSet1.Facturi);
        }

        private void filtreazaDetaliu()
        {
            try
            {
                facturiContinutBindingSource.Filter = "NrF=" + txtIdFactura.Text;

            }
            catch { }

        }

        private void facturiBindingSource_PositionChanged(object sender, EventArgs e)
        {
            filtreazaDetaliu();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnModificareComanda_Click(object sender, EventArgs e)
        {
            FFacturaAct f = new FFacturaAct();
            f.completeazaTitlu("MODIFICARE FACTURA");
            f.bs1 = facturiBindingSource;
            f.bs2 = facturiContinutBindingSource;
            f.ShowDialog();
            refreshGrid();
        }

        private void btnComandaNoua_Click(object sender, EventArgs e)
        {
            FFacturaAct f = new FFacturaAct();
            f.completeazaTitlu("FACTURA NOUA");
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

            con.ConnectionString = facturiTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            // Sterg continut comanda
            cmd.CommandText = "Delete From FacturaContinut Where IdF = " + textBox1.Text;

            MessageBox.Show("Continutul Facturii cu id-ul" + textBox1.Text + "a fost sters!");

            con.Open();

            cmd.ExecuteNonQuery();

            // Sterg comanda
            cmd.CommandText = "Delete From Factura Where IdF = " + textBox1.Text;
            MessageBox.Show(" Factura cu id-ul" + textBox1.Text + "a fost sters!");
            cmd.ExecuteNonQuery();

            con.Close();

            // Refresh grid-uri
            refreshGrid();
            filtreazaDetaliu();
        }
    }
}
