namespace project_akhir_stock_gudang
{
    partial class MainFormGudang
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
            pnlSideBarGudangMainform = new GradientPanel();
            btmMenuKeluar = new Button();
            btnMenuKeluarGudangMainform = new Button();
            btnMenuStokGudangMainform = new Button();
            btnMenuMasukGudangMainform = new Button();
            pnlAktifGudangMainform = new Panel();
            btnMenuDashboardGudangMainform = new Button();
            lblLogoGudangMainform = new Label();
            pnlTopBarGudangMainform = new Panel();
            lblJudulGudangMainform = new Label();
            pnlTopLineGudangMainform = new Panel();
            pnlContentGudangMainform = new Panel();
            ucDashboardGudang1 = new ucDashboardGudang();
            pnlSideBarGudangMainform.SuspendLayout();
            pnlTopBarGudangMainform.SuspendLayout();
            pnlContentGudangMainform.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSideBarGudangMainform
            // 
            pnlSideBarGudangMainform.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlSideBarGudangMainform.Angle = 90F;
            pnlSideBarGudangMainform.ColorBottom = Color.FromArgb(26, 90, 56);
            pnlSideBarGudangMainform.ColorTop = Color.FromArgb(38, 119, 74);
            pnlSideBarGudangMainform.Controls.Add(btmMenuKeluar);
            pnlSideBarGudangMainform.Controls.Add(btnMenuKeluarGudangMainform);
            pnlSideBarGudangMainform.Controls.Add(btnMenuStokGudangMainform);
            pnlSideBarGudangMainform.Controls.Add(btnMenuMasukGudangMainform);
            pnlSideBarGudangMainform.Controls.Add(pnlAktifGudangMainform);
            pnlSideBarGudangMainform.Controls.Add(btnMenuDashboardGudangMainform);
            pnlSideBarGudangMainform.Controls.Add(lblLogoGudangMainform);
            pnlSideBarGudangMainform.Location = new Point(0, 0);
            pnlSideBarGudangMainform.Name = "pnlSideBarGudangMainform";
            pnlSideBarGudangMainform.Size = new Size(260, 943);
            pnlSideBarGudangMainform.TabIndex = 0;
            pnlSideBarGudangMainform.Paint += pnlSideBarGudangMainform_Paint;
            // 
            // btmMenuKeluar
            // 
            btmMenuKeluar.BackColor = Color.FromArgb(38, 119, 74);
            btmMenuKeluar.Dock = DockStyle.Bottom;
            btmMenuKeluar.FlatAppearance.BorderColor = Color.FromArgb(38, 119, 74);
            btmMenuKeluar.FlatStyle = FlatStyle.Flat;
            btmMenuKeluar.ForeColor = Color.FromArgb(230, 247, 238);
            btmMenuKeluar.Location = new Point(0, 899);
            btmMenuKeluar.Name = "btmMenuKeluar";
            btmMenuKeluar.Size = new Size(260, 44);
            btmMenuKeluar.TabIndex = 6;
            btmMenuKeluar.Text = "Keluar";
            btmMenuKeluar.UseVisualStyleBackColor = false;
            btmMenuKeluar.Click += btmMenuKeluar_Click;
            // 
            // btnMenuKeluarGudangMainform
            // 
            btnMenuKeluarGudangMainform.BackColor = Color.FromArgb(38, 119, 74);
            btnMenuKeluarGudangMainform.FlatAppearance.BorderColor = Color.FromArgb(38, 119, 74);
            btnMenuKeluarGudangMainform.FlatStyle = FlatStyle.Flat;
            btnMenuKeluarGudangMainform.ForeColor = Color.FromArgb(230, 247, 238);
            btnMenuKeluarGudangMainform.Location = new Point(16, 188);
            btnMenuKeluarGudangMainform.Name = "btnMenuKeluarGudangMainform";
            btnMenuKeluarGudangMainform.Size = new Size(228, 44);
            btnMenuKeluarGudangMainform.TabIndex = 5;
            btnMenuKeluarGudangMainform.Text = "Barang keluar";
            btnMenuKeluarGudangMainform.UseVisualStyleBackColor = false;
            btnMenuKeluarGudangMainform.Click += btnMenuKeluarGudangMainform_Click;
            // 
            // btnMenuStokGudangMainform
            // 
            btnMenuStokGudangMainform.BackColor = Color.FromArgb(38, 119, 74);
            btnMenuStokGudangMainform.FlatAppearance.BorderColor = Color.FromArgb(38, 119, 74);
            btnMenuStokGudangMainform.FlatStyle = FlatStyle.Flat;
            btnMenuStokGudangMainform.ForeColor = Color.FromArgb(230, 247, 238);
            btnMenuStokGudangMainform.Location = new Point(16, 240);
            btnMenuStokGudangMainform.Name = "btnMenuStokGudangMainform";
            btnMenuStokGudangMainform.Size = new Size(228, 44);
            btnMenuStokGudangMainform.TabIndex = 4;
            btnMenuStokGudangMainform.Text = "Stok barang";
            btnMenuStokGudangMainform.UseVisualStyleBackColor = false;
            btnMenuStokGudangMainform.Click += btnMenuStokGudangMainform_Click;
            // 
            // btnMenuMasukGudangMainform
            // 
            btnMenuMasukGudangMainform.BackColor = Color.FromArgb(38, 119, 74);
            btnMenuMasukGudangMainform.FlatAppearance.BorderColor = Color.FromArgb(38, 119, 74);
            btnMenuMasukGudangMainform.FlatStyle = FlatStyle.Flat;
            btnMenuMasukGudangMainform.ForeColor = Color.FromArgb(230, 247, 238);
            btnMenuMasukGudangMainform.Location = new Point(16, 136);
            btnMenuMasukGudangMainform.Name = "btnMenuMasukGudangMainform";
            btnMenuMasukGudangMainform.Size = new Size(228, 44);
            btnMenuMasukGudangMainform.TabIndex = 3;
            btnMenuMasukGudangMainform.Text = "Barang masuk";
            btnMenuMasukGudangMainform.UseVisualStyleBackColor = false;
            btnMenuMasukGudangMainform.Click += btnMenuMasukGudangMainform_Click;
            // 
            // pnlAktifGudangMainform
            // 
            pnlAktifGudangMainform.BackColor = Color.FromArgb(152, 232, 193);
            pnlAktifGudangMainform.Location = new Point(16, 94);
            pnlAktifGudangMainform.Name = "pnlAktifGudangMainform";
            pnlAktifGudangMainform.Size = new Size(4, 24);
            pnlAktifGudangMainform.TabIndex = 1;
            // 
            // btnMenuDashboardGudangMainform
            // 
            btnMenuDashboardGudangMainform.BackColor = Color.FromArgb(26, 90, 56);
            btnMenuDashboardGudangMainform.FlatAppearance.BorderColor = Color.FromArgb(26, 90, 56);
            btnMenuDashboardGudangMainform.FlatStyle = FlatStyle.Flat;
            btnMenuDashboardGudangMainform.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenuDashboardGudangMainform.ForeColor = Color.White;
            btnMenuDashboardGudangMainform.Location = new Point(16, 84);
            btnMenuDashboardGudangMainform.Name = "btnMenuDashboardGudangMainform";
            btnMenuDashboardGudangMainform.Size = new Size(228, 44);
            btnMenuDashboardGudangMainform.TabIndex = 2;
            btnMenuDashboardGudangMainform.Text = "Dashboard";
            btnMenuDashboardGudangMainform.UseVisualStyleBackColor = false;
            btnMenuDashboardGudangMainform.Click += btnMenuDashboardGudangMainform_Click;
            // 
            // lblLogoGudangMainform
            // 
            lblLogoGudangMainform.AutoSize = true;
            lblLogoGudangMainform.BackColor = Color.Transparent;
            lblLogoGudangMainform.Font = new Font("Leelawadee UI", 15F, FontStyle.Bold);
            lblLogoGudangMainform.ForeColor = Color.White;
            lblLogoGudangMainform.Location = new Point(28, 24);
            lblLogoGudangMainform.Name = "lblLogoGudangMainform";
            lblLogoGudangMainform.Size = new Size(106, 35);
            lblLogoGudangMainform.TabIndex = 0;
            lblLogoGudangMainform.Text = "Gudang";
            // 
            // pnlTopBarGudangMainform
            // 
            pnlTopBarGudangMainform.Controls.Add(lblJudulGudangMainform);
            pnlTopBarGudangMainform.Controls.Add(pnlTopLineGudangMainform);
            pnlTopBarGudangMainform.Location = new Point(260, 0);
            pnlTopBarGudangMainform.Name = "pnlTopBarGudangMainform";
            pnlTopBarGudangMainform.Size = new Size(1270, 64);
            pnlTopBarGudangMainform.TabIndex = 1;
            // 
            // lblJudulGudangMainform
            // 
            lblJudulGudangMainform.AutoSize = true;
            lblJudulGudangMainform.Font = new Font("Leelawadee UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudulGudangMainform.ForeColor = Color.FromArgb(18, 55, 42);
            lblJudulGudangMainform.Location = new Point(24, 14);
            lblJudulGudangMainform.Name = "lblJudulGudangMainform";
            lblJudulGudangMainform.Size = new Size(288, 41);
            lblJudulGudangMainform.TabIndex = 1;
            lblJudulGudangMainform.Text = "Dashboard gudang";
            // 
            // pnlTopLineGudangMainform
            // 
            pnlTopLineGudangMainform.BackColor = Color.FromArgb(213, 235, 223);
            pnlTopLineGudangMainform.Dock = DockStyle.Bottom;
            pnlTopLineGudangMainform.Location = new Point(0, 63);
            pnlTopLineGudangMainform.Name = "pnlTopLineGudangMainform";
            pnlTopLineGudangMainform.Size = new Size(1270, 1);
            pnlTopLineGudangMainform.TabIndex = 0;
            // 
            // pnlContentGudangMainform
            // 
            pnlContentGudangMainform.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContentGudangMainform.Controls.Add(ucDashboardGudang1);
            pnlContentGudangMainform.Location = new Point(260, 64);
            pnlContentGudangMainform.Name = "pnlContentGudangMainform";
            pnlContentGudangMainform.Size = new Size(1270, 879);
            pnlContentGudangMainform.TabIndex = 2;
            // 
            // ucDashboardGudang1
            // 
            ucDashboardGudang1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ucDashboardGudang1.BackColor = Color.FromArgb(245, 251, 248);
            ucDashboardGudang1.Font = new Font("Leelawadee UI", 10.5F);
            ucDashboardGudang1.Location = new Point(0, -64);
            ucDashboardGudang1.Name = "ucDashboardGudang1";
            ucDashboardGudang1.Size = new Size(1270, 879);
            ucDashboardGudang1.TabIndex = 0;
            // 
            // MainFormGudang
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 251, 248);
            ClientSize = new Size(1530, 943);
            Controls.Add(pnlTopBarGudangMainform);
            Controls.Add(pnlContentGudangMainform);
            Controls.Add(pnlSideBarGudangMainform);
            Font = new Font("Leelawadee UI", 10.5F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainFormGudang";
            Text = "MainFormGudang";
            FormClosed += MainFormGudang_FormClosed;
            pnlSideBarGudangMainform.ResumeLayout(false);
            pnlSideBarGudangMainform.PerformLayout();
            pnlTopBarGudangMainform.ResumeLayout(false);
            pnlTopBarGudangMainform.PerformLayout();
            pnlContentGudangMainform.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GradientPanel pnlSideBarGudangMainform;
        private Label lblLogoGudangMainform;
        private Panel pnlAktifGudangMainform;
        private Panel pnlTopBarGudangMainform;
        private Panel pnlTopLineGudangMainform;
        private Label lblJudulGudangMainform;
        private Panel pnlContentGudangMainform;
        private Button btnMenuDashboardGudangMainform;
        private Button btnMenuMasukGudangMainform;
        private Button btmMenuKeluar;
        private Button btnMenuKeluarGudangMainform;
        private Button btnMenuStokGudangMainform;
        private ucDashboardGudang ucDashboardGudang1;
    }
}