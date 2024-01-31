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
using System.Text.RegularExpressions;

namespace kanriBnb.Prenotazioni
{
    public partial class Prenotazioni : Form
    {

        public Prenotazioni()
        {
            InitializeComponent();
           
        }

        private void Prenotazioni_Load(object sender, EventArgs e)
        {

            pnlAggiungiPrenotazioni.Visible = false;
            CaricaDatabasePrenotazioni();
        }

        private void ResetPannello()
        {
            pnlAggiungiPrenotazioni.Visible = false;
        }

        // AGGIUNGI PRENOTAZIONE
        private void btnAggiungiPrenotazioni_Click(object sender, EventArgs e)
        {
            if (pnlAggiungiPrenotazioni.Visible == false)
            {
                pnlAggiungiPrenotazioni.Visible = true;
                btnSalvaPrenotazione.Tag = "aggiungi";
            }
            else
            {
                pnlAggiungiPrenotazioni.Visible = false;
            }
        }
        // MODIFICA PRENOTAZIONE
        private void btnModificaPrenotazione_Click(object sender, EventArgs e)
        {
            if (pnlAggiungiPrenotazioni.Visible == false)
            {
                pnlAggiungiPrenotazioni.Visible = true;
                pnlAggiungiPrenotazioni.Dock = DockStyle.Left;
                btnSalvaPrenotazione.Tag = "modifica";

                CaricaDatiPrenotazioneSelezionata();
            }
            else
            {
                pnlAggiungiPrenotazioni.Visible = false;
            }
        }
        private string IdPrenotazione;
        private void CaricaDatiPrenotazioneSelezionata()
        {
            //AGGIUNTI DATI PRENOTAZIONE
            IdPrenotazione = dataElencoPrenotazioni.Rows[dataElencoPrenotazioni.SelectedRows[0].Index].Cells[0].Value.ToString();
            txtNome.Text = dataElencoPrenotazioni.Rows[dataElencoPrenotazioni.SelectedRows[0].Index].Cells[1].Value.ToString();
            txtCognome.Text = dataElencoPrenotazioni.Rows[dataElencoPrenotazioni.SelectedRows[0].Index].Cells[2].Value.ToString();
            txtIndirizzo.Text = dataElencoPrenotazioni.Rows[dataElencoPrenotazioni.SelectedRows[0].Index].Cells[3].Value.ToString();
            txtcitta.Text = dataElencoPrenotazioni.Rows[dataElencoPrenotazioni.SelectedRows[0].Index].Cells[4].Value.ToString();
            txtCAP.Text = dataElencoPrenotazioni.Rows[dataElencoPrenotazioni.SelectedRows[0].Index].Cells[5].Value.ToString();
            cmbNazione.Text = dataElencoPrenotazioni.Rows[dataElencoPrenotazioni.SelectedRows[0].Index].Cells[6].Value.ToString();
            dateNascita.Value = Convert.ToDateTime(dataElencoPrenotazioni.Rows[dataElencoPrenotazioni.SelectedRows[0].Index].Cells[7].Value.ToString());
            txtTelefono.Text = dataElencoPrenotazioni.Rows[dataElencoPrenotazioni.SelectedRows[0].Index].Cells[8].Value.ToString();
            txtEmail.Text = dataElencoPrenotazioni.Rows[dataElencoPrenotazioni.SelectedRows[0].Index].Cells[9].Value.ToString();
            cmbTipoDocumento.Text = dataElencoPrenotazioni.Rows[dataElencoPrenotazioni.SelectedRows[0].Index].Cells[10].Value.ToString();
            txtCodiceDocumento.Text = dataElencoPrenotazioni.Rows[dataElencoPrenotazioni.SelectedRows[0].Index].Cells[11].Value.ToString();
            txtCaricaDocumenti.Text = dataElencoPrenotazioni.Rows[dataElencoPrenotazioni.SelectedRows[0].Index].Cells[12].Value.ToString();
            dateArrivo.Value = Convert.ToDateTime(dataElencoPrenotazioni.Rows[dataElencoPrenotazioni.SelectedRows[0].Index].Cells[13].Value.ToString());
            datePartenza.Value = Convert.ToDateTime(dataElencoPrenotazioni.Rows[dataElencoPrenotazioni.SelectedRows[0].Index].Cells[14].Value.ToString());
            numNotti.Value = Convert.ToInt32(dataElencoPrenotazioni.Rows[dataElencoPrenotazioni.SelectedRows[0].Index].Cells[15].Value.ToString());
            numOspiti.Value = Convert.ToInt32(dataElencoPrenotazioni.Rows[dataElencoPrenotazioni.SelectedRows[0].Index].Cells[16].Value);
            cbxCamera.Text = dataElencoPrenotazioni.Rows[dataElencoPrenotazioni.SelectedRows[0].Index].Cells[17].Value.ToString();
            txtNote.Text = dataElencoPrenotazioni.Rows[dataElencoPrenotazioni.SelectedRows[0].Index].Cells[18].Value.ToString();
            // CostiExtra
            ModificaCostiSconti("costo", dataElencoPrenotazioni.Rows[dataElencoPrenotazioni.SelectedRows[0].Index].Cells[19].Value.ToString());
            // ScontiExtra
            ModificaCostiSconti("sconto", dataElencoPrenotazioni.Rows[dataElencoPrenotazioni.SelectedRows[0].Index].Cells[20].Value.ToString());
            if (dataElencoPrenotazioni.Rows[dataElencoPrenotazioni.SelectedRows[0].Index].Cells[21].Value.ToString() == "True")
            { cbxTasseSoggiorno.Checked = true; }
            else
            { cbxTasseSoggiorno.Checked = false; }
            txtEsenzione.Text = dataElencoPrenotazioni.Rows[dataElencoPrenotazioni.SelectedRows[0].Index].Cells[22].Value.ToString();
            cmbPagamento.Text = dataElencoPrenotazioni.Rows[dataElencoPrenotazioni.SelectedRows[0].Index].Cells[23].Value.ToString();
            txtTotale.Text = dataElencoPrenotazioni.Rows[dataElencoPrenotazioni.SelectedRows[0].Index].Cells[24].Value.ToString();         
        }

