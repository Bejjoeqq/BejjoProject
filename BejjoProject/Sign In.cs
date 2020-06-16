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
    public partial class Sign_In : Form
    {
        string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Hero.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
        string pw, user;
        public Sign_In()
        {
            InitializeComponent();
        }

        private void Sign_In_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(constring);
            SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) From Heroo where Username='" + txtUser.Text + "'and Password='" + txtPass.Text + "'", con);
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                /*
                user = txtUser.Text;
                pw = txtPass.Text;
                Menu mn = new Mendu(user,pw);
                mn.Show();
                this.Hide();
                 */
                Perpustakaan prst = new Perpustakaan();
                prst.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username Or Password Incorrectly","Please Check Again");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Lobby_Menu l1 = new Lobby_Menu();
            l1.Show();
            this.Hide();
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sign In");
        }
    }
}
