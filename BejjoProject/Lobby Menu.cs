using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BejjoProject
{
    public partial class Lobby_Menu : Form
    {
        int a;
        public Lobby_Menu()
        {
            InitializeComponent();
        }
        private void Lobby_Menu_Load(object sender, EventArgs e)
        {
            progressBar4.Hide();
            progressBar3.Hide();
            progressBar1.Hide();
            progressBar2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult button = MessageBox.Show("Ingin Masuk ?", "Pilih",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                 MessageBoxDefaultButton.Button2);
            if (button == DialogResult.Yes)
            {
                a = 1;
                progressBar1.Show();
                button1.Enabled = false;
                button2.Enabled = false;
                this.timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (a == 1)
            {
                progressBar1.Increment(1);
                if (progressBar1.Value == 100)
                {
                    timer1.Stop();
                    Form1 f1 = new Form1();
                    f1.Show();
                    this.Hide();
                }
            }
            else if (a == 2)
            {
                progressBar3.Increment(1);
                if (progressBar3.Value == 100)
                {
                    timer1.Stop();
                    Converter c1 = new Converter();
                    c1.Show();
                    this.Hide();
                }
            }
            else if (a == 3)
            {
                progressBar4.Increment(1);
                if (progressBar4.Value == 100)
                {
                    timer1.Stop();
                    Sign_In si = new Sign_In();
                    si.Show();
                    this.Hide();
                }
            }
            else if (a == 4)
            {
                progressBar2.Increment(1);
                if (progressBar2.Value == 100)
                {
                    timer1.Stop();
                    Perpustakaan perpus = new Perpustakaan();
                    perpus.Show();
                    this.Hide();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult button = MessageBox.Show("Ingin Masuk ?", "Pilih",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                 MessageBoxDefaultButton.Button2);
            if (button == DialogResult.Yes)
            {
                a = 4;
                progressBar2.Show();
                button1.Enabled = false;
                button2.Enabled = false;
                this.timer1.Start();
            }
        }

        private void Lobby_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult button = MessageBox.Show("Ingin Masuk ?", "Pilih",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                 MessageBoxDefaultButton.Button2);
            if (button == DialogResult.Yes)
            {
                a = 2;
                progressBar3.Show();
                button1.Enabled = false;
                button2.Enabled = false;
                this.timer1.Start();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult button = MessageBox.Show("Ingin Masuk ?", "Pilih",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                 MessageBoxDefaultButton.Button2);
            if (button == DialogResult.Yes)
            {
                a = 3;
                progressBar4.Show();
                button1.Enabled = false;
                button2.Enabled = false;
                this.timer1.Start();
            }
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }
    }
}
