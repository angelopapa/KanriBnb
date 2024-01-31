using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kanriBnb
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //icone 
            carica_icone();
            carica_ora();
            timerOrario.Enabled = true;
            timerOrario.Start();
        }

        private void carica_icone()
        {
            btnPrenotazione.Image = res.Properties.Resources.prenotazioni;
            btnCamere.Image = res.Properties.Resources.letto;
            btnImpostazioni.Image = res.Properties.Resources.impostazioni;
            btnInfo.Image = res.Properties.Resources.info;
            lblOrario.Image = res.Properties.Resources.ora;
            lblOrario.ImageAlign = ContentAlignment.MiddleRight;
            btnSconti.Image = res.Properties.Resources.sconti;

        }

        private void carica_ora()
        {
            lblOrario.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnPrenotazione_Click(object sender, EventArgs e)
        {
            Prenotazioni.Prenotazioni FormPrenotazioni = new Prenotazioni.Prenotazioni();
            FormPrenotazioni.ShowDialog();
        }

        private void Camere_Load_Click(object sender, EventArgs e)
        {
            Camere.Camere FormCamere = new Camere.Camere();
            FormCamere.ShowDialog();
        }

        private void timerOrario_Tick(object sender, EventArgs e)
        {
            carica_ora();
        }

        private void btnImpostazioni_Click(object sender, EventArgs e)
        {
            for (int a = 0; a < Application.OpenForms.Count; a++)
            {


                if (Application.OpenForms[a].Name == "Impostazioni")
                {
                    Application.OpenForms[a].BringToFront();
                    return;
                }
            }
            Impostazioni.Impostazioni FormImpostazioni = new Impostazioni.Impostazioni();
            FormImpostazioni.Show();
        }

        private void btnSconti_Click(object sender, EventArgs e)
        {
            for (int a = 0; a < Application.OpenForms.Count; a++)
            {
               

                if (Application.OpenForms[a].Name == "Sconti")
                {
                    Application.OpenForms[a].BringToFront();
                    return;
                }
            }
            Sconti.Sconti FormSconti = new Sconti.Sconti();
            FormSconti.Show();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Info.Info FormInfo = new Info.Info();
            FormInfo.ShowDialog();
        }
    }
}
