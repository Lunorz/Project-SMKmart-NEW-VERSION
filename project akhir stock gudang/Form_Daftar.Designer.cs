namespace project_akhir_stock_gudang
{
    partial class Form_Daftar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Daftar));
            panel1 = new Panel();
            label4 = new Label();
            kembali_ke_login = new Label();
            reg_lihat_password = new CheckBox();
            tombol_login = new Button();
            reg_password = new TextBox();
            reg_email = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
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
            panel1.Controls.Add(kembali_ke_login);
            panel1.Controls.Add(reg_lihat_password);
            panel1.Controls.Add(tombol_login);
            panel1.Controls.Add(reg_password);
            panel1.Controls.Add(reg_email);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-4, -22);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(577, 385);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(261, 92);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(117, 26);
            label4.TabIndex = 10;
            label4.Text = " ONE-mart";
            // 
            // kembali_ke_login
            // 
            kembali_ke_login.AutoSize = true;
            kembali_ke_login.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kembali_ke_login.Location = new Point(549, 30);
            kembali_ke_login.Margin = new Padding(2, 0, 2, 0);
            kembali_ke_login.Name = "kembali_ke_login";
            kembali_ke_login.Size = new Size(19, 20);
            kembali_ke_login.TabIndex = 9;
            kembali_ke_login.Text = "X";
            kembali_ke_login.Click += kembali_ke_login_Click;
            // 
            // reg_lihat_password
            // 
            reg_lihat_password.AutoSize = true;
            reg_lihat_password.Location = new Point(429, 270);
            reg_lihat_password.Margin = new Padding(2, 2, 2, 2);
            reg_lihat_password.Name = "reg_lihat_password";
            reg_lihat_password.Size = new Size(127, 24);
            reg_lihat_password.TabIndex = 8;
            reg_lihat_password.Text = "lihat password";
            reg_lihat_password.UseVisualStyleBackColor = true;
            reg_lihat_password.CheckedChanged += reg_lihat_password_CheckedChanged;
            // 
            // tombol_login
            // 
            tombol_login.BackColor = Color.Teal;
            tombol_login.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tombol_login.Location = new Point(261, 309);
            tombol_login.Margin = new Padding(2, 2, 2, 2);
            tombol_login.Name = "tombol_login";
            tombol_login.Size = new Size(290, 42);
            tombol_login.TabIndex = 6;
            tombol_login.Text = "daftar";
            tombol_login.UseVisualStyleBackColor = false;
            tombol_login.Click += tombol_login_Click;
            // 
            // reg_password
            // 
            reg_password.Location = new Point(261, 233);
            reg_password.Margin = new Padding(2, 2, 2, 2);
            reg_password.Name = "reg_password";
            reg_password.PlaceholderText = "masukkan password";
            reg_password.Size = new Size(287, 27);
            reg_password.TabIndex = 5;
            reg_password.UseSystemPasswordChar = true;
            reg_password.TextChanged += reg_password_TextChanged;
            // 
            // reg_email
            // 
            reg_email.Location = new Point(261, 165);
            reg_email.Margin = new Padding(2, 2, 2, 2);
            reg_email.Name = "reg_email";
            reg_email.PlaceholderText = "masukkan username";
            reg_email.Size = new Size(287, 27);
            reg_email.TabIndex = 4;
            reg_email.TextChanged += reg_nama_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(261, 203);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 3;
            label3.Text = "password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(261, 130);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "email";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(261, 60);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(191, 26);
            label1.TabIndex = 1;
            label1.Text = "Selamat datang di";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 412);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-14, 17);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(274, 384);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form_Daftar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 362);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form_Daftar";
            Text = "Form_Daftar";
            FormClosed += Form_Daftar_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CheckBox reg_lihat_password;
        private Button tombol_login;
        private TextBox reg_password;
        private TextBox reg_email;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label kembali_ke_login;
        private Label label4;
    }
}