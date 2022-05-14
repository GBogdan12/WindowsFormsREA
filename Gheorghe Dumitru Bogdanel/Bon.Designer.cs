
namespace Gheorghe_Dumitru_Bogdanel
{
    partial class Bon
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnStergeComanda = new System.Windows.Forms.Button();
            this.btnModificareComanda = new System.Windows.Forms.Button();
            this.btnComandaNoua = new System.Windows.Forms.Button();
            this.txtIdBon = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Gheorghe_Dumitru_Bogdanel.DataSet1();
            this.idBonDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrCrtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretBonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonContinutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBonContinutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrBonContinutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dLucrareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonTableAdapter = new Gheorghe_Dumitru_Bogdanel.DataSet1TableAdapters.BonTableAdapter();
            this.bonContinutTableAdapter = new Gheorghe_Dumitru_Bogdanel.DataSet1TableAdapters.BonContinutTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonContinutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.bonBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(514, 24);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Venituri";
            series1.XValueMember = "DataBonContinut";
            series1.YValueMembers = "Total";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(696, 258);
            this.chart1.TabIndex = 20;
            this.chart1.Text = "chart1";
            // 
            // btnStergeComanda
            // 
            this.btnStergeComanda.Location = new System.Drawing.Point(918, 487);
            this.btnStergeComanda.Name = "btnStergeComanda";
            this.btnStergeComanda.Size = new System.Drawing.Size(247, 30);
            this.btnStergeComanda.TabIndex = 19;
            this.btnStergeComanda.Text = "Sterge Bon";
            this.btnStergeComanda.UseVisualStyleBackColor = true;
            this.btnStergeComanda.Click += new System.EventHandler(this.btnStergeComanda_Click);
            // 
            // btnModificareComanda
            // 
            this.btnModificareComanda.Location = new System.Drawing.Point(918, 426);
            this.btnModificareComanda.Name = "btnModificareComanda";
            this.btnModificareComanda.Size = new System.Drawing.Size(247, 30);
            this.btnModificareComanda.TabIndex = 18;
            this.btnModificareComanda.Text = "Modificare  Bon";
            this.btnModificareComanda.UseVisualStyleBackColor = true;
            this.btnModificareComanda.Click += new System.EventHandler(this.btnModificareComanda_Click);
            // 
            // btnComandaNoua
            // 
            this.btnComandaNoua.Location = new System.Drawing.Point(918, 370);
            this.btnComandaNoua.Name = "btnComandaNoua";
            this.btnComandaNoua.Size = new System.Drawing.Size(247, 30);
            this.btnComandaNoua.TabIndex = 17;
            this.btnComandaNoua.Text = "Bon Nou";
            this.btnComandaNoua.UseVisualStyleBackColor = true;
            this.btnComandaNoua.Click += new System.EventHandler(this.btnComandaNoua_Click);
            // 
            // txtIdBon
            // 
            this.txtIdBon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bonBindingSource, "IdBon", true));
            this.txtIdBon.Location = new System.Drawing.Point(935, 301);
            this.txtIdBon.Name = "txtIdBon";
            this.txtIdBon.Size = new System.Drawing.Size(100, 20);
            this.txtIdBon.TabIndex = 16;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBonDataGridViewTextBoxColumn1,
            this.nrCrtDataGridViewTextBoxColumn,
            this.dProdusDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn,
            this.pretProdusDataGridViewTextBoxColumn,
            this.pretBonDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bonContinutBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(40, 301);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(668, 251);
            this.dataGridView2.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataBonContinutDataGridViewTextBoxColumn,
            this.nrBonContinutDataGridViewTextBoxColumn,
            this.dLucrareDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bonBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(40, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(458, 258);
            this.dataGridView1.TabIndex = 14;
            // 
            // bonBindingSource
            // 
            this.bonBindingSource.DataMember = "Bon";
            this.bonBindingSource.DataSource = this.dataSet1;
            this.bonBindingSource.PositionChanged += new System.EventHandler(this.bonBindingSource_PositionChanged);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idBonDataGridViewTextBoxColumn1
            // 
            this.idBonDataGridViewTextBoxColumn1.DataPropertyName = "IdBon";
            this.idBonDataGridViewTextBoxColumn1.HeaderText = "NrBon";
            this.idBonDataGridViewTextBoxColumn1.Name = "idBonDataGridViewTextBoxColumn1";
            this.idBonDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nrCrtDataGridViewTextBoxColumn
            // 
            this.nrCrtDataGridViewTextBoxColumn.DataPropertyName = "NrCrt";
            this.nrCrtDataGridViewTextBoxColumn.HeaderText = "NrCrt";
            this.nrCrtDataGridViewTextBoxColumn.Name = "nrCrtDataGridViewTextBoxColumn";
            this.nrCrtDataGridViewTextBoxColumn.ReadOnly = true;
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
            // pretProdusDataGridViewTextBoxColumn
            // 
            this.pretProdusDataGridViewTextBoxColumn.DataPropertyName = "PretProdus";
            this.pretProdusDataGridViewTextBoxColumn.HeaderText = "PretProdus";
            this.pretProdusDataGridViewTextBoxColumn.Name = "pretProdusDataGridViewTextBoxColumn";
            this.pretProdusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pretBonDataGridViewTextBoxColumn
            // 
            this.pretBonDataGridViewTextBoxColumn.DataPropertyName = "PretBon";
            this.pretBonDataGridViewTextBoxColumn.HeaderText = "PretBon";
            this.pretBonDataGridViewTextBoxColumn.Name = "pretBonDataGridViewTextBoxColumn";
            this.pretBonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bonContinutBindingSource
            // 
            this.bonContinutBindingSource.DataMember = "BonContinut";
            this.bonContinutBindingSource.DataSource = this.dataSet1;
            // 
            // dataBonContinutDataGridViewTextBoxColumn
            // 
            this.dataBonContinutDataGridViewTextBoxColumn.DataPropertyName = "DataBonContinut";
            this.dataBonContinutDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataBonContinutDataGridViewTextBoxColumn.Name = "dataBonContinutDataGridViewTextBoxColumn";
            this.dataBonContinutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrBonContinutDataGridViewTextBoxColumn
            // 
            this.nrBonContinutDataGridViewTextBoxColumn.DataPropertyName = "NrBonContinut";
            this.nrBonContinutDataGridViewTextBoxColumn.HeaderText = "NrBon";
            this.nrBonContinutDataGridViewTextBoxColumn.Name = "nrBonContinutDataGridViewTextBoxColumn";
            this.nrBonContinutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dLucrareDataGridViewTextBoxColumn
            // 
            this.dLucrareDataGridViewTextBoxColumn.DataPropertyName = "DLucrare";
            this.dLucrareDataGridViewTextBoxColumn.HeaderText = "Lucrare";
            this.dLucrareDataGridViewTextBoxColumn.Name = "dLucrareDataGridViewTextBoxColumn";
            this.dLucrareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bonTableAdapter
            // 
            this.bonTableAdapter.ClearBeforeFill = true;
            // 
            // bonContinutTableAdapter
            // 
            this.bonContinutTableAdapter.ClearBeforeFill = true;
            // 
            // Bon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 588);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnStergeComanda);
            this.Controls.Add(this.btnModificareComanda);
            this.Controls.Add(this.btnComandaNoua);
            this.Controls.Add(this.txtIdBon);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Bon";
            this.Text = "Bon";
            this.Load += new System.EventHandler(this.Bon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonContinutBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnStergeComanda;
        private System.Windows.Forms.Button btnModificareComanda;
        private System.Windows.Forms.Button btnComandaNoua;
        private System.Windows.Forms.TextBox txtIdBon;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource bonBindingSource;
        private DataSet1TableAdapters.BonTableAdapter bonTableAdapter;
        private System.Windows.Forms.BindingSource bonContinutBindingSource;
        private DataSet1TableAdapters.BonContinutTableAdapter bonContinutTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBonDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrCrtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretBonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataBonContinutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrBonContinutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dLucrareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}