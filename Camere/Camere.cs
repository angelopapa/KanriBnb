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

namespace kanriBnb.Camere
{
    public partial class Camere : Form
    {
        public Camere()
        {
            InitializeComponent();
        }

        private void Camere_Load_1(object sender, EventArgs e)
        {
           
            pnlAggiungiCamere.Visible = false;
            panelCamere.Dock = DockStyle.Fill;
            // connessione_db();
            CaricaDatabaseCamere();

        }

        //PANNELLO AGGIUNGI
        private void AggiungiCamera_Click(object sender, EventArgs e)
        {
            if(pnlAggiungiCamere.Visible == false)
            {
                if (btnAggiungi.Tag == "modifica")
                {
                    ResetPannello();
                }
                pnlAggiungiCamere.Visible = true;
                pnlAggiungiCamere.Dock = DockStyle.Left;
                btnAggiungi.Tag = "aggiungi";
                txtid.Enabled = true;
            } else
            {
                pnlAggiungiCamere.Visible = false;
            }
            
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
              if (txtid.Text.Length < 1)
            {

                MessageBox.Show("Il campo 'ID' non può essere vuoto!");
                return;
            }

              if (txtNome.Text.Length < 2 )
            {
                MessageBox.Show("Il campo 'Nome' non può essere vuoto!");
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

            } else
            {

                MessageBox.Show("Il campo 'Prezzo' contiene caratteri non validi!");
            }

         /*   int singola = 0;
            if (cbxSingola.Checked == true)
            {
                singola = 1;
            }

            int matrimoniale = 0;
            if (cbxMatrimoniale.Checked == true)
            {
                matrimoniale = 1;
                 
            }
         */

             //CONNESSIONE DB
            string stringa_connessione = Properties.Settings.Default.CamereConnectionString;
            SqlConnection connessioneDB = new SqlConnection(stringa_connessione);
            if (connessioneDB.State != ConnectionState.Open)
            {
                connessioneDB.Open();
            }

            //QUERY DATABASE

            string SqlQuery = "";
            if( btnAggiungi.Tag == "aggiungi" )
            {
                SqlQuery = "INSERT INTO [tblCamere] ([Id], [Nome], [Posti Letto], [Letto Singolo], [Letto Matrimoniale], [Prezzo], [Note]) VALUES ('" + txtid.Text
               + "', '" + txtNome.Text + "', '" + txtPostiLetto.Value + "', '" + txtSingola.Value
               + "', '" + txtMatrimoniale.Value + "', '" + txtPrezzo.Text + "', '" + txtNote.Text + "')";
            }   
            else
            {
                SqlQuery = "UPDATE [tblCamere] SET [Id] = '" + txtid.Text + "', [Nome] = '" + txtNome.Text
                    + "', [Posti Letto] = '" + txtPostiLetto.Value + "', [Letto Singolo] = '" + txtSingola.Value
                    + "', [Letto Matrimoniale] = '" + txtMatrimoniale.Value + "',  [Prezzo] = '" + txtPrezzo.Text + "', [Note] = '" + txtNote.Text + "' WHERE [Id] = '" + txtid.Text + "';";                             

            }

            btnAggiungi.Tag = "";
           
            SqlCommand QueryInsertIntoCamere = new SqlCommand(SqlQuery, connessioneDB);
            try { QueryInsertIntoCamere.ExecuteNonQuery(); 
               
            } catch (SqlException ex) {

                if(ex.Number.ToString() == "2627") {
                    MessageBox.Show("L'ID inserito è già in uso.");                
                  } else
                {
                    MessageBox.Show(ex.Message);
                }
                return;
            }
            connessioneDB.Close();
            //ricarica database
            CaricaDatabaseCamere();
            //reset pannello
            ResetPannello();
        }

