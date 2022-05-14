
namespace Gheorghe_Dumitru_Bogdanel
{
    partial class CalculStoc
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.stocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Gheorghe_Dumitru_Bogdanel.DataSet1();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.calculStocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calculStocTableAdapter = new Gheorghe_Dumitru_Bogdanel.DataSet1TableAdapters.CalculStocTableAdapter();
            this.stocTableAdapter = new Gheorghe_Dumitru_Bogdanel.DataSet1TableAdapters.StocTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProdus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOperatieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dProdusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.stocBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculStocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dProdusDataGridViewTextBoxColumn1,
            this.cantitateDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.stocBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(729, 76);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(510, 330);
            this.dataGridView2.TabIndex = 19;
            // 
            // stocBindingSource
            // 
            this.stocBindingSource.DataMember = "Stoc";
            this.stocBindingSource.DataSource = this.dataSet1;
            this.stocBindingSource.CurrentChanged += new System.EventHandler(this.stocBindingSource_CurrentChanged);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.IdProdus,
            this.dOperatieDataGridViewTextBoxColumn,
            this.dProdusDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn,
            this.Pret});
            this.dataGridView1.DataSource = this.calculStocBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(574, 330);
            this.dataGridView1.TabIndex = 18;
            // 
            // calculStocBindingSource
            // 
            this.calculStocBindingSource.DataMember = "CalculStoc";
            this.calculStocBindingSource.DataSource = this.dataSet1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(752, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Stoc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-66, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Calcul stoc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Calcul stoc";
            // 
            // calculStocTableAdapter
            // 
            this.calculStocTableAdapter.ClearBeforeFill = true;
            // 
            // stocTableAdapter
            // 
            this.stocTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stocBindingSource, "IdProdus", true));
            this.textBox1.Location = new System.Drawing.Point(609, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 21;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // IdProdus
            // 
            this.IdProdus.DataPropertyName = "IdProdus";
            this.IdProdus.HeaderText = "IdProdus";
            this.IdProdus.Name = "IdProdus";
            this.IdProdus.ReadOnly = true;
            this.IdProdus.Visible = false;
            // 
            // dOperatieDataGridViewTextBoxColumn
            // 
            this.dOperatieDataGridViewTextBoxColumn.DataPropertyName = "DOperatie";
            this.dOperatieDataGridViewTextBoxColumn.HeaderText = "DOperatie";
            this.dOperatieDataGridViewTextBoxColumn.Name = "dOperatieDataGridViewTextBoxColumn";
            this.dOperatieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dProdusDataGridViewTextBoxColumn
            // 
            this.dProdusDataGridViewTextBoxColumn.DataPropertyName = "DProdus";
            this.dProdusDataGridViewTextBoxColumn.HeaderText = "DProdus";
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
            // Pret
            // 
            this.Pret.DataPropertyName = "Pret";
            this.Pret.HeaderText = "Pret";
            this.Pret.Name = "Pret";
            this.Pret.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn1.HeaderText = "Data";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdProdus";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdProdus";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dProdusDataGridViewTextBoxColumn1
            // 
            this.dProdusDataGridViewTextBoxColumn1.DataPropertyName = "DProdus";
            this.dProdusDataGridViewTextBoxColumn1.HeaderText = "DProdus";
            this.dProdusDataGridViewTextBoxColumn1.Name = "dProdusDataGridViewTextBoxColumn1";
            this.dProdusDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cantitateDataGridViewTextBoxColumn1
            // 
            this.cantitateDataGridViewTextBoxColumn1.DataPropertyName = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn1.HeaderText = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn1.Name = "cantitateDataGridViewTextBoxColumn1";
            this.cantitateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.stocBindingSource1;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 425);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Piese Auto";
            series1.XValueMember = "DProdus";
            series1.YValueMembers = "Cantitate";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1224, 260);
            this.chart1.TabIndex = 22;
            this.chart1.Text = "chart1";
            // 
            // stocBindingSource1
            // 
            this.stocBindingSource1.DataMember = "Stoc";
            this.stocBindingSource1.DataSource = this.dataSet1;
            // 
            // CalculStoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 749);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CalculStoc";
            this.Text = "CalculStoc";
            this.Load += new System.EventHandler(this.CalculStoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculStocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource calculStocBindingSource;
        private DataSet1TableAdapters.CalculStocTableAdapter calculStocTableAdapter;
        private System.Windows.Forms.BindingSource stocBindingSource;
        private DataSet1TableAdapters.StocTableAdapter stocTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dProdusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProdus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOperatieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pret;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource stocBindingSource1;
    }
}