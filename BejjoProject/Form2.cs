using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace BejjoProject
{
    public partial class Form2 : Form
    {
        double z, x, yy, mapoin;
        string b, a, y, q, c, d, statusvip,gambar;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public Form2(string a, string b, double saldo, string vip, double poin)
            : this()
        {
            mapoin = poin;
            statusvip = vip;
            c = a;
            d = b;
            yy = saldo;
        }
        private void btnDaftar1_Click(object sender, EventArgs e)
        {
            string kata;
            double uang;
            if (txtUser1.Text == "")
            {
                MessageBox.Show("Username Tidak Boleh Kosong", "Perhatikan!");
            }
            else if (txtPass1.Text == "")
            {
                MessageBox.Show("Password Tidak Boleh Kosong", "Perhatikan!");
            }
            else if (txtBayar.Text == "")
            {
                MessageBox.Show("Silahkan Masukan Jumlah Uang Anda", "Perhatikan!");
            }
            else
            {
                z = Convert.ToDouble(txtBayar.Text);
            }
            if (txtUser1.Text == "")
            {
            }
            else if (txtPass1.Text == "")
            {
            }
            else if (txtBayar.Text == "")
            {
            }
            else if (z < 50000)
            {
                uang = 50000 - z;
                kata = "Uang Anda Kurang Rp." + uang.ToString("N");
                MessageBox.Show(Convert.ToString(kata), "Coba Ulangi");
            }
            else if (txtUser1.Text == a)
            {
                MessageBox.Show("Username Sudah Ada", "Coba Ulangi");
            }
            else if (txtUser1.Text == c)
            {
                MessageBox.Show("Username Sudah Ada", "Coba Ulangi");
            }
            else
            {
                gambar = @"D:\Bejjo\Tugas\Project\BejjoProject\BejjoProject\bin\Debug\Asd.jpg";
                byte[] im = null;
                FileStream st = new FileStream(this.gambar, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(st);
                im = br.ReadBytes((int)st.Length);

                string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
                string query = "insert into fLogin (Username, Password, Uang, Status, Poin, Gambar) values('" + this.txtUser1.Text + "','" + this.txtPass1.Text + "','" + this.yy + "','" + this.statusvip + "','" + this.mapoin + "',@IMG) ;";
                SqlConnection condb = new SqlConnection(constring);
                SqlCommand cmddb = new SqlCommand(query, condb);
                cmddb.Parameters.Add(new SqlParameter("@IMG", im));
                SqlDataReader myreader;
                try
                {
                    condb.Open();
                    myreader = cmddb.ExecuteReader();
                    MessageBox.Show("Daftar Berhasil", "Selamat");

                    x = z - 50000;
                    y = "Kembalian Anda Rp." + x.ToString("N");
                    MessageBox.Show(Convert.ToString(y), "Terima Kasih");
                    MessageBox.Show("Selamat Anda Vip Bronze, Silahkan Login Kembali", "Daftar Vip Sukses : Bronze");
                    a = txtUser1.Text;
                    b = txtPass1.Text;
                    DialogResult button = MessageBox.Show("Lanjutkan Ke Menu Login ?", "Pilihan",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                         MessageBoxDefaultButton.Button2);
                    if (button == DialogResult.Yes)
                    {
                        Form1 f1 = new Form1(a, b);
                        f1.Show();
                        this.Hide();
                    }
                    else if (button == DialogResult.No)
                    {
                        MessageBox.Show("Ok", "Tetap Disini");
                        q = "1";
                    }
                    while (myreader.Read())
                    {
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Username Sudah Ada", "Coba Ulangi");
                }                
            }
            /*
            string kata;
            double uang;
            if (txtUser1.Text == "")
            {
                MessageBox.Show("Username Tidak Boleh Kosong", "Perhatikan!");
            }
            else if (txtPass1.Text == "")
            {
                MessageBox.Show("Password Tidak Boleh Kosong", "Perhatikan!");
            }
            else if (txtBayar.Text == "")
            {
                MessageBox.Show("Silahkan Masukan Jumlah Uang Anda", "Perhatikan!");
            }
            else
            {
                z = Convert.ToDouble(txtBayar.Text);
            }
            if (txtUser1.Text == "")
            {
            }
            else if (txtPass1.Text == "")
            {
            }
            else if (txtBayar.Text =="")
            {
            }
            else if (z < 50000)
            {
                uang = 50000 - z;
                kata = "Uang Anda Kurang Rp." + uang.ToString("N");
                MessageBox.Show(Convert.ToString(kata),"Coba Ulangi");
            }
            else if (txtUser1.Text == a)
            {
                MessageBox.Show("Username Sudah Ada", "Coba Ulangi");
            }
            else if (txtUser1.Text == c)
            {
                MessageBox.Show("Username Sudah Ada", "Coba Ulangi");
            }
            else
            {
                x = z - 50000;
                y = "Kembalian Anda Rp." + x.ToString("N");
                MessageBox.Show(Convert.ToString(y), "Terima Kasih");
                MessageBox.Show("Selamat Anda Vip Bronze, Silahkan Login Kembali", "Daftar Vip Sukses : Bronze");
                a = txtUser1.Text;
                b = txtPass1.Text;
                DialogResult button = MessageBox.Show("Lanjutkan Ke Menu Login ?", "Pilihan",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                     MessageBoxDefaultButton.Button2);
                if (button == DialogResult.Yes)
                {
                    Form1 f1 = new Form1(a, b);
                    f1.Show();
                    this.Hide();
                }
                else if (button == DialogResult.No)
                {
                    MessageBox.Show("Ok", "Tetap Disini");
                    q = "1";
                }
            }
             */
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            if (q == "1")
            {
                Form1 f1 = new Form1(a, b, yy, statusvip, mapoin);
                f1.Show();
                this.Hide();
            }
            else
            {
                Form1 f1 = new Form1(c, d, yy, statusvip, mapoin);
                f1.Show();
                this.Hide();
            }
        }

        private void txtBayar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtUser1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPass1.Focus();
            }
        }

        private void txtPass1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBayar.Focus();
            }
        }
    }
}
