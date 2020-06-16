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
    public partial class Home : Form
    {
        SpeechSynthesizer rd = new SpeechSynthesizer();
        double harga, total, porsi, totals,diskon,kembalian,bayar,poin,mapoin;
        double y,exp,exps;
        string x, q, p, o, z, pesan, menu,statusvip,poins;
        string[] pet = new string[10];
        string[] files = new string[10];
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
            axWindowsMediaPlayer1.URL = @"D:\Bejjo\Tugas\Project\BejjoProject\Iklan\Ayam.mp4";
            listBox1.Text = "Ayam Penyet Bejjo";
        }
        public Home(string a, string b, string d, double saldo, double poinz)
            : this()
        {
            lblStatus.Text = a;
            if (lblStatus.Text == "")
            {
                lblStatus.Text = "Vip Bronze";
            }
            else if(lblStatus.Text == "          ")
            {
                lblStatus.Text = "Vip Bronze";
            }
            z = "1";
            if (lblStatus.Text == "Vip Bronze")
            {
                mapoin = poinz;
                lblPoin.Text = Convert.ToString(mapoin);
                statusvip = lblStatus.Text;
                p = d;
                o = b;
                y = saldo;
                q = "Rp." + y.ToString("N");
                lblSaldo.Text = q;
                lblStatus.ForeColor = Color.Peru;
                lblDiskon.Text = "Diskon Dari Vip 10%";
                btnBayar.Text = "Bayar Dengan Saldo";
                txtBayar.Enabled = false;
                button1.Hide();
            }
            else if (lblStatus.Text == "Vip Silver")
            {
                mapoin = poinz;
                lblPoin.Text = Convert.ToString(mapoin);
                statusvip = a;
                p = d;
                o = b;
                y = saldo;
                q = "Rp." + y.ToString("N");
                lblSaldo.Text = q;
                lblStatus.ForeColor = Color.Silver;
                lblDiskon.Text = "Diskon Dari Vip 15%";
                btnBayar.Text = "Bayar Dengan Saldo";
                txtBayar.Enabled = false;
                button1.Hide();
            }
            else if (lblStatus.Text == "Vip Gold")
            {
                mapoin = poinz;
                lblPoin.Text = Convert.ToString(mapoin);
                statusvip = a;
                p = d;
                o = b;
                y = saldo;
                q = "Rp." + y.ToString("N");
                lblSaldo.Text = q;
                lblStatus.ForeColor = Color.Gold;
                lblDiskon.Text = "Diskon Dari Vip 25%";
                btnBayar.Text = "Bayar Dengan Saldo";
                txtBayar.Enabled = false;
                button1.Hide();
            }
            else if (lblStatus.Text == "Vip Gold  ")
            {
                mapoin = poinz;
                lblPoin.Text = Convert.ToString(mapoin);
                statusvip = a;
                p = d;
                o = b;
                y = saldo;
                q = "Rp." + y.ToString("N");
                lblSaldo.Text = q;
                lblStatus.ForeColor = Color.Gold;
                lblDiskon.Text = "Diskon Dari Vip 25%";
                btnBayar.Text = "Bayar Dengan Saldo";
                txtBayar.Enabled = false;
                button1.Hide();
            }
            else if (lblStatus.Text == "Reguler")
            {
                y = saldo;
                p = d;
                o = b;
                lblSaldo.Text = "Bayar Tunai";
                lblStatus.ForeColor = Color.Red;
                profileToolStripMenuItem.Enabled = false;
                lblDiskon.Text = "Makan Banyak Ada Potongan Harga";
                btnBayar.Text = "Bayar Tunai";
                button1.Hide();
            }
            else if (lblStatus.Text == "Admin")
            {
                mapoin = poinz;
                lblPoin.Text = Convert.ToString(mapoin);
                statusvip = a;
                p = d;
                o = b;
                y = saldo;
                q = "Rp." + y.ToString("N");
                lblSaldo.Text = q;
                lblStatus.ForeColor = Color.Orange;
                lblDiskon.Text = "Diskon Dari Vip 25%";
                btnBayar.Text = "Bayar Dengan Saldo";
                txtBayar.Enabled = false;
                button1.Show();
            }
            if (lblStatus.Text == "Reguler1")
            {
                statusvip = "Vip Gold";
                lblStatus.Text = "Reguler";
                y = saldo;
                p = d;
                o = b;
                lblSaldo.Text = "Bayar Tunai";
                lblStatus.ForeColor = Color.Red;
                profileToolStripMenuItem.Enabled = false;
                lblDiskon.Text = "Makan Banyak Ada Potongan Harga";
                btnBayar.Text = "Bayar Tunai";
                button1.Hide();
            }
            else if (lblStatus.Text == "Reguler2")
            {
                statusvip = "Vip Silver";
                lblStatus.Text = "Reguler";
                y = saldo;
                p = d;
                o = b;
                lblSaldo.Text = "Bayar Tunai";
                lblStatus.ForeColor = Color.Red;
                profileToolStripMenuItem.Enabled = false;
                lblDiskon.Text = "Makan Banyak Ada Potongan Harga";
                btnBayar.Text = "Bayar Tunai";
                button1.Hide();
            }
            else if (lblStatus.Text == "Reguler3")
            {
                statusvip = "Vip Bronze";
                lblStatus.Text = "Reguler";
                y = saldo;
                p = d;
                o = b;
                lblSaldo.Text = "Bayar Tunai";
                lblStatus.ForeColor = Color.Red;
                profileToolStripMenuItem.Enabled = false;
                lblDiskon.Text = "Makan Banyak Ada Potongan Harga";
                btnBayar.Text = "Bayar Tunai";
                button1.Hide();
            }
            else if (lblStatus.Text == "Reguler4")
            {
                lblStatus.Text = "Reguler";
                y = saldo;
                p = d;
                o = b;
                lblSaldo.Text = "Bayar Tunai";
                lblStatus.ForeColor = Color.Red;
                profileToolStripMenuItem.Enabled = false;
                lblDiskon.Text = "Makan Banyak Ada Potongan Harga";
                btnBayar.Text = "Bayar Tunai";
                button1.Hide();
            }
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
            string query = "select * from fLogin where Username='" + o + "';";
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    double esp = Convert.ToDouble(myreader["Level"]);
                    exps = esp;
                }
            }
            catch (Exception)
            {
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult button = MessageBox.Show("Yakin Mau Keluar ?", "Exit",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                     MessageBoxDefaultButton.Button2);
            if (button == DialogResult.Yes)
            {
                string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
                string query = "update fLogin set Username='" + this.o + "',Password='" + this.p + "',Uang='" + this.y + "',Status='" + this.statusvip + "',Poin='" + this.mapoin + "' where Username='" + this.o + "' ";
                SqlConnection condb = new SqlConnection(constring);
                SqlCommand cmddb = new SqlCommand(query, condb);
                SqlDataReader myreader;
                try
                {
                    condb.Open();
                    myreader = cmddb.ExecuteReader();
                    while (myreader.Read())
                    {
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ada Kesalahan!", "Laporkan Kepada Admin");
                }  

                Application.Exit();
            }
        }
        
        private void goldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
            string query = "update fLogin set Username='" + this.o + "',Password='" + this.p + "',Uang='" + this.y + "',Status='" + this.statusvip + "',Poin='" + this.mapoin + "' where Username='" + this.o + "' ";
            SqlConnection condb = new SqlConnection(constring);
            SqlCommand cmddb = new SqlCommand(query, condb);
            SqlDataReader myreader;
            try
            {
                condb.Open();
                myreader = cmddb.ExecuteReader();
                while (myreader.Read())
                {
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ada Kesalahan!", "Laporkan Kepada Admin");
            }  

            Gold gcs = new Gold(o, p, y, statusvip, mapoin);
            gcs.Show();
            this.Hide();
            axWindowsMediaPlayer1.close();
            song.Stop();
        }

        private void silverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
            string query = "update fLogin set Username='" + this.o + "',Password='" + this.p + "',Uang='" + this.y + "',Status='" + this.statusvip + "',Poin='" + this.mapoin + "' where Username='" + this.o + "' ";
            SqlConnection condb = new SqlConnection(constring);
            SqlCommand cmddb = new SqlCommand(query, condb);
            SqlDataReader myreader;
            try
            {
                condb.Open();
                myreader = cmddb.ExecuteReader();
                while (myreader.Read())
                {
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ada Kesalahan!", "Laporkan Kepada Admin");
            }  

            Silver scs = new Silver(o, p, y, statusvip, mapoin);
            scs.Show();
            this.Hide();
            axWindowsMediaPlayer1.close();
            song.Stop();
        }

        private void bronzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
            string query = "update fLogin set Username='" + this.o + "',Password='" + this.p + "',Uang='" + this.y + "',Status='" + this.statusvip + "',Poin='" + this.mapoin + "' where Username='" + this.o + "' ";
            SqlConnection condb = new SqlConnection(constring);
            SqlCommand cmddb = new SqlCommand(query, condb);
            SqlDataReader myreader;
            try
            {
                condb.Open();
                myreader = cmddb.ExecuteReader();
                while (myreader.Read())
                {
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ada Kesalahan!", "Laporkan Kepada Admin");
            }  

            Bronze bcs = new Bronze(o, p, y, statusvip, mapoin);
            bcs.Show();
            this.Hide();
            axWindowsMediaPlayer1.close();
            song.Stop();
        }

        private void regulerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
            string query = "update fLogin set Username='" + this.o + "',Password='" + this.p + "',Uang='" + this.y + "',Status='" + this.statusvip + "',Poin='" + this.mapoin + "' where Username='" + this.o + "' ";
            SqlConnection condb = new SqlConnection(constring);
            SqlCommand cmddb = new SqlCommand(query, condb);
            SqlDataReader myreader;
            try
            {
                condb.Open();
                myreader = cmddb.ExecuteReader();
                while (myreader.Read())
                {
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ada Kesalahan!", "Laporkan Kepada Admin");
            }  

            Reguler rcs = new Reguler(o, p, y, statusvip, mapoin);
            rcs.Show();
            this.Hide();
            axWindowsMediaPlayer1.close();
            song.Stop();
        }

        private void aPBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Create By Aldhiya Rozak v2.10 (23/09/2017)", "Ayam Penyet Bejjo");
        }

        private void creatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Visit Our Website : www.itkonferensi.16mb.com", "About Creator");
        }

        private void detailProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
            string query = "update fLogin set Username='" + this.o + "',Password='" + this.p + "',Uang='" + this.y + "',Status='" + this.statusvip + "',Poin='" + this.mapoin + "' where Username='" + this.o + "' ";
            SqlConnection condb = new SqlConnection(constring);
            SqlCommand cmddb = new SqlCommand(query, condb);
            SqlDataReader myreader;
            try
            {
                condb.Open();
                myreader = cmddb.ExecuteReader();
                while (myreader.Read())
                {
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ada Kesalahan!", "Laporkan Kepada Admin");
            }  

            Profile p1 = new Profile(o, statusvip, y, p, mapoin);
            p1.Show();
            this.Hide();
            axWindowsMediaPlayer1.close();
            song.Stop();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
            string query = "update fLogin set Username='" + this.o + "',Password='" + this.p + "',Uang='" + this.y + "',Status='" + this.statusvip + "',Poin='" + this.mapoin + "' where Username='" + this.o + "' ";
            SqlConnection condb = new SqlConnection(constring);
            SqlCommand cmddb = new SqlCommand(query, condb);
            SqlDataReader myreader;
            try
            {
                condb.Open();
                myreader = cmddb.ExecuteReader();
                while (myreader.Read())
                {
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ada Kesalahan!", "Laporkan Kepada Admin");
            }  

            Form1 f1 = new Form1(o, p, y, statusvip, mapoin);
            f1.Show();
            this.Hide();
            axWindowsMediaPlayer1.close();
            song.Stop();
        }

        private void lstMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMenu.Text == "Ayam Penyet Khas Bejjo")
            {
                harga = 40000;
            }
            else if (lstMenu.Text == "Ayam Penyet Spesial")
            {
                harga = 25000;
            }
            else if (lstMenu.Text == "Nasi Goreng Ayam")
            {
                harga = 15000;
            }
            else if (lstMenu.Text == "Mie Goreng Ayam")
            {
                harga = 16000;
            }
            else if (lstMenu.Text == "Nasi Goreng Spesial")
            {
                harga = 20000;
            }
            else if (lstMenu.Text == "Mie Goreng Spesial")
            {
                harga = 21000;
            }
            else if (lstMenu.Text == "APBBurger")
            {
                harga = 35000;
            }
            else if (lstMenu.Text == "APBPizza")
            {
                harga = 65000;
            }
            else if (lstMenu.Text == "Sate Ayam")
            {
                harga = 23000;
            }
            else if (lstMenu.Text == "Martabak Mesir")
            {
                harga = 32000;
            }
            else if (lstMenu.Text == "Lemon Tea Spesial")
            {
                harga = 30000;
            }
            else if (lstMenu.Text == "Jus Jeruk")
            {
                harga = 10000;
            }
            else if (lstMenu.Text == "Jus Jambu")
            {
                harga = 12000;
            }
            else if (lstMenu.Text == "Jus Wortel")
            {
                harga = 11000;
            }
            else if (lstMenu.Text == "Jus Sayuran")
            {
                harga = 14000;
            }
            else if (lstMenu.Text == "Teh Manis")
            {
                harga = 8000;
            }
            else if (lstMenu.Text == "Kopi")
            {
                harga = 17000;
            }
            else if (lstMenu.Text == "Kopi Susu")
            {
                harga = 19000;
            }
            else if (lstMenu.Text == "Susu Segar")
            {
                harga = 13000;
            }
            else if (lstMenu.Text == "Air Mineral")
            {
                harga = 5000;
            }
            menu = lstMenu.Text;
            lblHarga.Text = harga.ToString("N");
        }
        private void txtPorsi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
        private void btnProses_Click(object sender, EventArgs e)
        {
            if (btnProses.Text == "Pesan")
            {
                btnProses.Text = "Proses";
                lstMenu.Enabled = true;
                txtPorsi.Enabled = true;
                lblHarga.Text = harga.ToString("N");
                txtBayar.Enabled = false;
                btnBayar.Enabled = false;
                btnHapus.Enabled = false;
                lblKembalian.Text = "0.00";
            }
            else if (lstMenu.Text == "")
            {
                MessageBox.Show("Silahkan Pilih Makanan Yang Anda Inginkan", "Perhatikan!");
            }
            else if (txtPorsi.Text == "")
            {
                MessageBox.Show("Silahkan Isi Porsi Anda", "Perhatikan!");
            }
            else
            {
                porsi = Convert.ToDouble(txtPorsi.Text);
                pesan = menu + " Rp." + harga.ToString("N") +" x" + porsi;
                lstPesan.Items.Add(pesan);
                btnProses.Text = "Pesan";
                txtPorsi.Text = "";
                lstMenu.Text = "";
                lblHarga.Text = "0.00";
                btnHapus.Enabled = true;
                lstMenu.Enabled = false;
                txtPorsi.Enabled = false;
                btnHapus.Enabled = true;
                total = porsi * harga;
                totals = total + totals;
                if (lblStatus.Text == "Reguler")
                {
                    if (totals > 499000)
                    {
                        lblPotong.Text = "- Rp.40.000,00";
                    }
                    else if (totals > 199000)
                    {
                        lblPotong.Text = "- Rp.10.000,00";
                    }
                    else
                    {
                        lblPotong.Text = "";
                    }
                    txtBayar.Enabled = true;
                }
                btnBayar.Enabled = true;
            }
            lblTotal.Text = totals.ToString("N");
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            btnBayar.Enabled = false;
            lblPotong.Text = "";
            txtBayar.Enabled = false;
            lstPesan.Items.Clear();
            lblTotal.Text = "0.00";
            totals = 0;
            btnHapus.Enabled = false;
        }

        private void txtBayar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            string kata,speech;
            double pulus;
            if (btnBayar.Text == "Bayar Tunai")
            {
                if (txtBayar.Text == "")
                {
                    MessageBox.Show("Masukkan Jumlah Uang", "Perhatikan!");
                }
                else
                {
                    bayar = Convert.ToDouble(txtBayar.Text);
                    if (totals > 499000)
                    {
                        diskon = 40000;
                        kembalian = bayar - totals + diskon;
                    }
                    else if (totals > 199000)
                    {
                        diskon = 10000;
                        kembalian = bayar - totals + diskon;
                    }
                    else
                    {
                        lblPotong.Text = "";
                        kembalian = bayar - totals;
                    }
                    if (kembalian > 0)
                    {

                        lblKembalian.Text = kembalian.ToString("N");
                        kata = "Kembalian Anda Rp." + kembalian.ToString("N");
                        MessageBox.Show(Convert.ToString(kata), "Terima Kasih");
                        txtBayar.Text = "";
                        btnBayar.Enabled = false;
                        lblPotong.Text = "";
                        txtBayar.Enabled = false;
                        lstPesan.Items.Clear();
                        lblTotal.Text = "0.00";
                        totals = 0;
                        btnHapus.Enabled = false;

                        speech = "Thanks You For Using Our Services";
                        rd.Dispose();
                        rd = new SpeechSynthesizer();
                        rd.SpeakAsync(speech);

                        string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
                        string query = "update fLogin set Username='" + this.o + "',Password='" + this.p + "',Uang='" + this.y + "',Status='" + this.statusvip + "',Poin='" + this.mapoin + "' where Username='" + this.o + "' ";
                        SqlConnection condb = new SqlConnection(constring);
                        SqlCommand cmddb = new SqlCommand(query, condb);
                        SqlDataReader myreader;
                        try
                        {
                            condb.Open();
                            myreader = cmddb.ExecuteReader();
                            while (myreader.Read())
                            {
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Ada Kesalahan!", "Laporkan Kepada Admin");
                        }  
                    }
                    else
                    {
                        pulus = totals - bayar;
                        kata = "Uang Anda Kurang Rp." + pulus.ToString("N");
                        MessageBox.Show(Convert.ToString(kata), "Periksa Kembali");
                    }
                }
            }
            else if (btnBayar.Text == "Bayar Dengan Saldo")
            {
                if (lblStatus.Text == "Vip Bronze")
                {
                    diskon = totals * 10 / 100;
                    kembalian = y - totals + diskon;
                }
                else if (lblStatus.Text == "Vip Silver")
                {
                    diskon = totals * 15 / 100;
                    kembalian = y - totals + diskon;
                }
                else if (lblStatus.Text == "Vip Gold")
                {
                    diskon = totals * 25 / 100;
                    kembalian = y - totals + diskon;
                }
                else if (lblStatus.Text == "Vip Gold  ")
                {
                    diskon = totals * 25 / 100;
                    kembalian = y - totals + diskon;
                }
                else if (lblStatus.Text == "Admin")
                {
                    diskon = totals * 25 / 100;
                    kembalian = y - totals + diskon;
                }
                if (kembalian >= 0)
                { 

                    lblKembalian.Text = kembalian.ToString("N");
                    kata = "Saldo Anda Sisa Rp." + kembalian.ToString("N");
                    MessageBox.Show(Convert.ToString(kata), "Terima Kasih");
                    Random rnd = new Random();
                    int acak = rnd.Next(1, 75);
                    switch (acak)
                    {
                        case 1: poin = totals * 6 / 100 + diskon;
                            poins = "Level 6 " + poin + " Poin"; break;
                        case 2: poin = totals * 7 / 100 + diskon;
                            poins = "Level 7 " + poin + " Poin"; break;
                        case 3: poin = totals * 8 / 100 + diskon;
                            poins = "Level 8 " + poin + " Poin"; break;
                        case 4: poin = totals * 9 / 100 + diskon;
                            poins = "Level 9 " + poin + " Poin"; break;
                        case 5: poin = totals * 10 / 100 + diskon;
                            poins = "Level 10 " + poin + " Poin"; break;
                        case 6: poin = totals * 1 / 100 + diskon;
                            poins = "Level 1 " + poin + " Poin"; break;
                        case 7: poin = totals * 2 / 100 + diskon;
                            poins = "Level 2 " + poin + " Poin"; break;
                        case 8: poin = totals * 3 / 100 + diskon;
                            poins = "Level 3 " + poin + " Poin"; break;
                        case 9: poin = totals * 11 / 100 + diskon;
                            poins = "Level 11" + poin + " Poin"; break;
                        case 10: poin = totals * 12 / 100 + diskon;
                            poins = "Level 12 " + poin + " Poin"; break;
                        case 11: poin = totals * 13 / 100 + diskon;
                            poins = "Level 13 " + poin + " Poin"; break;
                        case 12: poin = totals * 14 / 100 + diskon;
                            poins = "Level 14 " + poin + " Poin"; break;
                        case 13: poin = totals * 15 / 100 + diskon;
                            poins = "Level 15 " + poin + " Poin"; break;
                        case 14: poin = totals * 4 / 100 + diskon;
                            poins = "Level 4 " + poin + " Poin"; break;
                        case 15: poin = totals * 5 / 100 + diskon;
                            poins = "Level 5 " + poin + " Poin"; break;
                        case 16: poin = totals * 20 / 100 + diskon;
                            poins = "Level 20 " + poin + " Poin"; break;
                        case 17: poin = totals * 19 / 100 + diskon;
                            poins = "Level 19 " + poin + " Poin"; break;
                        case 18: poin = totals * 18 / 100 + diskon;
                            poins = "Level 18 " + poin + " Poin"; break;
                        case 19: poin = totals * 16 / 100 + diskon;
                            poins = "Level 16 " + poin + " Poin"; break;
                        case 20: poin = totals * 17 / 100 + diskon;
                            poins = "Level 17 " + poin + " Poin"; break;
                        case 21: poin = totals * 30 / 100 + diskon;
                            poins = "Level Max " + poin + " Poin"; break;


                        case 22: poin = totals * 6 / 100 + diskon;
                            poins = "Level 6 " + poin + " Poin"; break;
                        case 23: poin = totals * 7 / 100 + diskon;
                            poins = "Level 7 " + poin + " Poin"; break;
                        case 24: poin = totals * 8 / 100 + diskon;
                            poins = "Level 8 " + poin + " Poin"; break;
                        case 25: poin = totals * 9 / 100 + diskon;
                            poins = "Level 9 " + poin + " Poin"; break;
                        case 26: poin = totals * 10 / 100 + diskon;
                            poins = "Level 10 " + poin + " Poin"; break;
                        case 27: poin = totals * 1 / 100 + diskon;
                            poins = "Level 1 " + poin + " Poin"; break;
                        case 28: poin = totals * 2 / 100 + diskon;
                            poins = "Level 2 " + poin + " Poin"; break;
                        case 29: poin = totals * 3 / 100 + diskon;
                            poins = "Level 3 " + poin + " Poin"; break;
                        case 30: poin = totals * 11 / 100 + diskon;
                            poins = "Level 11" + poin + " Poin"; break;
                        case 31: poin = totals * 12 / 100 + diskon;
                            poins = "Level 12 " + poin + " Poin"; break;
                        case 32: poin = totals * 13 / 100 + diskon;
                            poins = "Level 13 " + poin + " Poin"; break;
                        case 33: poin = totals * 14 / 100 + diskon;
                            poins = "Level 14 " + poin + " Poin"; break;
                        case 34: poin = totals * 15 / 100 + diskon;
                            poins = "Level 15 " + poin + " Poin"; break;
                        case 35: poin = totals * 4 / 100 + diskon;
                            poins = "Level 4 " + poin + " Poin"; break;
                        case 36: poin = totals * 5 / 100 + diskon;
                            poins = "Level 5 " + poin + " Poin"; break;
                        case 37: poin = totals * 20 / 100 + diskon;
                            poins = "Level 20 " + poin + " Poin"; break;
                        case 38: poin = totals * 19 / 100 + diskon;
                            poins = "Level 19 " + poin + " Poin"; break;
                        case 39: poin = totals * 18 / 100 + diskon;
                            poins = "Level 18 " + poin + " Poin"; break;
                        case 40: poin = totals * 16 / 100 + diskon;
                            poins = "Level 16 " + poin + " Poin"; break;
                        case 41: poin = totals * 17 / 100 + diskon;
                            poins = "Level 17 " + poin + " Poin"; break;


                        case 42: poin = totals * 6 / 100 + diskon;
                            poins = "Level 6 " + poin + " Poin"; break;
                        case 43: poin = totals * 7 / 100 + diskon;
                            poins = "Level 7 " + poin + " Poin"; break;
                        case 44: poin = totals * 8 / 100 + diskon;
                            poins = "Level 8 " + poin + " Poin"; break;
                        case 45: poin = totals * 9 / 100 + diskon;
                            poins = "Level 9 " + poin + " Poin"; break;
                        case 46: poin = totals * 10 / 100 + diskon;
                            poins = "Level 10 " + poin + " Poin"; break;
                        case 47: poin = totals * 1 / 100 + diskon;
                            poins = "Level 1 " + poin + " Poin"; break;
                        case 48: poin = totals * 2 / 100 + diskon;
                            poins = "Level 2 " + poin + " Poin"; break;
                        case 49: poin = totals * 3 / 100 + diskon;
                            poins = "Level 3 " + poin + " Poin"; break;
                        case 50: poin = totals * 11 / 100 + diskon;
                            poins = "Level 11" + poin + " Poin"; break;
                        case 51: poin = totals * 12 / 100 + diskon;
                            poins = "Level 12 " + poin + " Poin"; break;
                        case 52: poin = totals * 13 / 100 + diskon;
                            poins = "Level 13 " + poin + " Poin"; break;
                        case 53: poin = totals * 14 / 100 + diskon;
                            poins = "Level 14 " + poin + " Poin"; break;
                        case 54: poin = totals * 15 / 100 + diskon;
                            poins = "Level 15 " + poin + " Poin"; break;
                        case 55: poin = totals * 4 / 100 + diskon;
                            poins = "Level 4 " + poin + " Poin"; break;
                        case 56: poin = totals * 5 / 100 + diskon;
                            poins = "Level 5 " + poin + " Poin"; break;

                        case 57: poin = totals * 6 / 100 + diskon;
                            poins = "Level 6 " + poin + " Poin"; break;
                        case 58: poin = totals * 7 / 100 + diskon;
                            poins = "Level 7 " + poin + " Poin"; break;
                        case 59: poin = totals * 8 / 100 + diskon;
                            poins = "Level 8 " + poin + " Poin"; break;
                        case 60: poin = totals * 9 / 100 + diskon;
                            poins = "Level 9 " + poin + " Poin"; break;
                        case 61: poin = totals * 10 / 100 + diskon;
                            poins = "Level 10 " + poin + " Poin"; break;
                        case 62: poin = totals * 1 / 100 + diskon;
                            poins = "Level 1 " + poin + " Poin"; break;
                        case 63: poin = totals * 2 / 100 + diskon;
                            poins = "Level 2 " + poin + " Poin"; break;
                        case 64: poin = totals * 3 / 100 + diskon;
                            poins = "Level 3 " + poin + " Poin"; break;
                        case 65: poin = totals * 4 / 100 + diskon;
                            poins = "Level 4 " + poin + " Poin"; break;
                        case 66: poin = totals * 5 / 100 + diskon;
                            poins = "Level 5 " + poin + " Poin"; break;

                        case 67: poin = totals * 1 / 100 + diskon;
                            poins = "Level 1 " + poin + " Poin"; break;
                        case 68: poin = totals * 2 / 100 + diskon;
                            poins = "Level 2 " + poin + " Poin"; break;
                        case 69: poin = totals * 3 / 100 + diskon;
                            poins = "Level 3 " + poin + " Poin"; break;
                        case 70: poin = totals * 4 / 100 + diskon;
                            poins = "Level 4 " + poin + " Poin"; break;
                        case 71: poin = totals * 5 / 100 + diskon;
                            poins = "Level 5 " + poin + " Poin"; break;

                        case 72: poin = totals * 1 / 100 + diskon;
                            poins = "Level 1 " + poin + " Poin"; break;
                        case 73: poin = totals * 2 / 100 + diskon;
                            poins = "Level 2 " + poin + " Poin"; break;
                        case 74: poin = totals * 3 / 100 + diskon;
                            poins = "Level 3 " + poin + " Poin"; break;

                        case 75: poin = totals * 1 / 100 + diskon;
                            poins = "Level 1 " + poin + " Poin"; break;
                    }
                    exp = diskon + (poin * 2);
                    kata = "Anda Mendapatkan Poin "+poins;
                    MessageBox.Show("Lihat Poin Yang Didapat", "Selamat");
                    MessageBox.Show(Convert.ToString(kata), "Selamat");
                    exps = exps + exp;
                    mapoin = mapoin + poin;
                    lblPoin.Text = Convert.ToString(mapoin);
                    txtBayar.Text = "";
                    btnBayar.Enabled = false;
                    lblPotong.Text = "";
                    txtBayar.Enabled = false;
                    lstPesan.Items.Clear();
                    lblTotal.Text = "0.00";
                    totals = 0;
                    btnHapus.Enabled = false;
                    y = kembalian;
                    lblSaldo.Text = "Rp." + y.ToString("N");

                    speech = "Thanks You For Using Our Services";
                    rd.Dispose();
                    rd = new SpeechSynthesizer();
                    rd.SpeakAsync(speech);

                    string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
                    string query = "update fLogin set Username='" + this.o + "',Password='" + this.p + "',Uang='" + this.y + "',Status='" + this.statusvip + "',Poin='" + this.mapoin + "',Level='" + this.exps + "' where Username='" + this.o + "' ";
                    SqlConnection condb = new SqlConnection(constring);
                    SqlCommand cmddb = new SqlCommand(query, condb);
                    SqlDataReader myreader;
                    try
                    {
                        condb.Open();
                        myreader = cmddb.ExecuteReader();
                        while (myreader.Read())
                        {
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ada Kesalahan!", "Laporkan Kepada Admin");
                    }  
                }
                else
                {
                    pulus = totals - y - diskon;
                    kata = "Saldo Anda Kurang Rp." + pulus.ToString("N");
                    MessageBox.Show(Convert.ToString(kata), "Silahkan TopUp");
                }
            }
        }

        private void v210ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("*Tukar Poin & *Profil Manual", "Whats New In v2.10");
        }

        private void vComingSoonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versi Terbaru Akan Segera Hadir Buat Anda", "Coming Soon");
        }

        private void poinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Poin Khusus User Vip Yang Didapatkan Setiap Menggunakan Saldo", "Hint");
            MessageBox.Show("Poin Dapat Ditukar Menjadi Saldo", "Hint");
        }

        private void originalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
                this.BackColor = colorDialog2.Color;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {  

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongTimeString();
            lblTgl.Text = DateTime.Now.ToLongDateString();

        }

        System.Media.SoundPlayer song = new System.Media.SoundPlayer();
        private void btnMusic_Click(object sender, EventArgs e)
        {
            song.SoundLocation = @"D:\Bejjo\Tugas\Project\BejjoProject\song.wav";
            if (btnMusic.Text == "Play Music")
            {
                try
                {
                    song.Load();
                    song.PlayLooping();
                    btnMusic.Text = "Stop Music";
                    axWindowsMediaPlayer1.close();
                }
                catch (Win32Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (btnMusic.Text == "Stop Music")
            {
                song.Stop();
                btnMusic.Text = "Play Music";
            }
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lblPoin_Click(object sender, EventArgs e)
        {

        }

        private void txtBayar_TextChanged(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.Text == "Ayam Penyet Bejjo")
            {
                axWindowsMediaPlayer1.URL = @"D:\Bejjo\Tugas\Project\BejjoProject\Iklan\Ayam.mp4";
            }
            else if (listBox1.Text == "Burger")
            {
                axWindowsMediaPlayer1.URL = @"D:\Bejjo\Tugas\Project\BejjoProject\Iklan\Burger.mp4";
            }
            else if (listBox1.Text == "Pizza")
            {
                axWindowsMediaPlayer1.URL = @"D:\Bejjo\Tugas\Project\BejjoProject\Iklan\Pizza.mp4";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            song.Stop();
            if (listBox1.Text == "Ayam Penyet Bejjo")
            {
                axWindowsMediaPlayer1.URL = @"D:\Bejjo\Tugas\Project\BejjoProject\Iklan\Burger.mp4";
                listBox1.Text = "Burger";
            }
            else if (listBox1.Text == "Burger")
            {
                axWindowsMediaPlayer1.URL = @"D:\Bejjo\Tugas\Project\BejjoProject\Iklan\Pizza.mp4";
                listBox1.Text = "Pizza";
            }
            else if (listBox1.Text == "Pizza")
            {
                axWindowsMediaPlayer1.URL = @"D:\Bejjo\Tugas\Project\BejjoProject\Iklan\Ayam.mp4";
                listBox1.Text = "Ayam Penyet Bejjo";
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            song.Stop();
            if (listBox1.Text == "Ayam Penyet Bejjo")
            {
                axWindowsMediaPlayer1.URL = @"D:\Bejjo\Tugas\Project\BejjoProject\Iklan\Pizza.mp4";
                listBox1.Text = "Pizza";
            }
            else if (listBox1.Text == "Burger")
            {
                axWindowsMediaPlayer1.URL = @"D:\Bejjo\Tugas\Project\BejjoProject\Iklan\Ayam.mp4";
                listBox1.Text = "Ayam Penyet Bejjo";
            }
            else if (listBox1.Text == "Pizza")
            {
                axWindowsMediaPlayer1.URL = @"D:\Bejjo\Tugas\Project\BejjoProject\Iklan\Burger.mp4";
                listBox1.Text = "Burger";
            }
        }
        string vid;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                vid = dlg.FileName.ToString();
                axWindowsMediaPlayer1.URL = vid;
            }
        }

        private void txtPorsi_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
