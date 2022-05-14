
namespace Gheorghe_Dumitru_Bogdanel
{
    partial class Logare
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
            this.lblParola = new System.Windows.Forms.Label();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblUtilizator = new System.Windows.Forms.Label();
            this.txtUtilizator = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.furnizoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propietateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impozitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lucrareNouaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.platiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stocRaportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Location = new System.Drawing.Point(213, 268);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(37, 13);
            this.lblParola.TabIndex = 20;
            this.lblParola.Text = "Parola";
            this.lblParola.Click += new System.EventHandler(this.lblParola_Click);
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(273, 265);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(198, 20);
            this.txtParola.TabIndex = 19;
            this.txtParola.TextChanged += new System.EventHandler(this.txtParola_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(312, 314);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(121, 23);
            this.btnStart.TabIndex = 18;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblUtilizator
            // 
            this.lblUtilizator.AutoSize = true;
            this.lblUtilizator.Location = new System.Drawing.Point(213, 220);
            this.lblUtilizator.Name = "lblUtilizator";
            this.lblUtilizator.Size = new System.Drawing.Size(47, 13);
            this.lblUtilizator.TabIndex = 17;
            this.lblUtilizator.Text = "Utilizator";
            this.lblUtilizator.Click += new System.EventHandler(this.lblUtilizator_Click);
            // 
            // txtUtilizator
            // 
            this.txtUtilizator.Location = new System.Drawing.Point(273, 217);
            this.txtUtilizator.Name = "txtUtilizator";
            this.txtUtilizator.Size = new System.Drawing.Size(198, 20);
            this.txtUtilizator.TabIndex = 16;
            this.txtUtilizator.TextChanged += new System.EventHandler(this.txtUtilizator_TextChanged);
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(270, 162);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(214, 13);
            this.lblAutor.TabIndex = 15;
            this.lblAutor.Text = "Autor: Gheorghe Dumitru-Bogdanel, grupa 2";
            this.lblAutor.Click += new System.EventHandler(this.lblAutor_Click);
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.Location = new System.Drawing.Point(183, 113);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(361, 20);
            this.lblTitlu.TabIndex = 14;
            this.lblTitlu.Text = "Aplicatie pt. evidenta pieselor dintr-un service auto";
            this.lblTitlu.Click += new System.EventHandler(this.lblTitlu_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientiToolStripMenuItem,
            this.furnizoriToolStripMenuItem,
            this.propietateToolStripMenuItem,
            this.impozitToolStripMenuItem,
            this.lucrareNouaToolStripMenuItem,
            this.raportToolStripMenuItem,
            this.platiToolStripMenuItem,
            this.stocRaportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientiToolStripMenuItem
            // 
            this.clientiToolStripMenuItem.Name = "clientiToolStripMenuItem";
            this.clientiToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.clientiToolStripMenuItem.Text = "Resurse";
            this.clientiToolStripMenuItem.Click += new System.EventHandler(this.clientiToolStripMenuItem_Click);
            // 
            // furnizoriToolStripMenuItem
            // 
            this.furnizoriToolStripMenuItem.Name = "furnizoriToolStripMenuItem";
            this.furnizoriToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.furnizoriToolStripMenuItem.Text = "Furnizori";
            this.furnizoriToolStripMenuItem.Click += new System.EventHandler(this.furnizoriToolStripMenuItem_Click);
            // 
            // propietateToolStripMenuItem
            // 
            this.propietateToolStripMenuItem.Name = "propietateToolStripMenuItem";
            this.propietateToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.propietateToolStripMenuItem.Text = "Calcul Stoc";
            this.propietateToolStripMenuItem.Click += new System.EventHandler(this.propietateToolStripMenuItem_Click);
            // 
            // impozitToolStripMenuItem
            // 
            this.impozitToolStripMenuItem.Name = "impozitToolStripMenuItem";
            this.impozitToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.impozitToolStripMenuItem.Text = "Facturi";
            this.impozitToolStripMenuItem.Click += new System.EventHandler(this.impozitToolStripMenuItem_Click);
            // 
            // lucrareNouaToolStripMenuItem
            // 
            this.lucrareNouaToolStripMenuItem.Name = "lucrareNouaToolStripMenuItem";
            this.lucrareNouaToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.lucrareNouaToolStripMenuItem.Text = "Bonuri";
            this.lucrareNouaToolStripMenuItem.Click += new System.EventHandler(this.lucrareNouaToolStripMenuItem_Click);
            // 
            // raportToolStripMenuItem
            // 
            this.raportToolStripMenuItem.Name = "raportToolStripMenuItem";
            this.raportToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.raportToolStripMenuItem.Text = "IncasariRaport";
            this.raportToolStripMenuItem.Click += new System.EventHandler(this.raportToolStripMenuItem_Click);
            // 
            // platiToolStripMenuItem
            // 
            this.platiToolStripMenuItem.Name = "platiToolStripMenuItem";
            this.platiToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.platiToolStripMenuItem.Text = "PlatiRaport";
            this.platiToolStripMenuItem.Click += new System.EventHandler(this.platiToolStripMenuItem_Click);
            // 
            // stocRaportToolStripMenuItem
            // 
            this.stocRaportToolStripMenuItem.Name = "stocRaportToolStripMenuItem";
            this.stocRaportToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.stocRaportToolStripMenuItem.Text = "StocRaport";
            this.stocRaportToolStripMenuItem.Click += new System.EventHandler(this.stocRaportToolStripMenuItem_Click);
            // 
            // Logare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblUtilizator);
            this.Controls.Add(this.txtUtilizator);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitlu);
            this.Name = "Logare";
            this.Text = "Logare";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblUtilizator;
        private System.Windows.Forms.TextBox txtUtilizator;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propietateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impozitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lucrareNouaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem furnizoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem platiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stocRaportToolStripMenuItem;
    }
}

