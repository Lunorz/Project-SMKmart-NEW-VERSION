namespace project_akhir_stock_gudang
{
    partial class ucBarangKeluar
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlPageGudang = new GradientPanel();
            pnlBawahGudang = new Panel();
            pnlKartuTabelGudang = new Panel();
            pnlKartuTabelDalamGudang = new Panel();
            dataGridView1 = new DataGridView();
            colWaktuGudang3 = new DataGridViewTextBoxColumn();
            colBarangGudang3 = new DataGridViewTextBoxColumn();
            colJumlahGudang3 = new DataGridViewTextBoxColumn();
            colAlasanGudang3 = new DataGridViewTextBoxColumn();
            colPetugasGudang3 = new DataGridViewTextBoxColumn();
            pnlToolbarGudang = new Panel();
            txtCariGudang3 = new TextBox();
            cmbJenisGudang3 = new ComboBox();
            pnlGapGudang = new Panel();
            pnlFormLuarGudang = new Panel();
            pnlFormDalamGudang = new Panel();
            cmbAlasanGudang3 = new ComboBox();
            lblCatatanGudang3 = new Label();
            lblAlasanGudang3 = new Label();
            lblJumlahGudang3 = new Label();
            lblStokInfoGudang3 = new Label();
            lblBarangGudang3 = new Label();
            btnSimpanGudang3 = new Button();
            btnBersihkanGudang3 = new Button();
            txtCatatanGudang3 = new TextBox();
            cmbBarangGudang3 = new ComboBox();
            nudJumlahGudang3 = new NumericUpDown();
            textBox2 = new TextBox();
            pnlHeaderFormGudang = new GradientPanel();
            lblInfoGudang3 = new Label();
            lblJudulFormGudang3 = new Label();
            pnlPageGudang.SuspendLayout();
            pnlBawahGudang.SuspendLayout();
            pnlKartuTabelGudang.SuspendLayout();
            pnlKartuTabelDalamGudang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlToolbarGudang.SuspendLayout();
            pnlFormLuarGudang.SuspendLayout();
            pnlFormDalamGudang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudJumlahGudang3).BeginInit();
            pnlHeaderFormGudang.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPageGudang
            // 
            pnlPageGudang.Angle = 90F;
            pnlPageGudang.ColorBottom = Color.White;
            pnlPageGudang.ColorTop = Color.FromArgb(230, 247, 238);
            pnlPageGudang.Controls.Add(pnlBawahGudang);
            pnlPageGudang.Dock = DockStyle.Fill;
            pnlPageGudang.Location = new Point(0, 0);
            pnlPageGudang.Name = "pnlPageGudang";
            pnlPageGudang.Padding = new Padding(24);
            pnlPageGudang.Size = new Size(1100, 700);
            pnlPageGudang.TabIndex = 1;
            // 
            // pnlBawahGudang
            // 
            pnlBawahGudang.BackColor = Color.Transparent;
            pnlBawahGudang.Controls.Add(pnlKartuTabelGudang);
            pnlBawahGudang.Controls.Add(pnlGapGudang);
            pnlBawahGudang.Controls.Add(pnlFormLuarGudang);
            pnlBawahGudang.Dock = DockStyle.Fill;
            pnlBawahGudang.Location = new Point(24, 24);
            pnlBawahGudang.Name = "pnlBawahGudang";
            pnlBawahGudang.Size = new Size(1052, 652);
            pnlBawahGudang.TabIndex = 0;
            // 
            // pnlKartuTabelGudang
            // 
            pnlKartuTabelGudang.BackColor = Color.FromArgb(213, 235, 223);
            pnlKartuTabelGudang.Controls.Add(pnlKartuTabelDalamGudang);
            pnlKartuTabelGudang.Dock = DockStyle.Fill;
            pnlKartuTabelGudang.Location = new Point(0, 0);
            pnlKartuTabelGudang.Name = "pnlKartuTabelGudang";
            pnlKartuTabelGudang.Padding = new Padding(1);
            pnlKartuTabelGudang.Size = new Size(688, 652);
            pnlKartuTabelGudang.TabIndex = 2;
            // 
            // pnlKartuTabelDalamGudang
            // 
            pnlKartuTabelDalamGudang.BackColor = Color.White;
            pnlKartuTabelDalamGudang.Controls.Add(dataGridView1);
            pnlKartuTabelDalamGudang.Controls.Add(pnlToolbarGudang);
            pnlKartuTabelDalamGudang.Dock = DockStyle.Fill;
            pnlKartuTabelDalamGudang.Location = new Point(1, 1);
            pnlKartuTabelDalamGudang.Name = "pnlKartuTabelDalamGudang";
            pnlKartuTabelDalamGudang.Size = new Size(686, 650);
            pnlKartuTabelDalamGudang.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 251, 248);
            dataGridViewCellStyle1.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(79, 106, 92);
            dataGridViewCellStyle1.Padding = new Padding(12, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(245, 251, 248);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(79, 106, 92);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colWaktuGudang3, colBarangGudang3, colJumlahGudang3, colAlasanGudang3, colPetugasGudang3 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Leelawadee UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(18, 55, 42);
            dataGridViewCellStyle2.Padding = new Padding(12, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(230, 247, 238);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(18, 55, 42);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(230, 247, 238);
            dataGridView1.Location = new Point(0, 72);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 56;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(686, 578);
            dataGridView1.TabIndex = 1;
            // 
            // colWaktuGudang3
            // 
            colWaktuGudang3.FillWeight = 20F;
            colWaktuGudang3.HeaderText = "Waktu";
            colWaktuGudang3.MinimumWidth = 6;
            colWaktuGudang3.Name = "colWaktuGudang3";
            colWaktuGudang3.ReadOnly = true;
            // 
            // colBarangGudang3
            // 
            colBarangGudang3.FillWeight = 24F;
            colBarangGudang3.HeaderText = "Barang";
            colBarangGudang3.MinimumWidth = 6;
            colBarangGudang3.Name = "colBarangGudang3";
            colBarangGudang3.ReadOnly = true;
            // 
            // colJumlahGudang3
            // 
            colJumlahGudang3.FillWeight = 12F;
            colJumlahGudang3.HeaderText = "Jumlah";
            colJumlahGudang3.MinimumWidth = 6;
            colJumlahGudang3.Name = "colJumlahGudang3";
            colJumlahGudang3.ReadOnly = true;
            // 
            // colAlasanGudang3
            // 
            colAlasanGudang3.FillWeight = 28F;
            colAlasanGudang3.HeaderText = "Alasan";
            colAlasanGudang3.MinimumWidth = 6;
            colAlasanGudang3.Name = "colAlasanGudang3";
            colAlasanGudang3.ReadOnly = true;
            // 
            // colPetugasGudang3
            // 
            colPetugasGudang3.FillWeight = 18F;
            colPetugasGudang3.HeaderText = "Petugas";
            colPetugasGudang3.MinimumWidth = 6;
            colPetugasGudang3.Name = "colPetugasGudang3";
            colPetugasGudang3.ReadOnly = true;
            // 
            // pnlToolbarGudang
            // 
            pnlToolbarGudang.Controls.Add(txtCariGudang3);
            pnlToolbarGudang.Controls.Add(cmbJenisGudang3);
            pnlToolbarGudang.Dock = DockStyle.Top;
            pnlToolbarGudang.Location = new Point(0, 0);
            pnlToolbarGudang.Name = "pnlToolbarGudang";
            pnlToolbarGudang.Size = new Size(686, 72);
            pnlToolbarGudang.TabIndex = 0;
            // 
            // txtCariGudang3
            // 
            txtCariGudang3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCariGudang3.BackColor = Color.White;
            txtCariGudang3.BorderStyle = BorderStyle.FixedSingle;
            txtCariGudang3.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCariGudang3.ForeColor = Color.FromArgb(18, 55, 42);
            txtCariGudang3.Location = new Point(16, 16);
            txtCariGudang3.Name = "txtCariGudang3";
            txtCariGudang3.PlaceholderText = "Cari barang atau alasan";
            txtCariGudang3.Size = new Size(470, 34);
            txtCariGudang3.TabIndex = 1;
            txtCariGudang3.TextChanged += txtCariGudang3_TextChanged;
            // 
            // cmbJenisGudang3
            // 
            cmbJenisGudang3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbJenisGudang3.BackColor = Color.White;
            cmbJenisGudang3.ForeColor = Color.FromArgb(18, 55, 42);
            cmbJenisGudang3.FormattingEnabled = true;
            cmbJenisGudang3.Items.AddRange(new object[] { "Semua jenis", "Keluar manual", "Penjualan" });
            cmbJenisGudang3.Location = new Point(500, 18);
            cmbJenisGudang3.Name = "cmbJenisGudang3";
            cmbJenisGudang3.Size = new Size(170, 31);
            cmbJenisGudang3.TabIndex = 6;
            cmbJenisGudang3.SelectedIndexChanged += cmbJenisGudang3_SelectedIndexChanged;
            // 
            // pnlGapGudang
            // 
            pnlGapGudang.Dock = DockStyle.Right;
            pnlGapGudang.Location = new Point(688, 0);
            pnlGapGudang.Name = "pnlGapGudang";
            pnlGapGudang.Size = new Size(24, 652);
            pnlGapGudang.TabIndex = 1;
            // 
            // pnlFormLuarGudang
            // 
            pnlFormLuarGudang.BackColor = Color.FromArgb(213, 235, 223);
            pnlFormLuarGudang.Controls.Add(pnlFormDalamGudang);
            pnlFormLuarGudang.Dock = DockStyle.Right;
            pnlFormLuarGudang.Location = new Point(712, 0);
            pnlFormLuarGudang.Name = "pnlFormLuarGudang";
            pnlFormLuarGudang.Padding = new Padding(1);
            pnlFormLuarGudang.Size = new Size(340, 652);
            pnlFormLuarGudang.TabIndex = 0;
            // 
            // pnlFormDalamGudang
            // 
            pnlFormDalamGudang.BackColor = Color.White;
            pnlFormDalamGudang.Controls.Add(cmbAlasanGudang3);
            pnlFormDalamGudang.Controls.Add(lblCatatanGudang3);
            pnlFormDalamGudang.Controls.Add(lblAlasanGudang3);
            pnlFormDalamGudang.Controls.Add(lblJumlahGudang3);
            pnlFormDalamGudang.Controls.Add(lblStokInfoGudang3);
            pnlFormDalamGudang.Controls.Add(lblBarangGudang3);
            pnlFormDalamGudang.Controls.Add(btnSimpanGudang3);
            pnlFormDalamGudang.Controls.Add(btnBersihkanGudang3);
            pnlFormDalamGudang.Controls.Add(txtCatatanGudang3);
            pnlFormDalamGudang.Controls.Add(cmbBarangGudang3);
            pnlFormDalamGudang.Controls.Add(nudJumlahGudang3);
            pnlFormDalamGudang.Controls.Add(textBox2);
            pnlFormDalamGudang.Controls.Add(pnlHeaderFormGudang);
            pnlFormDalamGudang.Dock = DockStyle.Fill;
            pnlFormDalamGudang.Location = new Point(1, 1);
            pnlFormDalamGudang.Name = "pnlFormDalamGudang";
            pnlFormDalamGudang.Size = new Size(338, 650);
            pnlFormDalamGudang.TabIndex = 0;
            // 
            // cmbAlasanGudang3
            // 
            cmbAlasanGudang3.BackColor = Color.White;
            cmbAlasanGudang3.Font = new Font("Leelawadee UI", 11F);
            cmbAlasanGudang3.ForeColor = Color.FromArgb(18, 55, 42);
            cmbAlasanGudang3.FormattingEnabled = true;
            cmbAlasanGudang3.Location = new Point(20, 276);
            cmbAlasanGudang3.Name = "cmbAlasanGudang3";
            cmbAlasanGudang3.Size = new Size(298, 33);
            cmbAlasanGudang3.TabIndex = 15;
            // 
            // lblCatatanGudang3
            // 
            lblCatatanGudang3.AutoSize = true;
            lblCatatanGudang3.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCatatanGudang3.ForeColor = Color.FromArgb(79, 106, 92);
            lblCatatanGudang3.Location = new Point(20, 318);
            lblCatatanGudang3.Name = "lblCatatanGudang3";
            lblCatatanGudang3.Size = new Size(63, 20);
            lblCatatanGudang3.TabIndex = 14;
            lblCatatanGudang3.Text = "Catatan";
            // 
            // lblAlasanGudang3
            // 
            lblAlasanGudang3.AutoSize = true;
            lblAlasanGudang3.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlasanGudang3.ForeColor = Color.FromArgb(79, 106, 92);
            lblAlasanGudang3.Location = new Point(20, 254);
            lblAlasanGudang3.Name = "lblAlasanGudang3";
            lblAlasanGudang3.Size = new Size(56, 20);
            lblAlasanGudang3.TabIndex = 13;
            lblAlasanGudang3.Text = "Alasan";
            // 
            // lblJumlahGudang3
            // 
            lblJumlahGudang3.AutoSize = true;
            lblJumlahGudang3.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJumlahGudang3.ForeColor = Color.FromArgb(79, 106, 92);
            lblJumlahGudang3.Location = new Point(20, 190);
            lblJumlahGudang3.Name = "lblJumlahGudang3";
            lblJumlahGudang3.Size = new Size(107, 20);
            lblJumlahGudang3.TabIndex = 12;
            lblJumlahGudang3.Text = "Jumlah keluar";
            // 
            // lblStokInfoGudang3
            // 
            lblStokInfoGudang3.AutoSize = true;
            lblStokInfoGudang3.Font = new Font("Leelawadee UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStokInfoGudang3.ForeColor = Color.FromArgb(79, 106, 92);
            lblStokInfoGudang3.Location = new Point(20, 160);
            lblStokInfoGudang3.Name = "lblStokInfoGudang3";
            lblStokInfoGudang3.Size = new Size(192, 20);
            lblStokInfoGudang3.TabIndex = 11;
            lblStokInfoGudang3.Text = "Pilih barang terlebih dahulu";
            // 
            // lblBarangGudang3
            // 
            lblBarangGudang3.AutoSize = true;
            lblBarangGudang3.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBarangGudang3.ForeColor = Color.FromArgb(79, 106, 92);
            lblBarangGudang3.Location = new Point(20, 104);
            lblBarangGudang3.Name = "lblBarangGudang3";
            lblBarangGudang3.Size = new Size(59, 20);
            lblBarangGudang3.TabIndex = 10;
            lblBarangGudang3.Text = "Barang";
            // 
            // btnSimpanGudang3
            // 
            btnSimpanGudang3.BackColor = Color.FromArgb(42, 127, 80);
            btnSimpanGudang3.FlatAppearance.BorderSize = 0;
            btnSimpanGudang3.FlatStyle = FlatStyle.Flat;
            btnSimpanGudang3.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpanGudang3.ForeColor = Color.White;
            btnSimpanGudang3.Location = new Point(118, 424);
            btnSimpanGudang3.Name = "btnSimpanGudang3";
            btnSimpanGudang3.Size = new Size(200, 40);
            btnSimpanGudang3.TabIndex = 8;
            btnSimpanGudang3.Text = "Simpan barang keluar";
            btnSimpanGudang3.UseVisualStyleBackColor = false;
            btnSimpanGudang3.Click += btnSimpanGudang3_Click;
            // 
            // btnBersihkanGudang3
            // 
            btnBersihkanGudang3.FlatAppearance.BorderColor = Color.FromArgb(213, 235, 223);
            btnBersihkanGudang3.FlatStyle = FlatStyle.Flat;
            btnBersihkanGudang3.ForeColor = Color.FromArgb(18, 55, 42);
            btnBersihkanGudang3.Location = new Point(20, 424);
            btnBersihkanGudang3.Name = "btnBersihkanGudang3";
            btnBersihkanGudang3.Size = new Size(98, 40);
            btnBersihkanGudang3.TabIndex = 7;
            btnBersihkanGudang3.Text = "Bersihkan";
            btnBersihkanGudang3.UseVisualStyleBackColor = true;
            btnBersihkanGudang3.Click += btnBersihkanGudang3_Click;
            // 
            // txtCatatanGudang3
            // 
            txtCatatanGudang3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCatatanGudang3.BackColor = Color.White;
            txtCatatanGudang3.BorderStyle = BorderStyle.FixedSingle;
            txtCatatanGudang3.Font = new Font("Leelawadee UI", 12F);
            txtCatatanGudang3.ForeColor = Color.FromArgb(18, 55, 42);
            txtCatatanGudang3.Location = new Point(20, 340);
            txtCatatanGudang3.Name = "txtCatatanGudang3";
            txtCatatanGudang3.PlaceholderText = "Opsional";
            txtCatatanGudang3.Size = new Size(298, 34);
            txtCatatanGudang3.TabIndex = 5;
            // 
            // cmbBarangGudang3
            // 
            cmbBarangGudang3.BackColor = Color.White;
            cmbBarangGudang3.Font = new Font("Leelawadee UI", 11F);
            cmbBarangGudang3.ForeColor = Color.FromArgb(18, 55, 42);
            cmbBarangGudang3.FormattingEnabled = true;
            cmbBarangGudang3.Location = new Point(20, 126);
            cmbBarangGudang3.Name = "cmbBarangGudang3";
            cmbBarangGudang3.Size = new Size(298, 33);
            cmbBarangGudang3.TabIndex = 4;
            cmbBarangGudang3.SelectedIndexChanged += cmbBarangGudang3_SelectedIndexChanged;
            // 
            // nudJumlahGudang3
            // 
            nudJumlahGudang3.BackColor = Color.White;
            nudJumlahGudang3.BorderStyle = BorderStyle.FixedSingle;
            nudJumlahGudang3.Font = new Font("Leelawadee UI", 11F);
            nudJumlahGudang3.ForeColor = Color.FromArgb(18, 55, 42);
            nudJumlahGudang3.Location = new Point(20, 212);
            nudJumlahGudang3.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudJumlahGudang3.Name = "nudJumlahGudang3";
            nudJumlahGudang3.Size = new Size(298, 32);
            nudJumlahGudang3.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(245, 251, 248);
            textBox2.ForeColor = Color.FromArgb(79, 106, 92);
            textBox2.Location = new Point(20, 180);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(298, 31);
            textBox2.TabIndex = 2;
            textBox2.TabStop = false;
            // 
            // pnlHeaderFormGudang
            // 
            pnlHeaderFormGudang.Angle = 45F;
            pnlHeaderFormGudang.ColorBottom = Color.FromArgb(152, 232, 193);
            pnlHeaderFormGudang.ColorTop = Color.FromArgb(42, 127, 80);
            pnlHeaderFormGudang.Controls.Add(lblInfoGudang3);
            pnlHeaderFormGudang.Controls.Add(lblJudulFormGudang3);
            pnlHeaderFormGudang.Dock = DockStyle.Top;
            pnlHeaderFormGudang.Location = new Point(0, 0);
            pnlHeaderFormGudang.Name = "pnlHeaderFormGudang";
            pnlHeaderFormGudang.Size = new Size(338, 84);
            pnlHeaderFormGudang.TabIndex = 0;
            // 
            // lblInfoGudang3
            // 
            lblInfoGudang3.AutoSize = true;
            lblInfoGudang3.BackColor = Color.Transparent;
            lblInfoGudang3.Font = new Font("Leelawadee UI", 9.75F);
            lblInfoGudang3.ForeColor = Color.FromArgb(14, 47, 34);
            lblInfoGudang3.Location = new Point(20, 50);
            lblInfoGudang3.Name = "lblInfoGudang3";
            lblInfoGudang3.Size = new Size(242, 23);
            lblInfoGudang3.TabIndex = 1;
            lblInfoGudang3.Text = "Mencatat pengeluaran barang";
            // 
            // lblJudulFormGudang3
            // 
            lblJudulFormGudang3.AutoSize = true;
            lblJudulFormGudang3.BackColor = Color.Transparent;
            lblJudulFormGudang3.Font = new Font("Leelawadee UI", 13.5F, FontStyle.Bold);
            lblJudulFormGudang3.ForeColor = Color.FromArgb(14, 47, 34);
            lblJudulFormGudang3.Location = new Point(20, 16);
            lblJudulFormGudang3.Name = "lblJudulFormGudang3";
            lblJudulFormGudang3.Size = new Size(227, 31);
            lblJudulFormGudang3.TabIndex = 0;
            lblJudulFormGudang3.Text = "Catat Barang Keluar\t";
            // 
            // ucBarangKeluar
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 251, 248);
            Controls.Add(pnlPageGudang);
            Font = new Font("Leelawadee UI", 10.5F);
            Name = "ucBarangKeluar";
            Size = new Size(1100, 700);
            Load += ucBarangKeluar_Load;
            pnlPageGudang.ResumeLayout(false);
            pnlBawahGudang.ResumeLayout(false);
            pnlKartuTabelGudang.ResumeLayout(false);
            pnlKartuTabelDalamGudang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlToolbarGudang.ResumeLayout(false);
            pnlToolbarGudang.PerformLayout();
            pnlFormLuarGudang.ResumeLayout(false);
            pnlFormDalamGudang.ResumeLayout(false);
            pnlFormDalamGudang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudJumlahGudang3).EndInit();
            pnlHeaderFormGudang.ResumeLayout(false);
            pnlHeaderFormGudang.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GradientPanel pnlPageGudang;
        private Panel pnlBawahGudang;
        private Panel pnlKartuTabelGudang;
        private Panel pnlKartuTabelDalamGudang;
        private DataGridView dataGridView1;
        private Panel pnlToolbarGudang;
        private Panel pnlGapGudang;
        private Panel pnlFormLuarGudang;
        private Panel pnlFormDalamGudang;
        private Button btnSimpanGudang3;
        private Button btnBersihkanGudang3;
        private ComboBox cmbJenisGudang3;
        private TextBox txtCatatanGudang3;
        private ComboBox cmbBarangGudang3;
        private NumericUpDown nudJumlahGudang3;
        private TextBox textBox2;
        private TextBox txtCariGudang3;
        private GradientPanel pnlHeaderFormGudang;
        private Label lblInfoGudang3;
        private Label lblJudulFormGudang3;
        private Label lblJumlahGudang3;
        private Label lblStokInfoGudang3;
        private Label lblBarangGudang3;
        private Label lblCatatanGudang3;
        private Label lblAlasanGudang3;
        private ComboBox cmbAlasanGudang3;
        private DataGridViewTextBoxColumn colWaktuGudang3;
        private DataGridViewTextBoxColumn colBarangGudang3;
        private DataGridViewTextBoxColumn colJumlahGudang3;
        private DataGridViewTextBoxColumn colAlasanGudang3;
        private DataGridViewTextBoxColumn colPetugasGudang3;
    }
}
