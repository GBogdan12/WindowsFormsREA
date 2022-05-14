
namespace Gheorghe_Dumitru_Bogdanel
{
    partial class Plati
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet1 = new Gheorghe_Dumitru_Bogdanel.DataSet1();
            this.FacturiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FacturiTableAdapter = new Gheorghe_Dumitru_Bogdanel.DataSet1TableAdapters.FacturiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.FacturiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Gheorghe_Dumitru_Bogdanel.Plati.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 46);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(763, 567);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FacturiBindingSource
            // 
            this.FacturiBindingSource.DataMember = "Facturi";
            this.FacturiBindingSource.DataSource = this.DataSet1;
            // 
            // FacturiTableAdapter
            // 
            this.FacturiTableAdapter.ClearBeforeFill = true;
            // 
            // Plati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 625);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Plati";
            this.Text = "Plati";
            this.Load += new System.EventHandler(this.Plati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FacturiBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.FacturiTableAdapter FacturiTableAdapter;
    }
}