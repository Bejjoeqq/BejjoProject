using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Speech;
using System.Speech.Synthesis;

namespace BejjoProject
{
    public partial class Form1 : Form
    {
        double y, mapoin;
        string c, d, speech, statusvip;
        SpeechSynthesizer rd = new SpeechSynthesizer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public Form1(string a, string b)
            : this()
        {
            txtUser.Text = a;
            txtPass.Text = b;
            c = Convert.ToString(txtUser.Text);
            d = Convert.ToString(txtPass.Text);
            txtUser.Text = "";
            txtPass.Text = "";
        }
        public Form1(string a,string b,double saldo1, string vip,double poin)
            : this()
        {
            mapoin = poin;
            txtUser.Text = a;
            txtPass.Text = b;
            c = Convert.ToString(txtUser.Text);
            d = Convert.ToString(txtPass.Text);
            txtUser.Text = "";
            txtPass.Text = "";
            y = saldo1;
            statusvip = vip;
        }
        private void btnMasuk_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
            string query = "select * from fLogin where Username='" + txtUser.Text + "';";
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) From fLogin where Username='" + txtUser.Text + "'and Password='" + txtPass.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string nma = myreader["Username"].ToString();
                    string pw = myreader["Password"].ToString();
                    double money = Convert.ToDouble(myreader["Uang"]);
                    string stas = myreader["Status"].ToString();
                    double myp = Convert.ToDouble(myreader["Poin"]);
                    c = nma;
                    d = pw;
                    y = money;
                    statusvip = stas;
                    mapoin = myp;
                }
            }
            catch (Exception)
            {
            }
            if (txtUser.Text == "")
            {
                speech = "Please Check Your Username";
                rd.Dispose();
                rd = new SpeechSynthesizer();
                rd.SpeakAsync(speech);

                MessageBox.Show("Username Tidak Boleh Kosong", "Perhatikan!");
            }
            else if (txtPass.Text == "")
            {
                speech = "Please Check Your Password";
                rd.Dispose();
                rd = new SpeechSynthesizer();
                rd.SpeakAsync(speech);

                MessageBox.Show("Password Tidak Boleh Kosong", "Perhatikan!");
            }
            else if (dt.Rows[0][0].ToString() == "1")
            {
                if (txtUser.Text.Equals("Bejjoeqq") && txtPass.Text.Equals("Aldhiyarozak"))
                {
                    MessageBox.Show("Masuk Sebagai Admin", "Welcome");
                    MessageBox.Show("Selamat Datang Di APB", "Login Sukses");
                    c = "Bejjoeqq";
                    d = "Aldhiyarozak";
                    y = 0 + y;
                    statusvip = "" + statusvip;
                    statusvip = "Admin";
                    y = 21000000;
                    mapoin = 60000000;
                    Home h1 = new Home(statusvip, c, d, y, mapoin);

                    speech = "Welcome Bejjoeqq Nice Too Meet You";
                    rd.Dispose();
                    rd = new SpeechSynthesizer();
                    rd.SpeakAsync(speech);

                    h1.Show();
                    this.Hide();
                }
                else
                {
                    /*
                    if (bz == c)
                    {*/
                    MessageBox.Show("Selamat Datang Di APB", "Login Sukses");
                    c = txtUser.Text;
                    d = txtPass.Text;
                    y = 0 + y;
                    statusvip = "" + statusvip;
                    Home h1 = new Home(statusvip, c, d, y, mapoin);

                    speech = "Welcome To Bejjoeqq Application";
                    rd.Dispose();
                    rd = new SpeechSynthesizer();
                    rd.SpeakAsync(speech);

                    h1.Show();
                    this.Hide();
                }/*
                }
                else
                {
                    MessageBox.Show("Selamat Datang Di APB", "Login Sukses");
                    c = txtUser.Text;
                    d = txtPass.Text;
                    y = 0 + y;
                    statusvip = "" + statusvip;
                    y = 0;
                    statusvip = "Vip Bronze";
                    Home h1 = new Home(statusvip, c, d, y, mapoin);
                    h1.Show();
                    this.Hide();
                }*/
            }
            else
            {
                speech = "Username Or Password Incorrect";
                rd.Dispose();
                rd = new SpeechSynthesizer();
                rd.SpeakAsync(speech);

                MessageBox.Show("Username Atau Password Salah", "Coba Ulangi");
            }
            /*
            if (txtUser.Text == "")
            {
                MessageBox.Show("Username Tidak Boleh Kosong","Perhatikan!");
            }
            else if (txtPass.Text == "")
            {
                MessageBox.Show("Password Tidak Boleh Kosong","Perhatikan!");
            }
            else if (txtUser.Text.Equals(c) && txtPass.Text.Equals(d))
            {
                MessageBox.Show("Selamat Datang Di APB","Login Sukses");
                y = 0+y;
                statusvip = "" + statusvip;
                Home h1 = new Home(statusvip, c, d, y, mapoin);
                h1.Show();
                this.Hide();
            }
            else if (txtUser.Text.Equals("Bejjoeqq") && txtPass.Text.Equals("Aldhiyarozak"))
            {
                MessageBox.Show("Masuk Sebagai Admin", "Welcome");
                MessageBox.Show("Selamat Datang Di APB", "Login Sukses");
                c = "Bejjoeqq";
                d = "Aldhiyarozak";
                y = 0 + y;
                statusvip = "" + statusvip;
                Home h1 = new Home(statusvip, c, d, y, mapoin);
                h1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username Atau Password Salah", "Coba Ulangi");
            }
             */
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            y = 0;
            statusvip = "";
            mapoin = 0;
            Form2 f2 = new Form2(c, d, y, statusvip, mapoin);
            f2.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult button = MessageBox.Show("Yakin Mau Keluar ?", "Exit",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                 MessageBoxDefaultButton.Button2);
            if (button == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void aPBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Create By Aldhiya Rozak v2.10 (23/09/2017)","Ayam Penyet Bejjo");
        }

        private void creatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Visit Our Website : www.itkonferensi.16mb.com","About Creator");
        }

        private void goldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gold gcs = new Gold(c, d, y, statusvip, mapoin);
            gcs.Show();
            this.Hide();
        }

        private void silverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Silver scs = new Silver(c, d, y, statusvip, mapoin);
            scs.Show();
            this.Hide();
        }

        private void bronzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bronze bcs = new Bronze(c, d, y, statusvip, mapoin);
            bcs.Show();
            this.Hide();
        }

        private void regulerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reguler rcs = new Reguler(c, d, y, statusvip, mapoin);
            rcs.Show();
            this.Hide();
        }

        private void btnReguler_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selamat Datang Di APB", "Welcome");
            if (statusvip == "Vip Gold")
            {
                statusvip = "Reguler1";
            }
            else if (statusvip == "Vip Silver")
            {
                statusvip = "Reguler2";
            }
            else if(statusvip == "Vip Bronze")
            {
                statusvip = "Reguler3";
            }
            else if (statusvip == "Reguler")
            {
                statusvip = "Reguler4";
            }
            else
            {
                statusvip = "Reguler4";
            }
            Home h1 = new Home(statusvip, c, d, y, mapoin);
            h1.Show();
            this.Hide();
        }

        private void v210NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("*Tukar Poin & *Profil Manual", "Whats New In v2.10");
        }

        private void vComingSoonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versi Terbaru Akan Segera Hadir Buat Anda", "Coming Soon");
        }

        private void originalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
        }

        private void otherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                this.BackColor = colorDialog1.Color;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Lobby_Menu l1 = new Lobby_Menu();
            l1.Show();
            this.Hide();
        }
    }
}
