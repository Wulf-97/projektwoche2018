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

namespace projektwoche2018_v2.UserControls
{
    public partial class UserControlWahl : UserControl
    {
        public UserControlWahl()
        {
            InitializeComponent();
        }

        private void FilllistBox()
        {
            string myConnectionString = "server=" + Wsconnection.server + ";UID=" + Wsconnection.UID + ";PWD=" + Wsconnection.PWD + ";database=" + Wsconnection.database + ";";
            MySqlConnection conn = new MySqlConnection(myConnectionString);

            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "select * from schueler order by nachname asc;";
            conn.Open();

            MySqlDataReader reader = command.ExecuteReader();
            
            while(reader.Read())
            {
                listBoxWahl.Items.Add(reader["schuelerID"].ToString() + ": " + reader["vorname"].ToString() + ", " + reader["nachname"].ToString());
            }
            conn.Close();
            
        }

        private void FillCombo()
        {
            string myConnectionString = "server=" + Wsconnection.server + ";UID=" + Wsconnection.UID + ";PWD=" + Wsconnection.PWD + ";database=" + Wsconnection.database + ";";
            MySqlConnection conn = new MySqlConnection(myConnectionString);

            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "select * from workshop;";
            conn.Open();

            MySqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                comboBoxWorkshop1.Items.Add(reader["workshopID"].ToString() + ": " + reader["titel"].ToString());
            }
            conn.Close();
        }

        private void UserControlWahl_Load(object sender, EventArgs e)
        {
            FillCombo();
            FilllistBox();
        }

        private void listBoxWahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            string myConnectionString = "server=" + Wsconnection.server + ";UID=" + Wsconnection.UID + ";PWD=" + Wsconnection.PWD + ";database=" + Wsconnection.database + ";";
            MySqlConnection conn = new MySqlConnection(myConnectionString);

            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "select workshop.workshopID,workshop.titel,rel_workshop_schueler_wahl.schuelerID from rel_workshop_schueler_wahl,workshop where rel_workshop_schueler_wahl.workshopID=workshop.workshopID and rel_workshop_schueler_wahl.schuelerID='" + listBoxWahl.SelectedItem.ToString().Split(':')[0] + "';";
            conn.Open();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                comboBoxWorkshop1.Text = reader["workshopID"].ToString() + ": " + reader["titel"].ToString();
            }
            conn.Close();
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            string myConnectionString = "server=" + Wsconnection.server + ";UID=" + Wsconnection.UID + ";PWD=" + Wsconnection.PWD + ";database=" + Wsconnection.database + ";";
            MySqlConnection conn = new MySqlConnection(myConnectionString);

            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "insert into rel_workshop_schueler_wahl(schuelerID,workshopID)values('" + listBoxWahl.SelectedItem.ToString().Split(':')[0] + "','" + comboBoxWorkshop1.Text + "')";
            conn.Open();

            command.ExecuteNonQuery();

            
            
               
            
        }
    }
}
