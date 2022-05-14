
namespace Gheorghe_Dumitru_Bogdanel
{
    partial class Facturi
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnStergeComanda = new System.Windows.Forms.Button();
            this.btnModificareComanda = new System.Windows.Forms.Button();
            this.btnComandaNoua = new System.Windows.Forms.Button();
            this.txtIdFactura = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.facturiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Gheorghe_Dumitru_Bogdanel.DataSet1();
            this.facturiContinutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nrFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dFurnizorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturiTableAdapter = new Gheorghe_Dumitru_Bogdanel.DataSet1TableAdapters.FacturiTableAdapter();
            this.facturiContinutTableAdapter = new Gheorghe_Dumitru_Bogdanel.DataSet1TableAdapters.FacturiContinutTableAdapter();
            this.nrFDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dFurnizorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretIntrareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturiContinutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStergeComanda
            // 
            this.btnStergeComanda.Location = new System.Drawing.Point(860, 454);
            this.btnStergeComanda.Name = "btnStergeComanda";
            this.btnStergeComanda.Size = new System.Drawing.Size(247, 30);
            this.btnStergeComanda.TabIndex = 12;
            this.btnStergeComanda.Text = "Sterge Factura";
            this.btnStergeComanda.UseVisualStyleBackColor = true;
            this.btnStergeComanda.Click += new System.EventHandler(this.btnStergeComanda_Click);
            // 
            // btnModificareComanda
            // 
            this.btnModificareComanda.Location = new System.Drawing.Point(860, 387);
            this.btnModificareComanda.Name = "btnModificareComanda";
            this.btnModificareComanda.Size = new System.Drawing.Size(247, 30);
            this.btnModificareComanda.TabIndex = 11;
            this.btnModificareComanda.Text = "Modificare  Factura";
            this.btnModificareComanda.UseVisualStyleBackColor = true;
            this.btnModificareComanda.Click += new System.EventHandler(this.btnModificareComanda_Click);
            // 
            // btnComandaNoua
            // 
            this.btnComandaNoua.Location = new System.Drawing.Point(860, 329);
            this.btnComandaNoua.Name = "btnComandaNoua";
            this.btnComandaNoua.Size = new System.Drawing.Size(247, 30);
            this.btnComandaNoua.TabIndex = 10;
            this.btnComandaNoua.Text = "Factura Noua";
            this.btnComandaNoua.UseVisualStyleBackColor = true;
            this.btnComandaNoua.Click += new System.EventHandler(this.btnComandaNoua_Click);
            // 
            // txtIdFactura
            // 
            this.txtIdFactura.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturiBindingSource, "NrF", true));
            this.txtIdFactura.Location = new System.Drawing.Point(671, 292);
            this.txtIdFactura.Name = "txtIdFactura";
            this.txtIdFactura.Size = new System.Drawing.Size(100, 20);
            this.txtIdFactura.TabIndex = 9;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrFDataGridViewTextBoxColumn1,
            this.nrcDataGridViewTextBoxColumn,
            this.dFurnizorDataGridViewTextBoxColumn1,
            this.dProdusDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn,
            this.pretIntrareDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.facturiContinutBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 292);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(653, 251);
            this.dataGridView2.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrFDataGridViewTextBoxColumn,
            this.dataFDataGridViewTextBoxColumn,
            this.dFurnizorDataGridViewTextBoxColumn,
            this.Total});
            this.dataGridView1.DataSource = this.facturiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(472, 258);
            this.dataGridView1.TabIndex = 7;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.DataSource = this.facturiBindingSource;
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(510, 28);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Suma Cheltuita";
            series4.XValueMember = "DataF";
            series4.YValueMembers = "Total";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(655, 258);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // facturiBindingSource
            // 
            this.facturiBindingSource.DataMember = "Facturi";
            this.facturiBindingSource.DataSource = this.dataSet1;
            this.facturiBindingSource.PositionChanged += new System.EventHandler(this.facturiBindingSource_PositionChanged);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facturiContinutBindingSource
            // 
            this.facturiContinutBindingSource.DataMember = "FacturiContinut";
            this.facturiContinutBindingSource.DataSource = this.dataSet1;
            // 
            // nrFDataGridViewTextBoxColumn
            // 
            this.nrFDataGridViewTextBoxColumn.DataPropertyName = "NrF";
            this.nrFDataGridViewTextBoxColumn.HeaderText = "NrF";
            this.nrFDataGridViewTextBoxColumn.Name = "nrFDataGridViewTextBoxColumn";
            this.nrFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataFDataGridViewTextBoxColumn
            // 
            this.dataFDataGridViewTextBoxColumn.DataPropertyName = "DataF";
            this.dataFDataGridViewTextBoxColumn.HeaderText = "DataF";
            this.dataFDataGridViewTextBoxColumn.Name = "dataFDataGridViewTextBoxColumn";
            this.dataFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dFurnizorDataGridViewTextBoxColumn
            // 
            this.dFurnizorDataGridViewTextBoxColumn.DataPropertyName = "DFurnizor";
            this.dFurnizorDataGridViewTextBoxColumn.HeaderText = "DFurnizor";
            this.dFurnizorDataGridViewTextBoxColumn.Name = "dFurnizorDataGridViewTextBoxColumn";
            this.dFurnizorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // facturiTableAdapter
            // 
            this.facturiTableAdapter.ClearBeforeFill = true;
            // 
            // facturiContinutTableAdapter
            // 
            this.facturiContinutTableAdapter.ClearBeforeFill = true;
            // 
            // nrFDataGridViewTextBoxColumn1
            // 
            this.nrFDataGridViewTextBoxColumn1.DataPropertyName = "NrF";
            this.nrFDataGridViewTextBoxColumn1.HeaderText = "NrF";
            this.nrFDataGridViewTextBoxColumn1.Name = "nrFDataGridViewTextBoxColumn1";
            this.nrFDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nrcDataGridViewTextBoxColumn
            // 
            this.nrcDataGridViewTextBoxColumn.DataPropertyName = "Nrc";
            this.nrcDataGridViewTextBoxColumn.HeaderText = "Nrc";
            this.nrcDataGridViewTextBoxColumn.Name = "nrcDataGridViewTextBoxColumn";
            this.nrcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dFurnizorDataGridViewTextBoxColumn1
            // 
            this.dFurnizorDataGridViewTextBoxColumn1.DataPropertyName = "DFurnizor";
            this.dFurnizorDataGridViewTextBoxColumn1.HeaderText = "Furnizor";
            this.dFurnizorDataGridViewTextBoxColumn1.Name = "dFurnizorDataGridViewTextBoxColumn1";
            this.dFurnizorDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dProdusDataGridViewTextBoxColumn
            // 
            this.dProdusDataGridViewTextBoxColumn.DataPropertyName = "DProdus";
            this.dProdusDataGridViewTextBoxColumn.HeaderText = "Produs";
            this.dProdusDataGridViewTextBoxColumn.Name = "dProdusDataGridViewTextBoxColumn";
            this.dProdusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantitateDataGridViewTextBoxColumn
            // 
            this.cantitateDataGridViewTextBoxColumn.DataPropertyName = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.Name = "cantitateDataGridViewTextBoxColumn";
            this.cantitateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pretIntrareDataGridViewTextBoxColumn
            // 
            this.pretIntrareDataGridViewTextBoxColumn.DataPropertyName = "PretIntrare";
            this.pretIntrareDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretIntrareDataGridViewTextBoxColumn.Name = "pretIntrareDataGridViewTextBoxColumn";
            this.pretIntrareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturiBindingSource, "IdF", true));
            this.textBox1.Location = new System.Drawing.Point(671, 329);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            // 
            // Facturi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 555);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnStergeComanda);
            this.Controls.Add(this.btnModificareComanda);
            this.Controls.Add(this.btnComandaNoua);
            this.Controls.Add(this.txtIdFactura);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Facturi";
            this.Text = "Facturi";
            this.Load += new System.EventHandler(this.Facturi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturiContinutBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStergeComanda;
        private System.Windows.Forms.Button btnModificareComanda;
        private System.Windows.Forms.Button btnComandaNoua;
        private System.Windows.Forms.TextBox txtIdFactura;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource facturiBindingSource;
        private DataSet1TableAdapters.FacturiTableAdapter facturiTableAdapter;
        private System.Windows.Forms.BindingSource facturiContinutBindingSource;
        private DataSet1TableAdapters.FacturiContinutTableAdapter facturiContinutTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dFurnizorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrFDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dFurnizorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretIntrareDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
    }
}