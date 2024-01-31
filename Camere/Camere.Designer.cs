
namespace kanriBnb.Camere
{
    partial class Camere
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Camere));
            this.panelCamere = new System.Windows.Forms.Panel();
            this.DataElencoCamere = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPostiLetto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSingola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatrimoniale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrezzo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTotaleCamere = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNumeroTotale = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AggiungiCamera = new System.Windows.Forms.ToolStripButton();
            this.ModificaCamera = new System.Windows.Forms.ToolStripButton();
            this.RimuoviCamera = new System.Windows.Forms.ToolStripButton();
            this.pnlAggiungiCamere = new System.Windows.Forms.Panel();
            this.txtMatrimoniale = new System.Windows.Forms.NumericUpDown();
            this.txtSingola = new System.Windows.Forms.NumericUpDown();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtPrezzo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtPostiLetto = new System.Windows.Forms.NumericUpDown();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblPrezzo = new System.Windows.Forms.Label();
            this.lblMatrimoniale = new System.Windows.Forms.Label();
            this.lblSingola = new System.Windows.Forms.Label();
            this.lblPostiLetto = new System.Windows.Forms.Label();
            this.lblCognome = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.camereDataSet = new kanriBnb.CamereDataSet();
            this.tblCamereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCamereTableAdapter = new kanriBnb.CamereDataSetTableAdapters.tblCamereTableAdapter();
            this.camereDataSet1 = new kanriBnb.CamereDataSet();
            this.tblCamereBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panelCamere.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataElencoCamere)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pnlAggiungiCamere.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatrimoniale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSingola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPostiLetto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camereDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCamereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camereDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCamereBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCamere
            // 
            this.panelCamere.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCamere.Controls.Add(this.DataElencoCamere);
            this.panelCamere.Controls.Add(this.statusStrip1);
            this.panelCamere.Controls.Add(this.toolStrip1);
            this.panelCamere.Location = new System.Drawing.Point(529, 66);
            this.panelCamere.Name = "panelCamere";
            this.panelCamere.Size = new System.Drawing.Size(673, 410);
            this.panelCamere.TabIndex = 0;
            // 
            // DataElencoCamere
            // 
            this.DataElencoCamere.AccessibleName = "DataElencoCamere";
            this.DataElencoCamere.AllowUserToAddRows = false;
            this.DataElencoCamere.AllowUserToDeleteRows = false;
            this.DataElencoCamere.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataElencoCamere.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(50)))), ((int)(((byte)(188)))));
            this.DataElencoCamere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataElencoCamere.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNome,
            this.colPostiLetto,
            this.colSingola,
            this.colMatrimoniale,
            this.colPrezzo,
            this.colNote});
            this.DataElencoCamere.Location = new System.Drawing.Point(3, 30);
            this.DataElencoCamere.Name = "DataElencoCamere";
            this.DataElencoCamere.ReadOnly = true;
            this.DataElencoCamere.RowHeadersWidth = 51;
            this.DataElencoCamere.RowTemplate.Height = 24;
            this.DataElencoCamere.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataElencoCamere.Size = new System.Drawing.Size(670, 351);
            this.DataElencoCamere.TabIndex = 1;
            this.DataElencoCamere.SelectionChanged += new System.EventHandler(this.DataElencoCamere_SelectionChanged);
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 40;
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Nome";
            this.colNome.MinimumWidth = 6;
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 125;
            // 
            // colPostiLetto
            // 
            this.colPostiLetto.HeaderText = "Posti Letto";
            this.colPostiLetto.MinimumWidth = 6;
            this.colPostiLetto.Name = "colPostiLetto";
            this.colPostiLetto.ReadOnly = true;
            this.colPostiLetto.Width = 125;
            // 
            // colSingola
            // 
            this.colSingola.HeaderText = "Letti Singoli";
            this.colSingola.MinimumWidth = 6;
            this.colSingola.Name = "colSingola";
            this.colSingola.ReadOnly = true;
            this.colSingola.Width = 125;
            // 
            // colMatrimoniale
            // 
            this.colMatrimoniale.HeaderText = "Letti Matrimoniali";
            this.colMatrimoniale.MinimumWidth = 6;
            this.colMatrimoniale.Name = "colMatrimoniale";
            this.colMatrimoniale.ReadOnly = true;
            this.colMatrimoniale.Width = 125;
            // 
            // colPrezzo
            // 
            this.colPrezzo.HeaderText = "Prezzo per Notte (€)";
            this.colPrezzo.MinimumWidth = 6;
            this.colPrezzo.Name = "colPrezzo";
            this.colPrezzo.ReadOnly = true;
            this.colPrezzo.Width = 125;
            // 
            // colNote
            // 
            this.colNote.HeaderText = "Note";
            this.colNote.MinimumWidth = 6;
            this.colNote.Name = "colNote";
            this.colNote.ReadOnly = true;
            this.colNote.Width = 300;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AccessibleName = "statusCamere";
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTotaleCamere,
            this.lblNumeroTotale});
            this.statusStrip1.Location = new System.Drawing.Point(0, 384);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(673, 26);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusCamere";
            // 
            // lblTotaleCamere
            // 
            this.lblTotaleCamere.AccessibleName = "lblTotaleCamere";
            this.lblTotaleCamere.Name = "lblTotaleCamere";
            this.lblTotaleCamere.Size = new System.Drawing.Size(53, 20);
            this.lblTotaleCamere.Text = "Totale:";
            // 
            // lblNumeroTotale
            // 
            this.lblNumeroTotale.AccessibleName = "lblNumeroTotale";
            this.lblNumeroTotale.Name = "lblNumeroTotale";
            this.lblNumeroTotale.Size = new System.Drawing.Size(17, 20);
            this.lblNumeroTotale.Text = "0";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AccessibleName = "toolCamere";
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AggiungiCamera,
            this.ModificaCamera,
            this.RimuoviCamera});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(673, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolCamere";
            // 
            // AggiungiCamera
            // 
            this.AggiungiCamera.AccessibleName = "AggiungiCamera";
            this.AggiungiCamera.Image = ((System.Drawing.Image)(resources.GetObject("AggiungiCamera.Image")));
            this.AggiungiCamera.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AggiungiCamera.Name = "AggiungiCamera";
            this.AggiungiCamera.Size = new System.Drawing.Size(149, 24);
            this.AggiungiCamera.Text = "Aggiungi Camera";
            this.AggiungiCamera.Click += new System.EventHandler(this.AggiungiCamera_Click);
            // 
            // ModificaCamera
            // 
            this.ModificaCamera.AccessibleName = "ModificaCamera";
            this.ModificaCamera.Image = ((System.Drawing.Image)(resources.GetObject("ModificaCamera.Image")));
            this.ModificaCamera.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ModificaCamera.Name = "ModificaCamera";
            this.ModificaCamera.Size = new System.Drawing.Size(147, 24);
            this.ModificaCamera.Text = "Modifica Camera";
            this.ModificaCamera.Click += new System.EventHandler(this.ModificaCamera_Click);
            // 
            // RimuoviCamera
            // 
            this.RimuoviCamera.AccessibleName = "RimuoviCamera";
            this.RimuoviCamera.Image = ((System.Drawing.Image)(resources.GetObject("RimuoviCamera.Image")));
            this.RimuoviCamera.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RimuoviCamera.Name = "RimuoviCamera";
            this.RimuoviCamera.Size = new System.Drawing.Size(142, 24);
            this.RimuoviCamera.Text = "Rimuovi Camera";
            this.RimuoviCamera.Click += new System.EventHandler(this.RimuoviCamera_Click);
            // 
            // pnlAggiungiCamere
            // 
            this.pnlAggiungiCamere.AccessibleName = "pnlAggiungiCamere";
            this.pnlAggiungiCamere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(99)))), ((int)(((byte)(227)))));
            this.pnlAggiungiCamere.Controls.Add(this.txtMatrimoniale);
            this.pnlAggiungiCamere.Controls.Add(this.txtSingola);
            this.pnlAggiungiCamere.Controls.Add(this.btnAnnulla);
            this.pnlAggiungiCamere.Controls.Add(this.btnAggiungi);
            this.pnlAggiungiCamere.Controls.Add(this.txtNote);
            this.pnlAggiungiCamere.Controls.Add(this.txtPrezzo);
            this.pnlAggiungiCamere.Controls.Add(this.txtNome);
            this.pnlAggiungiCamere.Controls.Add(this.txtid);
            this.pnlAggiungiCamere.Controls.Add(this.txtPostiLetto);
            this.pnlAggiungiCamere.Controls.Add(this.lblNote);
            this.pnlAggiungiCamere.Controls.Add(this.lblPrezzo);
            this.pnlAggiungiCamere.Controls.Add(this.lblMatrimoniale);
            this.pnlAggiungiCamere.Controls.Add(this.lblSingola);
            this.pnlAggiungiCamere.Controls.Add(this.lblPostiLetto);
            this.pnlAggiungiCamere.Controls.Add(this.lblCognome);
            this.pnlAggiungiCamere.Controls.Add(this.lblNome);
            this.pnlAggiungiCamere.Controls.Add(this.lblId);
            this.pnlAggiungiCamere.Location = new System.Drawing.Point(37, 26);
            this.pnlAggiungiCamere.Name = "pnlAggiungiCamere";
            this.pnlAggiungiCamere.Size = new System.Drawing.Size(360, 563);
            this.pnlAggiungiCamere.TabIndex = 1;
            this.pnlAggiungiCamere.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAggiungiCamere_Paint);
            // 
            // txtMatrimoniale
            // 
            this.txtMatrimoniale.AccessibleName = "txtMatrimoniale";
            this.txtMatrimoniale.Location = new System.Drawing.Point(146, 148);
            this.txtMatrimoniale.Name = "txtMatrimoniale";
            this.txtMatrimoniale.Size = new System.Drawing.Size(120, 22);
            this.txtMatrimoniale.TabIndex = 19;
            // 
            // txtSingola
            // 
            this.txtSingola.AccessibleName = "txtSingola";
            this.txtSingola.Location = new System.Drawing.Point(146, 118);
            this.txtSingola.Name = "txtSingola";
            this.txtSingola.Size = new System.Drawing.Size(120, 22);
            this.txtSingola.TabIndex = 18;
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnulla.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulla.Location = new System.Drawing.Point(251, 516);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(85, 40);
            this.btnAnnulla.TabIndex = 17;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAggiungi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiungi.Location = new System.Drawing.Point(161, 516);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(85, 40);
            this.btnAggiungi.TabIndex = 1;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNote.Location = new System.Drawing.Point(146, 220);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(201, 253);
            this.txtNote.TabIndex = 15;
            // 
            // txtPrezzo
            // 
            this.txtPrezzo.Location = new System.Drawing.Point(146, 181);
            this.txtPrezzo.Multiline = true;
            this.txtPrezzo.Name = "txtPrezzo";
            this.txtPrezzo.Size = new System.Drawing.Size(65, 25);
            this.txtPrezzo.TabIndex = 14;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(146, 53);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(192, 25);
            this.txtNome.TabIndex = 12;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(146, 21);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(65, 25);
            this.txtid.TabIndex = 11;
            // 
            // txtPostiLetto
            // 
            this.txtPostiLetto.Location = new System.Drawing.Point(146, 84);
            this.txtPostiLetto.Name = "txtPostiLetto";
            this.txtPostiLetto.Size = new System.Drawing.Size(120, 22);
            this.txtPostiLetto.TabIndex = 8;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.White;
            this.lblNote.Location = new System.Drawing.Point(92, 216);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(51, 21);
            this.lblNote.TabIndex = 7;
            this.lblNote.Text = "Note:";
            // 
            // lblPrezzo
            // 
            this.lblPrezzo.AutoSize = true;
            this.lblPrezzo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezzo.ForeColor = System.Drawing.Color.White;
            this.lblPrezzo.Location = new System.Drawing.Point(0, 181);
            this.lblPrezzo.Name = "lblPrezzo";
            this.lblPrezzo.Size = new System.Drawing.Size(140, 21);
            this.lblPrezzo.TabIndex = 6;
            this.lblPrezzo.Text = "Prezzo per Notte:";
            // 
            // lblMatrimoniale
            // 
            this.lblMatrimoniale.AutoSize = true;
            this.lblMatrimoniale.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatrimoniale.ForeColor = System.Drawing.Color.White;
            this.lblMatrimoniale.Location = new System.Drawing.Point(-1, 149);
            this.lblMatrimoniale.Name = "lblMatrimoniale";
            this.lblMatrimoniale.Size = new System.Drawing.Size(145, 21);
            this.lblMatrimoniale.TabIndex = 5;
            this.lblMatrimoniale.Text = "Letti Matrimoniali:";
            // 
            // lblSingola
            // 
            this.lblSingola.AutoSize = true;
            this.lblSingola.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSingola.ForeColor = System.Drawing.Color.White;
            this.lblSingola.Location = new System.Drawing.Point(40, 118);
            this.lblSingola.Name = "lblSingola";
            this.lblSingola.Size = new System.Drawing.Size(102, 21);
            this.lblSingola.TabIndex = 4;
            this.lblSingola.Text = "Letti Singoli:";
            // 
            // lblPostiLetto
            // 
            this.lblPostiLetto.AutoSize = true;
            this.lblPostiLetto.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostiLetto.ForeColor = System.Drawing.Color.White;
            this.lblPostiLetto.Location = new System.Drawing.Point(47, 84);
            this.lblPostiLetto.Name = "lblPostiLetto";
            this.lblPostiLetto.Size = new System.Drawing.Size(95, 21);
            this.lblPostiLetto.TabIndex = 3;
            this.lblPostiLetto.Text = "Posti Letto:";
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCognome.ForeColor = System.Drawing.Color.White;
            this.lblCognome.Location = new System.Drawing.Point(55, 84);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(0, 18);
            this.lblCognome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(83, 53);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(59, 21);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(111, 20);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(31, 21);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            // 
            // camereDataSet
            // 
            this.camereDataSet.DataSetName = "CamereDataSet";
            this.camereDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCamereBindingSource
            // 
            this.tblCamereBindingSource.DataMember = "tblCamere";
            this.tblCamereBindingSource.DataSource = this.camereDataSet;
            // 
            // tblCamereTableAdapter
            // 
            this.tblCamereTableAdapter.ClearBeforeFill = true;
            // 
            // camereDataSet1
            // 
            this.camereDataSet1.DataSetName = "CamereDataSet";
            this.camereDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCamereBindingSource1
            // 
            this.tblCamereBindingSource1.DataMember = "tblCamere";
            this.tblCamereBindingSource1.DataSource = this.camereDataSet1;
            // 
            // Camere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 665);
            this.Controls.Add(this.panelCamere);
            this.Controls.Add(this.pnlAggiungiCamere);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 700);
            this.Name = "Camere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camere";
            this.Load += new System.EventHandler(this.Camere_Load_1);
            this.panelCamere.ResumeLayout(false);
            this.panelCamere.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataElencoCamere)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlAggiungiCamere.ResumeLayout(false);
            this.pnlAggiungiCamere.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatrimoniale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSingola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPostiLetto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camereDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCamereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camereDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCamereBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCamere;
        private System.Windows.Forms.DataGridView DataElencoCamere;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTotaleCamere;
        private System.Windows.Forms.ToolStripStatusLabel lblNumeroTotale;
        private System.Windows.Forms.ToolStripButton AggiungiCamera;
        private System.Windows.Forms.ToolStripButton ModificaCamera;
        private System.Windows.Forms.ToolStripButton RimuoviCamera;
        private System.Windows.Forms.Panel pnlAggiungiCamere;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtPrezzo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.NumericUpDown txtPostiLetto;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblPrezzo;
        private System.Windows.Forms.Label lblMatrimoniale;
        private System.Windows.Forms.Label lblSingola;
        private System.Windows.Forms.Label lblPostiLetto;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblId;
        private CamereDataSet camereDataSet;
        private System.Windows.Forms.BindingSource tblCamereBindingSource;
        private CamereDataSetTableAdapters.tblCamereTableAdapter tblCamereTableAdapter;
        private CamereDataSet camereDataSet1;
        private System.Windows.Forms.BindingSource tblCamereBindingSource1;
        private System.Windows.Forms.NumericUpDown txtMatrimoniale;
        private System.Windows.Forms.NumericUpDown txtSingola;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPostiLetto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSingola;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatrimoniale;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrezzo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNote;
    }
}