        private void ResetPannello()
        {
            txtid.Text = "";
            txtNome.Text = "";          
            txtPostiLetto.Value = 0;
            txtSingola.Value = 0;
            txtMatrimoniale.Value = 0;
            //   cbxSingola.Checked = false;
            //   cbxMatrimoniale.Checked = false;
            txtPrezzo.Text = "";
            txtNote.Text = "";
            pnlAggiungiCamere.Visible = false;
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            ResetPannello();
        }
        private async void CaricaDatabaseCamere()
        {
            DataElencoCamere.Rows.Clear();

            string stringa_connessione = Properties.Settings.Default.CamereConnectionString;
            SqlConnection connessioneDB = new SqlConnection(stringa_connessione);
            string SqlQuery = "SELECT * FROM [tblCamere]";
            using (connessioneDB)
            {
                try
                {
                    await connessioneDB.OpenAsync();
                    var InviaQuery = new SqlCommand(SqlQuery, connessioneDB);
                    SqlDataReader DatiTabellaCamere = await InviaQuery.ExecuteReaderAsync();
                    while(DatiTabellaCamere.Read())
                    {
                        int valoreId = DatiTabellaCamere.GetInt32(0);
                        string valoreNome = DatiTabellaCamere.GetString(1);                       
                        int valorePostiLetto = DatiTabellaCamere.GetInt32(2);
                        int valoreSingola = DatiTabellaCamere.GetInt32(3);
                        int valoreMatrimoniale = DatiTabellaCamere.GetInt32(4);
                        //checkbox 1
                        //    int intSingola = DatiTabellaCamere.GetInt32(4);     
                        //     bool valoreSingola;
                        //   if ( intSingola == 0  ) { valoreSingola = false; } else { valoreSingola = true; }
                        // checkbox 2
                        //    int intMatrimoniale = DatiTabellaCamere.GetInt32(5);
                        //      bool valoreMatrimoniale;
                        //   if (intMatrimoniale == 0) { valoreMatrimoniale = false; } else { valoreMatrimoniale = true; }

                        decimal valorePrezzo = DatiTabellaCamere.GetDecimal(5);
                        string valoreNote = DatiTabellaCamere.GetString(6);
                        string[] nuovaCamera = { valoreId.ToString(), valoreNome, valorePostiLetto.ToString(), valoreSingola.ToString(), valoreMatrimoniale.ToString(), valorePrezzo.ToString(), valoreNote };
                        DataElencoCamere.Rows.Add(nuovaCamera);
                    }

                } catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                } finally
                {
                    if (connessioneDB.State != ConnectionState.Open)
                    {
                        connessioneDB.Close();
                    }
                }
                lblNumeroTotale.Text = DataElencoCamere.Rows.Count.ToString();
            }
        }

        //PANNELLO MODIFICA
        private void ModificaCamera_Click(object sender, EventArgs e)
        {

            if (pnlAggiungiCamere.Visible == false)
            {
                pnlAggiungiCamere.Visible = true;
                pnlAggiungiCamere.Dock = DockStyle.Left;
                btnAggiungi.Tag = "modifica";
                txtid.Enabled = false;

                CaricaDatiCameraSelezionata();
            }
            else
            {
                pnlAggiungiCamere.Visible = false;
            }

        }

        private void CaricaDatiCameraSelezionata()
        {
            //AGGIUNGI DATI CAMERA
            txtid.Text = DataElencoCamere.Rows[DataElencoCamere.SelectedRows[0].Index].Cells[0].Value.ToString();
            txtNome.Text = DataElencoCamere.Rows[DataElencoCamere.SelectedRows[0].Index].Cells[1].Value.ToString();
            txtPostiLetto.Value = Convert.ToInt32(DataElencoCamere.Rows[DataElencoCamere.SelectedRows[0].Index].Cells[2].Value.ToString());
            txtSingola.Value = Convert.ToInt32(DataElencoCamere.Rows[DataElencoCamere.SelectedRows[0].Index].Cells[3].Value.ToString());
            txtMatrimoniale.Value = Convert.ToInt32(DataElencoCamere.Rows[DataElencoCamere.SelectedRows[0].Index].Cells[4].Value.ToString());
          //  if (DataElencoCamere.Rows[DataElencoCamere.SelectedRows[0].Index].Cells[4].Value.ToString() == "True")
         //   { cbxSingola.Checked = true; }
          //  else { cbxSingola.Checked = false; }
          //  if (DataElencoCamere.Rows[DataElencoCamere.SelectedRows[0].Index].Cells[5].Value.ToString() == "True")
          //  { cbxMatrimoniale.Checked = true; }
          //  else { cbxMatrimoniale.Checked = false; }
            txtPrezzo.Text = DataElencoCamere.Rows[DataElencoCamere.SelectedRows[0].Index].Cells[5].Value.ToString();
            txtNote.Text = DataElencoCamere.Rows[DataElencoCamere.SelectedRows[0].Index].Cells[6].Value.ToString();
        }

        //RIMUOVI CAMERA
        private void RimuoviCamera_Click(object sender, EventArgs e)
        {

            string stringa_connessione = Properties.Settings.Default.CamereConnectionString;
            SqlConnection connessioneDB = new SqlConnection(stringa_connessione);
            if (connessioneDB.State != ConnectionState.Open)
            {
                connessioneDB.Open();
            }

            //QUERY DATABASE
            // DELETE

            string IdRimozione = DataElencoCamere.Rows[DataElencoCamere.SelectedRows[0].Index].Cells[0].Value.ToString();
            string SqlQuery = "DELETE FROM [tblCamere] WHERE [Id] =  '" + IdRimozione + "';";
       

            SqlCommand QueryInsertIntoCamere = new SqlCommand(SqlQuery, connessioneDB);
            try
            {
                if(MessageBox.Show("Sei sicuro di voler rimuovere camera ID: " + IdRimozione + " ?", "Rimuovere camera?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    QueryInsertIntoCamere.ExecuteNonQuery();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Number.ToString());
            }
            connessioneDB.Close();
            //ricarica database
            CaricaDatabaseCamere(); 


        }

        private void DataElencoCamere_SelectionChanged(object sender, EventArgs e)
        {

            if (pnlAggiungiCamere.Visible == true)
            {
               if( btnAggiungi.Tag.ToString() == "modifica")
                {
                    CaricaDatiCameraSelezionata();
                }
            }


        }

        private void pnlAggiungiCamere_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
