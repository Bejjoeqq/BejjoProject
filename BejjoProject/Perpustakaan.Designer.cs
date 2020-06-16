namespace BejjoProject
{
    partial class Perpustakaan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.txtLihat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLihat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAdd = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStok = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.lblJudul = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnBeli = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblKembalian = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnBayar = new System.Windows.Forms.Button();
            this.lblDiskon = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCoba = new System.Windows.Forms.Button();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPem = new System.Windows.Forms.TextBox();
            this.btnPocer = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTHarga = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(739, 184);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cari Judul Buku :";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(164, 12);
            this.txtFind.Multiline = true;
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(260, 22);
            this.txtFind.TabIndex = 8;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // txtLihat
            // 
            this.txtLihat.Location = new System.Drawing.Point(80, 257);
            this.txtLihat.Name = "txtLihat";
            this.txtLihat.Size = new System.Drawing.Size(153, 22);
            this.txtLihat.TabIndex = 9;
            this.txtLihat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLihat_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID Buku :";
            // 
            // btnLihat
            // 
            this.btnLihat.Location = new System.Drawing.Point(239, 257);
            this.btnLihat.Name = "btnLihat";
            this.btnLihat.Size = new System.Drawing.Size(75, 23);
            this.btnLihat.TabIndex = 11;
            this.btnLihat.Text = "Lihat";
            this.btnLihat.UseVisualStyleBackColor = true;
            this.btnLihat.Click += new System.EventHandler(this.btnLihat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAdd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblStok);
            this.groupBox1.Controls.Add(this.lblHarga);
            this.groupBox1.Controls.Add(this.lblJudul);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 123);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detail Buku";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.BackColor = System.Drawing.Color.Transparent;
            this.lblAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAdd.Enabled = false;
            this.lblAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAdd.Location = new System.Drawing.Point(262, 91);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(31, 20);
            this.lblAdd.TabIndex = 20;
            this.lblAdd.Text = ">>";
            this.lblAdd.Click += new System.EventHandler(this.lblAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Stok :";
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Location = new System.Drawing.Point(67, 80);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(0, 17);
            this.lblStok.TabIndex = 4;
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Location = new System.Drawing.Point(67, 54);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(0, 17);
            this.lblHarga.TabIndex = 3;
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Location = new System.Drawing.Point(67, 28);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(0, 17);
            this.lblJudul.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Harga :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Judul :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(545, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Genre :";
            // 
            // cboGenre
            // 
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Items.AddRange(new object[] {
            "All",
            "Romance",
            "Comedy",
            "Horor"});
            this.cboGenre.Location = new System.Drawing.Point(607, 12);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(121, 24);
            this.cboGenre.TabIndex = 14;
            this.cboGenre.SelectedIndexChanged += new System.EventHandler(this.cboGenre_SelectedIndexChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 55);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(739, 184);
            this.dataGridView2.TabIndex = 15;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 55);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(739, 184);
            this.dataGridView3.TabIndex = 16;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(0, 55);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(739, 184);
            this.dataGridView4.TabIndex = 17;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "<<";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(320, 257);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(408, 97);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView1_DragDrop);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // btnBeli
            // 
            this.btnBeli.Location = new System.Drawing.Point(349, 360);
            this.btnBeli.Name = "btnBeli";
            this.btnBeli.Size = new System.Drawing.Size(75, 23);
            this.btnBeli.TabIndex = 22;
            this.btnBeli.Text = "Beli";
            this.btnBeli.UseVisualStyleBackColor = true;
            this.btnBeli.Click += new System.EventHandler(this.btnBeli_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(482, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Total :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(536, 363);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 17);
            this.lblTotal.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblKembalian);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.btnBayar);
            this.panel1.Controls.Add(this.lblDiskon);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btnCoba);
            this.panel1.Controls.Add(this.txtKode);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtPem);
            this.panel1.Controls.Add(this.btnPocer);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lblTHarga);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(0, 257);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 154);
            this.panel1.TabIndex = 25;
            // 
            // lblKembalian
            // 
            this.lblKembalian.AutoSize = true;
            this.lblKembalian.Location = new System.Drawing.Point(111, 76);
            this.lblKembalian.Name = "lblKembalian";
            this.lblKembalian.Size = new System.Drawing.Size(0, 17);
            this.lblKembalian.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 17);
            this.label13.TabIndex = 11;
            this.label13.Text = "Kembalian :";
            // 
            // btnBayar
            // 
            this.btnBayar.Location = new System.Drawing.Point(12, 118);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(75, 23);
            this.btnBayar.TabIndex = 10;
            this.btnBayar.Text = "Bayar";
            this.btnBayar.UseVisualStyleBackColor = true;
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // lblDiskon
            // 
            this.lblDiskon.AutoSize = true;
            this.lblDiskon.Location = new System.Drawing.Point(547, 88);
            this.lblDiskon.Name = "lblDiskon";
            this.lblDiskon.Size = new System.Drawing.Size(0, 17);
            this.lblDiskon.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(482, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "Diskon :";
            // 
            // btnCoba
            // 
            this.btnCoba.Location = new System.Drawing.Point(653, 85);
            this.btnCoba.Name = "btnCoba";
            this.btnCoba.Size = new System.Drawing.Size(75, 23);
            this.btnCoba.TabIndex = 7;
            this.btnCoba.Text = "Coba";
            this.btnCoba.UseVisualStyleBackColor = true;
            this.btnCoba.Click += new System.EventHandler(this.btnCoba_Click);
            // 
            // txtKode
            // 
            this.txtKode.Location = new System.Drawing.Point(537, 45);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(191, 22);
            this.txtKode.TabIndex = 6;
            this.txtKode.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(482, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "Kode :";
            // 
            // txtPem
            // 
            this.txtPem.Location = new System.Drawing.Point(114, 45);
            this.txtPem.Name = "txtPem";
            this.txtPem.Size = new System.Drawing.Size(221, 22);
            this.txtPem.TabIndex = 4;
            // 
            // btnPocer
            // 
            this.btnPocer.Location = new System.Drawing.Point(653, 3);
            this.btnPocer.Name = "btnPocer";
            this.btnPocer.Size = new System.Drawing.Size(75, 23);
            this.btnPocer.TabIndex = 3;
            this.btnPocer.Text = "Voucher";
            this.btnPocer.UseVisualStyleBackColor = true;
            this.btnPocer.Click += new System.EventHandler(this.btnPocer_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Pembayaran :";
            // 
            // lblTHarga
            // 
            this.lblTHarga.AutoSize = true;
            this.lblTHarga.Location = new System.Drawing.Point(109, 18);
            this.lblTHarga.Name = "lblTHarga";
            this.lblTHarga.Size = new System.Drawing.Size(0, 17);
            this.lblTHarga.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Total Harga :";
            // 
            // Perpustakaan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 414);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnBeli);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.cboGenre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLihat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLihat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(746, 449);
            this.MinimumSize = new System.Drawing.Size(746, 449);
            this.Name = "Perpustakaan";
            this.Text = "Tokoh Buku Bejjo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Perpustakaan_FormClosing);
            this.Load += new System.EventHandler(this.Perpustakaan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.TextBox txtLihat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLihat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboGenre;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnBeli;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTHarga;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPem;
        private System.Windows.Forms.Button btnPocer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDiskon;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCoba;
        private System.Windows.Forms.Label lblKembalian;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnBayar;
    }
}