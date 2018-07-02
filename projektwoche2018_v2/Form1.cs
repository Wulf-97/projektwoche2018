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

namespace projektwoche2018_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        UserControls.UserControlEinstellungen uce = new UserControls.UserControlEinstellungen();
        UserControls.UserControlSchueler ucs = new UserControls.UserControlSchueler();
        UserControls.UserControlWorkshop ucwo = new UserControls.UserControlWorkshop();
        UserControls.UserControlWahl ucwa = new UserControls.UserControlWahl();
        FormNeu formNeu = new FormNeu();
        FormOeffnen formOeffnen = new FormOeffnen();


        private void WorkshopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucwo.Dock = DockStyle.Fill;
            groupBox1.Controls.Clear();
            groupBox1.Controls.Add(ucwo);
        }

        private void schülerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ucs.Dock = DockStyle.Fill;
            groupBox1.Controls.Clear();
            groupBox1.Controls.Add(ucs);
        }

        private void wahlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucwa.Dock = DockStyle.Fill;
            groupBox1.Controls.Clear();
            groupBox1.Controls.Add(ucwa);
        }

        private void einstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uce.Dock = DockStyle.Fill;
            groupBox1.Controls.Clear();
            groupBox1.Controls.Add(uce);

            uce.textBoxServer.Text = Wsconnection.server;
            uce.textBoxUID.Text = Wsconnection.UID;
            uce.textBoxPWD.Text = Wsconnection.PWD;
            uce.textBoxDB.Text = Wsconnection.database;
        }

        private void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formOeffnen.Show();
        }

        private void neuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formNeu.Show();
        }

        public void myConnString()
        {
            try
            {
                string myConnectionString = "server=" + Wsconnection.server + ";UID=" + Wsconnection.UID + ";PWD=" + Wsconnection.PWD + ";";
                MySqlConnection conn = new MySqlConnection(myConnectionString);
                conn.Open();
                conn.Close();
            }

            catch(Exception)
            {


            }
        }
    }
}
