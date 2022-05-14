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
    public partial class StocRaport : Form
    {
        public StocRaport()
        {
            InitializeComponent();
        }

        private void StocRaport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.Stoc' table. You can move, or remove it, as needed.
            this.StocTableAdapter.Fill(this.DataSet1.Stoc);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
