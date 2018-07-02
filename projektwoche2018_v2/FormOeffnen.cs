using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace projektwoche2018_v2
{
    public partial class FormOeffnen : Form
    {
        string myConnectionString = "server=" + Wsconnection.server + ";UID=" + Wsconnection.UID + ";PWD=" + Wsconnection.PWD + ";";
        MySqlConnection conn;
        public FormOeffnen()
        {
            InitializeComponent();
            comboBoxFill();
        }

        private void comboBoxFill()
        {
            
            conn = new MySqlConnection(myConnectionString);
            MySqlCommand mycommand = conn.CreateCommand();
            mycommand.CommandText = "Show Databases;";
            conn.Open();
            MySqlDataReader reader = mycommand.ExecuteReader();
            
            while(reader.Read())
            {
                comboBoxDatabase.Items.Add(reader.GetValue(0).ToString());

            }
            reader.Close();
            conn.Close();
        }


        private void buttonOeffnen_Click(object sender, EventArgs e)
        {
            Wsconnection.database = comboBoxDatabase.Text;
            Close();
          //  MessageBox.Show("gespeichert");
        }
    }
}
