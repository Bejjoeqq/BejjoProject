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
    public partial class Converter : Form
    {
        string a;
        int b,c,d;
        public Converter()
        {
            InitializeComponent();
        }

        private void Converter_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Show();
            timer1.Start();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            comboBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.textBox1.Text = file.FileName;
                a = textBox1.Text;
                b = 1;
                comboBox1.Enabled = true;
                if (b == 1 && c == 1)
                {
                    button1.Enabled = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox1.Enabled = false;
            button1.Enabled = false;
            textBox1.Text = "";
            progressBar1.Value = 0;
            b = 0;
            progressBar1.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Silahkan Isi Link Photo", "Perhatikan");
            }
            else
            {
                progressBar1.Increment(1);
                if (progressBar1.Value == 100)
                {
                    System.Drawing.Image im = System.Drawing.Image.FromFile(@a);
                    if (d == 1)
                    {
                        im.Save(@a + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    else if (d == 2)
                    {
                        im.Save(@a + ".ico", System.Drawing.Imaging.ImageFormat.Icon);
                    }
                    else if (d == 3)
                    {
                        im.Save(@a + ".gif", System.Drawing.Imaging.ImageFormat.Gif);
                    }
                    else if (d == 4)
                    {
                        im.Save(@a + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                    }
                    else if (d == 5)
                    {
                        im.Save(@a + ".emf", System.Drawing.Imaging.ImageFormat.Emf);
                    }
                    else if (d == 6)
                    {
                        im.Save(@a + ".png", System.Drawing.Imaging.ImageFormat.Png);
                    }
                    else if (d == 7)
                    {
                        im.Save(@a + ".tiff", System.Drawing.Imaging.ImageFormat.Tiff);
                    }
                    else if (d == 8)
                    {
                        im.Save(@a + ".wmf", System.Drawing.Imaging.ImageFormat.Wmf);
                    }
                    button1.Enabled = false;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    progressBar1.Hide();
                    timer1.Stop();
                    comboBox1.Text = "";
                    comboBox1.Enabled = false;
                    textBox1.Text = "";
                    progressBar1.Value = 0;
                    b = 0;
                    MessageBox.Show("Berhasil", "Terima Kasih");
                }
            }

        }

        private void Converter_Load(object sender, EventArgs e)
        {
            progressBar1.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == ".jpeg")
            {
                d = 1;
                c = 1;
            }
            else if (comboBox1.Text == ".ico")
            {
                d = 2;
                c = 1;
            }
            else if (comboBox1.Text == ".gif")
            {
                d = 3;
                c = 1;
            }
            else if (comboBox1.Text == ".bmp")
            {
                d = 4;
                c = 1;
            }
            else if (comboBox1.Text == ".emf")
            {
                d = 5;
                c = 1;
            }
            else if (comboBox1.Text == ".png")
            {
                d = 6;
                c = 1;
            }
            else if (comboBox1.Text == ".tiff")
            {
                d = 7;
                c = 1;
            }
            else if (comboBox1.Text == ".wmf")
            {
                d = 8;
                c = 1;
            }
            if (b == 1 && c == 1)
            {
                button1.Enabled = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Lobby_Menu l1 = new Lobby_Menu();
            l1.Show();
            this.Hide();
        }
    }
}
