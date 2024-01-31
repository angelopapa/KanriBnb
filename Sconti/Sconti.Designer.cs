
namespace kanriBnb.Sconti
{
    partial class Sconti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sconti));
            this.btnEliminaCosti = new System.Windows.Forms.Button();
            this.btnModificaCosti = new System.Windows.Forms.Button();
            this.btnAggiungiCosti = new System.Windows.Forms.Button();
            this.lblCosti = new System.Windows.Forms.Label();
            this.lstCosti = new System.Windows.Forms.ListView();
            this.colElemento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrezzo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTipologia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescrizione = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEliminaSconti = new System.Windows.Forms.Button();
            this.btnModificaSconti = new System.Windows.Forms.Button();
            this.btnAggiungiSconti = new System.Windows.Forms.Button();
            this.lblSconti = new System.Windows.Forms.Label();
            this.grpAggiungiElemento = new System.Windows.Forms.GroupBox();
            this.radPercentuale = new System.Windows.Forms.RadioButton();
            this.radPrezzo = new System.Windows.Forms.RadioButton();
            this.btnAnnullaElemento = new System.Windows.Forms.Button();
            this.btnSalvaElemento = new System.Windows.Forms.Button();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.txtPrezzo = new System.Windows.Forms.TextBox();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.lblDescrizione = new System.Windows.Forms.Label();
            this.lblTipologia = new System.Windows.Forms.Label();
            this.lblPrezzo = new System.Windows.Forms.Label();
            this.lblElemento = new System.Windows.Forms.Label();
            this.lstSconti = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpAggiungiElemento.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminaCosti
            // 
            this.btnEliminaCosti.AccessibleName = "btnEliminaExtra";
            this.btnEliminaCosti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminaCosti.Enabled = false;
            this.btnEliminaCosti.Location = new System.Drawing.Point(966, 154);
            this.btnEliminaCosti.Name = "btnEliminaCosti";
            this.btnEliminaCosti.Size = new System.Drawing.Size(40, 40);
            this.btnEliminaCosti.TabIndex = 13;
            this.btnEliminaCosti.Text = "button3";
            this.btnEliminaCosti.UseVisualStyleBackColor = true;
            this.btnEliminaCosti.Click += new System.EventHandler(this.btnEliminaCosti_Click);
            // 
            // btnModificaCosti
            // 
            this.btnModificaCosti.AccessibleName = "btnModificaExtra";
            this.btnModificaCosti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificaCosti.Enabled = false;
            this.btnModificaCosti.Location = new System.Drawing.Point(966, 99);
            this.btnModificaCosti.Name = "btnModificaCosti";
            this.btnModificaCosti.Size = new System.Drawing.Size(40, 40);
            this.btnModificaCosti.TabIndex = 14;
            this.btnModificaCosti.Text = "button2";
            this.btnModificaCosti.UseVisualStyleBackColor = true;
            this.btnModificaCosti.Click += new System.EventHandler(this.btnModificaCosti_Click);
            // 
            // btnAggiungiCosti
            // 
            this.btnAggiungiCosti.AccessibleName = "btnAggiungiCosti";
            this.btnAggiungiCosti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAggiungiCosti.Location = new System.Drawing.Point(966, 42);
            this.btnAggiungiCosti.Name = "btnAggiungiCosti";
            this.btnAggiungiCosti.Size = new System.Drawing.Size(40, 40);
            this.btnAggiungiCosti.TabIndex = 15;
            this.btnAggiungiCosti.Text = "button1";
            this.btnAggiungiCosti.UseVisualStyleBackColor = true;
            this.btnAggiungiCosti.Click += new System.EventHandler(this.btnAggiungiCosti_Click);
            // 
            // lblCosti
            // 
            this.lblCosti.AccessibleName = "lblCosti";
            this.lblCosti.AutoSize = true;
            this.lblCosti.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosti.ForeColor = System.Drawing.Color.White;
            this.lblCosti.Location = new System.Drawing.Point(15, 22);
            this.lblCosti.Name = "lblCosti";
            this.lblCosti.Size = new System.Drawing.Size(83, 18);
            this.lblCosti.TabIndex = 11;
            this.lblCosti.Text = "Costi Extra:";
            // 
            // lstCosti
            // 
            this.lstCosti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCosti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colElemento,
            this.colPrezzo,
            this.colTipologia,
            this.colDescrizione});
            this.lstCosti.FullRowSelect = true;
            this.lstCosti.HideSelection = false;
            this.lstCosti.Location = new System.Drawing.Point(18, 42);
            this.lstCosti.MinimumSize = new System.Drawing.Size(200, 200);
            this.lstCosti.MultiSelect = false;
            this.lstCosti.Name = "lstCosti";
            this.lstCosti.Size = new System.Drawing.Size(925, 258);
            this.lstCosti.TabIndex = 10;
            this.lstCosti.UseCompatibleStateImageBehavior = false;
            this.lstCosti.View = System.Windows.Forms.View.Details;
            this.lstCosti.SelectedIndexChanged += new System.EventHandler(this.lstCosti_SelectedIndexChanged);
            // 
            // colElemento
            // 
            this.colElemento.Text = "Elemento";
            this.colElemento.Width = 200;
            // 
            // colPrezzo
            // 
            this.colPrezzo.Text = "Prezzo";
            // 
            // colTipologia
            // 
            this.colTipologia.Text = "Tipologia";
            this.colTipologia.Width = 80;
            // 
            // colDescrizione
            // 
            this.colDescrizione.Text = "Descrizione";
            this.colDescrizione.Width = 250;
            // 
            // btnEliminaSconti
            // 
            this.btnEliminaSconti.AccessibleName = "btnRimuoviExtra";
            this.btnEliminaSconti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminaSconti.Enabled = false;
            this.btnEliminaSconti.Location = new System.Drawing.Point(966, 446);
            this.btnEliminaSconti.Name = "btnEliminaSconti";
            this.btnEliminaSconti.Size = new System.Drawing.Size(40, 40);
            this.btnEliminaSconti.TabIndex = 20;
            this.btnEliminaSconti.Text = "button3";
            this.btnEliminaSconti.UseVisualStyleBackColor = true;
            this.btnEliminaSconti.Click += new System.EventHandler(this.btnEliminaSconti_Click);
            // 
            // btnModificaSconti
            // 
            this.btnModificaSconti.AccessibleName = "btnModificaExtra";
            this.btnModificaSconti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificaSconti.Enabled = false;
            this.btnModificaSconti.Location = new System.Drawing.Point(966, 390);
            this.btnModificaSconti.Name = "btnModificaSconti";
            this.btnModificaSconti.Size = new System.Drawing.Size(40, 40);
            this.btnModificaSconti.TabIndex = 21;
            this.btnModificaSconti.Text = "button2";
            this.btnModificaSconti.UseVisualStyleBackColor = true;
            this.btnModificaSconti.Click += new System.EventHandler(this.btnModificaSconti_Click);
            // 
            // btnAggiungiSconti
            // 
            this.btnAggiungiSconti.AccessibleName = "btnAggiungiExtra";
            this.btnAggiungiSconti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAggiungiSconti.Location = new System.Drawing.Point(966, 332);
            this.btnAggiungiSconti.Name = "btnAggiungiSconti";
            this.btnAggiungiSconti.Size = new System.Drawing.Size(40, 40);
            this.btnAggiungiSconti.TabIndex = 22;
            this.btnAggiungiSconti.Text = "button1";
            this.btnAggiungiSconti.UseVisualStyleBackColor = true;
            this.btnAggiungiSconti.Click += new System.EventHandler(this.btnAggiungiSconti_Click);
            // 
            // lblSconti
            // 
            this.lblSconti.AccessibleName = "lblSconti";
            this.lblSconti.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSconti.AutoSize = true;
            this.lblSconti.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSconti.ForeColor = System.Drawing.Color.White;
            this.lblSconti.Location = new System.Drawing.Point(15, 312);
            this.lblSconti.Name = "lblSconti";
            this.lblSconti.Size = new System.Drawing.Size(124, 18);
            this.lblSconti.TabIndex = 19;
            this.lblSconti.Text = "Sconti ed Offerte:";
            // 
            // grpAggiungiElemento
            // 
            this.grpAggiungiElemento.Controls.Add(this.radPercentuale);
            this.grpAggiungiElemento.Controls.Add(this.radPrezzo);
            this.grpAggiungiElemento.Controls.Add(this.btnAnnullaElemento);
            this.grpAggiungiElemento.Controls.Add(this.btnSalvaElemento);
            this.grpAggiungiElemento.Controls.Add(this.txtDescrizione);
            this.grpAggiungiElemento.Controls.Add(this.txtPrezzo);
            this.grpAggiungiElemento.Controls.Add(this.txtElemento);
            this.grpAggiungiElemento.Controls.Add(this.lblDescrizione);
            this.grpAggiungiElemento.Controls.Add(this.lblTipologia);
            this.grpAggiungiElemento.Controls.Add(this.lblPrezzo);
            this.grpAggiungiElemento.Controls.Add(this.lblElemento);
            this.grpAggiungiElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAggiungiElemento.ForeColor = System.Drawing.Color.White;
            this.grpAggiungiElemento.Location = new System.Drawing.Point(165, 89);
            this.grpAggiungiElemento.Name = "grpAggiungiElemento";
            this.grpAggiungiElemento.Size = new System.Drawing.Size(724, 402);
            this.grpAggiungiElemento.TabIndex = 23;
            this.grpAggiungiElemento.TabStop = false;
            this.grpAggiungiElemento.Text = "Aggiungi Elemento";
            // 
            // radPercentuale
            // 
            this.radPercentuale.AutoSize = true;
            this.radPercentuale.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPercentuale.Location = new System.Drawing.Point(236, 130);
            this.radPercentuale.Name = "radPercentuale";
            this.radPercentuale.Size = new System.Drawing.Size(100, 20);
            this.radPercentuale.TabIndex = 11;
            this.radPercentuale.TabStop = true;
            this.radPercentuale.Text = "Percentuale";
            this.radPercentuale.UseVisualStyleBackColor = true;
            // 
            // radPrezzo
            // 
            this.radPrezzo.AutoSize = true;
            this.radPrezzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPrezzo.Location = new System.Drawing.Point(151, 130);
            this.radPrezzo.Name = "radPrezzo";
            this.radPrezzo.Size = new System.Drawing.Size(69, 20);
            this.radPrezzo.TabIndex = 10;
            this.radPrezzo.TabStop = true;
            this.radPrezzo.Text = "Prezzo";
            this.radPrezzo.UseVisualStyleBackColor = true;
            // 
            // btnAnnullaElemento
            // 
            this.btnAnnullaElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnullaElemento.ForeColor = System.Drawing.Color.Black;
            this.btnAnnullaElemento.Location = new System.Drawing.Point(624, 361);
            this.btnAnnullaElemento.Name = "btnAnnullaElemento";
            this.btnAnnullaElemento.Size = new System.Drawing.Size(83, 31);
            this.btnAnnullaElemento.TabIndex = 9;
            this.btnAnnullaElemento.Text = "Annulla";
            this.btnAnnullaElemento.UseVisualStyleBackColor = true;
            this.btnAnnullaElemento.Click += new System.EventHandler(this.btnAnnullaElemento_Click);
            // 
            // btnSalvaElemento
            // 
            this.btnSalvaElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvaElemento.ForeColor = System.Drawing.Color.Black;
            this.btnSalvaElemento.Location = new System.Drawing.Point(535, 361);
            this.btnSalvaElemento.Name = "btnSalvaElemento";
            this.btnSalvaElemento.Size = new System.Drawing.Size(83, 31);
            this.btnSalvaElemento.TabIndex = 8;
            this.btnSalvaElemento.Text = "Salva";
            this.btnSalvaElemento.UseVisualStyleBackColor = true;
            this.btnSalvaElemento.Click += new System.EventHandler(this.btnSalvaElemento_Click);
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Location = new System.Drawing.Point(152, 179);
            this.txtDescrizione.Multiline = true;
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(546, 170);
            this.txtDescrizione.TabIndex = 7;
            // 
            // txtPrezzo
            // 
            this.txtPrezzo.Location = new System.Drawing.Point(151, 80);
            this.txtPrezzo.Name = "txtPrezzo";
            this.txtPrezzo.Size = new System.Drawing.Size(100, 27);
            this.txtPrezzo.TabIndex = 5;
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(151, 37);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(190, 27);
            this.txtElemento.TabIndex = 4;
            // 
            // lblDescrizione
            // 
            this.lblDescrizione.AutoSize = true;
            this.lblDescrizione.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrizione.Location = new System.Drawing.Point(59, 179);
            this.lblDescrizione.Name = "lblDescrizione";
            this.lblDescrizione.Size = new System.Drawing.Size(87, 18);
            this.lblDescrizione.TabIndex = 3;
            this.lblDescrizione.Text = "Descrizione";
            // 
            // lblTipologia
            // 
            this.lblTipologia.AutoSize = true;
            this.lblTipologia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipologia.Location = new System.Drawing.Point(75, 130);
            this.lblTipologia.Name = "lblTipologia";
            this.lblTipologia.Size = new System.Drawing.Size(68, 18);
            this.lblTipologia.TabIndex = 2;
            this.lblTipologia.Text = "TIpologia";
            // 
            // lblPrezzo
            // 
            this.lblPrezzo.AutoSize = true;
            this.lblPrezzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezzo.Location = new System.Drawing.Point(89, 83);
            this.lblPrezzo.Name = "lblPrezzo";
            this.lblPrezzo.Size = new System.Drawing.Size(56, 18);
            this.lblPrezzo.TabIndex = 1;
            this.lblPrezzo.Text = "Prezzo";
            // 
            // lblElemento
            // 
            this.lblElemento.AutoSize = true;
            this.lblElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElemento.Location = new System.Drawing.Point(75, 40);
            this.lblElemento.Name = "lblElemento";
            this.lblElemento.Size = new System.Drawing.Size(71, 18);
            this.lblElemento.TabIndex = 0;
            this.lblElemento.Text = "Elemento";
            // 
            // lstSconti
            // 
            this.lstSconti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSconti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstSconti.FullRowSelect = true;
            this.lstSconti.HideSelection = false;
            this.lstSconti.Location = new System.Drawing.Point(18, 332);
            this.lstSconti.MinimumSize = new System.Drawing.Size(200, 200);
            this.lstSconti.MultiSelect = false;
            this.lstSconti.Name = "lstSconti";
            this.lstSconti.Size = new System.Drawing.Size(925, 227);
            this.lstSconti.TabIndex = 24;
            this.lstSconti.UseCompatibleStateImageBehavior = false;
            this.lstSconti.View = System.Windows.Forms.View.Details;
            this.lstSconti.SelectedIndexChanged += new System.EventHandler(this.lstSconti_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Elemento";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Prezzo";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tipologia";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Descrizione";
            this.columnHeader4.Width = 250;
            // 
            // Sconti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(99)))), ((int)(((byte)(227)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1018, 570);
            this.Controls.Add(this.grpAggiungiElemento);
            this.Controls.Add(this.lstCosti);
            this.Controls.Add(this.lstSconti);
            this.Controls.Add(this.btnEliminaSconti);
            this.Controls.Add(this.btnModificaSconti);
            this.Controls.Add(this.btnAggiungiSconti);
            this.Controls.Add(this.lblSconti);
            this.Controls.Add(this.btnEliminaCosti);
            this.Controls.Add(this.btnModificaCosti);
            this.Controls.Add(this.btnAggiungiCosti);
            this.Controls.Add(this.lblCosti);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Sconti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sconti";
            this.Load += new System.EventHandler(this.Sconti_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Sconti_Paint);
            this.grpAggiungiElemento.ResumeLayout(false);
            this.grpAggiungiElemento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEliminaCosti;
        private System.Windows.Forms.Button btnModificaCosti;
        private System.Windows.Forms.Button btnAggiungiCosti;
        private System.Windows.Forms.Label lblCosti;
        private System.Windows.Forms.ListView lstCosti;
        private System.Windows.Forms.ColumnHeader colElemento;
        private System.Windows.Forms.ColumnHeader colPrezzo;
        private System.Windows.Forms.ColumnHeader colDescrizione;
        private System.Windows.Forms.Button btnEliminaSconti;
        private System.Windows.Forms.Button btnModificaSconti;
        private System.Windows.Forms.Button btnAggiungiSconti;
        private System.Windows.Forms.Label lblSconti;
        private System.Windows.Forms.GroupBox grpAggiungiElemento;
        private System.Windows.Forms.RadioButton radPercentuale;
        private System.Windows.Forms.RadioButton radPrezzo;
        private System.Windows.Forms.Button btnAnnullaElemento;
        private System.Windows.Forms.Button btnSalvaElemento;
        private System.Windows.Forms.TextBox txtDescrizione;
        private System.Windows.Forms.TextBox txtPrezzo;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Label lblDescrizione;
        private System.Windows.Forms.Label lblTipologia;
        private System.Windows.Forms.Label lblPrezzo;
        private System.Windows.Forms.Label lblElemento;
        private System.Windows.Forms.ColumnHeader colTipologia;
        private System.Windows.Forms.ListView lstSconti;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}