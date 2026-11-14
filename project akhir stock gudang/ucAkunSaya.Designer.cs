namespace project_akhir_stock_gudang
{
    partial class ucAkunSaya
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlPage = new Panel();
            pnlBaris = new Panel();
            pnlInfoLuar = new Panel();
            pnlGap = new Panel();
            pnlFormLuar = new Panel();
            pnlFormDalam = new Panel();
            pnlInfoDalam = new Panel();
            lblJudul = new Label();
            pnlPemisahForm = new Panel();
            lblLama = new Label();
            lblKonfirmasi = new Label();
            lblBaru = new Label();
            txtLama = new TextBox();
            txtBaru = new TextBox();
            txtKonfirmasi = new TextBox();
            prgKekuatan = new ProgressBar();
            btnBersihkan = new Button();
            btnSimpan = new Button();
            pnlSyarat = new Panel();
            lblSyaratJudul = new Label();
            lblS1 = new Label();
            lblS4 = new Label();
            lblS5 = new Label();
            lblS3 = new Label();
            lblS2 = new Label();
            pnlHeaderInfo = new GradientPanel();
            lblJudulInfo = new Label();
            lblUsername = new Label();
            lblRole = new Label();
            lblLogin = new Label();
            lblGanti = new Label();
            txtUsername = new TextBox();
            txtRoleInfo = new TextBox();
            txtLogin = new TextBox();
            txtGamti = new TextBox();
            llblCatatan = new Label();
            pnlPage.SuspendLayout();
            pnlBaris.SuspendLayout();
            pnlInfoLuar.SuspendLayout();
            pnlFormLuar.SuspendLayout();
            pnlFormDalam.SuspendLayout();
            pnlInfoDalam.SuspendLayout();
            pnlSyarat.SuspendLayout();
            pnlHeaderInfo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPage
            // 
            pnlPage.Controls.Add(pnlBaris);
            pnlPage.Dock = DockStyle.Fill;
            pnlPage.Location = new Point(0, 0);
            pnlPage.Name = "pnlPage";
            pnlPage.Padding = new Padding(24);
            pnlPage.Size = new Size(1100, 700);
            pnlPage.TabIndex = 0;
            // 
            // pnlBaris
            // 
            pnlBaris.Controls.Add(pnlFormLuar);
            pnlBaris.Controls.Add(pnlGap);
            pnlBaris.Controls.Add(pnlInfoLuar);
            pnlBaris.Dock = DockStyle.Top;
            pnlBaris.Location = new Point(24, 24);
            pnlBaris.Name = "pnlBaris";
            pnlBaris.Size = new Size(1052, 470);
            pnlBaris.TabIndex = 0;
            // 
            // pnlInfoLuar
            // 
            pnlInfoLuar.BackColor = Color.FromArgb(213, 235, 223);
            pnlInfoLuar.Controls.Add(pnlInfoDalam);
            pnlInfoLuar.Dock = DockStyle.Right;
            pnlInfoLuar.Location = new Point(712, 0);
            pnlInfoLuar.Name = "pnlInfoLuar";
            pnlInfoLuar.Size = new Size(340, 470);
            pnlInfoLuar.TabIndex = 0;
            // 
            // pnlGap
            // 
            pnlGap.Dock = DockStyle.Right;
            pnlGap.Location = new Point(688, 0);
            pnlGap.Name = "pnlGap";
            pnlGap.Size = new Size(24, 470);
            pnlGap.TabIndex = 1;
            // 
            // pnlFormLuar
            // 
            pnlFormLuar.BackColor = Color.FromArgb(213, 235, 223);
            pnlFormLuar.Controls.Add(pnlFormDalam);
            pnlFormLuar.Dock = DockStyle.Fill;
            pnlFormLuar.Location = new Point(0, 0);
            pnlFormLuar.Name = "pnlFormLuar";
            pnlFormLuar.Size = new Size(688, 470);
            pnlFormLuar.TabIndex = 2;
            // 
            // pnlFormDalam
            // 
            pnlFormDalam.BackColor = Color.White;
            pnlFormDalam.Controls.Add(pnlSyarat);
            pnlFormDalam.Controls.Add(btnSimpan);
            pnlFormDalam.Controls.Add(btnBersihkan);
            pnlFormDalam.Controls.Add(prgKekuatan);
            pnlFormDalam.Controls.Add(txtKonfirmasi);
            pnlFormDalam.Controls.Add(txtBaru);
            pnlFormDalam.Controls.Add(txtLama);
            pnlFormDalam.Controls.Add(lblBaru);
            pnlFormDalam.Controls.Add(lblKonfirmasi);
            pnlFormDalam.Controls.Add(lblLama);
            pnlFormDalam.Controls.Add(pnlPemisahForm);
            pnlFormDalam.Controls.Add(lblJudul);
            pnlFormDalam.Dock = DockStyle.Fill;
            pnlFormDalam.Location = new Point(0, 0);
            pnlFormDalam.Name = "pnlFormDalam";
            pnlFormDalam.Size = new Size(688, 470);
            pnlFormDalam.TabIndex = 0;
            // 
            // pnlInfoDalam
            // 
            pnlInfoDalam.BackColor = Color.White;
            pnlInfoDalam.Controls.Add(llblCatatan);
            pnlInfoDalam.Controls.Add(txtGamti);
            pnlInfoDalam.Controls.Add(txtLogin);
            pnlInfoDalam.Controls.Add(txtRoleInfo);
            pnlInfoDalam.Controls.Add(txtUsername);
            pnlInfoDalam.Controls.Add(lblGanti);
            pnlInfoDalam.Controls.Add(lblLogin);
            pnlInfoDalam.Controls.Add(lblRole);
            pnlInfoDalam.Controls.Add(lblUsername);
            pnlInfoDalam.Controls.Add(pnlHeaderInfo);
            pnlInfoDalam.Dock = DockStyle.Fill;
            pnlInfoDalam.Location = new Point(0, 0);
            pnlInfoDalam.Name = "pnlInfoDalam";
            pnlInfoDalam.Size = new Size(340, 470);
            pnlInfoDalam.TabIndex = 1;
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.ForeColor = Color.FromArgb(18, 55, 42);
            lblJudul.Location = new Point(16, 14);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(155, 28);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Ubah Password";
            // 
            // pnlPemisahForm
            // 
            pnlPemisahForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlPemisahForm.BackColor = Color.FromArgb(213, 235, 223);
            pnlPemisahForm.Location = new Point(0, 51);
            pnlPemisahForm.Name = "pnlPemisahForm";
            pnlPemisahForm.Size = new Size(686, 1);
            pnlPemisahForm.TabIndex = 1;
            // 
            // lblLama
            // 
            lblLama.AutoSize = true;
            lblLama.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLama.ForeColor = Color.FromArgb(79, 106, 92);
            lblLama.Location = new Point(32, 76);
            lblLama.Name = "lblLama";
            lblLama.Size = new Size(114, 20);
            lblLama.TabIndex = 2;
            lblLama.Text = "Password lama";
            // 
            // lblKonfirmasi
            // 
            lblKonfirmasi.AutoSize = true;
            lblKonfirmasi.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKonfirmasi.ForeColor = Color.FromArgb(79, 106, 92);
            lblKonfirmasi.Location = new Point(32, 216);
            lblKonfirmasi.Name = "lblKonfirmasi";
            lblKonfirmasi.Size = new Size(157, 20);
            lblKonfirmasi.TabIndex = 3;
            lblKonfirmasi.Text = "Konfirmasi password";
            // 
            // lblBaru
            // 
            lblBaru.AutoSize = true;
            lblBaru.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBaru.ForeColor = Color.FromArgb(79, 106, 92);
            lblBaru.Location = new Point(32, 146);
            lblBaru.Name = "lblBaru";
            lblBaru.Size = new Size(112, 20);
            lblBaru.TabIndex = 4;
            lblBaru.Text = "Password baru";
            // 
            // txtLama
            // 
            txtLama.BorderStyle = BorderStyle.FixedSingle;
            txtLama.Font = new Font("Leelawadee UI", 11F, FontStyle.Bold);
            txtLama.ForeColor = Color.FromArgb(18, 55, 42);
            txtLama.Location = new Point(32, 98);
            txtLama.Name = "txtLama";
            txtLama.Size = new Size(360, 32);
            txtLama.TabIndex = 5;
            // 
            // txtBaru
            // 
            txtBaru.BorderStyle = BorderStyle.FixedSingle;
            txtBaru.Font = new Font("Leelawadee UI", 11F, FontStyle.Bold);
            txtBaru.ForeColor = Color.FromArgb(18, 55, 42);
            txtBaru.Location = new Point(32, 168);
            txtBaru.Name = "txtBaru";
            txtBaru.Size = new Size(360, 32);
            txtBaru.TabIndex = 6;
            // 
            // txtKonfirmasi
            // 
            txtKonfirmasi.BorderStyle = BorderStyle.FixedSingle;
            txtKonfirmasi.Font = new Font("Leelawadee UI", 11F, FontStyle.Bold);
            txtKonfirmasi.ForeColor = Color.FromArgb(18, 55, 42);
            txtKonfirmasi.Location = new Point(32, 239);
            txtKonfirmasi.Name = "txtKonfirmasi";
            txtKonfirmasi.Size = new Size(360, 32);
            txtKonfirmasi.TabIndex = 7;
            // 
            // prgKekuatan
            // 
            prgKekuatan.Location = new Point(32, 430);
            prgKekuatan.Maximum = 4;
            prgKekuatan.Name = "prgKekuatan";
            prgKekuatan.Size = new Size(360, 8);
            prgKekuatan.Style = ProgressBarStyle.Continuous;
            prgKekuatan.TabIndex = 8;
            // 
            // btnBersihkan
            // 
            btnBersihkan.FlatAppearance.BorderSize = 0;
            btnBersihkan.FlatAppearance.MouseDownBackColor = Color.FromArgb(213, 235, 223);
            btnBersihkan.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBersihkan.ForeColor = Color.FromArgb(18, 55, 42);
            btnBersihkan.Location = new Point(32, 382);
            btnBersihkan.Name = "btnBersihkan";
            btnBersihkan.Size = new Size(110, 40);
            btnBersihkan.TabIndex = 9;
            btnBersihkan.Text = "Bersihkan";
            btnBersihkan.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.FromArgb(42, 127, 80);
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(154, 382);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(238, 40);
            btnSimpan.TabIndex = 10;
            btnSimpan.Text = "Simpan password";
            btnSimpan.UseVisualStyleBackColor = false;
            // 
            // pnlSyarat
            // 
            pnlSyarat.BackColor = Color.FromArgb(245, 251, 248);
            pnlSyarat.Controls.Add(lblS2);
            pnlSyarat.Controls.Add(lblS3);
            pnlSyarat.Controls.Add(lblS5);
            pnlSyarat.Controls.Add(lblS4);
            pnlSyarat.Controls.Add(lblS1);
            pnlSyarat.Controls.Add(lblSyaratJudul);
            pnlSyarat.Location = new Point(424, 76);
            pnlSyarat.Name = "pnlSyarat";
            pnlSyarat.Size = new Size(238, 196);
            pnlSyarat.TabIndex = 11;
            // 
            // lblSyaratJudul
            // 
            lblSyaratJudul.AutoSize = true;
            lblSyaratJudul.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSyaratJudul.ForeColor = Color.FromArgb(79, 106, 92);
            lblSyaratJudul.Location = new Point(16, 14);
            lblSyaratJudul.Name = "lblSyaratJudul";
            lblSyaratJudul.Size = new Size(124, 20);
            lblSyaratJudul.TabIndex = 0;
            lblSyaratJudul.Text = "Syarat password";
            // 
            // lblS1
            // 
            lblS1.AutoSize = true;
            lblS1.Font = new Font("Leelawadee UI", 9.75F);
            lblS1.ForeColor = Color.FromArgb(79, 106, 92);
            lblS1.Location = new Point(16, 44);
            lblS1.Name = "lblS1";
            lblS1.Size = new Size(171, 23);
            lblS1.TabIndex = 1;
            lblS1.Text = "○ Minimal 8 karakter";
            // 
            // lblS4
            // 
            lblS4.AutoSize = true;
            lblS4.Font = new Font("Leelawadee UI", 9.75F);
            lblS4.ForeColor = Color.FromArgb(79, 106, 92);
            lblS4.Location = new Point(16, 128);
            lblS4.Name = "lblS4";
            lblS4.Size = new Size(183, 23);
            lblS4.TabIndex = 2;
            lblS4.Text = "\t○ Minimal satu simbol\t";
            // 
            // lblS5
            // 
            lblS5.AutoSize = true;
            lblS5.Font = new Font("Leelawadee UI", 9.75F);
            lblS5.ForeColor = Color.FromArgb(79, 106, 92);
            lblS5.Location = new Point(16, 156);
            lblS5.Name = "lblS5";
            lblS5.Size = new Size(196, 23);
            lblS5.TabIndex = 3;
            lblS5.Text = "○ Berbeda dari pw lama";
            // 
            // lblS3
            // 
            lblS3.AutoSize = true;
            lblS3.Font = new Font("Leelawadee UI", 9.75F);
            lblS3.ForeColor = Color.FromArgb(79, 106, 92);
            lblS3.Location = new Point(16, 100);
            lblS3.Name = "lblS3";
            lblS3.Size = new Size(179, 23);
            lblS3.TabIndex = 4;
            lblS3.Text = "\t○ Minimal satu angka";
            // 
            // lblS2
            // 
            lblS2.AutoSize = true;
            lblS2.Font = new Font("Leelawadee UI", 9.75F);
            lblS2.ForeColor = Color.FromArgb(79, 106, 92);
            lblS2.Location = new Point(16, 72);
            lblS2.Name = "lblS2";
            lblS2.Size = new Size(191, 23);
            lblS2.TabIndex = 5;
            lblS2.Text = "○ Huruf besar dan kecil";
            // 
            // pnlHeaderInfo
            // 
            pnlHeaderInfo.Angle = 45F;
            pnlHeaderInfo.ColorBottom = Color.FromArgb(152, 232, 193);
            pnlHeaderInfo.ColorTop = Color.FromArgb(42, 127, 80);
            pnlHeaderInfo.Controls.Add(lblJudulInfo);
            pnlHeaderInfo.Dock = DockStyle.Top;
            pnlHeaderInfo.Location = new Point(0, 0);
            pnlHeaderInfo.Name = "pnlHeaderInfo";
            pnlHeaderInfo.Size = new Size(340, 84);
            pnlHeaderInfo.TabIndex = 0;
            // 
            // lblJudulInfo
            // 
            lblJudulInfo.AutoSize = true;
            lblJudulInfo.BackColor = Color.Transparent;
            lblJudulInfo.Font = new Font("Leelawadee UI", 13.5F, FontStyle.Bold);
            lblJudulInfo.ForeColor = Color.FromArgb(14, 47, 34);
            lblJudulInfo.Location = new Point(20, 16);
            lblJudulInfo.Name = "lblJudulInfo";
            lblJudulInfo.Size = new Size(123, 31);
            lblJudulInfo.TabIndex = 0;
            lblJudulInfo.Text = "Akun saya";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(79, 106, 92);
            lblUsername.Location = new Point(20, 104);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(80, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username\t";
            lblUsername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.FromArgb(79, 106, 92);
            lblRole.Location = new Point(20, 168);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(40, 20);
            lblRole.TabIndex = 2;
            lblRole.Text = "Role";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.FromArgb(79, 106, 92);
            lblLogin.Location = new Point(20, 232);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(106, 20);
            lblLogin.TabIndex = 3;
            lblLogin.Text = "Terakhir login\t";
            // 
            // lblGanti
            // 
            lblGanti.AutoSize = true;
            lblGanti.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGanti.ForeColor = Color.FromArgb(79, 106, 92);
            lblGanti.Location = new Point(20, 296);
            lblGanti.Name = "lblGanti";
            lblGanti.Size = new Size(178, 20);
            lblGanti.TabIndex = 4;
            lblGanti.Text = "Terakhir ganti password";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(245, 251, 248);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Leelawadee UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.FromArgb(79, 106, 92);
            txtUsername.Location = new Point(20, 126);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(298, 31);
            txtUsername.TabIndex = 5;
            // 
            // txtRoleInfo
            // 
            txtRoleInfo.BackColor = Color.FromArgb(245, 251, 248);
            txtRoleInfo.BorderStyle = BorderStyle.FixedSingle;
            txtRoleInfo.Font = new Font("Leelawadee UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoleInfo.ForeColor = Color.FromArgb(79, 106, 92);
            txtRoleInfo.Location = new Point(20, 190);
            txtRoleInfo.Name = "txtRoleInfo";
            txtRoleInfo.ReadOnly = true;
            txtRoleInfo.Size = new Size(298, 31);
            txtRoleInfo.TabIndex = 6;
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.FromArgb(245, 251, 248);
            txtLogin.BorderStyle = BorderStyle.FixedSingle;
            txtLogin.Font = new Font("Leelawadee UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLogin.ForeColor = Color.FromArgb(79, 106, 92);
            txtLogin.Location = new Point(20, 254);
            txtLogin.Name = "txtLogin";
            txtLogin.ReadOnly = true;
            txtLogin.Size = new Size(298, 31);
            txtLogin.TabIndex = 7;
            // 
            // txtGamti
            // 
            txtGamti.BackColor = Color.FromArgb(245, 251, 248);
            txtGamti.BorderStyle = BorderStyle.FixedSingle;
            txtGamti.Font = new Font("Leelawadee UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGamti.ForeColor = Color.FromArgb(79, 106, 92);
            txtGamti.Location = new Point(20, 318);
            txtGamti.Name = "txtGamti";
            txtGamti.ReadOnly = true;
            txtGamti.Size = new Size(298, 31);
            txtGamti.TabIndex = 8;
            // 
            // llblCatatan
            // 
            llblCatatan.AutoSize = true;
            llblCatatan.Font = new Font("Leelawadee UI", 7F);
            llblCatatan.ForeColor = Color.FromArgb(79, 106, 92);
            llblCatatan.Location = new Point(20, 366);
            llblCatatan.Name = "llblCatatan";
            llblCatatan.Size = new Size(309, 15);
            llblCatatan.TabIndex = 9;
            llblCatatan.Text = "Password lama diperlukan untuk menyimpan perubahan.\t";
            // 
            // ucAkunSaya
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 251, 248);
            Controls.Add(pnlPage);
            Font = new Font("Leelawadee UI", 10.5F, FontStyle.Bold);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ucAkunSaya";
            Size = new Size(1100, 700);
            pnlPage.ResumeLayout(false);
            pnlBaris.ResumeLayout(false);
            pnlInfoLuar.ResumeLayout(false);
            pnlFormLuar.ResumeLayout(false);
            pnlFormDalam.ResumeLayout(false);
            pnlFormDalam.PerformLayout();
            pnlInfoDalam.ResumeLayout(false);
            pnlInfoDalam.PerformLayout();
            pnlSyarat.ResumeLayout(false);
            pnlSyarat.PerformLayout();
            pnlHeaderInfo.ResumeLayout(false);
            pnlHeaderInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPage;
        private Panel pnlBaris;
        private Panel pnlFormLuar;
        private Panel pnlGap;
        private Panel pnlInfoLuar;
        private Panel pnlFormDalam;
        private Panel pnlInfoDalam;
        private Label lblJudul;
        private Panel pnlPemisahForm;
        private TextBox txtLama;
        private Label lblBaru;
        private Label lblKonfirmasi;
        private Label lblLama;
        private TextBox txtKonfirmasi;
        private TextBox txtBaru;
        private Button btnSimpan;
        private Button btnBersihkan;
        private ProgressBar prgKekuatan;
        private Panel pnlSyarat;
        private Label lblS1;
        private Label lblSyaratJudul;
        private Label lblS2;
        private Label lblS3;
        private Label lblS5;
        private Label lblS4;
        private GradientPanel pnlHeaderInfo;
        private Label lblJudulInfo;
        private Label lblGanti;
        private Label lblLogin;
        private Label lblRole;
        private Label lblUsername;
        private TextBox txtGamti;
        private TextBox txtLogin;
        private TextBox txtRoleInfo;
        private TextBox txtUsername;
        private Label llblCatatan;
    }
}
