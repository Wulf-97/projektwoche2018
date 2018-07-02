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
    public partial class UserControlSchueler : UserControl
    {
        public UserControlSchueler()
        {
            InitializeComponent();

        }

        private void FilllistBox()
        {
            string myConnectionString = "server=" + Wsconnection.server + ";UID=" + Wsconnection.UID + ";PWD=" + Wsconnection.PWD + ";database=" + Wsconnection.database + ";";
            MySqlConnection conn = new MySqlConnection(myConnectionString);

            MySqlCommand command = conn.CreateCommand();
            try
            { 
            command.CommandText = "select * from schueler order by nachname asc;";
            conn.Open();

            MySqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {

                listBoxSchueler.Items.Add(reader["schuelerID"].ToString() + ": " + reader["vorname"].ToString() + ", " + reader["nachname"].ToString());
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

        private void FillComboBox()
        {
            string myConnectionString = "server=" + Wsconnection.server + ";UID=" + Wsconnection.UID + ";PWD=" + Wsconnection.PWD + ";database=" + Wsconnection.database + ";";
            MySqlConnection conn = new MySqlConnection(myConnectionString);

            MySqlCommand command = conn.CreateCommand();
            try
            {
                command.CommandText = "select klasseID,bezeichnung from klasse;";
                conn.Open();

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxKlasse.Items.Add(reader["klasseID"].ToString() + ": " + reader["bezeichnung"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
            
        }

        private void listBoxSchueler_SelectedIndexChanged(object sender, EventArgs e)
        {
            string myConnectionString = "server=" + Wsconnection.server + ";UID=" + Wsconnection.UID + ";PWD=" + Wsconnection.PWD + ";database=" + Wsconnection.database + ";";
            MySqlConnection conn = new MySqlConnection(myConnectionString);

            MySqlCommand command = conn.CreateCommand();
            try
            { 
            command.CommandText = "select schueler.vorname,schueler.nachname,schueler.email,klasse.klasseID,klasse.bezeichnung from schueler,klasse where  schueler.klasseID=klasse.klasseID and schueler.schuelerID='" + listBoxSchueler.SelectedItem.ToString().Split(':')[0] + "';";
            conn.Open();

            MySqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                textBoxVorname.Text = reader["vorname"].ToString();
                textBoxNachname.Text = reader["nachname"].ToString();
                textBoxEmail.Text = reader["email"].ToString();
                comboBoxKlasse.Text = reader["klasseID"].ToString() + ": " + reader["bezeichnung"];
                comboBoxAbschluss.Text = reader["bezeichnung"].ToString();

            }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void buttonNeu_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void buttonLoeschen_Click(object sender, EventArgs e)
        {
            string myConnectionString = "server=" + Wsconnection.server + ";UID=" + Wsconnection.UID + ";PWD=" + Wsconnection.PWD + ";database=" + Wsconnection.database + ";";
            MySqlConnection conn = new MySqlConnection(myConnectionString);

            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "delete from schueler where schuelerID='" + listBoxSchueler.SelectedItem.ToString().Split(':')[0] + "' ;";
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            clearall();

        }


        private void clearall()
        {

            textBoxEmail.Text = "";
            textBoxLehrkraft.Text = "";
            textBoxNachname.Text = "";
            textBoxVorname.Text = "";
            comboBoxAbschluss.SelectedText = "";
            comboBoxAbschluss.SelectedText = "";
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            string myConnectionString = "server=" + Wsconnection.server + ";UID=" + Wsconnection.UID + ";PWD=" + Wsconnection.PWD + ";database=" + Wsconnection.database + ";";
            MySqlConnection conn = new MySqlConnection(myConnectionString);
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "insert into schueler(vorname,nachname,email,klasseID)" + "values('" + textBoxVorname.Text + "','" + textBoxNachname.Text + "','" + textBoxEmail.Text + "','" + comboBoxKlasse.SelectedItem.ToString().Split(':')[0] + "')";

            command.ExecuteNonQuery();
            conn.Close();
            clearall();
        }

        private void UserControlSchueler_Load(object sender, EventArgs e)
        {
            FillComboBox();
            FilllistBox();
        }
    }
}
