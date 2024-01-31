
namespace kanriBnb.Impostazioni
{
    partial class Impostazioni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Impostazioni));
            this.lblNomeStruttura = new System.Windows.Forms.Label();
            this.txtNomeStruttura = new System.Windows.Forms.TextBox();
            this.txtTasse = new System.Windows.Forms.TextBox();
            this.lblTasseSoggiorno = new System.Windows.Forms.Label();
            this.btnSalvaImpostazioni = new System.Windows.Forms.Button();
            this.btnAnnullaImpostazioni = new System.Windows.Forms.Button();
            this.grpTasse = new System.Windows.Forms.GroupBox();
            this.btnTema = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnTax = new System.Windows.Forms.Button();
            this.btnLingua = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpTasse.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeStruttura
            // 
            this.lblNomeStruttura.AccessibleName = "lblNomeStruttura";
            this.lblNomeStruttura.AutoSize = true;
            this.lblNomeStruttura.ForeColor = System.Drawing.Color.White;
            this.lblNomeStruttura.Location = new System.Drawing.Point(16, 39);
            this.lblNomeStruttura.Name = "lblNomeStruttura";
            this.lblNomeStruttura.Size = new System.Drawing.Size(128, 20);
            this.lblNomeStruttura.TabIndex = 0;
            this.lblNomeStruttura.Text = "Nome Struttura:";
            // 
            // txtNomeStruttura
            // 
            this.txtNomeStruttura.Location = new System.Drawing.Point(158, 39);
            this.txtNomeStruttura.Name = "txtNomeStruttura";
            this.txtNomeStruttura.Size = new System.Drawing.Size(234, 27);
            this.txtNomeStruttura.TabIndex = 1;
            // 
            // txtTasse
            // 
            this.txtTasse.Location = new System.Drawing.Point(158, 86);
            this.txtTasse.Name = "txtTasse";
            this.txtTasse.Size = new System.Drawing.Size(78, 27);
            this.txtTasse.TabIndex = 3;
            // 
            // lblTasseSoggiorno
            // 
            this.lblTasseSoggiorno.AccessibleName = "lblTasseSoggiorno";
            this.lblTasseSoggiorno.AutoSize = true;
            this.lblTasseSoggiorno.ForeColor = System.Drawing.Color.White;
            this.lblTasseSoggiorno.Location = new System.Drawing.Point(64, 89);
            this.lblTasseSoggiorno.Name = "lblTasseSoggiorno";
            this.lblTasseSoggiorno.Size = new System.Drawing.Size(60, 20);
            this.lblTasseSoggiorno.TabIndex = 2;
            this.lblTasseSoggiorno.Text = "Tassa:";
            // 
            // btnSalvaImpostazioni
            // 
            this.btnSalvaImpostazioni.AccessibleName = "btnSalvaImpostazioni";
            this.btnSalvaImpostazioni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvaImpostazioni.ForeColor = System.Drawing.Color.Black;
            this.btnSalvaImpostazioni.Location = new System.Drawing.Point(350, 361);
            this.btnSalvaImpostazioni.Name = "btnSalvaImpostazioni";
            this.btnSalvaImpostazioni.Size = new System.Drawing.Size(85, 35);
            this.btnSalvaImpostazioni.TabIndex = 9;
            this.btnSalvaImpostazioni.Text = "Salva";
            this.btnSalvaImpostazioni.UseVisualStyleBackColor = true;
            this.btnSalvaImpostazioni.Click += new System.EventHandler(this.btnSalvaImpostazioni_Click);
            // 
            // btnAnnullaImpostazioni
            // 
            this.btnAnnullaImpostazioni.AccessibleName = "btnAnnullaImpostazioni";
            this.btnAnnullaImpostazioni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnullaImpostazioni.ForeColor = System.Drawing.Color.Black;
            this.btnAnnullaImpostazioni.Location = new System.Drawing.Point(454, 361);
            this.btnAnnullaImpostazioni.Name = "btnAnnullaImpostazioni";
            this.btnAnnullaImpostazioni.Size = new System.Drawing.Size(85, 35);
            this.btnAnnullaImpostazioni.TabIndex = 10;
            this.btnAnnullaImpostazioni.Text = "Annulla";
            this.btnAnnullaImpostazioni.UseVisualStyleBackColor = true;
            this.btnAnnullaImpostazioni.Click += new System.EventHandler(this.btnAnnullaImpostazioni_Click);
            // 
            // grpTasse
            // 
            this.grpTasse.Controls.Add(this.lblNomeStruttura);
            this.grpTasse.Controls.Add(this.btnSalvaImpostazioni);
            this.grpTasse.Controls.Add(this.btnAnnullaImpostazioni);
            this.grpTasse.Controls.Add(this.txtNomeStruttura);
            this.grpTasse.Controls.Add(this.lblTasseSoggiorno);
            this.grpTasse.Controls.Add(this.txtTasse);
            this.grpTasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTasse.ForeColor = System.Drawing.Color.White;
            this.grpTasse.Location = new System.Drawing.Point(0, 0);
            this.grpTasse.Name = "grpTasse";
            this.grpTasse.Size = new System.Drawing.Size(561, 421);
            this.grpTasse.TabIndex = 11;
            this.grpTasse.TabStop = false;
            this.grpTasse.Text = "Inserisci Tassa di Soggiorno";
            // 
            // btnTema
            // 
            this.btnTema.Location = new System.Drawing.Point(33, 39);
            this.btnTema.Name = "btnTema";
            this.btnTema.Size = new System.Drawing.Size(76, 69);
            this.btnTema.TabIndex = 12;
            this.btnTema.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(124, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(325, 50);
            this.button2.TabIndex = 13;
            this.button2.Text = "AGGIORNAMENTO SOFTWARE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnTax
            // 
            this.btnTax.Location = new System.Drawing.Point(33, 128);
            this.btnTax.Name = "btnTax";
            this.btnTax.Size = new System.Drawing.Size(76, 69);
            this.btnTax.TabIndex = 14;
            this.btnTax.UseVisualStyleBackColor = true;
            this.btnTax.Click += new System.EventHandler(this.btnTax_Click);
            // 
            // btnLingua
            // 
            this.btnLingua.Location = new System.Drawing.Point(33, 216);
            this.btnLingua.Name = "btnLingua";
            this.btnLingua.Size = new System.Drawing.Size(76, 69);
            this.btnLingua.TabIndex = 15;
            this.btnLingua.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(33, 313);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(76, 69);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(136, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "AGGIORNAMENTO SOFTWARE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(136, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "IMPOSTAZIONI DI LINGUA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(136, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "MODIFICA TASSE DI SOGGIORNO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(136, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "TEMA E CONTRASTO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Impostazioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(99)))), ((int)(((byte)(227)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(567, 430);
            this.Controls.Add(this.grpTasse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnLingua);
            this.Controls.Add(this.btnTax);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTema);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 200);
            this.Name = "Impostazioni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impostazioni";
            this.Load += new System.EventHandler(this.Impostazioni_Load);
            this.grpTasse.ResumeLayout(false);
            this.grpTasse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeStruttura;
        private System.Windows.Forms.TextBox txtNomeStruttura;
        private System.Windows.Forms.TextBox txtTasse;
        private System.Windows.Forms.Label lblTasseSoggiorno;
        private System.Windows.Forms.Button btnSalvaImpostazioni;
        private System.Windows.Forms.Button btnAnnullaImpostazioni;
        private System.Windows.Forms.GroupBox grpTasse;
        private System.Windows.Forms.Button btnTema;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnTax;
        private System.Windows.Forms.Button btnLingua;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}