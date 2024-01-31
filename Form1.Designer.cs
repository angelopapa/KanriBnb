
namespace kanriBnb
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnPrenotazione = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblOrario = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCamere = new System.Windows.Forms.Button();
            this.btnImpostazioni = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.timerOrario = new System.Windows.Forms.Timer(this.components);
            this.btnSconti = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrenotazione
            // 
            this.btnPrenotazione.AccessibleName = "btnPrenotazione";
            this.btnPrenotazione.BackColor = System.Drawing.Color.White;
            this.btnPrenotazione.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrenotazione.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrenotazione.Location = new System.Drawing.Point(122, 81);
            this.btnPrenotazione.Name = "btnPrenotazione";
            this.btnPrenotazione.Size = new System.Drawing.Size(160, 80);
            this.btnPrenotazione.TabIndex = 0;
            this.btnPrenotazione.Text = "Prenotazione\r\n";
            this.btnPrenotazione.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrenotazione.UseVisualStyleBackColor = false;
            this.btnPrenotazione.Click += new System.EventHandler(this.btnPrenotazione_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblOrario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 408);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(567, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblOrario
            // 
            this.lblOrario.BackColor = System.Drawing.Color.White;
            this.lblOrario.MergeAction = System.Windows.Forms.MergeAction.Remove;
            this.lblOrario.Name = "lblOrario";
            this.lblOrario.Size = new System.Drawing.Size(552, 17);
            this.lblOrario.Spring = true;
            this.lblOrario.Text = "lblOrario";
            this.lblOrario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCamere
            // 
            this.btnCamere.AccessibleName = "btnCamere";
            this.btnCamere.BackColor = System.Drawing.Color.White;
            this.btnCamere.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCamere.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCamere.Location = new System.Drawing.Point(294, 81);
            this.btnCamere.Name = "btnCamere";
            this.btnCamere.Size = new System.Drawing.Size(160, 80);
            this.btnCamere.TabIndex = 5;
            this.btnCamere.Text = "Camere";
            this.btnCamere.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCamere.UseVisualStyleBackColor = false;
            this.btnCamere.UseWaitCursor = true;
            this.btnCamere.Click += new System.EventHandler(this.Camere_Load_Click);
            // 
            // btnImpostazioni
            // 
            this.btnImpostazioni.AccessibleName = "btnImpostazioni";
            this.btnImpostazioni.BackColor = System.Drawing.Color.White;
            this.btnImpostazioni.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpostazioni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImpostazioni.Location = new System.Drawing.Point(208, 257);
            this.btnImpostazioni.Name = "btnImpostazioni";
            this.btnImpostazioni.Size = new System.Drawing.Size(160, 80);
            this.btnImpostazioni.TabIndex = 6;
            this.btnImpostazioni.Text = "Impostazioni";
            this.btnImpostazioni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImpostazioni.UseVisualStyleBackColor = false;
            this.btnImpostazioni.Click += new System.EventHandler(this.btnImpostazioni_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.AccessibleName = "btnInfo";
            this.btnInfo.BackColor = System.Drawing.Color.White;
            this.btnInfo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(380, 257);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(160, 80);
            this.btnInfo.TabIndex = 7;
            this.btnInfo.Text = "Info";
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // timerOrario
            // 
            this.timerOrario.Interval = 1000;
            this.timerOrario.Tick += new System.EventHandler(this.timerOrario_Tick);
            // 
            // btnSconti
            // 
            this.btnSconti.AccessibleName = "btnSconti";
            this.btnSconti.BackColor = System.Drawing.Color.White;
            this.btnSconti.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSconti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSconti.Location = new System.Drawing.Point(39, 257);
            this.btnSconti.Name = "btnSconti";
            this.btnSconti.Size = new System.Drawing.Size(160, 80);
            this.btnSconti.TabIndex = 8;
            this.btnSconti.Text = "Sconti";
            this.btnSconti.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSconti.UseVisualStyleBackColor = false;
            this.btnSconti.Click += new System.EventHandler(this.btnSconti_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(50)))), ((int)(((byte)(188)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(567, 430);
            this.Controls.Add(this.btnSconti);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnImpostazioni);
            this.Controls.Add(this.btnCamere);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnPrenotazione);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 200);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KanriBnb";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrenotazione;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnCamere;
        private System.Windows.Forms.Button btnImpostazioni;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.ToolStripStatusLabel lblOrario;
        private System.Windows.Forms.Timer timerOrario;
        private System.Windows.Forms.Button btnSconti;
    }
}

