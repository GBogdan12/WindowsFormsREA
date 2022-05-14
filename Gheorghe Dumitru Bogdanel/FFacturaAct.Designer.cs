
namespace Gheorghe_Dumitru_Bogdanel
{
    partial class FFacturaAct
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
            this.lblOp = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nrcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.produseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Gheorghe_Dumitru_Bogdanel.DataSet1();
            this.IdProdus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretIntrareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturaContinutManevraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.furnizoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtNrFactura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNrFactura = new System.Windows.Forms.Label();
            this.furnizoriTableAdapter = new Gheorghe_Dumitru_Bogdanel.DataSet1TableAdapters.FurnizoriTableAdapter();
            this.produseTableAdapter = new Gheorghe_Dumitru_Bogdanel.DataSet1TableAdapters.ProduseTableAdapter();
            this.facturiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturiTableAdapter = new Gheorghe_Dumitru_Bogdanel.DataSet1TableAdapters.FacturiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaContinutManevraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnizoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(434, 87);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(31, 13);
            this.lblOp.TabIndex = 24;
            this.lblOp.Text = "lblOp";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrcDataGridViewTextBoxColumn,
            this.dProdusDataGridViewTextBoxColumn,
            this.IdProdus,
            this.cantitateDataGridViewTextBoxColumn,
            this.pretIntrareDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.facturaContinutManevraBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(958, 150);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // nrcDataGridViewTextBoxColumn
            // 
            this.nrcDataGridViewTextBoxColumn.DataPropertyName = "Nrc";
            this.nrcDataGridViewTextBoxColumn.HeaderText = "Nrc";
            this.nrcDataGridViewTextBoxColumn.Name = "nrcDataGridViewTextBoxColumn";
            // 
            // dProdusDataGridViewTextBoxColumn
            // 
            this.dProdusDataGridViewTextBoxColumn.DataPropertyName = "DProdus";
            this.dProdusDataGridViewTextBoxColumn.DataSource = this.produseBindingSource;
            this.dProdusDataGridViewTextBoxColumn.DisplayMember = "DProdus";
            this.dProdusDataGridViewTextBoxColumn.HeaderText = "Produs";
            this.dProdusDataGridViewTextBoxColumn.Name = "dProdusDataGridViewTextBoxColumn";
            this.dProdusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dProdusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // produseBindingSource
            // 
            this.produseBindingSource.DataMember = "Produse";
            this.produseBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // IdProdus
            // 
            this.IdProdus.DataPropertyName = "IdProdus";
            this.IdProdus.HeaderText = "IdProdus";
            this.IdProdus.Name = "IdProdus";
            this.IdProdus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdProdus.Visible = false;
            // 
            // cantitateDataGridViewTextBoxColumn
            // 
            this.cantitateDataGridViewTextBoxColumn.DataPropertyName = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.Name = "cantitateDataGridViewTextBoxColumn";
            // 
            // pretIntrareDataGridViewTextBoxColumn
            // 
            this.pretIntrareDataGridViewTextBoxColumn.DataPropertyName = "PretIntrare";
            this.pretIntrareDataGridViewTextBoxColumn.HeaderText = "PretIntrare";
            this.pretIntrareDataGridViewTextBoxColumn.Name = "pretIntrareDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // facturaContinutManevraBindingSource
            // 
            this.facturaContinutManevraBindingSource.DataMember = "FacturaContinutManevra";
            this.facturaContinutManevraBindingSource.DataSource = this.dataSet1;
            this.facturaContinutManevraBindingSource.CurrentChanged += new System.EventHandler(this.facturaContinutManevraBindingSource_CurrentChanged);
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Location = new System.Drawing.Point(380, 24);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmare.TabIndex = 22;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(653, 108);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(607, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Total";
            // 
            // cmbClient
            // 
            this.cmbClient.DataSource = this.furnizoriBindingSource;
            this.cmbClient.DisplayMember = "DFurnizor";
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(127, 100);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(121, 21);
            this.cmbClient.TabIndex = 19;
            this.cmbClient.ValueMember = "IdFurnizor";
            // 
            // furnizoriBindingSource
            // 
            this.furnizoriBindingSource.DataMember = "Furnizori";
            this.furnizoriBindingSource.DataSource = this.dataSet1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Location = new System.Drawing.Point(127, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // txtNrFactura
            // 
            this.txtNrFactura.Location = new System.Drawing.Point(127, 29);
            this.txtNrFactura.Name = "txtNrFactura";
            this.txtNrFactura.Size = new System.Drawing.Size(100, 20);
            this.txtNrFactura.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Furnizor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Data";
            // 
            // lblNrFactura
            // 
            this.lblNrFactura.AutoSize = true;
            this.lblNrFactura.Location = new System.Drawing.Point(40, 29);
            this.lblNrFactura.Name = "lblNrFactura";
            this.lblNrFactura.Size = new System.Drawing.Size(54, 13);
            this.lblNrFactura.TabIndex = 14;
            this.lblNrFactura.Text = "NrFactura";
            this.lblNrFactura.Click += new System.EventHandler(this.lb1_Click);
            // 
            // furnizoriTableAdapter
            // 
            this.furnizoriTableAdapter.ClearBeforeFill = true;
            // 
            // produseTableAdapter
            // 
            this.produseTableAdapter.ClearBeforeFill = true;
            // 
            // facturiBindingSource
            // 
            this.facturiBindingSource.DataMember = "Facturi";
            this.facturiBindingSource.DataSource = this.dataSet1;
            // 
            // facturiTableAdapter
            // 
            this.facturiTableAdapter.ClearBeforeFill = true;
            // 
            // FFacturaAct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 389);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtNrFactura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNrFactura);
            this.Name = "FFacturaAct";
            this.Text = "FFacturaAct";
            this.Load += new System.EventHandler(this.FFacturaAct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaContinutManevraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnizoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtNrFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNrFactura;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource furnizoriBindingSource;
        private DataSet1TableAdapters.FurnizoriTableAdapter furnizoriTableAdapter;
        private System.Windows.Forms.BindingSource facturaContinutManevraBindingSource;
        private System.Windows.Forms.BindingSource produseBindingSource;
        private DataSet1TableAdapters.ProduseTableAdapter produseTableAdapter;
        private System.Windows.Forms.BindingSource facturiBindingSource;
        private DataSet1TableAdapters.FacturiTableAdapter facturiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProdus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretIntrareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}