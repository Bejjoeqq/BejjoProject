using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BejjoProject
{
    public partial class Menu : Form
    {
        string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Hero.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
        string user, pw;
        public Menu()
        {
            InitializeComponent();
        }
        public Menu(string auser, string apw)
            : this()
        {
            user = auser;
            pw = apw;
            string query = "select * from Heroo where Username='" + user + "' ";
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string nma = myreader["Username"].ToString();
                    double lvl = Convert.ToDouble(myreader["Level"]);
                    double sta = Convert.ToDouble(myreader["Stamina"]);
                    lblNama.Text = nma;
                    lblLvl.Text = lvl.ToString();
                    lblStamina.Text = sta.ToString();
                }
            }
            catch (Exception)
            {
            }
        }
        int min = 1;
        int sec = 59;
        int ms = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblWaktu.Text ="("+ min + " : " + sec + ")";
            lblStamina.Text = waktu.ToString();
            if (waktu != 120)
            {
                ms--;
                if (min == 0 && sec == 0 && ms == 0)
                {
                    ms = 10;
                    sec = 59;
                    min = 1;
                    waktu++;
                }
                else if (sec == 0 && ms == 0)
                {
                    sec = 59;
                    ms = 10;
                    min--;
                }
                else if (ms == 0)
                {
                    ms = 10;
                    sec--;
                }
            }
            else if (waktu == 120)
            {
                ms = 10;
                sec = 59;
                min = 1;
            }
        }
        int waktu;
        private void Menu_Load(object sender, EventArgs e)
        {
            waktu = Convert.ToInt16(lblStamina.Text);
            timer1.Start();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

        }
    }
}
