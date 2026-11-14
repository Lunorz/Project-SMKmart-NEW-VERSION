namespace project_akhir_stock_gudang
{
    partial class MainFormAdmin
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
            pnlSideBar = new GradientPanel();
            btnKeluar = new Button();
            pnlAktif = new Panel();
            btnMenuLapPenjualan = new Button();
            btnMenuUser = new Button();
            btnMenuLapGudang = new Button();
            btnDataBarang = new Button();
            btnMenuDashboard = new Button();
            label1 = new Label();
            pnlTopBar = new Panel();
            lblTopBar10 = new Label();
            pnlTopline = new Panel();
            pnlContent = new Panel();
            ucAdminDataUser1 = new ucAdminDataUser();
            btnLogAktivitas = new Button();
            pnlSideBar.SuspendLayout();
            pnlTopBar.SuspendLayout();
            pnlContent.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSideBar
            // 
            pnlSideBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlSideBar.Angle = 90F;
            pnlSideBar.ColorBottom = Color.FromArgb(26, 90, 56);
            pnlSideBar.ColorTop = Color.FromArgb(38, 119, 74);
            pnlSideBar.Controls.Add(btnLogAktivitas);
            pnlSideBar.Controls.Add(btnKeluar);
            pnlSideBar.Controls.Add(pnlAktif);
            pnlSideBar.Controls.Add(btnMenuLapPenjualan);
            pnlSideBar.Controls.Add(btnMenuUser);
            pnlSideBar.Controls.Add(btnMenuLapGudang);
            pnlSideBar.Controls.Add(btnDataBarang);
            pnlSideBar.Controls.Add(btnMenuDashboard);
            pnlSideBar.Controls.Add(label1);
            pnlSideBar.Location = new Point(0, 64);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Padding = new Padding(16, 24, 16, 24);
            pnlSideBar.Size = new Size(260, 879);
            pnlSideBar.TabIndex = 0;
            // 
            // btnKeluar
            // 
            btnKeluar.BackColor = Color.FromArgb(38, 119, 74);
            btnKeluar.Dock = DockStyle.Bottom;
            btnKeluar.FlatAppearance.BorderColor = Color.FromArgb(38, 119, 74);
            btnKeluar.FlatAppearance.BorderSize = 0;
            btnKeluar.FlatStyle = FlatStyle.Flat;
            btnKeluar.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKeluar.ForeColor = Color.FromArgb(230, 247, 238);
            btnKeluar.Location = new Point(16, 811);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(228, 44);
            btnKeluar.TabIndex = 6;
            btnKeluar.Text = "Keluar";
            btnKeluar.TextAlign = ContentAlignment.MiddleLeft;
            btnKeluar.UseVisualStyleBackColor = false;
            btnKeluar.Click += btnKeluar_Click;
            // 
            // pnlAktif
            // 
            pnlAktif.BackColor = Color.FromArgb(152, 232, 193);
            pnlAktif.Location = new Point(16, 146);
            pnlAktif.Name = "pnlAktif";
            pnlAktif.Size = new Size(4, 24);
            pnlAktif.TabIndex = 1;
            // 
            // btnMenuLapPenjualan
            // 
            btnMenuLapPenjualan.BackColor = Color.FromArgb(38, 119, 74);
            btnMenuLapPenjualan.FlatAppearance.BorderColor = Color.FromArgb(38, 119, 74);
            btnMenuLapPenjualan.FlatAppearance.BorderSize = 0;
            btnMenuLapPenjualan.FlatStyle = FlatStyle.Flat;
            btnMenuLapPenjualan.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenuLapPenjualan.ForeColor = Color.FromArgb(230, 247, 238);
            btnMenuLapPenjualan.Location = new Point(16, 240);
            btnMenuLapPenjualan.Name = "btnMenuLapPenjualan";
            btnMenuLapPenjualan.Size = new Size(228, 44);
            btnMenuLapPenjualan.TabIndex = 5;
            btnMenuLapPenjualan.Text = "Laporan Penjualan";
            btnMenuLapPenjualan.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuLapPenjualan.UseVisualStyleBackColor = false;
            btnMenuLapPenjualan.Click += btnMenuLapPenjualan_Click;
            // 
            // btnMenuUser
            // 
            btnMenuUser.BackColor = Color.FromArgb(26, 90, 56);
            btnMenuUser.FlatAppearance.BorderColor = Color.FromArgb(38, 119, 74);
            btnMenuUser.FlatAppearance.BorderSize = 0;
            btnMenuUser.FlatStyle = FlatStyle.Flat;
            btnMenuUser.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenuUser.ForeColor = Color.FromArgb(230, 247, 238);
            btnMenuUser.Location = new Point(16, 136);
            btnMenuUser.Name = "btnMenuUser";
            btnMenuUser.Size = new Size(228, 44);
            btnMenuUser.TabIndex = 4;
            btnMenuUser.Text = "Data user";
            btnMenuUser.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuUser.UseVisualStyleBackColor = false;
            btnMenuUser.Click += btnMenuUser_Click;
            // 
            // btnMenuLapGudang
            // 
            btnMenuLapGudang.BackColor = Color.FromArgb(38, 119, 74);
            btnMenuLapGudang.FlatAppearance.BorderColor = Color.FromArgb(38, 119, 74);
            btnMenuLapGudang.FlatAppearance.BorderSize = 0;
            btnMenuLapGudang.FlatStyle = FlatStyle.Flat;
            btnMenuLapGudang.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenuLapGudang.ForeColor = Color.FromArgb(230, 247, 238);
            btnMenuLapGudang.Location = new Point(16, 292);
            btnMenuLapGudang.Name = "btnMenuLapGudang";
            btnMenuLapGudang.Size = new Size(228, 44);
            btnMenuLapGudang.TabIndex = 3;
            btnMenuLapGudang.Text = "Laporan gudang";
            btnMenuLapGudang.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuLapGudang.UseVisualStyleBackColor = false;
            btnMenuLapGudang.Click += btnMenuLapGudang_Click;
            // 
            // btnDataBarang
            // 
            btnDataBarang.BackColor = Color.FromArgb(38, 119, 74);
            btnDataBarang.FlatAppearance.BorderColor = Color.FromArgb(38, 119, 74);
            btnDataBarang.FlatAppearance.BorderSize = 0;
            btnDataBarang.FlatStyle = FlatStyle.Flat;
            btnDataBarang.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDataBarang.ForeColor = Color.FromArgb(230, 247, 238);
            btnDataBarang.Location = new Point(16, 188);
            btnDataBarang.Name = "btnDataBarang";
            btnDataBarang.Size = new Size(228, 44);
            btnDataBarang.TabIndex = 2;
            btnDataBarang.Text = "Data barang";
            btnDataBarang.TextAlign = ContentAlignment.MiddleLeft;
            btnDataBarang.UseVisualStyleBackColor = false;
            btnDataBarang.Click += btnDataBarang_Click;
            // 
            // btnMenuDashboard
            // 
            btnMenuDashboard.BackColor = Color.FromArgb(38, 119, 74);
            btnMenuDashboard.FlatAppearance.BorderColor = Color.FromArgb(38, 119, 74);
            btnMenuDashboard.FlatAppearance.BorderSize = 0;
            btnMenuDashboard.FlatStyle = FlatStyle.Flat;
            btnMenuDashboard.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenuDashboard.ForeColor = Color.FromArgb(230, 247, 238);
            btnMenuDashboard.Location = new Point(16, 84);
            btnMenuDashboard.Name = "btnMenuDashboard";
            btnMenuDashboard.Size = new Size(228, 44);
            btnMenuDashboard.TabIndex = 1;
            btnMenuDashboard.Text = "Dashboard";
            btnMenuDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuDashboard.UseVisualStyleBackColor = false;
            btnMenuDashboard.Click += btnMenuDashboard_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Leelawadee UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(28, 24);
            label1.Name = "label1";
            label1.Size = new Size(140, 35);
            label1.TabIndex = 0;
            label1.Text = "ONEMART";
            // 
            // pnlTopBar
            // 
            pnlTopBar.BackColor = Color.White;
            pnlTopBar.Controls.Add(lblTopBar10);
            pnlTopBar.Location = new Point(0, 0);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(1530, 64);
            pnlTopBar.TabIndex = 1;
            // 
            // lblTopBar10
            // 
            lblTopBar10.AutoSize = true;
            lblTopBar10.BackColor = Color.Transparent;
            lblTopBar10.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTopBar10.ForeColor = Color.FromArgb(18, 55, 42);
            lblTopBar10.Location = new Point(24, 14);
            lblTopBar10.Name = "lblTopBar10";
            lblTopBar10.Size = new Size(177, 38);
            lblTopBar10.TabIndex = 2;
            lblTopBar10.Text = "User control";
            // 
            // pnlTopline
            // 
            pnlTopline.BackColor = Color.FromArgb(213, 235, 223);
            pnlTopline.Dock = DockStyle.Bottom;
            pnlTopline.Location = new Point(0, 942);
            pnlTopline.Name = "pnlTopline";
            pnlTopline.Size = new Size(1530, 1);
            pnlTopline.TabIndex = 2;
            // 
            // pnlContent
            // 
            pnlContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContent.Controls.Add(ucAdminDataUser1);
            pnlContent.Location = new Point(260, 64);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1270, 878);
            pnlContent.TabIndex = 3;
            // 
            // ucAdminDataUser1
            // 
            ucAdminDataUser1.BackColor = Color.FromArgb(245, 251, 248);
            ucAdminDataUser1.Dock = DockStyle.Fill;
            ucAdminDataUser1.Font = new Font("Leelawadee UI", 10.5F);
            ucAdminDataUser1.Location = new Point(0, 0);
            ucAdminDataUser1.Name = "ucAdminDataUser1";
            ucAdminDataUser1.Size = new Size(1270, 878);
            ucAdminDataUser1.TabIndex = 0;
            // 
            // btnLogAktivitas
            // 
            btnLogAktivitas.BackColor = Color.FromArgb(38, 119, 74);
            btnLogAktivitas.FlatAppearance.BorderColor = Color.FromArgb(38, 119, 74);
            btnLogAktivitas.FlatAppearance.BorderSize = 0;
            btnLogAktivitas.FlatStyle = FlatStyle.Flat;
            btnLogAktivitas.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogAktivitas.ForeColor = Color.FromArgb(230, 247, 238);
            btnLogAktivitas.Location = new Point(16, 344);
            btnLogAktivitas.Name = "btnLogAktivitas";
            btnLogAktivitas.Size = new Size(228, 44);
            btnLogAktivitas.TabIndex = 7;
            btnLogAktivitas.Text = "Log aktivitas";
            btnLogAktivitas.TextAlign = ContentAlignment.MiddleLeft;
            btnLogAktivitas.UseVisualStyleBackColor = false;
            btnLogAktivitas.Click += btnLogAktivitas_Click;
            // 
            // MainFormAdmin
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 251, 248);
            ClientSize = new Size(1530, 943);
            Controls.Add(pnlTopBar);
            Controls.Add(pnlContent);
            Controls.Add(pnlTopline);
            Controls.Add(pnlSideBar);
            Font = new Font("Leelawadee UI", 10.5F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainFormAdmin";
            Text = "MainFormAdmin";
            FormClosed += MainFormAdmin_FormClosed;
            pnlSideBar.ResumeLayout(false);
            pnlSideBar.PerformLayout();
            pnlTopBar.ResumeLayout(false);
            pnlTopBar.PerformLayout();
            pnlContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GradientPanel pnlSideBar;
        private Label label1;
        private Button btnMenuDashboard;
        private Button btnMenuLapPenjualan;
        private Button btnMenuUser;
        private Button btnMenuLapGudang;
        private Button btnDataBarang;
        private Panel pnlAktif;
        private Panel pnlTopBar;
        private Label lblTopBar10;
        private Panel pnlTopline;
        private Panel pnlContent;
        private Button btnKeluar;
        private ucAdminDataUser ucAdminDataUser1;
        private Button btnLogAktivitas;
    }
}