using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace BejjoProject
{
    public partial class Profile : Form
    {
        int pilihan;
        int code = 0;
        string yxg, a;
        double y, debit, up, mapoin,uang,exps;
        string z, v, p, x;
        public Profile()
        {
            InitializeComponent();
        }
        public static DialogResult InputBox(string judul, string promptTeks, ref string nilai)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();
            form.Text = judul;
            label.Text = promptTeks;
            textBox.Text = nilai;
            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;
            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);
            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;
            DialogResult dialogResult = form.ShowDialog();
            nilai = textBox.Text;
            return dialogResult;
        }
        public Profile(string a, string b, double c, string d, double poin)
            : this()
        {
            btnDatabase.Hide();
            mapoin = poin;
            lblPoin.Text = Convert.ToString(mapoin);
            v = a;
            p = d;
            lblUser.Text = a;
            lblVip.Text = b;
            x = b;
            y = c;
            z = "Rp." + c.ToString("N");
            lblSaldo.Text = z;

            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
            string query = "select * from fLogin where Username='" + v + "';";
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
                    string pw = myreader["Password"].ToString();
                    double money = Convert.ToDouble(myreader["Uang"]);
                    string stas = myreader["Status"].ToString();
                    double myp = Convert.ToDouble(myreader["Poin"]);
                    double esp = Convert.ToDouble(myreader["Level"]);
                    exps = esp;
                    byte[] img = (byte[])(myreader["Gambar"]);
                    if (img == null)
                    {
                        pictureBox1.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        pictureBox1.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
            }
            catch (Exception)
            {
            }

            if (lblVip.Text == "Vip Bronze")
            {
                lblVip.ForeColor = Color.Peru;
            }
            else if (lblVip.Text == "Vip Silver")
            {
                lblVip.ForeColor = Color.Silver;
            }
            else if (lblVip.Text == "Vip Gold")
            {
                lblVip.ForeColor = Color.Gold;
                btnUpgrade.Enabled = false;
                btnUpgrade.Text = "Upgrade Max";
                btnUpgrade.ForeColor = Color.Teal;
            }
            else if (lblVip.Text == "Vip Gold  ")
            {
                lblVip.ForeColor = Color.Gold;
                btnUpgrade.Enabled = false;
                btnUpgrade.Text = "Upgrade Max";
                btnUpgrade.ForeColor = Color.Teal;
            }
            else if (lblVip.Text == "Admin")
            {
                btnDatabase.Show();
                lblVip.ForeColor = Color.Orange;
                btnUpgrade.Enabled = false;
                btnUpgrade.Text = "Upgrade Max";
                btnUpgrade.ForeColor = Color.Teal;
            }

            

        }
        private void Profile_Load(object sender, EventArgs e)
        {
            btnEV.Hide();
            timer2.Start();
            progressBar1.Hide();
            if (exps >= 1000000000)
            {
                lblExpnow.Text = exps.ToString();
                lblExplate.Text = "/MAX";
                lblLvl.Text = "16";
                btnEV.Show();
            }
            else if (exps >= 500000000)
            {
                lblExpnow.Text = exps.ToString();
                lblExplate.Text = "/1000000000";
                lblLvl.Text = "15";
            }
            else if (exps >= 200000000)
            {
                lblExpnow.Text = exps.ToString();
                lblExplate.Text = "/500000000";
                lblLvl.Text = "14";
            }
            else if (exps >= 100000000)
            {
                lblExpnow.Text = exps.ToString();
                lblExplate.Text = "/200000000";
                lblLvl.Text = "13";
            }
            else if (exps >= 40000000)
            {
                lblExpnow.Text = exps.ToString();
                lblExplate.Text = "/100000000";
                lblLvl.Text = "12";
            }
            else if (exps >= 20000000)
            {
                lblExpnow.Text = exps.ToString();
                lblExplate.Text = "/40000000";
                lblLvl.Text = "11";
            }
            else if (exps >= 10000000)
            {
                lblExpnow.Text = exps.ToString();
                lblExplate.Text = "/20000000";
                lblLvl.Text = "10";
            }
            else if (exps >= 6000000)
            {
                lblExpnow.Text = exps.ToString();
                lblExplate.Text = "/10000000";
                lblLvl.Text = "9";
            }
            else if (exps >= 3000000)
            {
                lblExpnow.Text = exps.ToString();
                lblExplate.Text = "/6000000";
                lblLvl.Text = "8";
            }
            else if (exps >= 1500000)
            {
                lblExpnow.Text = exps.ToString();
                lblExplate.Text = "/3000000";
                lblLvl.Text = "7";
            }
            else if (exps >= 800000)
            {
                lblExpnow.Text = exps.ToString();
                lblExplate.Text = "/1500000";
                lblLvl.Text = "6";
            }
            else if (exps >= 400000)
            {
                lblExpnow.Text = exps.ToString();
                lblExplate.Text = "/800000";
                lblLvl.Text = "5";
            }
            else if (exps >= 200000)
            {
                lblExpnow.Text = exps.ToString();
                lblExplate.Text = "/400000";
                lblLvl.Text = "4";
            }
            else if (exps >= 100000)
            {
                lblExpnow.Text = exps.ToString();
                lblExplate.Text = "/200000";
                lblLvl.Text = "3";
            }
            else if (exps >= 50000)
            {
                lblExpnow.Text = exps.ToString();
                lblExplate.Text = "/100000";
                lblLvl.Text = "2";
            }
            else
            {
                lblExpnow.Text = exps.ToString();
                lblExplate.Text = "/50000";
                lblLvl.Text = "1";
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
            string query = "update fLogin set Username='" + this.v + "',Password='" + this.p + "',Uang='" + this.y + "',Status='" + this.x + "',Poin='" + this.mapoin + "',Level='" + this.exps + "' where Username='" + this.v + "' ";
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

            Home h1 = new Home(x, v, p, y, mapoin);
            h1.Show();
            this.Hide();
        }

        private void btnOnoff_Click(object sender, EventArgs e)
        {
            if (btnOnoff.Text == "ON")
            {
                txtUser.Enabled = true;
                txtSaldo.Enabled = true;
                txtPW.Enabled = true;
                btnSaldo.Enabled = true;
                btnOnoff.Text = "OFF";
            }
            else if(btnOnoff.Text == "OFF")
            {
                txtUser.Enabled = false;
                txtSaldo.Enabled = false;
                txtPW.Enabled = false;
                btnSaldo.Enabled = false;
                btnOnoff.Text = "ON";
            }
        }

        private void btnSaldo_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                MessageBox.Show("Username Tidak Boleh Kosong", "Perhatikan!");
            }
            else if (txtPW.Text == "")
            {
                MessageBox.Show("Password Tidak Boleh Kosong", "Perhatikan!");
            }
            else if (txtSaldo.Text == "")
            {
                MessageBox.Show("Silahkan Masukkan Nilai Uang", "Coba Lagi");
            }
            else if(Convert.ToDouble(txtSaldo.Text) < 10000)
            {
                MessageBox.Show("Minimum Anda Harus Mengisi Rp.10.000,00","Coba Lagi");
            }
            else if (txtUser.Text.Equals(v) && txtPW.Text.Equals(p))
            {

                MessageBox.Show("Isi Saldo Berhasil", "Login Sukses");
                debit = Convert.ToDouble(txtSaldo.Text);
                y = y + debit;
                z = "Rp." + y.ToString("N");
                lblSaldo.Text = Convert.ToString(z);
                txtPW.Text = "";
                txtSaldo.Text = "";
                txtUser.Text = "";
                if (btnOnoff.Text == "OFF")
                {
                    txtUser.Enabled = false;
                    txtSaldo.Enabled = false;
                    txtPW.Enabled = false;
                    btnSaldo.Enabled = false;
                    btnOnoff.Text = "ON";
                }

                string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
                string query = "update fLogin set Username='" + this.v + "',Password='" + this.p + "',Uang='" + this.y + "',Status='" + this.x + "',Poin='" + this.mapoin + "' where Username='" + this.v + "' ";
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
                MessageBox.Show("Username Atau Password Salah", "Coba Ulangi");
            }
        }

        private void txtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string strNamaFile = "";
            string strSahabat = "";
            string strTelepon = "";
            string strUmur = "";
            string strJenis = "";
            string strAgama = "";
            string strAlamat = "";
            StreamWriter FileSahabat;

            string strMasukan = "";
            if (InputBox("Profil", "Masukkan Username Anda", ref strMasukan) == DialogResult.OK)
            {
            }
            if (InputBox("Profil", "Masukkan Password Anda", ref yxg) == DialogResult.OK)
            {
                if (strMasukan.Equals(v) && yxg.Equals(p))
                {
                    strNamaFile = strMasukan;
                }
                else
                {
                    MessageBox.Show("Username Atau Password Salah", "Coba Lagi");
                }
            }

            try
            {
                FileSahabat = File.CreateText(strNamaFile);
                if (InputBox("Profil","Nama Lengkap", ref strMasukan) == DialogResult.OK)
                {
                    strSahabat = strMasukan;
                }
                if (InputBox("Profil", "Jenis Kelamin", ref strMasukan) == DialogResult.OK)
                {
                    strJenis = strMasukan;
                }
                if (InputBox("Profil", "Tempat Tanggal Lahir", ref strMasukan) == DialogResult.OK)
                {
                    strUmur = strMasukan;
                }
                if (InputBox("Profl", "Agama", ref strMasukan) == DialogResult.OK)
                {
                    strAgama = strMasukan;
                }
                if (InputBox("Profl", "Alamat", ref strMasukan) == DialogResult.OK)
                {
                    strAlamat = strMasukan;
                }
                if (InputBox("Profil", "Nomor Telepon/HP", ref strMasukan) == DialogResult.OK)
                {
                    strTelepon = strMasukan;
                }
                FileSahabat.WriteLine(strSahabat);
                FileSahabat.WriteLine(strJenis);
                FileSahabat.WriteLine(strUmur);
                FileSahabat.WriteLine(strAgama);
                FileSahabat.WriteLine(strAlamat);
                FileSahabat.WriteLine(strTelepon);

                FileSahabat.Close();
            }
            catch
            {
                MessageBox.Show("File tidak dapat diciptakan","Periksa Kembali");
            }
        }
        private void btnTampil_Click(object sender, EventArgs e)
        {
            kotakList.Items.Clear();
            
            StreamReader FileSahabat;
            string strNamaFile = "";
            string strSahabat = "";
            string strTelepon = "";
            string strUmur = "";
            string strJenis = "";
            string strAgama = "";
            string strAlamat = "";

            string strMasukan = "";
            if (InputBox("Profil", "Masukkan Username Anda", ref strMasukan) == DialogResult.OK)
            {
            }
            if (InputBox("Profil", "Masukkan Password Anda", ref yxg) == DialogResult.OK)
            {
                if (strMasukan.Equals(v) && yxg.Equals(p))
                {
                    strNamaFile = strMasukan;
                }
                else
                {
                    MessageBox.Show("Username Atau Password Salah", "Coba Lagi");
                }
            }

            try
            {
                FileSahabat = File.OpenText(strNamaFile);
                strSahabat = FileSahabat.ReadLine();
                strJenis = FileSahabat.ReadLine();
                strUmur = FileSahabat.ReadLine();
                strAgama = FileSahabat.ReadLine();
                strAlamat = FileSahabat.ReadLine();
                strTelepon = FileSahabat.ReadLine();

                kotakList.Items.Add("Biodata User");
                kotakList.Items.Add("~~~~~~~~~~~~");
                kotakList.Items.Add("Nama: " + strSahabat);
                kotakList.Items.Add("Jenis Kelamin: " + strJenis);
                kotakList.Items.Add("Tempat Tanggal Lahir: " + strUmur);
                kotakList.Items.Add("Agama: " + strAgama);
                kotakList.Items.Add("Alamat: " + strAlamat);
                kotakList.Items.Add("Telpon/Hp: " + strTelepon);
                kotakList.Items.Add("");
                FileSahabat.Close();
            }
            catch
            {
                MessageBox.Show("Anda Belum Pernah Mengisi Ini, Lakukan Edit","Periksa Kembali");
            }
        }

        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            if (lblVip.Text == "Vip Bronze" && exps >= 400000)
            {
                MessageBox.Show("Upgrade Dikenakan Biaya Rp.100.000,00 Sesuai Level Vip", "Perhatikan!");
                MessageBox.Show("Pembayaran Akan Di Potong Dengan Saldo Anda", "Perhatikan!");
                DialogResult button = MessageBox.Show("Apakah Anda Ingin Upgrade Ke Silver ?", "Pilihan",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                     MessageBoxDefaultButton.Button2);
                if (button == DialogResult.Yes)
                {
                    up = y - 100000;
                    if (up >= 0)
                    {

                        MessageBox.Show("Upgrade Berhasil", "Selamat");
                        lblVip.Text = "Vip Silver";
                        lblVip.ForeColor = Color.Silver;
                        x = lblVip.Text;
                        y = up;
                        lblSaldo.Text = "Rp." + y.ToString("N");

                        string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
                        string query = "update fLogin set Username='" + this.v + "',Password='" + this.p + "',Uang='" + this.y + "',Status='" + this.x + "',Poin='" + this.mapoin + "' where Username='" + this.v + "' ";
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
                        MessageBox.Show("Saldo Anda Tidak Mencukupi", "Silahkan TopUp");
                    }
                }
                else if (button == DialogResult.No)
                {
                    MessageBox.Show("OK", "Tetap Disini");
                }
            }
            else if (exps < 400000)
            {
                MessageBox.Show("Harus Level 5 Bisa Upgrade Vip Silver", "Coba Lagi");
            }
            else if (lblVip.Text == "Vip Silver" && exps >= 10000000)
            {
                MessageBox.Show("Upgrade Dikenakan Biaya Rp.200.000,00 Sesuai Level Vip", "Perhatikan!");
                MessageBox.Show("Pembayaran Akan Di Potong Dengan Saldo Anda", "Perhatikan!");
                DialogResult button = MessageBox.Show("Apakah Anda Ingin Upgrade Ke Gold ?", "Pilihan",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                     MessageBoxDefaultButton.Button2);
                if (button == DialogResult.Yes)
                {
                    up = y - 200000;
                    if (up >= 0)
                    {

                        MessageBox.Show("Upgrade Berhasil", "Selamat");
                        lblVip.Text = "Vip Gold";
                        lblVip.ForeColor = Color.Gold;
                        x = lblVip.Text;
                        y = up;
                        lblSaldo.Text = "Rp." + y.ToString("N");
                        btnUpgrade.Enabled = false;
                        btnUpgrade.Text = "Upgrade Max";
                        btnUpgrade.ForeColor = Color.Teal;

                        string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
                        string query = "update fLogin set Username='" + this.v + "',Password='" + this.p + "',Uang='" + this.y + "',Status='" + this.x + "',Poin='" + this.mapoin + "' where Username='" + this.v + "' ";
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
                        MessageBox.Show("Saldo Anda Tidak Mencukupi", "Silahkan TopUp");
                    }
                }
                else if (button == DialogResult.No)
                {
                    MessageBox.Show("OK", "Tetap Disini");
                }
            }
            else if(exps < 10000000)
            {
                MessageBox.Show("Harus Level 10 Bisa Upgrade Vip Gold", "Coba Lagi");
            }
        }

        private void btnTukar_Click(object sender, EventArgs e)
        {
            string kata;
            if (mapoin > 2499)
            { 

                uang = mapoin * 40 / 100;
                mapoin = 0;
                lblPoin.Text = "0";
                kata = "Anda Mendapatkan Rp." + uang.ToString("N") + " Dari Menukarkan Poin Anda";
                MessageBox.Show(Convert.ToString(kata), "Berhasil Tukar");
                y = y + uang;
                lblSaldo.Text = "Rp." + y.ToString("N");

                string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
                string query = "update fLogin set Username='" + this.v + "',Password='" + this.p + "',Uang='" + this.y + "',Status='" + this.x + "',Poin='" + this.mapoin + "' where Username='" + this.v + "' ";
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
                MessageBox.Show("Minimum Poin Anda 2500 Bisa Tukar", "Coba Lagi Nanti");
            }
        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.ShowDialog(this);
        }

        private void txtSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnGF_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string pic = dlg.FileName.ToString();
                a = pic;
                pictureBox1.ImageLocation = pic;
                progressBar1.Show();
                timer1.Start();
                progressBar1.Value = 0;
                btnBonus.Enabled = false;
                btnDatabase.Enabled = false;
                btnEdit.Enabled = false;
                btnGF.Enabled = false;
                btnKembali.Enabled = false;
                btnOnoff.Enabled = false;
                btnSaldo.Enabled = false;
                btnTampil.Enabled = false;
                btnTukar.Enabled = false;
                btnUpgrade.Enabled = false;
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                progressBar1.Hide();

                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] im = ms.ToArray();
                string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
                string query = "update fLogin set Username='" + this.v + "',Password='" + this.p + "',Uang='" + this.y + "',Status='" + this.x + "',Poin='" + this.mapoin + "',Gambar=@IMG where Username='" + this.v + "'";
                SqlConnection cn = new SqlConnection(constring);
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.Add("@IMG", SqlDbType.Image).Value = im;
                SqlDataReader rd;
                try
                {
                    cn.Open();
                    rd = cmd.ExecuteReader();
                    MessageBox.Show("Berhasil Menyimpan", "Sukses");
                    while (rd.Read())
                    {
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ada Kesalahan Lapor Admin", "Warning");
                }
                btnBonus.Enabled = true;
                btnDatabase.Enabled = true;
                btnEdit.Enabled = true;
                btnGF.Enabled = true;
                btnKembali.Enabled = true;
                btnOnoff.Enabled = true;
                btnSaldo.Enabled = true;
                btnTampil.Enabled = true;
                btnTukar.Enabled = true;
                btnUpgrade.Enabled = true;
            }
        }
        int min = 0;
        int sec = 10;
        int ms = 10;
        private void timer2_Tick(object sender, EventArgs e)
        {
            btnBonus.Text = sec + " : " + ms.ToString();
            ms--;
            if (min == 0 && sec == 0 && ms == 0)
            {
                ms = 0;
                timer2.Stop();
                btnBonus.Enabled = true;
                btnBonus.Text = "Undian";
            }
            else if (sec == 0 && ms == 0)
            {
                min = 0;
                sec = 59;
                ms = 10;
            }
            else if (ms == 0)
            {
                ms = 10;
                sec--;
            }
        }

        string kata;
        private void btnBonus_Click(object sender, EventArgs e)
        {
            DialogResult button = MessageBox.Show("Membutuhkan Rp.10.000,00 Untuk Undian ?", "Pilihan",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);
            if (button == DialogResult.Yes)
            {
                if (y > 9999)
                {
                    y = y - 10000;
                    min = 0;
                    sec = 10;
                    ms = 10;
                    btnBonus.Enabled = false;
                    Random rnd = new Random();
                    int acak = rnd.Next(1, 30);
                    switch (acak)
                    {
                        case 1: exps = exps + 25000;
                            kata = "Bad Common : 25000 EXP";
                            break;
                        case 2: exps = exps + 50000;
                            kata = "Common : 50000 EXP";
                            break;
                        case 3: mapoin = mapoin + 7500;
                            kata = "Uncommon : 7500 Poin";
                            break;
                        case 4: mapoin = mapoin + 12500;
                            kata = "Very Uncommon : 12500 Poin";
                            break;
                        case 5: y = y + 10000;
                            kata = "Rare : Rp.10.000,00";
                            break;
                        case 6: y = y + 20000;
                            kata = "Very Rare : Rp.20.000,00";
                            break;
                        case 7: exps = exps + 500000;
                            kata = "Epic : 500000 EXP";
                            break;
                        case 8: mapoin = mapoin + 125000;
                            kata = "Very Epic : 125000 Poin";
                            break;
                        case 9: y = y + 100000;
                            kata = "Legendary : Rp.100.000,00";
                            break;
                        case 10: exps = exps + 300000;
                            mapoin = mapoin + 50000;
                            y = y + 50000;
                            kata = "Legendary Myth : 300000 EXP, 50000 Poin, Rp.50.000,00";
                            break;


                        case 11: exps = exps + 25000;
                            kata = "Bad Common : 25000 EXP";
                            break;
                        case 12: exps = exps + 50000;
                            kata = "Common : 50000 EXP";
                            break;
                        case 13: mapoin = mapoin + 7500;
                            kata = "Uncommon : 7500 Poin";
                            break;
                        case 14: mapoin = mapoin + 12500;
                            kata = "Very Uncommon : 12500 Poin";
                            break;
                        case 15: y = y + 10000;
                            kata = "Rare : Rp.10.000,00";
                            break;
                        case 16: y = y + 20000;
                            kata = "Very Rare : Rp.20.000,00";
                            break;
                        case 17: exps = exps + 500000;
                            kata = "Epic : 500000 EXP";
                            break;
                        case 18: mapoin = mapoin + 125000;
                            kata = "Very Epic : 125000 Poin";
                            break;
                        case 19: y = y + 100000;
                            kata = "Legendary : Rp.100.000,00";
                            break;


                        case 20: exps = exps + 25000;
                            kata = "Bad Common : 25000 EXP";
                            break;
                        case 21: exps = exps + 50000;
                            kata = "Common : 50000 EXP";
                            break;
                        case 22: mapoin = mapoin + 7500;
                            kata = "Uncommon : 7500 Poin";
                            break;
                        case 23: mapoin = mapoin + 12500;
                            kata = "Very Uncommon : 12500 Poin";
                            break;
                        case 24: y = y + 10000;
                            kata = "Rare : Rp.10.000,00";
                            break;
                        case 25: y = y + 20000;
                            kata = "Very Rare : Rp.20.000,00";
                            break;


                        case 26: exps = exps + 25000;
                            kata = "Bad Common : 25000 EXP";
                            break;
                        case 27: mapoin = mapoin + 7500;
                            kata = "Uncommon : 7500 Poin";
                            break;
                        case 28: y = y + 10000;
                            kata = "Rare : Rp.10.000,00";
                            break;


                        case 29: exps = exps + 25000;
                            kata = "Bad Common : 25000 EXP";
                            break;
                        case 30: mapoin = mapoin + 7500;
                            kata = "Uncommon : 7500 Poin";
                            break;


                        case 31: exps = exps + 25000;
                            kata = "Bad Common : 25000 EXP";
                            break;
                        case 32: exps = exps + 50000;
                            kata = "Common : 50000 EXP";
                            break;
                        case 33: mapoin = mapoin + 7500;
                            kata = "Uncommon : 7500 Poin";
                            break;
                        case 34: mapoin = mapoin + 12500;
                            kata = "Very Uncommon : 12500 Poin";
                            break;
                        case 35: y = y + 10000;
                            kata = "Rare : Rp.10.000,00";
                            break;
                        case 36: y = y + 20000;
                            kata = "Very Rare : Rp.20.000,00";
                            break;
                        case 37: exps = exps + 500000;
                            kata = "Epic : 500000 EXP";
                            break;
                        case 38: mapoin = mapoin + 125000;
                            kata = "Very Epic : 125000 Poin";
                            break;
                        case 39: y = y + 100000;
                            kata = "Legendary : Rp.100.000,00";
                            break;
                        case 40: exps = exps + 300000;
                            mapoin = mapoin + 50000;
                            y = y + 50000;
                            kata = "Legendary Myth : 300000 EXP, 50000 Poin, Rp.50.000,00";
                            break;
                        case 41: code++;
                            lblCode.Text = code.ToString();
                            kata = "Redeem Now Or It Will Be Lost (1AS2D3)";
                            break;
                    }
                    MessageBox.Show(kata, "Berhasil");
                    if (exps >= 1000000000)
                    {
                        lblExpnow.Text = exps.ToString();
                        lblExplate.Text = "/MAX";
                        lblLvl.Text = "16";
                        btnEV.Show();
                    }
                    else if (exps >= 500000000)
                    {
                        lblExpnow.Text = exps.ToString();
                        lblExplate.Text = "/1000000000";
                        lblLvl.Text = "15";
                    }
                    else if (exps >= 200000000)
                    {
                        lblExpnow.Text = exps.ToString();
                        lblExplate.Text = "/500000000";
                        lblLvl.Text = "14";
                    }
                    else if (exps >= 100000000)
                    {
                        lblExpnow.Text = exps.ToString();
                        lblExplate.Text = "/200000000";
                        lblLvl.Text = "13";
                    }
                    else if (exps >= 40000000)
                    {
                        lblExpnow.Text = exps.ToString();
                        lblExplate.Text = "/100000000";
                        lblLvl.Text = "12";
                    }
                    else if (exps >= 20000000)
                    {
                        lblExpnow.Text = exps.ToString();
                        lblExplate.Text = "/40000000";
                        lblLvl.Text = "11";
                    }
                    else if (exps >= 10000000)
                    {
                        lblExpnow.Text = exps.ToString();
                        lblExplate.Text = "/20000000";
                        lblLvl.Text = "10";
                    }
                    else if (exps >= 6000000)
                    {
                        lblExpnow.Text = exps.ToString();
                        lblExplate.Text = "/10000000";
                        lblLvl.Text = "9";
                    }
                    else if (exps >= 3000000)
                    {
                        lblExpnow.Text = exps.ToString();
                        lblExplate.Text = "/6000000";
                        lblLvl.Text = "8";
                    }
                    else if (exps >= 1500000)
                    {
                        lblExpnow.Text = exps.ToString();
                        lblExplate.Text = "/3000000";
                        lblLvl.Text = "7";
                    }
                    else if (exps >= 800000)
                    {
                        lblExpnow.Text = exps.ToString();
                        lblExplate.Text = "/1500000";
                        lblLvl.Text = "6";
                    }
                    else if (exps >= 400000)
                    {
                        lblExpnow.Text = exps.ToString();
                        lblExplate.Text = "/800000";
                        lblLvl.Text = "5";
                    }
                    else if (exps >= 200000)
                    {
                        lblExpnow.Text = exps.ToString();
                        lblExplate.Text = "/400000";
                        lblLvl.Text = "4";
                    }
                    else if (exps >= 100000)
                    {
                        lblExpnow.Text = exps.ToString();
                        lblExplate.Text = "/200000";
                        lblLvl.Text = "3";
                    }
                    else if (exps >= 50000)
                    {
                        lblExpnow.Text = exps.ToString();
                        lblExplate.Text = "/100000";
                        lblLvl.Text = "2";
                    }
                    else
                    {
                        lblExpnow.Text = exps.ToString();
                        lblExplate.Text = "/50000";
                        lblLvl.Text = "1";
                    }
                    lblPoin.Text = mapoin.ToString();
                    lblSaldo.Text = "Rp." + y.ToString("N");


                    string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
                    string query = "update fLogin set Username='" + this.v + "',Password='" + this.p + "',Uang='" + this.y + "',Status='" + this.x + "',Poin='" + this.mapoin + "',Level='" + this.exps + "' where Username='" + this.v + "' ";
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
                    timer2.Start();
                }
                else
                {
                    MessageBox.Show("Uang Anda Kurang", "Periksa Kembali");
                }
            }
            else if (button == DialogResult.No)
            {
            }
        }

        private void lblExpnow_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            if(code > 1)
            {
                if (txtCode.Text == "21062001")
                {
                    code = 0;
                    exps = exps + 300000000;
                    mapoin = mapoin + 5000000;
                    y = y + 500000;
                    kata = "Secret JACKPOT : 300000 X 1000 EXP, 50000 X 100 Poin, Rp.50.000,00 X 10";
                    MessageBox.Show(kata, "Selamat");
                    lblCode.Text = code.ToString();
                }
                else if (txtCode.Text == "1AS2D3")
                {
                    code--;
                    exps = exps + 30000000;
                    mapoin = mapoin + 500000;
                    y = y + 100000;
                    kata = "Legendary Myth X JACKPOT : 300000 X 100 EXP, 50000 X 10 Poin, Rp.50.000,00 X 2";
                    MessageBox.Show(kata, "Selamat");
                    lblCode.Text = code.ToString();
                }
                else
                {
                    MessageBox.Show("Code Salah","Ulangi");
                }
            }
            else if (code == 1)
            {
                if (txtCode.Text == "1AS2D3")
                {
                    code--;
                    exps = exps + 30000000;
                    mapoin = mapoin + 500000;
                    y = y + 100000;
                    kata = "Legendary Myth X JACKPOT : 300000 X 100 EXP, 50000 X 10 Poin, Rp.50.000,00 X 2";
                    MessageBox.Show(kata, "Selamat");
                    lblCode.Text = code.ToString();
                }
                else
                {
                    MessageBox.Show("Code Salah", "Ulangi");
                }
            }
            else if (txtCode.Text == "LVLUP")
            {
                exps = exps + 1000;
            }
            else if (txtCode.Text == "MONEYMONEY")
            {
                y = y + 10000;
            }
            else if (code < 1)
            {
                if (txtCode.Text == "GTCGTCGTC")
                {
                    code=2;
                    lblCode.Text = code.ToString();
                }
                else
                {
                    MessageBox.Show("Cari Code Di Bonus", "Coba Lagi");
                }
            }



            if (exps >= 1000000000)
            {
                lblExpnow.Text = exps.ToString();
                lblExplate.Text = "/MAX";
                lblLvl.Text = "16";
                btnEV.Show();
            }
            else if (exps >= 500000000)
            {
                lblExpnow.Text = exps.ToString();
                lblExplate.Text = "/1000000000";
                lblLvl.Text = "15";
            }
            else if (exps >= 200000000)
            {
                lblExpnow.Text = exps.ToString();
                lblExplate.Text = "/500000000";
                lblLvl.Text = "14";
            }
            else if (exps >= 100000000)
            {
                lblExpnow.Text = exps.ToString();
                lblExplate.Text = "/200000000";
                lblLvl.Text = "13";
            }
            else if (exps >= 40000000)
            {
                lblExpnow.Text = exps.ToString();
                lblExplate.Text = "/100000000";
                lblLvl.Text = "12";
            }
            else if (exps >= 20000000)
            {
                lblExpnow.Text = exps.ToString();
                lblExplate.Text = "/40000000";
                lblLvl.Text = "11";
            }
            else if (exps >= 10000000)
            {
                lblExpnow.Text = exps.ToString();
                lblExplate.Text = "/20000000";
                lblLvl.Text = "10";
            }
            else if (exps >= 6000000)
            {
                lblExpnow.Text = exps.ToString();
                lblExplate.Text = "/10000000";
                lblLvl.Text = "9";
            }
            else if (exps >= 3000000)
            {
                lblExpnow.Text = exps.ToString();
                lblExplate.Text = "/6000000";
                lblLvl.Text = "8";
            }
            else if (exps >= 1500000)
            {
                lblExpnow.Text = exps.ToString();
                lblExplate.Text = "/3000000";
                lblLvl.Text = "7";
            }
            else if (exps >= 800000)
            {
                lblExpnow.Text = exps.ToString();
                lblExplate.Text = "/1500000";
                lblLvl.Text = "6";
            }
            else if (exps >= 400000)
            {
                lblExpnow.Text = exps.ToString();
                lblExplate.Text = "/800000";
                lblLvl.Text = "5";
            }
            else if (exps >= 200000)
            {
                lblExpnow.Text = exps.ToString();
                lblExplate.Text = "/400000";
                lblLvl.Text = "4";
            }
            else if (exps >= 100000)
            {
                lblExpnow.Text = exps.ToString();
                lblExplate.Text = "/200000";
                lblLvl.Text = "3";
            }
            else if (exps >= 50000)
            {
                lblExpnow.Text = exps.ToString();
                lblExplate.Text = "/100000";
                lblLvl.Text = "2";
            }
            else
            {
                lblExpnow.Text = exps.ToString();
                lblExplate.Text = "/50000";
                lblLvl.Text = "1";
            }
            lblPoin.Text = mapoin.ToString();
            lblSaldo.Text = "Rp." + y.ToString("N");


            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
            string query = "update fLogin set Username='" + this.v + "',Password='" + this.p + "',Uang='" + this.y + "',Status='" + this.x + "',Poin='" + this.mapoin + "',Level='" + this.exps + "' where Username='" + this.v + "' ";
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

        private void btnEV_Click(object sender, EventArgs e)
        {
            double ax;         
            if (exps >= 30000000000)
            {
                ax = Convert.ToInt64(exps / 1000000000);
                lblExpnow.Text = ax.ToString() + "★";
                lblExplate.Text = "/MAX";
                lblLvl.Text = "$";
            }
            else if (exps >= 15000000000)
            {
                ax = Convert.ToInt64(exps / 1000000000);
                lblExpnow.Text = ax.ToString() + "★";
                lblExplate.Text = "/30★";
                lblLvl.Text = "SSS";
            }
            else if (exps >= 8000000000)
            {
                ax = Convert.ToInt64(exps / 1000000000);
                lblExpnow.Text = ax.ToString() + "★";
                lblExplate.Text = "/15★";
                lblLvl.Text = "SS";
            }
            else if (exps >= 4000000000)
            {
                ax = Convert.ToInt64(exps / 1000000000);
                lblExpnow.Text = ax.ToString() + "★";
                lblExplate.Text = "/8★";
                lblLvl.Text = "S";
            }
            else if (exps >= 2000000000)
            {
                ax = Convert.ToInt64(exps / 1000000000);
                lblExpnow.Text = ax.ToString() + "★";
                lblExplate.Text = "/4★";
                lblLvl.Text = "A";
            } 
            else if (exps >= 1000000000)
            {
                ax = Convert.ToInt64(exps / 1000000000);
                lblExpnow.Text = ax.ToString() + "★";
                lblExplate.Text = "/2★";
                lblLvl.Text = "B";
            }
            btnEV.Hide();
        }
    }
}
