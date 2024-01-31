using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kanriBnb.Impostazioni
{
    public partial class Impostazioni : Form
    {
        public Impostazioni()
        {
            InitializeComponent();
            carica_icone();
            grpTasse.Visible = false;
        }

        private void carica_icone()
        {
            btnTema.Image = res.Properties.Resources.tema;
            btnTax.Image = res.Properties.Resources.tax;
            btnUpdate.Image = res.Properties.Resources.update;
            btnLingua.Image = res.Properties.Resources.lingua;



        }
        private void Impostazioni_Load(object sender, EventArgs e)
        {
           
            txtNomeStruttura.Text = Properties.Settings.Default.NomeStruttura;
            txtTasse.Text = Properties.Settings.Default.TasseSoggiorno.ToString();

        }

        private void btnSalvaImpostazioni_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.NomeStruttura = txtNomeStruttura.Text;
            Properties.Settings.Default.TasseSoggiorno = Convert.ToDecimal(txtTasse.Text);
            Properties.Settings.Default.Save();
            MessageBox.Show("Impostazioni salvate correttamente!");
            this.Close();




        }

        private void btnAnnullaImpostazioni_Click(object sender, EventArgs e)
        {
            grpTasse.Visible = false;
        }

        private void btnTax_Click(object sender, EventArgs e)
        {
            grpTasse.Visible = true;
        }
    }
}
