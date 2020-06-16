namespace BejjoProject
{
    partial class Sign_Up
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
            this.txtUser1 = new System.Windows.Forms.TextBox();
            this.txtPass1 = new System.Windows.Forms.TextBox();
            this.btnDaftar1 = new System.Windows.Forms.Button();
            this.btnKembali = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUser1
            // 
            this.txtUser1.BackColor = System.Drawing.Color.LightGray;
            this.txtUser1.Location = new System.Drawing.Point(118, 33);
            this.txtUser1.Name = "txtUser1";
            this.txtUser1.Size = new System.Drawing.Size(151, 22);
            this.txtUser1.TabIndex = 12;
            // 
            // txtPass1
            // 
            this.txtPass1.BackColor = System.Drawing.Color.LightGray;
            this.txtPass1.Location = new System.Drawing.Point(118, 76);
            this.txtPass1.Name = "txtPass1";
            this.txtPass1.PasswordChar = '*';
            this.txtPass1.Size = new System.Drawing.Size(151, 22);
            this.txtPass1.TabIndex = 11;
            // 
            // btnDaftar1
            // 
            this.btnDaftar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDaftar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDaftar1.Location = new System.Drawing.Point(194, 197);
            this.btnDaftar1.Name = "btnDaftar1";
            this.btnDaftar1.Size = new System.Drawing.Size(75, 23);
            this.btnDaftar1.TabIndex = 10;
            this.btnDaftar1.Text = "Daftar";
            this.btnDaftar1.UseVisualStyleBackColor = false;
            this.btnDaftar1.Click += new System.EventHandler(this.btnDaftar1_Click);
            // 
            // btnKembali
            // 
            this.btnKembali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnKembali.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKembali.Location = new System.Drawing.Point(17, 197);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(75, 23);
            this.btnKembali.TabIndex = 9;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Username";
            // 
            // Sign_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.txtUser1);
            this.Controls.Add(this.txtPass1);
            this.Controls.Add(this.btnDaftar1);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Sign_Up";
            this.Text = "Sign_Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser1;
        private System.Windows.Forms.TextBox txtPass1;
        private System.Windows.Forms.Button btnDaftar1;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}