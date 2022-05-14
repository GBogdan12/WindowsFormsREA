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
    public partial class Plati : Form
    {
        public Plati()
        {
            InitializeComponent();
        }

        private void Plati_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.Facturi' table. You can move, or remove it, as needed.
            this.FacturiTableAdapter.Fill(this.DataSet1.Facturi);

            this.reportViewer1.RefreshReport();
        }
    }
}