        // RIMUOVI PRENOTAZIONE
        private void btnRimuoviPrenotazione_Click(object sender, EventArgs e)
        {
            //CONNESSIONE DATABASE
            string stringa_connessione = Properties.Settings.Default.CamereConnectionString;
            SqlConnection connessioneDB = new SqlConnection(stringa_connessione);
            if (connessioneDB.State != ConnectionState.Open)
            {
                connessioneDB.Open();
            }
            //QUERY DATABASE
            // DELETE FROM [tblCamere] WHERE ID = 'valore';
            string IdRimozione = dataElencoPrenotazioni.Rows[dataElencoPrenotazioni.SelectedRows[0].Index].Cells[0].Value.ToString();
            string sqlQuery = "DELETE FROM [tblPrenotazioni] WHERE [Id] = '" + IdRimozione + "';";
            SqlCommand QueryRimozionePrenotazione = new SqlCommand(sqlQuery, connessioneDB);
            try
            {
                if (MessageBox.Show("Sei sicuro di voler rimuovere la prenotazione con ID: " + IdRimozione + " ?", "Rimuovere la prenotazione?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    QueryRimozionePrenotazione.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Number.ToString());
            }
            connessioneDB.Close();
            // RICARICA DATABASE
            CaricaDatabasePrenotazioni();
        }

        private void btnAnnullaPrenotazione_Click(object sender, EventArgs e)
        {
            ResetPannello();
        }



            private void btnSalvaPrenotazione_Click(object sender, EventArgs e)
        {
            // CONTROLLO PRESENZA NOME E COGNOME
            if (txtNome.Text.Length < 2 || txtCognome.Text.Length < 2)
            {
                MessageBox.Show("I campi Nome e Cognome non possono contenere meno di 2 caratteri!");
                return;
            }
            // CONTROLLO EMAIL 
            if (txtEmail.Text.Length < 1)
            {
                MessageBox.Show("Il campo 'Email' è obbligatorio e deve essere un formato valido nome@indirizzo.xxx");
                return;
            }
            // CONTROLLO CAP
            if (txtCAP.Text.Length >= 6)
            {
                MessageBox.Show("Il codice di avviamento postale non può avere più di 5 cifre");
                return;
            }
            // CONTROLLO DATA ARRIVO E DATA PARTENZA
            if (DateTime.Compare(dateArrivo.Value, DateTime.Now) < 0)
            {
                MessageBox.Show("La data di arrivo non può essere antecedente al giorno stesso.");
                return;
            }
            if (DateTime.Compare(datePartenza.Value, dateArrivo.Value) < 0)
            {
                MessageBox.Show("La data di partenza non può essere antecedente alla data di arrivo.");
                return;
            }
            // CONTROLLO NUMERO NOTTI E NUMERO OSPITI
            if (numNotti.Value < 1 || numOspiti.Value < 1)
            {
                MessageBox.Show("I campi Notti ed Ospiti non possono essere inferiori ad 1!");
                return;
            }
            // CONTROLLO CAMERA SCELTA
            if (cbxCamera.Text.Length < 1)
            {
                MessageBox.Show("Non è stata selezionata la camera dell'ospite.");
                return;
            }
            // CONTROLLO TOTALE
            if (txtTotale.Text.Length < 1)
            {
                MessageBox.Show("Non è stato inserito il costo totale della prenotazione.");
                return;
            }
            // CONTROLLO NUMERO CARTA
            if (txtNumeroCarta.Text.Length >= 17)
            {
                MessageBox.Show("La carta di credito ha troppe cifre!");
                return;
            }
            //CONTROLLO CVV
            if (txtCVV.Text.Length >= 4)
            {
                MessageBox.Show("Troppi valori sul CVV!");
                return;
            }
           
            string IDCliente = dateArrivo.Value.Year + dateArrivo.Value.Month + dateArrivo.Value.Day + ControllaCaratteri(txtNome.Text) + ControllaCaratteri(txtCognome.Text);
            SalvaPrenotazione(IDCliente);
        }



        void SalvaPrenotazione(string IdCliente)
        {
            int SwitchTasseSoggiorno = 0;
            string StringaCostiExtra = StringaDaListBox(lstCosti);
            string StringaScontiExtra = StringaDaListBox(lstSconti);
            if (cbxTasseSoggiorno.Checked == true)
            {
                SwitchTasseSoggiorno = 1;
            }
            else
            { SwitchTasseSoggiorno = 0; }
            //CONNESSIONE DATABASE
            string stringa_connessione = Properties.Settings.Default.CamereConnectionString;
            SqlConnection connessioneDB = new SqlConnection(stringa_connessione);
            if (connessioneDB.State != ConnectionState.Open)
            {
                connessioneDB.Open();
            }

            //QUERY DATABASE
            string sqlQuery = "";
            if (btnSalvaPrenotazione.Tag == "aggiungi")
            {
                sqlQuery = "INSERT INTO [tblPrenotazioni] ([Id], [Nome], [Cognome], [Indirizzo], [Citta] , [Cap], [Nazione], [DataNascita]," +
            "[Telefono], [Email], [TipoDocumento], [CodiceDocumento], [Documento], [DataArrivo], [DataPartenza], [NumeroNotti], [NumeroOspiti]," +
            "[Camera], [Note], [CostiExtra], [ScontiExtra], [TasseSoggiorno], [MotivoEsenzione], [MetodoPagamento], [Totale]) VALUES ('" + IdCliente
       + "', '" + CorreggiApici(txtNome.Text) + "', '" + CorreggiApici(txtCognome.Text) + "', '" + CorreggiApici(txtIndirizzo.Text) + "', '" + CorreggiApici(txtcitta.Text) + "', '" + txtCAP.Text + "', '" + CorreggiApici(cmbNazione.Text)
       + "', '" + ConvertiData(dateNascita.Value.Day, dateNascita.Value.Month, dateNascita.Value.Year) + "', '" + txtTelefono.Text + "', '" + txtEmail.Text + "', '" + CorreggiApici(cmbTipoDocumento.Text) + "', '" + txtCodiceDocumento.Text
       + "', '" + CorreggiApici(txtCaricaDocumenti.Text) + "', '" + ConvertiData(dateArrivo.Value.Day, dateArrivo.Value.Month, dateArrivo.Value.Year) + "', '" + ConvertiData(datePartenza.Value.Day, datePartenza.Value.Month, datePartenza.Value.Year)
       + "', '" + numNotti.Value + "', '" + numOspiti.Text + "', '" + CorreggiApici(cbxCamera.Text) + "', '" + CorreggiApici(txtNote.Text) + "', '" + CorreggiApici(StringaCostiExtra) + "', '" + CorreggiApici(StringaScontiExtra)
       + "', '" + SwitchTasseSoggiorno + "', '" + CorreggiApici(txtEsenzione.Text) + "', '" + cmbPagamento.Text + "', '" + ConvertiPrezzoFinale(txtTotale) + "');";
            }
            else
            {
                sqlQuery = "UPDATE [Prenotazioni] SET [Id] = '" + IdPrenotazione + "', [Nome] = '" + CorreggiApici(txtNome.Text) + "', [Cognome] = '"
                     + CorreggiApici(txtCognome.Text) + "', [Indirizzo] = '" + CorreggiApici(txtIndirizzo.Text) + "', [Citta] = '"
                     + CorreggiApici(txtcitta.Text) + "', [CAP] = '" + txtCAP.Text + "', [Nazione] = '" + CorreggiApici(cmbNazione.Text)
                     + "', [DataNascita] = '" + ConvertiData(dateNascita.Value.Year, dateNascita.Value.Month, dateNascita.Value.Day)
                     + "', [Telefono] = '" + txtTelefono.Text
                     + "', [Email] = '" + txtEmail.Text + "', [TipoDocumento] = '" + CorreggiApici(cmbTipoDocumento.Text)
                     + "', [CodiceDocumento] = '" + txtCodiceDocumento.Text + "', [Documento] = '" + txtCaricaDocumenti.Text
                     + "', [DataArrivo] = '" + ConvertiData(dateArrivo.Value.Year, dateArrivo.Value.Month, dateArrivo.Value.Day)
                     + "', [DataPartenza] = '" + ConvertiData(datePartenza.Value.Year, datePartenza.Value.Month, datePartenza.Value.Day)
                     + "', [NumeroNotti] = '" + numNotti.Value + "', [NumeroOspiti] = '" + "', [Camera] = '" + CorreggiApici(cbxCamera.Text)
                     + "', [Note] = '" + txtNote.Text + "', [CostiExtra] = '" + CorreggiApici(StringaCostiExtra) + "', [Sconti]"
                     + CorreggiApici(StringaScontiExtra) + "', [TasseSoggiorno] = '" + SwitchTasseSoggiorno + "', [MotivoEsenzione] = '"
                     + CorreggiApici(txtEsenzione.Text) + "', [MetodoPagamento] = '" + cmbPagamento.Text                 
                    + "', [Totale] = '" + ConvertiPrezzoFinale(txtTotale) + "WHERE [Id] = '" + IdPrenotazione + "';"; 
            }
            btnSalvaPrenotazione.Tag = "";

            SqlCommand QueryInserimentoCamera = new SqlCommand(sqlQuery, connessioneDB);
            try
            {
                QueryInserimentoCamera.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (ex.Number.ToString() == "2627")
                {
                    MessageBox.Show("L'ID inserito è già presente.");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
                return;
            }
            connessioneDB.Close();
            //ricarica database
            CaricaDatabasePrenotazioni();
            //reset pannello
             ResetPannello();

            // RICARICA DATABASE
            MessageBox.Show("La Prenotazione è stata aggiunta correttamente");
        }

        void ModificaCostiSconti(string TipoExtra, string ElencoExtra)
        {
            string[] ArrayExtra = ElencoExtra.Split(';');

            for (int a = 0; a < ArrayExtra.Length; a++)
            {
                if (ArrayExtra[a].Contains(": "))
                {
                    string CaratteriIniziali = ArrayExtra[a].Remove(ArrayExtra[a].IndexOf(": "));
                    bool IndiceNumerico = int.TryParse(CaratteriIniziali, out _);
                    if (IndiceNumerico == true)
                    {
                        //NUOVO METODO
                        CaricaDatabaseCostiSconti();
                        for (int b = 0; b < cmbExtra.Items.Count; b++)
                        {
                            if (ArrayExtra[a] == cmbExtra.GetItemText(cmbExtra.SelectedIndex))
                            {
                                var ExtraSelezionato = (ExtraScontiItem)cmbExtra.SelectedItem;
                                if (TipoExtra == "costo")
                                {
                                    lstCosti.Items.Add(new ExtraScontiItem(ExtraSelezionato.ToString(), ExtraSelezionato.PrezzoExtra(), ExtraSelezionato.TipologiaExtra()));
                                }
                                else
                                {
                                    lstSconti.Items.Add(new ExtraScontiItem(ExtraSelezionato.ToString(), ExtraSelezionato.PrezzoExtra(), ExtraSelezionato.TipologiaExtra()));
                                }
                            }
                        }
                    }
                    else
                    {
                        // VECCHIO METODO
                        CaricaDatabaseCostiSconti();
                        for (int b = 0; b < cmbExtra.Items.Count; b++)
                        {
                            string ElementoDaControllare = cmbExtra.GetItemText(cmbExtra.SelectedIndex);
                            if (ArrayExtra[a] == ElementoDaControllare.Substring(ElementoDaControllare.IndexOf(": ")))
                            {
                                var ExtraSelezionato = (ExtraScontiItem)cmbExtra.SelectedItem;
                                if (TipoExtra == "costo")
                                {
                                    lstCosti.Items.Add(new ExtraScontiItem(ExtraSelezionato.ToString(), ExtraSelezionato.PrezzoExtra(), ExtraSelezionato.TipologiaExtra()));
                                }
                                else
                                {
                                    lstSconti.Items.Add(new ExtraScontiItem(ExtraSelezionato.ToString(), ExtraSelezionato.PrezzoExtra(), ExtraSelezionato.TipologiaExtra()));
                                }
                            }
                        }
                    }
                }

            }

        }

        String CorreggiApici(string StringaDaControllare)
        {
            string StringaCorretta = StringaDaControllare.Replace("'", "''");
            StringaCorretta = StringaCorretta.Trim();
            return StringaCorretta;
        }

        String ConvertiData(int AnnoInput, int MeseInput, int GiornoInput)
        {
            String DataFinale = GiornoInput + "/" + MeseInput + "/" + AnnoInput;
            return DataFinale;
        }

        string ConvertiPrezzoFinale(TextBox TextInput)
        {
            if (System.Text.RegularExpressions.Regex.Match(TextInput.Text, @"^[0-9,.€]*$").Success is true)
            {
                if (TextInput.Text.Contains("€"))
                {
                    TextInput.Text = TextInput.Text.Replace("€", "");
                }
                if (TextInput.Text.Contains(","))
                {
                    TextInput.Text = TextInput.Text.Replace(",", ".");
                }
            }
            string PrezzoFinale = TextInput.Text;
            return PrezzoFinale;
        }
        string StringaDaListBox(ListBox ListBoxInput)
        {
            string StringaFinale = "";
            if (ListBoxInput.Items.Count > 0)
            {
                for (int a = 0; a < ListBoxInput.Items.Count; a++)
                {
                    StringaFinale = StringaFinale + ListBoxInput.Items[a];
                    if (a != ListBoxInput.Items.Count - 1)
                    {
                        StringaFinale = StringaFinale + ";";
                    }
                }
            }
            return StringaFinale;
        }

        private string ControllaCaratteri(string TestoDaControllare)
        {
            foreach (char Carattere in TestoDaControllare)
            {
                if (Char.IsLetterOrDigit(Carattere) == false)
                {
                    TestoDaControllare = TestoDaControllare.Replace(Carattere, '_');
                }
            }
            return TestoDaControllare;
        }
        private async void CaricaDatabaseCamere()
        {
            cbxCamera.Items.Clear();

            //CONNESSIONE DATABASE
            string stringa_connessione = Properties.Settings.Default.CamereConnectionString;
            SqlConnection connessioneDB = new SqlConnection(stringa_connessione);
            string sqlQuery = "SELECT * FROM [tblCamere]";
            using (connessioneDB)
            {
                try
                {
                    await connessioneDB.OpenAsync();
                    var InviaQuery = new SqlCommand(sqlQuery, connessioneDB);
                    SqlDataReader DatiTabellaCamere = await InviaQuery.ExecuteReaderAsync();
                    while (DatiTabellaCamere.Read())
                    {
                        cbxCamera.Items.Add(new ComboBoxItem(DatiTabellaCamere.GetInt32(0), DatiTabellaCamere.GetString(1), DatiTabellaCamere.GetDecimal(5)));
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

            if (cbxCamera.Items.Count > 0)
            {
                cbxCamera.SelectedIndex = 0;
            }
        }

        private void tabDatiPrenotazione_Enter(object sender, EventArgs e)
        {
            if (cbxCamera.Items.Count == 0)  //per mostrare sempre la camera selezionata anche se cambiamo pagina
            {
                CaricaDatabaseCamere();
            }
        }

        private void btnCaricaDocumento_Click(object sender, EventArgs e)
        {
            CaricaDocumenti.ShowDialog();

            if (CaricaDocumenti.FileName != null)
            {
                if (System.IO.File.Exists(CaricaDocumenti.FileName) == true)
                {
                    txtCaricaDocumenti.Text = CaricaDocumenti.FileName;
                    MessageBox.Show("Documento caricato con successo!");
                }

              //  if (CaricaDocumenti.ShowDialog() == DialogResult.OK)
               // { 
                //    MessageBox.Show("Documento caricato con successo!");
               // }
            }
        }

        #region Sconti Ed Extra
        private async void CaricaDatabaseCostiSconti()
        {
            cmbExtra.Items.Clear();

            //CONNESSIONE DATABASE
            string stringa_connessione = Properties.Settings.Default.CamereConnectionString;
            SqlConnection connessioneDB = new SqlConnection(stringa_connessione);
            string sqlQuery = "";
            if (grpCostiSconti.Tag == "costoextra")
            {
                sqlQuery = "SELECT * FROM [tblExtra]";
            }
            else if (grpCostiSconti.Tag == "scontoextra")
            {
                sqlQuery = "SELECT * FROM [tblSconti]";
            }
            else
            {
                sqlQuery = "SELECT * FROM [tblSconti]";
            }
            using (connessioneDB)
            {
                try
                {
                    await connessioneDB.OpenAsync();
                    var InviaQuery = new SqlCommand(sqlQuery, connessioneDB);
                    SqlDataReader DatiTabellaScontiExtra = await InviaQuery.ExecuteReaderAsync();
                    while (DatiTabellaScontiExtra.Read())
                    {
                        cmbExtra.Items.Add(new ExtraScontiItem(DatiTabellaScontiExtra.GetInt32(0) + ": " + DatiTabellaScontiExtra.GetString(1), DatiTabellaScontiExtra.GetDecimal(2), DatiTabellaScontiExtra.GetInt32(3)));
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

            if (cmbExtra.Items.Count > 0)
            {
                cmbExtra.SelectedIndex = 0;
            }
        }

        //DB METODO PAGAMENTO
        private async void CaricaDatabaseDatiPagamento()
        {
          

            //CONNESSIONE DATABASE
            string stringa_connessione = Properties.Settings.Default.CamereConnectionString;
            SqlConnection connessioneDB = new SqlConnection(stringa_connessione);
            string sqlQuery = "SELECT * FROM [tblDatiPagamento]";
            using (connessioneDB)
            {
                try
                {
                    await connessioneDB.OpenAsync();
                    var InviaQuery = new SqlCommand(sqlQuery, connessioneDB);
                    SqlDataReader DatiTabellaPagamento= await InviaQuery.ExecuteReaderAsync();
                    while (DatiTabellaPagamento.Read())
                    {
                        string valoreId = DatiTabellaPagamento.GetString(0);
                        string valoreNomeCarta = DatiTabellaPagamento.GetString(1);
                        string valoreNumeroCarta = DatiTabellaPagamento.GetString(2);
                        string valoreMesepagamento = DatiTabellaPagamento.GetString(3);
                        string valoreAnnoPagamento = DatiTabellaPagamento.GetString(4);
                        string valoreCvv = DatiTabellaPagamento.GetString(5);
                        string[] CartaDiCredito = {
                            valoreId, valoreNomeCarta, valoreNumeroCarta, valoreMesepagamento, valoreAnnoPagamento, valoreCvv }; 
                        cmbPagamento.Items.Add("Carta di Credito");
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
        private void btnAggiungiCosti_Click(object sender, EventArgs e)
        {
            grpCostiSconti.Text = "Seleziona Costo Extra";
            grpCostiSconti.Tag = "costoextra";
            grpCostiSconti.Visible = true;
            grpCostiSconti.Left = 5;
            grpCostiSconti.Top = 5;
            grpCostiSconti.Width = 260;
            grpCostiSconti.Height = 455;
            CaricaDatabaseCostiSconti();

        }
        private void btnAggiungiSconti_Click(object sender, EventArgs e)
        {
            grpCostiSconti.Text = "Seleziona Sconto Extra";
            grpCostiSconti.Tag = "scontoextra";
            grpCostiSconti.Visible = true;
            grpCostiSconti.Left = 5;
            grpCostiSconti.Top = 5;
            grpCostiSconti.Width = 260;
            grpCostiSconti.Height = 455;
            CaricaDatabaseCostiSconti();
        }
        private void btnAnnullaCosti_Click(object sender, EventArgs e)
        {
            grpCostiSconti.Visible = false;
        }
        private void btnConferma_Click(object sender, EventArgs e)
        {
            if (grpCostiSconti.Tag == "costoextra")
            {
                var ExtraSelezionato = (ExtraScontiItem)cmbExtra.SelectedItem;
                lstCosti.Items.Add(new ExtraScontiItem(ExtraSelezionato.ToString(), ExtraSelezionato.PrezzoExtra(), ExtraSelezionato.TipologiaExtra()));
            }
            else if (grpCostiSconti.Tag == "scontoextra")
            {
                var ExtraSelezionato = (ExtraScontiItem)cmbExtra.SelectedItem;
                lstSconti.Items.Add(new ExtraScontiItem(ExtraSelezionato.ToString(), ExtraSelezionato.PrezzoExtra(), ExtraSelezionato.TipologiaExtra()));
            }
            grpCostiSconti.Visible = false;
        }
        private void btnRimuoviCosti_Click(object sender, EventArgs e)
        {
            if (lstCosti.Items.Count > 0 && lstCosti.SelectedIndex >= 0)
            {
                if (MessageBox.Show("Sicuro di voler rimuovere: ?" + lstCosti.Items[lstCosti.SelectedIndex].ToString(), "Rimozione Costo Extra",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lstCosti.Items.RemoveAt(lstCosti.SelectedIndex);
                }
            }
        }
        private void btnRimuoviSconti_Click(object sender, EventArgs e)
        {
            if (lstSconti.Items.Count > 0 && lstSconti.SelectedIndex >= 0)
            {
                if (MessageBox.Show("Sicuro di voler rimuovere: ?" + lstSconti.Items[lstSconti.SelectedIndex].ToString(), "Rimozione Sconto",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lstSconti.Items.RemoveAt(lstSconti.SelectedIndex);
                }
            }
        }
        #endregion

        
        string PrezzoTotale()
        {
            string PrezzoFinale = "";

            //CALCOLO PREZZO CAMERA X NOTTI
            var CameraSelezionata = (ComboBoxItem)cbxCamera.SelectedItem;
            decimal PrezzoCameraTotale = CameraSelezionata.Prezzo() * numNotti.Value;
            //AGGIUNTA COSTO EXTRA
            decimal TotaleCostiExtra = 0;
            if (lstCosti.Items.Count > 0)
            {
                for (int a = 0; a <= lstCosti.Items.Count - 1; a++)
                {
                    decimal CostoExtraOggettoSelezionato = 0;
                    var CostoExtraSelezionato = (ExtraScontiItem)lstCosti.Items[a];
                    if (CostoExtraSelezionato.TipologiaExtra() == 0)
                    {
                        CostoExtraOggettoSelezionato = CostoExtraSelezionato.PrezzoExtra();
                    }
                    else if (CostoExtraSelezionato.TipologiaExtra() == 1)
                    {
                        CostoExtraOggettoSelezionato = PrezzoCameraTotale * CostoExtraSelezionato.PrezzoExtra() / 100;
                    }
                    else
                    {
                        CostoExtraOggettoSelezionato = 0;
                    }
                    TotaleCostiExtra = TotaleCostiExtra + CostoExtraOggettoSelezionato;
                }
            }
            //AGGIUNTA SCONTO EXTRA
            decimal TotaleScontiExtra = 0;
            if (lstSconti.Items.Count > 0)
            {
                for (int a = 0; a <= lstSconti.Items.Count - 1; a++)
                {
                    decimal ScontoExtraOggettoSelezionato = 0;
                    var ScontoExtraSelezionato = (ExtraScontiItem)lstSconti.Items[a];
                    if (ScontoExtraSelezionato.TipologiaExtra() == 0)
                    {
                        ScontoExtraOggettoSelezionato = ScontoExtraSelezionato.PrezzoExtra();
                    }
                    else if (ScontoExtraSelezionato.TipologiaExtra() == 1)
                    {
                        ScontoExtraOggettoSelezionato = PrezzoCameraTotale * ScontoExtraSelezionato.PrezzoExtra() / 100;
                    }
                    else
                    {
                        ScontoExtraOggettoSelezionato = 0;
                    }
                    TotaleScontiExtra = TotaleScontiExtra + ScontoExtraOggettoSelezionato;
                }
            }

            //AGGIUNTA TASSE SOGGIORNO
            decimal TotaleTasseSoggiorno = 0;
            if (cbxTasseSoggiorno.Checked == true)
            {
                TotaleTasseSoggiorno = Properties.Settings.Default.TasseSoggiorno * numOspiti.Value * numNotti.Value;
            }
            //TOTALE
            decimal PrezzoFinaleDecimale = PrezzoCameraTotale + TotaleCostiExtra - TotaleScontiExtra + TotaleTasseSoggiorno;
            PrezzoFinaleDecimale = Decimal.Round(PrezzoFinaleDecimale, 2);
            PrezzoFinale = Convert.ToString(PrezzoFinaleDecimale);

            return PrezzoFinale;
        } 
        private void txtTotale_TextChanged(object sender, EventArgs e)
        {
            
           
        }
        private void btnAggiornaPrezzo_Click(object sender, EventArgs e)
        {
          txtTotale.Text = PrezzoTotale();
        }


        private void dateNascita_ValueChanged(object sender, EventArgs e)
        {

            if (dateNascita.Value.ToString() == string.Empty)
            {
               MessageBox.Show("Perfavore seleziona la data!");
                dateNascita.Focus();
                return;
            }
            else
            {
                
                Console.WriteLine(dateNascita.Value.ToString());
            }

        }

        private void dateArrivo_ValueChanged(object sender, EventArgs e)
        {
          
            Console.WriteLine(dateArrivo.Value.ToString());

        }

        private void datePartenza_ValueChanged(object senser, EventArgs e)
        {
         
            Console.WriteLine(datePartenza.Value.ToString());
        }


        private async void CaricaDatabasePrenotazioni()
        {
            dataElencoPrenotazioni.Rows.Clear();
            //CONNESSIONE DATABASE
            string stringa_connessione = Properties.Settings.Default.CamereConnectionString;
            SqlConnection connessioneDB = new SqlConnection(stringa_connessione);
            string sqlQuery = "SELECT * FROM [tblPrenotazioni]";

            using (connessioneDB)
            {
                try
                {
                    await connessioneDB.OpenAsync();
                    var InviaQuery = new SqlCommand(sqlQuery, connessioneDB);
                    SqlDataReader DatiTabellaPrenotazioni = await InviaQuery.ExecuteReaderAsync();
                    while (DatiTabellaPrenotazioni.Read())
                    {
                        string valoreId = DatiTabellaPrenotazioni.GetString(0);
                        string valoreNome = DatiTabellaPrenotazioni.GetString(1);
                        string valoreCognome = DatiTabellaPrenotazioni.GetString(2);
                        string valoreIndirizzo = DatiTabellaPrenotazioni.GetString(3);
                        string valoreCitta = DatiTabellaPrenotazioni.GetString(4);
                        string valoreCap = DatiTabellaPrenotazioni.GetString(5);
                        string valoreNazione = DatiTabellaPrenotazioni.GetString(6);
                        DateTime valoreDataNascita = DatiTabellaPrenotazioni.GetDateTime(7);
                        string valoreTelefono = DatiTabellaPrenotazioni.GetString(8);
                        string valoreEmail = DatiTabellaPrenotazioni.GetString(9);
                        string valoreTipoDocumento = DatiTabellaPrenotazioni.GetString(10);
                        string valoreCodiceDocumento = DatiTabellaPrenotazioni.GetString(11);
                        string valoreDocumento = DatiTabellaPrenotazioni.GetString(12);
                        DateTime valoreDataArrivo = DatiTabellaPrenotazioni.GetDateTime(13);
                        DateTime valoreDataPartenza = DatiTabellaPrenotazioni.GetDateTime(14);
                        int valoreNumeroNotti = DatiTabellaPrenotazioni.GetInt32(15);
                        int valoreNumeroOspiti = DatiTabellaPrenotazioni.GetInt32(16);
                        string valoreCamera = DatiTabellaPrenotazioni.GetString(17);
                        string valoreNote = DatiTabellaPrenotazioni.GetString(18);
                        string valoreCostiExtra = DatiTabellaPrenotazioni.GetString(19);
                        string valoreScontiExtra = DatiTabellaPrenotazioni.GetString(20);
                        int valoreTasseSoggiorno = DatiTabellaPrenotazioni.GetInt32(21);
                        string valoreMotivoEsenzione = DatiTabellaPrenotazioni.GetString(22);
                        string valoreMetodoPagamento = DatiTabellaPrenotazioni.GetString(23);
                        decimal valoreTotale = DatiTabellaPrenotazioni.GetDecimal(24);
                        
                        bool ValoreFinaleTasseSoggiorno;
                        if (valoreTasseSoggiorno == 0) { ValoreFinaleTasseSoggiorno = false; } else { ValoreFinaleTasseSoggiorno = true; }
                        string[] NuovaPrenotazione = { valoreId.ToString(), valoreNome, valoreCognome, valoreIndirizzo, valoreCitta, valoreCap, valoreNazione,
                            valoreDataNascita.ToString(), valoreTelefono, valoreEmail, valoreTipoDocumento, valoreCodiceDocumento, valoreDocumento,
                            valoreDataArrivo.ToString(), valoreDataPartenza.ToString(), valoreNumeroNotti.ToString(),
                            valoreNumeroOspiti.ToString(), valoreCamera, valoreNote,  valoreCostiExtra, valoreScontiExtra, ValoreFinaleTasseSoggiorno.ToString(),
                            valoreMotivoEsenzione, valoreMetodoPagamento, valoreTotale.ToString() };
                            dataElencoPrenotazioni.Rows.Add(NuovaPrenotazione);
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
                    lblNumeroPrenotazioni.Text = dataElencoPrenotazioni.Rows.Count.ToString();
                }
            }
        }



        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            grpCostiSconti.Visible = false;
        }



        #region ClassiCamere_Sconti
        public class ComboBoxItem : Object
        {
            protected int CameraId;
            protected string CameraNome;
            protected decimal CameraPrezzo;
            public ComboBoxItem(int CameraIdInput, string CameraNomeInput, decimal CameraPrezzoInput)
            {

                CameraId = CameraIdInput;
                CameraNome = CameraNomeInput;
                CameraPrezzo = CameraPrezzoInput;

            }

            public override string ToString()
            {
                return CameraNome;
            }

            public int ID()
            {
                return CameraId;
            }

            public decimal Prezzo()
            {
                return CameraPrezzo;
            }
        }
        public class ExtraScontiItem : Object
        {
           
            protected string NomeElemento;
            protected decimal Prezzo;
            protected int Tipologia;
            public ExtraScontiItem(string NomeElementoInput, decimal PrezzoInput, int TipologiaInput)
            {
               
                NomeElemento = NomeElementoInput;
                Prezzo = PrezzoInput;
                Tipologia = TipologiaInput;
            }
            
            public override string ToString()
            {
                return NomeElemento;
            }
            public int TipologiaExtra()
            {
                return Tipologia;
            }
            public decimal PrezzoExtra()
            {
                return Prezzo;
            }
        }

        #endregion

        private void txtCVV_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void grpMetodoPagamento_Enter(object sender, EventArgs e)
        {

        }

        private void cmbPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPagamento.Text == "CARTA DI CREDITO/DEBITO")
            {
                grpMetodoPagamento.Visible = true;
                grpMetodoPagamento.Left = 5;
                grpMetodoPagamento.Top = 5;
                grpMetodoPagamento.Width = 260;
                grpMetodoPagamento.Height = 455;
                CaricaDatabaseDatiPagamento();
               
            }
        }

        private void btnConfermaPagamento_Click(object sender, EventArgs e)
        {
            grpMetodoPagamento.Visible = false;
        }

        private void btnAnnullaPagamento_Click(object sender, EventArgs e)
        {
            grpMetodoPagamento.Visible = false;
        }

        private void grpCostiSconti_Enter(object sender, EventArgs e)
        {

        }
    }
}









