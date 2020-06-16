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
    public partial class Database : Form
    {
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlCommandBuilder scb;
        public Database()
        {
            InitializeComponent();
        }
        private void btnDatabase_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
            string query = "select * from fLogin";
            SqlConnection condb = new SqlConnection(constring);
            SqlCommand cmddb = new SqlCommand(query, condb);
            try
            {
                sda.SelectCommand = cmddb;
                sda.Fill(dt);
                BindingSource bs = new BindingSource();

                bs.DataSource = dt;
                dataGridView1.RowTemplate.Height = 60;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.DataSource = bs;
                DataGridViewImageColumn image = new DataGridViewImageColumn();
                image = (DataGridViewImageColumn)dataGridView1.Columns[5];
                image.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                sda.Update(dt);
            }
            catch (Exception)
            {
                MessageBox.Show("Ada Kesalahan", "Teliti Kembali");
            }
            btnSave.Enabled = true;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string asddsa,zzzz;
            zzzz = textBox1.Text;
            asddsa ="Apakah Anda Ingin Menghapus ->" + zzzz;
             DialogResult button = MessageBox.Show(asddsa, "Pilihan",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                     MessageBoxDefaultButton.Button2);
             if (button == DialogResult.Yes)
             {
                 string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
                 string query = "delete from fLogin where Username=@Username";
                 SqlConnection condb = new SqlConnection(constring);
                 SqlCommand cmddb = new SqlCommand(query, condb);
                 cmddb.Parameters.Add("@Username", SqlDbType.VarChar).Value = textBox1.Text;
                 SqlDataReader myreader;
                 try
                 {
                     condb.Open();
                     myreader = cmddb.ExecuteReader();
                     MessageBox.Show("Berhasil", "Selamat");
                     while (myreader.Read())
                     {
                     }
                 }
                 catch (Exception)
                 {
                     MessageBox.Show("Ada Kesalahan", "Periksa Kembali");
                 }
             }
             else
             {
             }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        public void FillDGV(string find)
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
            string query = "select * from fLogin where Username like '%"+find+"%'";
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
                DataGridViewImageColumn image = new DataGridViewImageColumn();
                image = (DataGridViewImageColumn)dataGridView1.Columns[5];
                image.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                sda.Update(dt);
            }
            catch (Exception)
            {
                MessageBox.Show("Ada Kesalahan", "Teliti Kembali");
            }  
        }
        private void Database_Load(object sender, EventArgs e)
        {
            FillDGV("");
            textBox1.Hide();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void Database_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            FillDGV(txtFind.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
            MessageBox.Show("Simpan Berhasil","Sukses");
        }
    }
}
