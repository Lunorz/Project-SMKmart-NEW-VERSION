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
            label5 = new Label();
            cmbRole = new ComboBox();
            label4 = new Label();
            kembali_ke_login = new Label();
            tombol_daftar = new Button();
            reg_username = new TextBox();
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
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cmbRole);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(kembali_ke_login);
            panel1.Controls.Add(tombol_daftar);
            panel1.Controls.Add(reg_username);
            panel1.Controls.Add(reg_email);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 560);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(365, 351);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 12;
            label5.Text = "role";
            // 
            // cmbRole
            // 
            cmbRole.BackColor = Color.FromArgb(250, 253, 251);
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.FlatStyle = FlatStyle.Flat;
            cmbRole.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "kasir", "gudang" });
            cmbRole.Location = new Point(365, 382);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(326, 33);
            cmbRole.TabIndex = 11;
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(365, 105);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(117, 26);
            label4.TabIndex = 10;
            label4.Text = " ONE-mart";
            // 
            // kembali_ke_login
            // 
            kembali_ke_login.AutoSize = true;
            kembali_ke_login.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kembali_ke_login.ForeColor = Color.Teal;
            kembali_ke_login.Cursor = Cursors.Hand;
            kembali_ke_login.Location = new Point(674, 22);
            kembali_ke_login.Margin = new Padding(2, 0, 2, 0);
            kembali_ke_login.Name = "kembali_ke_login";
            kembali_ke_login.Size = new Size(19, 20);
            kembali_ke_login.TabIndex = 9;
            kembali_ke_login.Text = "×";
            kembali_ke_login.Click += kembali_ke_login_Click;
            // 
            // tombol_daftar
            // 
            tombol_daftar.BackColor = Color.Teal;
            tombol_daftar.FlatAppearance.BorderSize = 0;
            tombol_daftar.FlatStyle = FlatStyle.Flat;
            tombol_daftar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tombol_daftar.ForeColor = Color.White;
            tombol_daftar.Location = new Point(365, 461);
            tombol_daftar.Margin = new Padding(2);
            tombol_daftar.Name = "tombol_daftar";
            tombol_daftar.Size = new Size(326, 50);
            tombol_daftar.TabIndex = 6;
            tombol_daftar.Text = "daftar";
            tombol_daftar.UseVisualStyleBackColor = false;
            tombol_daftar.Click += tombol_daftar_Click;
            // 
            // reg_username
            // 
            reg_username.BackColor = Color.FromArgb(250, 253, 251);
            reg_username.BorderStyle = BorderStyle.FixedSingle;
            reg_username.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reg_username.Location = new Point(365, 283);
            reg_username.Margin = new Padding(2);
            reg_username.Name = "reg_username";
            reg_username.PlaceholderText = "masukkan username";
            reg_username.Size = new Size(326, 32);
            reg_username.TabIndex = 5;
            reg_username.UseSystemPasswordChar = false;
            reg_username.TextChanged += reg_username_TextChanged;
            // 
            // reg_email
            // 
            reg_email.BackColor = Color.FromArgb(250, 253, 251);
            reg_email.BorderStyle = BorderStyle.FixedSingle;
            reg_email.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reg_email.Location = new Point(365, 190);
            reg_email.Margin = new Padding(2);
            reg_email.Name = "reg_email";
            reg_email.PlaceholderText = "masukkan email";
            reg_email.Size = new Size(326, 32);
            reg_email.TabIndex = 4;
            reg_email.TextChanged += reg_nama_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(365, 254);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 3;
            label3.Text = "username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(365, 161);
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
            label1.Font = new Font("Yu Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(365, 65);
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
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 560);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(336, 500);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form_Daftar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 560);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Form_Daftar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pendaftaran ONE-mart";
            FormClosed += Form_Daftar_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button tombol_daftar;
        private TextBox reg_username;
        private TextBox reg_email;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label kembali_ke_login;
        private Label label4;
        private Label label5;
        private ComboBox cmbRole;
    }
}