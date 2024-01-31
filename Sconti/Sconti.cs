using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kanriBnb.Sconti
{
    public partial class Sconti : Form
    {
        public Sconti()
        {
            InitializeComponent();
        }

        private void Sconti_Load(object sender, EventArgs e)
        {
            btnAggiungiCosti.Image = res.Properties.Resources.aggiungi;
            btnModificaCosti.Image = res.Properties.Resources.modifica;
            btnEliminaCosti.Image = res.Properties.Resources.rimuovi;
            btnAggiungiCosti.Text = "";
            btnModificaCosti.Text = "";
            btnEliminaCosti.Text = "";
            btnAggiungiSconti.Image = res.Properties.Resources.aggiungi;
            btnModificaSconti.Image = res.Properties.Resources.modifica;
            btnEliminaSconti.Image = res.Properties.Resources.rimuovi;
            btnAggiungiSconti.Text = "";
            btnModificaSconti.Text = "";
            btnEliminaSconti.Text = "";
            grpAggiungiElemento.Visible = false;

            CaricaDatabaseExtra();
            CaricaDatabaseSconti();
        }

        #region GROUPBOX
        private void MostraGroupbox()
        {
            //MOSTRA GROUPBOX
            grpAggiungiElemento.Visible = true;
            radPrezzo.Checked = true;
            radPercentuale.Checked = false;
            //BLOCCA ELEMENTI
            btnAggiungiCosti.Enabled = false;
            btnModificaCosti.Enabled = false;
            btnEliminaCosti.Enabled = false;
            lstCosti.Enabled = false;

            btnAggiungiSconti.Enabled = false;
            btnModificaSconti.Enabled = false;
            btnEliminaSconti.Enabled = false;
            lstSconti.Enabled = false;

        }

        private void NascondiGroupbox()
        {
            //NASCONDI GROUPBOX
            grpAggiungiElemento.Visible = false;

            //SBLOCCA ELEMENTI 
            btnAggiungiCosti.Enabled = true;
            btnModificaCosti.Enabled = true;
            btnEliminaCosti.Enabled = true;
            lstCosti.Enabled = true;

            btnAggiungiSconti.Enabled = true;
            btnModificaSconti.Enabled = true;
            btnEliminaSconti.Enabled = true;
            lstSconti.Enabled = true;
        }

        private void btnAnnullaElemento_Click(object sender, EventArgs e)
        {
            NascondiGroupbox();
        }

        private void btnSalvaElemento_Click(object sender, EventArgs e)
        {
            // VERIFICA CAMPI
            if (txtElemento.Text.Length < 1 || txtPrezzo.Text.Length < 1)
            {
                MessageBox.Show("Elemento e Prezzo non possono essere vuoti!");
                return;
            }
            if (System.Text.RegularExpressions.Regex.Match(txtPrezzo.Text, @"^[0-9,.€]*$").Success is true)
            {
                if (txtPrezzo.Text.Contains("€"))
                {
                    txtPrezzo.Text = txtPrezzo.Text.Replace("€", "");
                }
                if (txtPrezzo.Text.Contains(","))

                {
                    txtPrezzo.Text = txtPrezzo.Text.Replace(",", ".");
                }

            }
            else
            {
                MessageBox.Show("Il campo 'Prezzo' contiene caratteri non validi!");
                return;
            }

            //REGISTRA DATI
            string stringa_connessione = Properties.Settings.Default.CamereConnectionString;
            SqlConnection connessioneDB = new SqlConnection(stringa_connessione);
            if (connessioneDB.State != ConnectionState.Open)
            {
                connessioneDB.Open();
            }

            //QUERY DATABASE
            string SqlQuery = "";
            int varTipologia = 0;
            if (radPercentuale.Checked == true)
            {
                varTipologia = 1;
            }

            ElementiTag CaricaElementi = (ElementiTag)grpAggiungiElemento.Tag;
            if (CaricaElementi.TipoElemento == "aggiungi" && CaricaElementi.Tabella == "extra")
            {
                
                //AGGIUNGI ELEMENTO EXTRA
                SqlQuery = "INSERT INTO [tblExtra] ([Elemento], [Prezzo], [Tipologia], [Descrizione]) VALUES ('" + txtElemento.Text
               + "',  '" + txtPrezzo.Text + "', '" + varTipologia + "', '" + txtDescrizione.Text + "')";

               
            }
            else if (CaricaElementi.TipoElemento == "modifica" && CaricaElementi.Tabella == "extra")
            {
                string varID = CaricaElementi.IdElemento;
       
                // MODIFICA ELEMENTO EXTRA
                SqlQuery = "UPDATE [tblExtra] SET [Elemento] = '" + txtElemento.Text + "', [Prezzo] = '" + txtPrezzo.Text + "'," +
                    " [Tipologia] = '" + varTipologia + "', [Descrizione] = '" + txtDescrizione.Text + "' WHERE [Id] = '" + varID + "';";


            }
            else if (CaricaElementi.TipoElemento == "aggiungi" && CaricaElementi.Tabella == "sconti")
            {
                // INSERISCI NUOVO ELEMENTO SCONTI
                SqlQuery = "INSERT INTO [tblSconti] ([Elemento], [Prezzo], [Tipologia], [Descrizione]) VALUES ('" + txtElemento.Text
             + "',  '" + txtPrezzo.Text + "', '" + varTipologia + "', '" + txtDescrizione.Text + "')";
            }
            else 
            {
                string varID = CaricaElementi.IdElemento;
                //MODIFICA ELEMENTO SCONTI
                SqlQuery = "UPDATE [tblSconti] SET [Elemento] = '" + txtElemento.Text + "', [Prezzo] = '" + txtPrezzo.Text + "'," +
                    " [Tipologia] = '" + varTipologia + "', [Descrizione] = '" + txtDescrizione.Text + "' WHERE [Id] = '" + varID + "';";
            }

            grpAggiungiElemento.Tag = "";

            SqlCommand QueryInsertIntoCamere = new SqlCommand(SqlQuery, connessioneDB);
            try
            {
                QueryInsertIntoCamere.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {

                if (ex.Number.ToString() == "2627")
                {
                    MessageBox.Show("L'ID inserito è già in uso.");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
                return;
            }
            connessioneDB.Close();

            //chiudere groupbox
            NascondiGroupbox();
            //CARICA DATABASE
            if(CaricaElementi.Tabella == "extra")
            {
                lstCosti.Items.Clear();
                CaricaDatabaseExtra();

            } else if (CaricaElementi.Tabella == "sconti")
            {
                // CARICA DATABASE SCONTI
                lstSconti.Items.Clear();
                CaricaDatabaseSconti();
            }

        }

        private void ResetGroupbox()
        {
            txtElemento.Text = "";
            txtPrezzo.Text = "";
            txtDescrizione.Text = "";
            radPrezzo.Checked = true;
            radPercentuale.Checked = false;
        }

        #endregion

        #region SEZIONE COSTI EXTRA
        async void CaricaDatabaseExtra()
        {

            string stringa_connessione = Properties.Settings.Default.CamereConnectionString;
            SqlConnection connessioneDB = new SqlConnection(stringa_connessione);
            //CARICA ELEMENTI EXTRA
            string SqlQuery = "SELECT * FROM [tblExtra]";
            using (connessioneDB)
            {
                try
                {
                    await connessioneDB.OpenAsync();
                    var InviaQuery = new SqlCommand(SqlQuery, connessioneDB);
                    SqlDataReader DatiTabellaCamere = await InviaQuery.ExecuteReaderAsync();
                    while (DatiTabellaCamere.Read())
                    {
                        int valoreId = DatiTabellaCamere.GetInt32(0);
                        string valoreElemento = DatiTabellaCamere.GetString(1);
                        decimal valorePrezzo = DatiTabellaCamere.GetDecimal(2);
                        int valoreTipologia = DatiTabellaCamere.GetInt32(3);
                        string valoreDescrizione = DatiTabellaCamere.GetString(4);
                        ListViewItem NuovoElemento = new ListViewItem();
                        NuovoElemento.Text = valoreElemento;
                        NuovoElemento.Tag = valoreId;
                        NuovoElemento.SubItems.Add(DatiTabellaCamere.GetDecimal(2).ToString());
                        if (valoreTipologia == 0)
                        {
                            NuovoElemento.SubItems.Add("€");
                        } else
                        {
                            NuovoElemento.SubItems.Add("%");
                        }

                        NuovoElemento.SubItems.Add(DatiTabellaCamere.GetString(4));
                        lstCosti.Items.Add(NuovoElemento);

                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (connessioneDB.State != ConnectionState.Open)
                    {
                        connessioneDB.Close();
                    }
                }


            }

        }

          private void lstCosti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstCosti.SelectedItems.Count > 0)
            {
                btnModificaCosti.Enabled = true;
                btnEliminaCosti.Enabled = true;

            } else
            {
                btnModificaCosti.Enabled = false;
                btnEliminaCosti.Enabled = false;
            }
            
        }

           private void btnAggiungiCosti_Click(object sender, EventArgs e)
        {
            ResetGroupbox();
            MostraGroupbox();
            grpAggiungiElemento.Text = "Aggiungi Costo Extra";
            grpAggiungiElemento.Tag = new ElementiTag { TipoElemento = "aggiungi", Tabella = "extra" };

          
        }

          private void btnModificaCosti_Click(object sender, EventArgs e)
        {
            if(lstCosti.SelectedItems.Count < 1)
            {
                MessageBox.Show("Selezionare un elemento da modificare");
                return;
                    
            }
            MostraGroupbox();
            grpAggiungiElemento.Text = "Modifica Costo Extra";
            grpAggiungiElemento.Tag = new ElementiTag { TipoElemento = "modifica", Tabella = "extra", IdElemento = lstCosti.SelectedItems[0].Tag.ToString() };
            txtElemento.Text = lstCosti.SelectedItems[0].Text;
            txtPrezzo.Text = lstCosti.SelectedItems[0].SubItems[1].Text;
            if(lstCosti.SelectedItems[0].SubItems[2].Text == "€")
            {
                radPrezzo.Checked = true;
                radPercentuale.Checked = false;

            } else if (lstCosti.SelectedItems[0].SubItems[2].Text == "%")
            {
                radPrezzo.Checked = false;
                radPercentuale.Checked = true;

            } else
            {
                radPrezzo.Checked = true;
                radPercentuale.Checked = false;
            }
            txtDescrizione.Text = lstCosti.SelectedItems[0].SubItems[3].Text;
        }

          private void btnEliminaCosti_Click(object sender, EventArgs e)
        {
            if(lstCosti.SelectedItems.Count < 1)
            {
                MessageBox.Show("Seleziona un elemento da rimuovere");
                return;
            }
            string stringa_connessione = Properties.Settings.Default.CamereConnectionString;
            SqlConnection connessioneDB = new SqlConnection(stringa_connessione);
            if (connessioneDB.State != ConnectionState.Open)
            {
                connessioneDB.Open();
            }

            //QUERY DATABASE
            // DELETE

            string IdRimozione = lstCosti.SelectedItems[0].Tag.ToString();
            string SqlQuery = "DELETE FROM [tblExtra] WHERE [Id] =  '" + IdRimozione + "';";


            SqlCommand QueryInsertIntoCamere = new SqlCommand(SqlQuery, connessioneDB);
            try
            {
                if (MessageBox.Show("Sei sicuro di voler rimuovere l'elemento con ID: " + IdRimozione + ":("+ lstCosti.SelectedItems[0].Text + ")","?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    QueryInsertIntoCamere.ExecuteNonQuery();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Number.ToString());
            }
            connessioneDB.Close();
            //RICARICA DATABASE
            lstCosti.Items.Clear();
            CaricaDatabaseExtra();
            
        }

        #endregion


        #region SEZIONE SCONTI ED OFFERTE

        async void CaricaDatabaseSconti()
        {
            //CONNESSIONE DATABASE
            string stringa_connessione = Properties.Settings.Default.CamereConnectionString;
            SqlConnection connessioneDB = new SqlConnection(stringa_connessione);
            // CARICA ELEMENTI SCONTI
            string sqlQuery = "SELECT * FROM [tblSconti]";
            using (connessioneDB)
            {
                try
                {
                    await connessioneDB.OpenAsync();
                    var InviaQuery = new SqlCommand(sqlQuery, connessioneDB);
                    SqlDataReader DatiTabellaCamere = await InviaQuery.ExecuteReaderAsync();
                    while (DatiTabellaCamere.Read())
                    {
                        int valoreId = DatiTabellaCamere.GetInt32(0);
                        string valoreElemento = DatiTabellaCamere.GetString(1);
                        decimal valorePrezzo = DatiTabellaCamere.GetDecimal(2);
                        int valoreTipologia = DatiTabellaCamere.GetInt32(3);
                        string valoreDescrizione = DatiTabellaCamere.GetString(4);
                        ListViewItem NuovoElemento = new ListViewItem();
                        NuovoElemento.Text = valoreElemento;
                        NuovoElemento.Tag = valoreId;
                        NuovoElemento.SubItems.Add(DatiTabellaCamere.GetDecimal(2).ToString());
                        if (valoreTipologia == 0)
                        {
                            NuovoElemento.SubItems.Add("€");
                        }
                        else
                        {
                            NuovoElemento.SubItems.Add("%");
                        }
                        //
                        NuovoElemento.SubItems.Add(DatiTabellaCamere.GetString(4));
                        lstSconti.Items.Add(NuovoElemento);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (connessioneDB.State == ConnectionState.Open)
                    {
                        connessioneDB.Close();
                    }
                }
            }
        }
       
        private void btnEliminaSconti_Click(object sender, EventArgs e)
        {
            if (lstSconti.SelectedItems.Count < 1)
            {
                MessageBox.Show("Seleziona un elemento da rimuovere");
                return;
            }

            //CONNESSIONE DATABASE
            string stringa_connessione = Properties.Settings.Default.CamereConnectionString;
            SqlConnection connessioneDB = new SqlConnection(stringa_connessione);
            if (connessioneDB.State != ConnectionState.Open)
            {
                connessioneDB.Open();
            }
            //QUERY DATABASE
            // DELETE FROM [tblCamere] WHERE ID = 'valore';
            string IdRimozione = lstSconti.SelectedItems[0].Tag.ToString();
            string sqlQuery = "DELETE FROM [tblSconti] WHERE [Id] = '" + IdRimozione + "';";
            SqlCommand QueryInserimentoCamera = new SqlCommand(sqlQuery, connessioneDB);
            try
            {
                if (MessageBox.Show("Sei sicuro di voler rimuovere l'elemento con ID " + IdRimozione + ": (" + lstSconti.SelectedItems[0].Text + ")?", "Rimuovere la camera?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    QueryInserimentoCamera.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Number.ToString());
            }
            connessioneDB.Close();
            // RICARICA DATABASE
            lstSconti.Items.Clear();
            CaricaDatabaseSconti();
        }
       
        private void btnAggiungiSconti_Click(object sender, EventArgs e)
        {
            ResetGroupbox();
            MostraGroupbox();
            grpAggiungiElemento.Text = "Aggiungi Sconto e Offerta";
            grpAggiungiElemento.Tag = new ElementiTag { TipoElemento = "aggiungi", Tabella = "sconti" };
        }

        private void lstSconti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSconti.SelectedItems.Count > 0)
            {
                btnModificaSconti.Enabled = true;
                btnEliminaSconti.Enabled = true;
            }
            else
            {
                btnModificaSconti.Enabled = false;
                btnEliminaSconti.Enabled = false;
            }
        }

        private void btnModificaSconti_Click(object sender, EventArgs e)
        {
            if (lstSconti.SelectedItems.Count < 1)
            {
                MessageBox.Show("Selezionare l'elemento da modificare");
                return;
            }
            MostraGroupbox();
            grpAggiungiElemento.Text = "Modifica Sconto e Offerta";
            grpAggiungiElemento.Tag = new ElementiTag { TipoElemento = "modifica", Tabella = "sconti", IdElemento = lstSconti.SelectedItems[0].Tag.ToString() };
            txtElemento.Text = lstSconti.SelectedItems[0].Text;
            txtPrezzo.Text = lstSconti.SelectedItems[0].SubItems[1].Text;
            if (lstSconti.SelectedItems[0].SubItems[2].Text == "€")
            {
                radPrezzo.Checked = true;
                radPercentuale.Checked = false;
            }
            else if (lstSconti.SelectedItems[0].SubItems[2].Text == "%")
            {
                radPrezzo.Checked = false;
                radPercentuale.Checked = true;
            }
            else
            {
                radPrezzo.Checked = true;
                radPercentuale.Checked = false;
            }
            txtDescrizione.Text = lstSconti.SelectedItems[0].SubItems[3].Text;
        }




        #endregion

        
        private void Sconti_Paint(object sender, PaintEventArgs e)
        { 
            
            System.Drawing.Size DimensioneListView = new Size();
            DimensioneListView.Width = this.Width - 45;
            DimensioneListView.Height = this.Height - 45 - lblSconti.Top - 15;

          //    lstCosti.Height = Convert.ToInt32(Math.Round(this.Height * 0.45, 0));
            //  lstCosti.MaximumSize = DimensioneListView;

              lstCosti.Width = this.Width - 18 - 90;
               lstSconti.Width = this.Width - 18 - 90;

            //    lstSconti.Height = this.Height - lstSconti.Top - 94;
            //   lblSconti.Top = lstCosti.Bottom + 15;
            //     lblSconti.Top = lstSconti.Bottom + 12;

            //RIPOSIZIONAMENTO BUTTON
          //      btnAggiungiSconti.Top = lstSconti.Top;
           //     btnModificaSconti.Top = btnAggiungiSconti.Top + 40;
           //   btnEliminaSconti.Top = btnModificaSconti.Top + 40;

            //GROUPBOX CENTRATA
              grpAggiungiElemento.Top = Convert.ToInt32(Math.Round(this.Height / 2.0, 0)) - Convert.ToInt32(Math.Round(grpAggiungiElemento.Height / 2.0, 0));
               grpAggiungiElemento.Left = Convert.ToInt32(Math.Round(this.Width / 2.0, 0)) - Convert.ToInt32(Math.Round(grpAggiungiElemento.Width / 2.0, 0));


        }
    }

    public class ElementiTag
        {
            public string TipoElemento;  //aggiungi o modificare
            public string Tabella;    // sconti o extra
            public string IdElemento = "";
        }


}
