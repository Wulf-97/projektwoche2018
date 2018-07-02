using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace projektwoche2018_v2.UserControls
{
    public partial class UserControlWorkshop : UserControl
    {
        public UserControlWorkshop()
        {
            InitializeComponent();
        }

        private void ClearAll()
        {
            textBoxNr.Text = "";
            textBoxTitel.Text = "";
            textBoxKosten.Text = "";
            textBoxBeschreibung.Text = "";
            textBoxTeilMin.Text = "";
            textBoxMax.Text = "";
            textBoxSchwerpunkt.Text = "";
            textBoxVoraussetzungen.Text = "";
        }

        private void buttonNeu_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            string myConnectionString = "server=" + Wsconnection.server + ";UID=" + Wsconnection.UID + ";PWD=" + Wsconnection.PWD + ";database=" + Wsconnection.database + ";";
            MySqlConnection conn = new MySqlConnection(myConnectionString);

            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "insert into workshop(nr,titel,kosten,beschreibung,voraussetzungen,teilnehmerMin,teilnehmerMax,schwerpunkt)" +
            "values('" + textBoxNr.Text + "','" + textBoxTitel.Text + "','" + textBoxKosten.Text + "','" + textBoxBeschreibung.Text + "','" + textBoxVoraussetzungen.Text + "','" + textBoxTeilMin.Text + "','" + textBoxMax.Text + "','" + textBoxSchwerpunkt.Text + "')";
            command.ExecuteNonQuery();
        }

        private void buttonLoeschen_Click(object sender, EventArgs e)
        {
            string myConnectionString = "server=" + Wsconnection.server + ";UID=" + Wsconnection.UID + ";PWD=" + Wsconnection.PWD + ";database=" + Wsconnection.database + ";";
            MySqlConnection conn = new MySqlConnection(myConnectionString);

            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "delete from workshop where titel='" + listBoxWorkshops.SelectedItem.ToString() + "' ;";
            command.ExecuteNonQuery();
        }

        private void listBoxWorkshops_SelectedIndexChanged(object sender, EventArgs e)
        {
            string myConnectionString = "server=" + Wsconnection.server + ";UID=" + Wsconnection.UID + ";PWD=" + Wsconnection.PWD + ";database=" + Wsconnection.database + ";";
            MySqlConnection conn = new MySqlConnection(myConnectionString);

            MySqlCommand command = conn.CreateCommand();

            try
            { 
            command.CommandText = "select * from workshop where titel='" + listBoxWorkshops.SelectedItem.ToString() + "';";
            conn.Open();

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                textBoxNr.Text = reader["nr"].ToString();
                textBoxTitel.Text = reader["titel"].ToString();
                textBoxKosten.Text = reader["kosten"].ToString();
                textBoxSchwerpunkt.Text = reader["schwerpunkt"].ToString();
                textBoxTeilMin.Text = reader["teilnehmerMax"].ToString();
                textBoxMax.Text = reader["teilnehmerMin"].ToString();
                textBoxBeschreibung.Text = reader["beschreibung"].ToString();
                textBoxVoraussetzungen.Text = reader["voraussetzungen"].ToString();
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            
            

        }

        public void Fill_ListBox_W()
        {
            string myConnectionString = "server=" + Wsconnection.server + ";UID=" + Wsconnection.UID + ";PWD=" + Wsconnection.PWD +";database="+Wsconnection.database+ ";";
            MySqlConnection conn = new MySqlConnection(myConnectionString);
            MySqlCommand command = conn.CreateCommand();

            try
            {
                command.CommandText = "select * from workshop;";
                conn.Open();

                MySqlDataReader reader = command.ExecuteReader();
                listBoxWorkshops.Items.Clear();
                while (reader.Read())
                {
                    listBoxWorkshops.Items.Add(reader["titel"].ToString());
                }
            }
            catch(Exception ex)

            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                conn.Close();
            }
            
        }

        private void UserControlWorkshop_Load(object sender, EventArgs e)
        {
            Fill_ListBox_W();
        }
    }
}
