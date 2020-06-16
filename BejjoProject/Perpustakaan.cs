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
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;

namespace BejjoProject
{
    public partial class Perpustakaan : Form
    {
        public Perpustakaan()
        {
            InitializeComponent();
        }

        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public void FillDGV(string find)
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Buku.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
            string query = "select * from Bukuku where Judul like '%" + find + "%'";
            SqlConnection condb = new SqlConnection(constring);
            SqlCommand cmddb = new SqlCommand(query, condb);
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmddb;
                sda.Fill(dt);
                BindingSource bs = new BindingSource();

                bs.DataSource = dt;
                dataGridView1.RowTemplate.Height = 60;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.DataSource = bs;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                sda.Update(dt);
            }
            catch (Exception)
            {
                MessageBox.Show("Ada Kesalahan", "Teliti Kembali");
            }  
        }
        private void FindAndReplace(Word.Application wordApp, object FindText, object ReplaceWith)
        {

            object MatchCase = true;
            object MatchWholeWord = true;
            object MatchWildcards = false;
            object MatchSoundsLike = false;
            object MatchAllWordForms = false;
            object Forward = true;
            object Format = false;
            object MatchKashida = false;
            object MatchDiacritics = false;
            object MatchAlefHamza = false;
            object MatchControl = false;
            object read_only = false;
            object visible = true;
            object Replace = 2;
            object Wrap = 1;

            wordApp.Selection.Find.Execute(ref FindText,
                ref MatchCase, ref MatchWholeWord,
                ref MatchWildcards, ref MatchSoundsLike,
                ref MatchAllWordForms, ref Forward,
                ref Wrap, ref Format, ref ReplaceWith,
                ref Replace, ref MatchKashida,
                ref MatchDiacritics, ref MatchAlefHamza,
                ref MatchControl);
        }
        string user = "Aldi";
        string kod = "K123ANR";
        private void CreateWord(object filename, object SaveAs)
        {
            Word.Application wordApp = new Word.Application();
            object missing = Missing.Value;
            Word.Document myWordDoc = null;
            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;                                    
                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();

                this.FindAndReplace(wordApp, "<username>", user);
                this.FindAndReplace(wordApp, "<aidi>", aidi);
                this.FindAndReplace(wordApp, "<judul>", judul);
                this.FindAndReplace(wordApp, "<genre>", genre);
                this.FindAndReplace(wordApp, "<harga>", harga);
                this.FindAndReplace(wordApp, "<vc>", vc);
                this.FindAndReplace(wordApp, "<kode>", kod);
            }
            else
            {
                MessageBox.Show("File not found", "Try Again");
            }
            myWordDoc.SaveAs(ref SaveAs, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing);
            myWordDoc.Close();
            wordApp.Quit();
            MessageBox.Show("File Created", "Success");
        }
        public void FillDGV1(string find)
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Buku.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
            string query = "select * from Bukuku where GENRE like '%" + find + "%'";
            SqlConnection condb = new SqlConnection(constring);
            SqlCommand cmddb = new SqlCommand(query, condb);
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmddb;
                sda.Fill(dt);
                BindingSource bs = new BindingSource();

                bs.DataSource = dt;
                dataGridView2.RowTemplate.Height = 60;
                dataGridView2.AllowUserToAddRows = false;
                dataGridView2.DataSource = bs;

                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                sda.Update(dt);
            }
            catch (Exception)
            {
                MessageBox.Show("Ada Kesalahan", "Teliti Kembali");
            }
        }

        public void FillDGV2(string find)
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Buku.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
            string query = "select * from Bukuku where GENRE like '%" + find + "%'";
            SqlConnection condb = new SqlConnection(constring);
            SqlCommand cmddb = new SqlCommand(query, condb);
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmddb;
                sda.Fill(dt);
                BindingSource bs = new BindingSource();

                bs.DataSource = dt;
                dataGridView3.RowTemplate.Height = 60;
                dataGridView3.AllowUserToAddRows = false;
                dataGridView3.DataSource = bs;

                dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                sda.Update(dt);
            }
            catch (Exception)
            {
                MessageBox.Show("Ada Kesalahan", "Teliti Kembali");
            }
        }
        public void FillDGV3(string find)
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Buku.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
            string query = "select * from Bukuku where GENRE like '%" + find + "%'";
            SqlConnection condb = new SqlConnection(constring);
            SqlCommand cmddb = new SqlCommand(query, condb);
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmddb;
                sda.Fill(dt);
                BindingSource bs = new BindingSource();

                bs.DataSource = dt;
                dataGridView4.RowTemplate.Height = 60;
                dataGridView4.AllowUserToAddRows = false;
                dataGridView4.DataSource = bs;

                dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                sda.Update(dt);
            }
            catch (Exception)
            {
                MessageBox.Show("Ada Kesalahan", "Teliti Kembali");
            }
        }
        int aidi, stok, xxx=0;
        int[] aa = new int[100];
        string judul, genre;
        double harga;
        private void Perpustakaan_Load(object sender, EventArgs e)
        {
            btnBeli.Enabled = false;
            panel1.Hide();
            listView1.GridLines = true;
            listView1.View = View.Details;
            listView1.Columns.Add("Judul Buku", 180);
            listView1.Columns.Add("Harga", 120);
            timer1.Start();
            cboGenre.Text = "All";
            FillDGV("");
            FillDGV1("");
            FillDGV2("");
            FillDGV3("");
        }

        private void Perpustakaan_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            FillDGV(txtFind.Text);
        }
        private void btnLihat_Click(object sender, EventArgs e)
        {
            judul = "";
            harga = 0;
            stok = 0;

            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Buku.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
            string query = "select * from Bukuku where ID='" + txtLihat.Text + "';";
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    int id = Convert.ToInt32(myreader["ID"]);
                    string jdl = myreader["JUDUL"].ToString();
                    string gn = myreader["GENRE"].ToString();
                    double hrg = Convert.ToDouble(myreader["HARGA"]);
                    int stk = Convert.ToInt32(myreader["STOK"]);

                    aidi = id;
                    judul = jdl;
                    genre = gn;
                    harga = hrg;
                    stok = stk;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ada Kesalahan");
            }

            lblJudul.Text = judul;
            lblHarga.Text = "Rp. "+ harga.ToString("N");
            if (stok > 0)
            {
                lblStok.Text = stok.ToString() + " Tersedia";
            }
            else
            {
                lblStok.Text = "Stok Habis";
            }

            if (lblStok.Text == "Stok Habis")
            {
                lblAdd.Enabled = false;
            }
            else
            {
                lblAdd.Enabled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtLihat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void cboGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGenre.Text == "All")
            {
                txtFind.Enabled = true;
                dataGridView1.Show();
                dataGridView2.Hide();
                dataGridView3.Hide();
                dataGridView4.Hide();
            }
            else if (cboGenre.Text == "Comedy")
            {
                txtFind.Enabled = false;
                dataGridView2.Show();
                dataGridView1.Hide();
                dataGridView3.Hide();
                dataGridView4.Hide();
                FillDGV1("Comedy");
            }
            else if (cboGenre.Text == "Horor")
            {
                txtFind.Enabled = false;
                dataGridView3.Show();
                dataGridView2.Hide();
                dataGridView1.Hide();
                dataGridView4.Hide();
                FillDGV2("Horor");
            }
            else if (cboGenre.Text == "Romance")
            {
                txtFind.Enabled = false;
                dataGridView4.Show();
                dataGridView3.Hide();
                dataGridView2.Hide();
                dataGridView1.Hide();
                FillDGV3("Romance");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        int sec = 1;
        int ms = 5;
        int x = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            ms--;
            if (sec == 0 && ms == 0)
            {
                sec = 1;
                ms = 5;
                x++;
            }
            else if (ms == 0)
            {
                ms = 5;
                sec--;
            }
            if (x == 1)
            {
                groupBox1.ForeColor = Color.Maroon;
            }
            else if (x == 2)
            {
                groupBox1.ForeColor = Color.Red;
            }
            else if (x == 3)
            {
                groupBox1.ForeColor = Color.LightCoral;
            }
            else if (x == 4)
            {
                groupBox1.ForeColor = Color.Coral;
            }
            else if (x == 5)
            {
                groupBox1.ForeColor = Color.Chocolate;
            }
            else if (x == 6)
            {
                groupBox1.ForeColor = Color.DarkGoldenrod;
            }
            else if (x == 7)
            {
                groupBox1.ForeColor = Color.OliveDrab;
            }
            else if (x == 8)
            {
                groupBox1.ForeColor = Color.ForestGreen;
            }
            else if (x == 9)
            {
                groupBox1.ForeColor = Color.MediumSeaGreen;
            }
            else if (x == 10)
            {
                groupBox1.ForeColor = Color.DeepSkyBlue;
            }
            else if (x == 11)
            {
                groupBox1.ForeColor = Color.RoyalBlue;
            }
            else if (x == 12)
            {
                groupBox1.ForeColor = Color.SlateBlue;
            }
            else if (x == 13)
            {
                groupBox1.ForeColor = Color.Crimson;
            }
            else if (x == 14)
            {
                groupBox1.ForeColor = Color.Black;
                x = 0;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Lobby_Menu l1 = new Lobby_Menu();
            l1.Show();
            this.Hide();
        }
        double total;
        private void lblAdd_Click(object sender, EventArgs e)
        {
            aa[xxx] = aidi;
            xxx++;
            stok--;
            string harg;
            harg= "Rp. " + harga.ToString("N");
            string[] arr = new string[2];
            arr[0] = judul;
            arr[1] = harg;
            ListViewItem daftaritem;
            daftaritem = listView1.Items.Add(arr[0]);
            daftaritem.SubItems.Add(arr[1]);

            total = total + harga;
            lblTotal.Text = "Rp. " + total.ToString("N");
            
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Buku.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
            string query = "update Bukuku set STOK='" + this.stok + "' where ID='" + this.aidi + "' ";
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

            btnBeli.Enabled = true;
            lblAdd.Enabled = false;
            lblJudul.Text = "";
            lblHarga.Text = "";
            lblStok.Text = "";
            txtLihat.Text = "";
        }

        private void btnBeli_Click(object sender, EventArgs e)
        {
            btnCoba.Enabled = false;
            txtKode.Enabled = false;
            lblTHarga.Text = "Rp. " + total.ToString("N");
            panel1.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPocer_Click(object sender, EventArgs e)
        {
            if (btnPocer.Text == "Voucher")
            {
                btnPocer.Text = "Batal";
                btnCoba.Enabled = true;
                txtKode.Enabled = true;
            }
            else if (btnPocer.Text == "Batal")
            {
                btnPocer.Text = "Voucher";
                btnCoba.Enabled = false;
                txtKode.Enabled = false;
            }
        }
        double diskon;
        string vc = "-";
        private void btnCoba_Click(object sender, EventArgs e)
        {
            if (txtKode.Text == "A12B3C")
            {
                diskon = total * 20 / 100;
                total = total - diskon;
                lblDiskon.Text = "Diskon 20%";
                lblTHarga.Text = "Rp. " + total.ToString("N");
                btnCoba.Enabled = false;
                vc = "A12B3C";
            }
            else
            {
                MessageBox.Show("Kode Salah");
            }
        }
        double bayar,kem;
        int hitung=0;
        string template = @"D:\Buku\Setting\Template.docx";
        string print = @"D:\Buku\Formulir\FormulirBTC ";
        private void btnBayar_Click(object sender, EventArgs e)
        {
            hitung++;
            bayar = Convert.ToDouble(txtPem.Text);
            kem = bayar - total;
            if (kem < 0)
            {
                MessageBox.Show("Uang Anda Kurang");
            }
            else
            {
                lblKembalian.Text = "Rp. " + kem.ToString("N");
                MessageBox.Show("Kembalian anda Rp." + kem.ToString("N"));
                CreateWord(template, print + hitung.ToString());
                Close();
            }

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtLihat.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        int xax = 0;
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Buku.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
            string query = "select * from Bukuku where ID='" + aa[xax] + "';";
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    int id = Convert.ToInt32(myreader["ID"]);
                    string jdl = myreader["JUDUL"].ToString();
                    string gn = myreader["GENRE"].ToString();
                    double hrg = Convert.ToDouble(myreader["HARGA"]);
                    int stk = Convert.ToInt32(myreader["STOK"]);

                    aidi = id;
                    judul = jdl;
                    genre = gn;
                    harga = hrg;
                    stok = stk;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ada Kesalahan");
            }

            listView1.TopItem.Remove();
            stok++;
            total = total - harga;
            lblTotal.Text = "Rp. " + total.ToString("N");

            string cnst = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Buku.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
            string qr = "update Bukuku set STOK='" + this.stok + "' where ID='" + aa[xax] + "' ";
            SqlConnection condb = new SqlConnection(cnst);
            SqlCommand cmddb = new SqlCommand(qr, condb);
            SqlDataReader myr;
            try
            {
                condb.Open();
                myr = cmddb.ExecuteReader();
                while (myr.Read())
                {
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ada Kesalahan!", "Laporkan Kepada Admin");
            }
            xax++;
        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
        }


    }
}
