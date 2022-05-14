
namespace Gheorghe_Dumitru_Bogdanel
{
    partial class FBonAct
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
            this.idBonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrCrtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.produseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Gheorghe_Dumitru_Bogdanel.DataSet1();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PretProdus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PretBon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonContinutManevraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.lucrareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtNrFactura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNrFactura = new System.Windows.Forms.Label();
            this.lucrareTableAdapter = new Gheorghe_Dumitru_Bogdanel.DataSet1TableAdapters.LucrareTableAdapter();
            this.produseTableAdapter = new Gheorghe_Dumitru_Bogdanel.DataSet1TableAdapters.ProduseTableAdapter();
            this.bonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bonTableAdapter = new Gheorghe_Dumitru_Bogdanel.DataSet1TableAdapters.BonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonContinutManevraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucrareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(434, 99);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(31, 13);
            this.lblOp.TabIndex = 37;
            this.lblOp.Text = "lblOp";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBonDataGridViewTextBoxColumn,
            this.nrCrtDataGridViewTextBoxColumn,
            this.dProdusDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn,
            this.PretProdus,
            this.PretBon,
            this.idProdusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bonContinutManevraBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(958, 150);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // idBonDataGridViewTextBoxColumn
            // 
            this.idBonDataGridViewTextBoxColumn.DataPropertyName = "IdBon";
            this.idBonDataGridViewTextBoxColumn.HeaderText = "IdBon";
            this.idBonDataGridViewTextBoxColumn.Name = "idBonDataGridViewTextBoxColumn";
            this.idBonDataGridViewTextBoxColumn.Visible = false;
            // 
            // nrCrtDataGridViewTextBoxColumn
            // 
            this.nrCrtDataGridViewTextBoxColumn.DataPropertyName = "NrCrt";
            this.nrCrtDataGridViewTextBoxColumn.HeaderText = "NrCrt";
            this.nrCrtDataGridViewTextBoxColumn.Name = "nrCrtDataGridViewTextBoxColumn";
            // 
            // dProdusDataGridViewTextBoxColumn
            // 
            this.dProdusDataGridViewTextBoxColumn.DataPropertyName = "DProdus";
            this.dProdusDataGridViewTextBoxColumn.DataSource = this.produseBindingSource;
            this.dProdusDataGridViewTextBoxColumn.DisplayMember = "DProdus";
            this.dProdusDataGridViewTextBoxColumn.HeaderText = "DProdus";
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
            // cantitateDataGridViewTextBoxColumn
            // 
            this.cantitateDataGridViewTextBoxColumn.DataPropertyName = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.Name = "cantitateDataGridViewTextBoxColumn";
            // 
            // PretProdus
            // 
            this.PretProdus.DataPropertyName = "PretProdus";
            this.PretProdus.HeaderText = "PretProdus";
            this.PretProdus.Name = "PretProdus";
            // 
            // PretBon
            // 
            this.PretBon.DataPropertyName = "PretBon";
            this.PretBon.HeaderText = "PretBon";
            this.PretBon.Name = "PretBon";
            // 
            // idProdusDataGridViewTextBoxColumn
            // 
            this.idProdusDataGridViewTextBoxColumn.DataPropertyName = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn.HeaderText = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn.Name = "idProdusDataGridViewTextBoxColumn";
            this.idProdusDataGridViewTextBoxColumn.Visible = false;
            // 
            // bonContinutManevraBindingSource
            // 
            this.bonContinutManevraBindingSource.DataMember = "BonContinutManevra";
            this.bonContinutManevraBindingSource.DataSource = this.dataSet1;
            this.bonContinutManevraBindingSource.CurrentChanged += new System.EventHandler(this.bonContinutManevraBindingSource_CurrentChanged);
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Location = new System.Drawing.Point(380, 36);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmare.TabIndex = 35;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(653, 120);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(607, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Total";
            // 
            // cmbClient
            // 
            this.cmbClient.DataSource = this.lucrareBindingSource;
            this.cmbClient.DisplayMember = "DLucrare";
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(127, 112);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(121, 21);
            this.cmbClient.TabIndex = 32;
            this.cmbClient.ValueMember = "IdLucrare";
            // 
            // lucrareBindingSource
            // 
            this.lucrareBindingSource.DataMember = "Lucrare";
            this.lucrareBindingSource.DataSource = this.dataSet1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Location = new System.Drawing.Point(127, 78);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 31;
            // 
            // txtNrFactura
            // 
            this.txtNrFactura.Location = new System.Drawing.Point(127, 41);
            this.txtNrFactura.Name = "txtNrFactura";
            this.txtNrFactura.Size = new System.Drawing.Size(100, 20);
            this.txtNrFactura.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Lucrare";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Data";
            // 
            // lblNrFactura
            // 
            this.lblNrFactura.AutoSize = true;
            this.lblNrFactura.Location = new System.Drawing.Point(40, 41);
            this.lblNrFactura.Name = "lblNrFactura";
            this.lblNrFactura.Size = new System.Drawing.Size(37, 13);
            this.lblNrFactura.TabIndex = 27;
            this.lblNrFactura.Text = "NrBon";
            // 
            // lucrareTableAdapter
            // 
            this.lucrareTableAdapter.ClearBeforeFill = true;
            // 
            // produseTableAdapter
            // 
            this.produseTableAdapter.ClearBeforeFill = true;
            // 
            // bonBindingSource
            // 
            this.bonBindingSource.DataMember = "Bon";
            this.bonBindingSource.DataSource = this.dataSet1;
            // 
            // bonTableAdapter
            // 
            this.bonTableAdapter.ClearBeforeFill = true;
            // 
            // FBonAct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 450);
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
            this.Name = "FBonAct";
            this.Text = "FBonAct";
            this.Load += new System.EventHandler(this.FBonAct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonContinutManevraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucrareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource bonContinutManevraBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource lucrareBindingSource;
        private DataSet1TableAdapters.LucrareTableAdapter lucrareTableAdapter;
        private System.Windows.Forms.BindingSource produseBindingSource;
        private DataSet1TableAdapters.ProduseTableAdapter produseTableAdapter;
        private System.Windows.Forms.BindingSource bonBindingSource;
        private DataSet1TableAdapters.BonTableAdapter bonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrCrtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PretProdus;
        private System.Windows.Forms.DataGridViewTextBoxColumn PretBon;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdusDataGridViewTextBoxColumn;
    }
}