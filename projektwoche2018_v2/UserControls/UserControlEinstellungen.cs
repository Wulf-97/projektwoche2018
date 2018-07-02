using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace projektwoche2018_v2.UserControls
{
    public partial class UserControlEinstellungen : UserControl
    {
        public UserControlEinstellungen()
        {
            InitializeComponent();
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
             Wsconnection.server = textBoxServer.Text;
             Wsconnection.UID = textBoxUID.Text;
             Wsconnection.PWD = textBoxPWD.Text;
             Wsconnection.database = textBoxDB.Text;
            // textBoxServer.Text = Wsconnection.server;
            // textBoxUID.Text = Wsconnection.UID;
            // textBoxPWD.Text = Wsconnection.PWD;
            // textBoxDB.Text = Wsconnection.database;
            Form1 form_1 = new Form1();

           form_1.myConnString();
        }

            
   }
}

