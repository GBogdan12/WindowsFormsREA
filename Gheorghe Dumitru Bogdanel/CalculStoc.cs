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

   
    public partial class CalculStoc : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        public CalculStoc()
        {
            InitializeComponent();
        }

        private void CalculStoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Stoc' table. You can move, or remove it, as needed.
            this.stocTableAdapter.Fill(this.dataSet1.Stoc);
            // TODO: This line of code loads data into the 'dataSet1.CalculStoc' table. You can move, or remove it, as needed.
            this.calculStocTableAdapter.Fill(this.dataSet1.CalculStoc);
            //Configurez obiectele conexiune si comanda
            con.ConnectionString = calculStocTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;

            //Sterg continut tabele CalculStoc si Stoc
            con.Open();
            cmd.CommandText = "Delete * from CalculStoc";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "Delete * from Stoc";
            cmd.ExecuteNonQuery();

            con.Close();

            this.calculStocTableAdapter.Fill(this.dataSet1.CalculStoc);
            this.stocTableAdapter.Fill(this.dataSet1.Stoc);

            con.Open();

            //Stoc Initial
            cmd.CommandText = "Insert into CalculStoc(IdOperatie, Data, IdProdus, Cantitate, Pret) " +
                              "Select 1,Data,IdProdus,Cantitate ,Pret " +
                              "From StocInitial";

            try { cmd.ExecuteNonQuery(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            con.Close();
            //Incarc dataTable-ul CalculStoc
            dataSet1.CalculStoc.Clear();
            calculStocTableAdapter.Fill(this.dataSet1.CalculStoc);


            //Intrari
            con.Open();
            cmd.CommandText = "Insert into CalculStoc(IdOperatie, Data, IdProdus, Cantitate,Pret) " +
                   "Select 3,DataF as Data, IdProdus, Cantitate, -PretIntrare as Pret " +
                   "From Factura f "+
                   "INNER JOIN FacturaContinut bf ON bf.IdF = f.IdF";
            try { cmd.ExecuteNonQuery(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            con.Close();
            //Incarc dataTable-ul CalculStoc
            dataSet1.CalculStoc.Clear();
            calculStocTableAdapter.Fill(this.dataSet1.CalculStoc);

            // Iesiri
            con.Open();

            cmd.CommandText = "Insert into CalculStoc(IdOperatie, Data,IdProdus, Cantitate, Pret) " +
                              "SELECT 2, DataBonContinut as Data, IdProdus, -Cantitate, Pret " +
                              "From Bon b " +
                              "INNER JOIN BonContinut bc ON bc.IdBon = b.IdBon ";
            try { cmd.ExecuteNonQuery(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            con.Close();
            //Incarc dataTable-ul CalculStoc
            dataSet1.CalculStoc.Clear();
            calculStocTableAdapter.Fill(this.dataSet1.CalculStoc);        

            con.Close();

            con.Open();

            // Calculez totaluri pe Cantitate si grupez pe IdProdus 
            // inserez rezultatul in tabela Stoc
            cmd.CommandText = "INSERT INTO Stoc ( IdProdus, Cantitate, Data )  " +
                              "SELECT  IdProdus, Sum(CalculStoc.Cantitate) AS Cantitate, FORMAT(now(),'dd/MMM/yyyy') as Data " +
                              "FROM CalculStoc GROUP BY CalculStoc.IdProdus";
            cmd.ExecuteNonQuery();
            con.Close();

           
            dataSet1.Stoc.Clear();
            stocTableAdapter.Fill(this.dataSet1.Stoc);

            filtrare();
            textBox1.Visible = false;
        }

        private void stocBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            filtrare();
        }

        private void filtrare()
        {
            try { calculStocBindingSource.Filter = "IdProdus=" + textBox1.Text; }
            catch { }
        }

    }
}
