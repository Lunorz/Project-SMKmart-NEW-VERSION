namespace project_akhir_stock_gudang
{
    partial class ucBarangMasuk
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
            colWaktuGudang2 = new DataGridViewTextBoxColumn();
            colBarangGudang2 = new DataGridViewTextBoxColumn();
            colJumlahGudang2 = new DataGridViewTextBoxColumn();
            colAsalGudang2 = new DataGridViewTextBoxColumn();
            colSJGudang2 = new DataGridViewTextBoxColumn();
            pnlToolbarGudang = new Panel();
            txtCariGudang2 = new TextBox();
            cmbPerriodeGudang2 = new ComboBox();
            pnlGapGudang = new Panel();
            pnlFormLuarGudang = new Panel();
            pnlFormDalamGudang = new Panel();
            txtSJGudang2 = new TextBox();
            txtCatatanGudang2 = new TextBox();
            txtAsalGudang2 = new TextBox();
            lblCatatanGudang2 = new Label();
            lblSJGudang2 = new Label();
            lblAsalGudang2 = new Label();
            lblJumlahGudang2 = new Label();
            lblStokInfoGudang2 = new Label();
            lblBarang = new Label();
            btnSimpanGudang2 = new Button();
            btnBersihkanGudang2 = new Button();
            cmbBarangGudang2 = new ComboBox();
            nudJumlahGudang2 = new NumericUpDown();
            pnlHeaderFormGudang = new GradientPanel();
            lblInfoGudang2 = new Label();
            lblJudulGudang2 = new Label();
            pnlPageGudang.SuspendLayout();
            pnlBawahGudang.SuspendLayout();
            pnlKartuTabelGudang.SuspendLayout();
            pnlKartuTabelDalamGudang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlToolbarGudang.SuspendLayout();
            pnlFormLuarGudang.SuspendLayout();
            pnlFormDalamGudang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudJumlahGudang2).BeginInit();
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
            pnlPageGudang.TabIndex = 0;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colWaktuGudang2, colBarangGudang2, colJumlahGudang2, colAsalGudang2, colSJGudang2 });
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
            // colWaktuGudang2
            // 
            colWaktuGudang2.FillWeight = 20F;
            colWaktuGudang2.HeaderText = "waktu";
            colWaktuGudang2.MinimumWidth = 6;
            colWaktuGudang2.Name = "colWaktuGudang2";
            colWaktuGudang2.ReadOnly = true;
            // 
            // colBarangGudang2
            // 
            colBarangGudang2.FillWeight = 33F;
            colBarangGudang2.HeaderText = "barang";
            colBarangGudang2.MinimumWidth = 6;
            colBarangGudang2.Name = "colBarangGudang2";
            colBarangGudang2.ReadOnly = true;
            // 
            // colJumlahGudang2
            // 
            colJumlahGudang2.FillWeight = 10F;
            colJumlahGudang2.HeaderText = "jumlah";
            colJumlahGudang2.MinimumWidth = 6;
            colJumlahGudang2.Name = "colJumlahGudang2";
            colJumlahGudang2.ReadOnly = true;
            // 
            // colAsalGudang2
            // 
            colAsalGudang2.FillWeight = 20F;
            colAsalGudang2.HeaderText = "Asal barang";
            colAsalGudang2.MinimumWidth = 6;
            colAsalGudang2.Name = "colAsalGudang2";
            colAsalGudang2.ReadOnly = true;
            // 
            // colSJGudang2
            // 
            colSJGudang2.FillWeight = 17F;
            colSJGudang2.HeaderText = "No. surat jalan";
            colSJGudang2.MinimumWidth = 6;
            colSJGudang2.Name = "colSJGudang2";
            colSJGudang2.ReadOnly = true;
            // 
            // pnlToolbarGudang
            // 
            pnlToolbarGudang.Controls.Add(txtCariGudang2);
            pnlToolbarGudang.Controls.Add(cmbPerriodeGudang2);
            pnlToolbarGudang.Dock = DockStyle.Top;
            pnlToolbarGudang.Location = new Point(0, 0);
            pnlToolbarGudang.Name = "pnlToolbarGudang";
            pnlToolbarGudang.Size = new Size(686, 72);
            pnlToolbarGudang.TabIndex = 0;
            // 
            // txtCariGudang2
            // 
            txtCariGudang2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCariGudang2.BackColor = Color.White;
            txtCariGudang2.BorderStyle = BorderStyle.FixedSingle;
            txtCariGudang2.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCariGudang2.ForeColor = Color.FromArgb(18, 55, 42);
            txtCariGudang2.Location = new Point(16, 16);
            txtCariGudang2.Name = "txtCariGudang2";
            txtCariGudang2.PlaceholderText = "Cari barang atau asal";
            txtCariGudang2.Size = new Size(470, 34);
            txtCariGudang2.TabIndex = 1;
            txtCariGudang2.TextChanged += txtCariGudang2_TextChanged;
            // 
            // cmbPerriodeGudang2
            // 
            cmbPerriodeGudang2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbPerriodeGudang2.BackColor = Color.White;
            cmbPerriodeGudang2.ForeColor = Color.FromArgb(18, 55, 42);
            cmbPerriodeGudang2.FormattingEnabled = true;
            cmbPerriodeGudang2.Items.AddRange(new object[] { "Hari ini", "7 Hari terakhir", "30 Hari terakhir", "Semua" });
            cmbPerriodeGudang2.Location = new Point(500, 18);
            cmbPerriodeGudang2.Name = "cmbPerriodeGudang2";
            cmbPerriodeGudang2.Size = new Size(170, 31);
            cmbPerriodeGudang2.TabIndex = 6;
            cmbPerriodeGudang2.SelectedIndexChanged += cmbPerriodeGudang2_SelectedIndexChanged;
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
            pnlFormDalamGudang.Controls.Add(txtSJGudang2);
            pnlFormDalamGudang.Controls.Add(txtCatatanGudang2);
            pnlFormDalamGudang.Controls.Add(txtAsalGudang2);
            pnlFormDalamGudang.Controls.Add(lblCatatanGudang2);
            pnlFormDalamGudang.Controls.Add(lblSJGudang2);
            pnlFormDalamGudang.Controls.Add(lblAsalGudang2);
            pnlFormDalamGudang.Controls.Add(lblJumlahGudang2);
            pnlFormDalamGudang.Controls.Add(lblStokInfoGudang2);
            pnlFormDalamGudang.Controls.Add(lblBarang);
            pnlFormDalamGudang.Controls.Add(btnSimpanGudang2);
            pnlFormDalamGudang.Controls.Add(btnBersihkanGudang2);
            pnlFormDalamGudang.Controls.Add(cmbBarangGudang2);
            pnlFormDalamGudang.Controls.Add(nudJumlahGudang2);
            pnlFormDalamGudang.Controls.Add(pnlHeaderFormGudang);
            pnlFormDalamGudang.Dock = DockStyle.Fill;
            pnlFormDalamGudang.Location = new Point(1, 1);
            pnlFormDalamGudang.Name = "pnlFormDalamGudang";
            pnlFormDalamGudang.Size = new Size(338, 650);
            pnlFormDalamGudang.TabIndex = 0;
            // 
            // txtSJGudang2
            // 
            txtSJGudang2.BackColor = Color.White;
            txtSJGudang2.BorderStyle = BorderStyle.FixedSingle;
            txtSJGudang2.Font = new Font("Leelawadee UI", 11F);
            txtSJGudang2.ForeColor = Color.FromArgb(18, 55, 42);
            txtSJGudang2.Location = new Point(20, 340);
            txtSJGudang2.Name = "txtSJGudang2";
            txtSJGudang2.Size = new Size(298, 32);
            txtSJGudang2.TabIndex = 17;
            // 
            // txtCatatanGudang2
            // 
            txtCatatanGudang2.BackColor = Color.White;
            txtCatatanGudang2.BorderStyle = BorderStyle.FixedSingle;
            txtCatatanGudang2.Font = new Font("Leelawadee UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCatatanGudang2.ForeColor = Color.FromArgb(18, 55, 42);
            txtCatatanGudang2.Location = new Point(20, 404);
            txtCatatanGudang2.Name = "txtCatatanGudang2";
            txtCatatanGudang2.PlaceholderText = "Opsional";
            txtCatatanGudang2.Size = new Size(298, 31);
            txtCatatanGudang2.TabIndex = 16;
            // 
            // txtAsalGudang2
            // 
            txtAsalGudang2.BackColor = Color.White;
            txtAsalGudang2.BorderStyle = BorderStyle.FixedSingle;
            txtAsalGudang2.Font = new Font("Leelawadee UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAsalGudang2.ForeColor = Color.FromArgb(18, 55, 42);
            txtAsalGudang2.Location = new Point(20, 276);
            txtAsalGudang2.Name = "txtAsalGudang2";
            txtAsalGudang2.Size = new Size(298, 31);
            txtAsalGudang2.TabIndex = 15;
            // 
            // lblCatatanGudang2
            // 
            lblCatatanGudang2.AutoSize = true;
            lblCatatanGudang2.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCatatanGudang2.ForeColor = Color.FromArgb(79, 106, 92);
            lblCatatanGudang2.Location = new Point(20, 382);
            lblCatatanGudang2.Name = "lblCatatanGudang2";
            lblCatatanGudang2.Size = new Size(63, 20);
            lblCatatanGudang2.TabIndex = 14;
            lblCatatanGudang2.Text = "Catatan";
            // 
            // lblSJGudang2
            // 
            lblSJGudang2.AutoSize = true;
            lblSJGudang2.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSJGudang2.ForeColor = Color.FromArgb(79, 106, 92);
            lblSJGudang2.Location = new Point(20, 318);
            lblSJGudang2.Name = "lblSJGudang2";
            lblSJGudang2.Size = new Size(111, 20);
            lblSJGudang2.TabIndex = 13;
            lblSJGudang2.Text = "No. surat jalan";
            // 
            // lblAsalGudang2
            // 
            lblAsalGudang2.AutoSize = true;
            lblAsalGudang2.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsalGudang2.ForeColor = Color.FromArgb(79, 106, 92);
            lblAsalGudang2.Location = new Point(20, 254);
            lblAsalGudang2.Name = "lblAsalGudang2";
            lblAsalGudang2.Size = new Size(92, 20);
            lblAsalGudang2.TabIndex = 12;
            lblAsalGudang2.Text = "Asal barang";
            // 
            // lblJumlahGudang2
            // 
            lblJumlahGudang2.AutoSize = true;
            lblJumlahGudang2.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJumlahGudang2.ForeColor = Color.FromArgb(79, 106, 92);
            lblJumlahGudang2.Location = new Point(20, 190);
            lblJumlahGudang2.Name = "lblJumlahGudang2";
            lblJumlahGudang2.Size = new Size(110, 20);
            lblJumlahGudang2.TabIndex = 11;
            lblJumlahGudang2.Text = "Jumlah masuk";
            // 
            // lblStokInfoGudang2
            // 
            lblStokInfoGudang2.AutoSize = true;
            lblStokInfoGudang2.Font = new Font("Leelawadee UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStokInfoGudang2.ForeColor = Color.FromArgb(79, 106, 92);
            lblStokInfoGudang2.Location = new Point(20, 160);
            lblStokInfoGudang2.Name = "lblStokInfoGudang2";
            lblStokInfoGudang2.Size = new Size(192, 20);
            lblStokInfoGudang2.TabIndex = 10;
            lblStokInfoGudang2.Text = "Pilih barang terlebih dahulu";
            // 
            // lblBarang
            // 
            lblBarang.AutoSize = true;
            lblBarang.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBarang.ForeColor = Color.FromArgb(79, 106, 92);
            lblBarang.Location = new Point(20, 104);
            lblBarang.Name = "lblBarang";
            lblBarang.Size = new Size(59, 20);
            lblBarang.TabIndex = 3;
            lblBarang.Text = "Barang";
            // 
            // btnSimpanGudang2
            // 
            btnSimpanGudang2.BackColor = Color.FromArgb(42, 127, 80);
            btnSimpanGudang2.FlatAppearance.BorderSize = 0;
            btnSimpanGudang2.FlatStyle = FlatStyle.Flat;
            btnSimpanGudang2.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpanGudang2.ForeColor = Color.White;
            btnSimpanGudang2.Location = new Point(118, 468);
            btnSimpanGudang2.Name = "btnSimpanGudang2";
            btnSimpanGudang2.Size = new Size(200, 40);
            btnSimpanGudang2.TabIndex = 8;
            btnSimpanGudang2.Text = "Simpan barang  masuk";
            btnSimpanGudang2.UseVisualStyleBackColor = false;
            btnSimpanGudang2.Click += btnSimpanGudang2_Click;
            // 
            // btnBersihkanGudang2
            // 
            btnBersihkanGudang2.FlatAppearance.BorderColor = Color.FromArgb(213, 235, 223);
            btnBersihkanGudang2.FlatStyle = FlatStyle.Flat;
            btnBersihkanGudang2.ForeColor = Color.FromArgb(18, 55, 42);
            btnBersihkanGudang2.Location = new Point(20, 468);
            btnBersihkanGudang2.Name = "btnBersihkanGudang2";
            btnBersihkanGudang2.Size = new Size(98, 40);
            btnBersihkanGudang2.TabIndex = 7;
            btnBersihkanGudang2.Text = "Bersihkan";
            btnBersihkanGudang2.UseVisualStyleBackColor = true;
            btnBersihkanGudang2.Click += btnBersihkanGudang2_Click;
            // 
            // cmbBarangGudang2
            // 
            cmbBarangGudang2.BackColor = Color.White;
            cmbBarangGudang2.Font = new Font("Leelawadee UI", 11F);
            cmbBarangGudang2.ForeColor = Color.FromArgb(18, 55, 42);
            cmbBarangGudang2.FormattingEnabled = true;
            cmbBarangGudang2.Location = new Point(20, 126);
            cmbBarangGudang2.Name = "cmbBarangGudang2";
            cmbBarangGudang2.Size = new Size(298, 33);
            cmbBarangGudang2.TabIndex = 4;
            cmbBarangGudang2.SelectedIndexChanged += cmbBarangGudang2_SelectedIndexChanged;
            // 
            // nudJumlahGudang2
            // 
            nudJumlahGudang2.BackColor = Color.White;
            nudJumlahGudang2.BorderStyle = BorderStyle.FixedSingle;
            nudJumlahGudang2.Font = new Font("Leelawadee UI", 11F);
            nudJumlahGudang2.ForeColor = Color.FromArgb(18, 55, 42);
            nudJumlahGudang2.Location = new Point(20, 212);
            nudJumlahGudang2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nudJumlahGudang2.Name = "nudJumlahGudang2";
            nudJumlahGudang2.Size = new Size(298, 32);
            nudJumlahGudang2.TabIndex = 3;
            // 
            // pnlHeaderFormGudang
            // 
            pnlHeaderFormGudang.Angle = 45F;
            pnlHeaderFormGudang.ColorBottom = Color.FromArgb(152, 232, 193);
            pnlHeaderFormGudang.ColorTop = Color.FromArgb(42, 127, 80);
            pnlHeaderFormGudang.Controls.Add(lblInfoGudang2);
            pnlHeaderFormGudang.Controls.Add(lblJudulGudang2);
            pnlHeaderFormGudang.Dock = DockStyle.Top;
            pnlHeaderFormGudang.Location = new Point(0, 0);
            pnlHeaderFormGudang.Name = "pnlHeaderFormGudang";
            pnlHeaderFormGudang.Size = new Size(338, 84);
            pnlHeaderFormGudang.TabIndex = 0;
            // 
            // lblInfoGudang2
            // 
            lblInfoGudang2.AutoSize = true;
            lblInfoGudang2.BackColor = Color.Transparent;
            lblInfoGudang2.Font = new Font("Leelawadee UI", 9.75F);
            lblInfoGudang2.ForeColor = Color.FromArgb(14, 47, 34);
            lblInfoGudang2.Location = new Point(20, 50);
            lblInfoGudang2.Name = "lblInfoGudang2";
            lblInfoGudang2.Size = new Size(314, 23);
            lblInfoGudang2.TabIndex = 1;
            lblInfoGudang2.Text = "Stok bertambah otomatis saat disimpan\t";
            // 
            // lblJudulGudang2
            // 
            lblJudulGudang2.AutoSize = true;
            lblJudulGudang2.BackColor = Color.Transparent;
            lblJudulGudang2.Font = new Font("Leelawadee UI", 13.5F, FontStyle.Bold);
            lblJudulGudang2.ForeColor = Color.FromArgb(14, 47, 34);
            lblJudulGudang2.Location = new Point(20, 16);
            lblJudulGudang2.Name = "lblJudulGudang2";
            lblJudulGudang2.Size = new Size(229, 31);
            lblJudulGudang2.TabIndex = 0;
            lblJudulGudang2.Text = "Catat Barang Masuk";
            // 
            // ucBarangMasuk
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 251, 248);
            Controls.Add(pnlPageGudang);
            Font = new Font("Leelawadee UI", 10.5F);
            Name = "ucBarangMasuk";
            Size = new Size(1100, 700);
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
            ((System.ComponentModel.ISupportInitialize)nudJumlahGudang2).EndInit();
            pnlHeaderFormGudang.ResumeLayout(false);
            pnlHeaderFormGudang.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GradientPanel pnlPageGudang;
        private Panel pnlBawahGudang;
        private Panel pnlFormLuarGudang;
        private Panel pnlFormDalamGudang;
        private GradientPanel pnlHeaderFormGudang;
        private Panel pnlKartuTabelGudang;
        private Panel pnlKartuTabelDalamGudang;
        private Panel pnlGapGudang;
        private Panel pnlToolbarGudang;
        private Label lblJudulGudang2;
        private Label lblInfoGudang2;
        private TextBox txtCariGudang2;
        private NumericUpDown nudJumlahGudang2;
        private ComboBox cmbBarangGudang2;
        private ComboBox cmbPerriodeGudang2;
        private Button btnSimpanGudang2;
        private Button btnBersihkanGudang2;
        private DataGridView dataGridView1;
        private Label lblBarang;
        private Label lblStokInfoGudang2;
        private Label lblSJGudang2;
        private Label lblAsalGudang2;
        private Label lblJumlahGudang2;
        private Label lblCatatanGudang2;
        private TextBox txtAsalGudang2;
        private TextBox txtSJGudang2;
        private TextBox txtCatatanGudang2;
        private DataGridViewTextBoxColumn colWaktuGudang2;
        private DataGridViewTextBoxColumn colBarangGudang2;
        private DataGridViewTextBoxColumn colJumlahGudang2;
        private DataGridViewTextBoxColumn colAsalGudang2;
        private DataGridViewTextBoxColumn colSJGudang2;
    }
}
