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
    public partial class Gold : Form
    {
        double y, mapoin;
        string c, d, x, statusvip;
        public Gold()
        {
            InitializeComponent();
        }
        public Gold(string a, string b, double saldo, string vip,double poin)
            : this()
        {
            mapoin = poin;
            statusvip = vip;
            c = a;
            d = b;
            y = saldo;
        }
        private void btnKembali_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(c, d, y, statusvip, mapoin);
            f1.Show();
            this.Hide();
        }

        private void Gold_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
