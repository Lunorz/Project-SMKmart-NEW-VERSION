namespace project_akhir_stock_gudang
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label4 = new Label();
            label1 = new Label();
            label8 = new Label();
            label6 = new Label();
            lihat_password = new CheckBox();
            tombol_batal = new Button();
            tombol_login = new Button();
            textpassword = new TextBox();
            textemail = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lihat_password);
            panel1.Controls.Add(tombol_batal);
            panel1.Controls.Add(tombol_login);
            panel1.Controls.Add(textpassword);
            panel1.Controls.Add(textemail);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, -1);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(565, 406);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(265, 71);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(117, 26);
            label4.TabIndex = 13;
            label4.Text = " ONE-mart";
            label4.Click += label4_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(265, 39);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(191, 26);
            label1.TabIndex = 12;
            label1.Text = "Selamat datang di";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(510, 350);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 11;
            label8.Text = "daftar";
            label8.Click += label8_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(366, 350);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(154, 20);
            label6.TabIndex = 9;
            label6.Text = "belum memiliki akun?";
            // 
            // lihat_password
            // 
            lihat_password.AutoSize = true;
            lihat_password.Location = new Point(437, 234);
            lihat_password.Margin = new Padding(2);
            lihat_password.Name = "lihat_password";
            lihat_password.Size = new Size(127, 24);
            lihat_password.TabIndex = 8;
            lihat_password.Text = "lihat password";
            lihat_password.UseVisualStyleBackColor = true;
            lihat_password.CheckedChanged += lihat_password_CheckedChanged;
            // 
            // tombol_batal
            // 
            tombol_batal.BackColor = Color.Teal;
            tombol_batal.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tombol_batal.Location = new Point(357, 282);
            tombol_batal.Margin = new Padding(2);
            tombol_batal.Name = "tombol_batal";
            tombol_batal.Size = new Size(90, 42);
            tombol_batal.TabIndex = 7;
            tombol_batal.Text = "keluar";
            tombol_batal.UseVisualStyleBackColor = false;
            tombol_batal.Click += tombol_batal_Click;
            // 
            // tombol_login
            // 
            tombol_login.BackColor = Color.Teal;
            tombol_login.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tombol_login.Location = new Point(466, 282);
            tombol_login.Margin = new Padding(2);
            tombol_login.Name = "tombol_login";
            tombol_login.Size = new Size(90, 42);
            tombol_login.TabIndex = 6;
            tombol_login.Text = "login";
            tombol_login.UseVisualStyleBackColor = false;
            tombol_login.Click += tombol_login_Click;
            // 
            // textpassword
            // 
            textpassword.Location = new Point(265, 205);
            textpassword.Margin = new Padding(2);
            textpassword.Name = "textpassword";
            textpassword.PlaceholderText = "masukkan password";
            textpassword.Size = new Size(287, 27);
            textpassword.TabIndex = 5;
            textpassword.UseSystemPasswordChar = true;
            textpassword.TextChanged += textBox2_TextChanged;
            // 
            // textemail
            // 
            textemail.Location = new Point(265, 140);
            textemail.Margin = new Padding(2);
            textemail.Name = "textemail";
            textemail.PlaceholderText = "masukkan email";
            textemail.Size = new Size(287, 27);
            textemail.TabIndex = 4;
            textemail.TextChanged += textnama_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(265, 182);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 3;
            label3.Text = "password";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(265, 118);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "email";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 412);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-9, -53);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 509);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 403);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private TextBox textpassword;
        private TextBox textemail;
        private Label label3;
        private Button tombol_batal;
        private Button tombol_login;
        private CheckBox lihat_password;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label6;
        private Label label1;
        private Label label4;
    }
}
