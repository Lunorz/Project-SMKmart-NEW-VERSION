namespace project_akhir_stock_gudang
{
    partial class ucStockBarang
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
            colKode = new DataGridViewTextBoxColumn();
            colNama = new DataGridViewTextBoxColumn();
            colStok = new DataGridViewTextBoxColumn();
            colMin = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            pnlToolbarGudang = new Panel();
            txtCarigudang1 = new TextBox();
            cmbKategoriGudang1 = new ComboBox();
            cmbStatusGudang1 = new ComboBox();
            pnlGapGudang = new Panel();
            pnlFormLuarGudang = new Panel();
            pnlFormDalamGudang = new Panel();
            nudMinGudang1 = new NumericUpDown();
            nudFisikGudang1 = new NumericUpDown();
            txtAlasanGudang1 = new TextBox();
            txtSelisih = new TextBox();
            txtSistemGudang1 = new TextBox();
            lblMinGudang1 = new Label();
            lblAlasanGudang1 = new Label();
            lblSelisihGudang1 = new Label();
            lblFIsikGudang1 = new Label();
            lblSistemGudang1 = new Label();
            btnOpnameGudang1 = new Button();
            btnPengaturanGudang1 = new Button();
            pnlHeaderFormGudang = new GradientPanel();
            lblInfoGudang1 = new Label();
            pnlJudulFormGudang1 = new Label();
            pnlPageGudang.SuspendLayout();
            pnlBawahGudang.SuspendLayout();
            pnlKartuTabelGudang.SuspendLayout();
            pnlKartuTabelDalamGudang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlToolbarGudang.SuspendLayout();
            pnlFormLuarGudang.SuspendLayout();
            pnlFormDalamGudang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMinGudang1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFisikGudang1).BeginInit();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colKode, colNama, colStok, colMin, colStatus });
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
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // colKode
            // 
            colKode.FillWeight = 12F;
            colKode.HeaderText = "kode";
            colKode.MinimumWidth = 6;
            colKode.Name = "colKode";
            colKode.ReadOnly = true;
            // 
            // colNama
            // 
            colNama.FillWeight = 24F;
            colNama.HeaderText = "nama";
            colNama.MinimumWidth = 6;
            colNama.Name = "colNama";
            colNama.ReadOnly = true;
            // 
            // colStok
            // 
            colStok.FillWeight = 8F;
            colStok.HeaderText = "stok";
            colStok.MinimumWidth = 6;
            colStok.Name = "colStok";
            colStok.ReadOnly = true;
            // 
            // colMin
            // 
            colMin.FillWeight = 8F;
            colMin.HeaderText = "min";
            colMin.MinimumWidth = 6;
            colMin.Name = "colMin";
            colMin.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.FillWeight = 16F;
            colStatus.HeaderText = "status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // pnlToolbarGudang
            // 
            pnlToolbarGudang.Controls.Add(txtCarigudang1);
            pnlToolbarGudang.Controls.Add(cmbKategoriGudang1);
            pnlToolbarGudang.Controls.Add(cmbStatusGudang1);
            pnlToolbarGudang.Dock = DockStyle.Top;
            pnlToolbarGudang.Location = new Point(0, 0);
            pnlToolbarGudang.Name = "pnlToolbarGudang";
            pnlToolbarGudang.Size = new Size(686, 72);
            pnlToolbarGudang.TabIndex = 0;
            // 
            // txtCarigudang1
            // 
            txtCarigudang1.BackColor = Color.White;
            txtCarigudang1.BorderStyle = BorderStyle.FixedSingle;
            txtCarigudang1.Font = new Font("Leelawadee UI", 11F);
            txtCarigudang1.ForeColor = Color.FromArgb(18, 55, 42);
            txtCarigudang1.Location = new Point(18, 16);
            txtCarigudang1.Name = "txtCarigudang1";
            txtCarigudang1.PlaceholderText = "Cari kode atau nama barang";
            txtCarigudang1.Size = new Size(340, 32);
            txtCarigudang1.TabIndex = 1;
            txtCarigudang1.TextChanged += txtCarigudang1_TextChanged;
            // 
            // cmbKategoriGudang1
            // 
            cmbKategoriGudang1.BackColor = Color.White;
            cmbKategoriGudang1.Font = new Font("Leelawadee UI", 11F);
            cmbKategoriGudang1.ForeColor = Color.FromArgb(18, 55, 42);
            cmbKategoriGudang1.FormattingEnabled = true;
            cmbKategoriGudang1.Location = new Point(374, 15);
            cmbKategoriGudang1.Name = "cmbKategoriGudang1";
            cmbKategoriGudang1.Size = new Size(150, 33);
            cmbKategoriGudang1.TabIndex = 4;
            cmbKategoriGudang1.SelectedIndexChanged += cmbKategoriGudang1_SelectedIndexChanged;
            // 
            // cmbStatusGudang1
            // 
            cmbStatusGudang1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbStatusGudang1.BackColor = Color.White;
            cmbStatusGudang1.Font = new Font("Leelawadee UI", 11F);
            cmbStatusGudang1.ForeColor = Color.FromArgb(18, 55, 42);
            cmbStatusGudang1.FormattingEnabled = true;
            cmbStatusGudang1.Location = new Point(530, 14);
            cmbStatusGudang1.Name = "cmbStatusGudang1";
            cmbStatusGudang1.Size = new Size(151, 33);
            cmbStatusGudang1.TabIndex = 6;
            cmbStatusGudang1.SelectedIndexChanged += cmbStatusGudang1_SelectedIndexChanged;
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
            pnlFormDalamGudang.Controls.Add(nudMinGudang1);
            pnlFormDalamGudang.Controls.Add(nudFisikGudang1);
            pnlFormDalamGudang.Controls.Add(txtAlasanGudang1);
            pnlFormDalamGudang.Controls.Add(txtSelisih);
            pnlFormDalamGudang.Controls.Add(txtSistemGudang1);
            pnlFormDalamGudang.Controls.Add(lblMinGudang1);
            pnlFormDalamGudang.Controls.Add(lblAlasanGudang1);
            pnlFormDalamGudang.Controls.Add(lblSelisihGudang1);
            pnlFormDalamGudang.Controls.Add(lblFIsikGudang1);
            pnlFormDalamGudang.Controls.Add(lblSistemGudang1);
            pnlFormDalamGudang.Controls.Add(btnOpnameGudang1);
            pnlFormDalamGudang.Controls.Add(btnPengaturanGudang1);
            pnlFormDalamGudang.Controls.Add(pnlHeaderFormGudang);
            pnlFormDalamGudang.Dock = DockStyle.Fill;
            pnlFormDalamGudang.Font = new Font("Leelawadee UI", 11F);
            pnlFormDalamGudang.Location = new Point(1, 1);
            pnlFormDalamGudang.Name = "pnlFormDalamGudang";
            pnlFormDalamGudang.Size = new Size(338, 650);
            pnlFormDalamGudang.TabIndex = 0;
            // 
            // nudMinGudang1
            // 
            nudMinGudang1.BackColor = Color.White;
            nudMinGudang1.BorderStyle = BorderStyle.FixedSingle;
            nudMinGudang1.ForeColor = Color.FromArgb(18, 55, 42);
            nudMinGudang1.Location = new Point(20, 388);
            nudMinGudang1.Name = "nudMinGudang1";
            nudMinGudang1.Size = new Size(140, 32);
            nudMinGudang1.TabIndex = 19;
            // 
            // nudFisikGudang1
            // 
            nudFisikGudang1.BackColor = Color.White;
            nudFisikGudang1.BorderStyle = BorderStyle.FixedSingle;
            nudFisikGudang1.ForeColor = Color.FromArgb(18, 55, 42);
            nudFisikGudang1.Location = new Point(20, 190);
            nudFisikGudang1.Name = "nudFisikGudang1";
            nudFisikGudang1.Size = new Size(298, 32);
            nudFisikGudang1.TabIndex = 18;
            nudFisikGudang1.ValueChanged += nudFisikGudang1_ValueChanged;
            // 
            // txtAlasanGudang1
            // 
            txtAlasanGudang1.BackColor = Color.White;
            txtAlasanGudang1.BorderStyle = BorderStyle.FixedSingle;
            txtAlasanGudang1.ForeColor = Color.FromArgb(18, 55, 42);
            txtAlasanGudang1.Location = new Point(20, 318);
            txtAlasanGudang1.MaxLength = 80;
            txtAlasanGudang1.Name = "txtAlasanGudang1";
            txtAlasanGudang1.Size = new Size(298, 32);
            txtAlasanGudang1.TabIndex = 17;
            // 
            // txtSelisih
            // 
            txtSelisih.BackColor = Color.FromArgb(245, 251, 248);
            txtSelisih.BorderStyle = BorderStyle.FixedSingle;
            txtSelisih.Font = new Font("Leelawadee UI", 11F);
            txtSelisih.ForeColor = Color.FromArgb(79, 106, 92);
            txtSelisih.Location = new Point(20, 254);
            txtSelisih.Name = "txtSelisih";
            txtSelisih.ReadOnly = true;
            txtSelisih.Size = new Size(298, 32);
            txtSelisih.TabIndex = 16;
            txtSelisih.TabStop = false;
            // 
            // txtSistemGudang1
            // 
            txtSistemGudang1.BackColor = Color.FromArgb(245, 251, 248);
            txtSistemGudang1.BorderStyle = BorderStyle.FixedSingle;
            txtSistemGudang1.ForeColor = Color.FromArgb(79, 106, 92);
            txtSistemGudang1.Location = new Point(20, 126);
            txtSistemGudang1.Name = "txtSistemGudang1";
            txtSistemGudang1.ReadOnly = true;
            txtSistemGudang1.Size = new Size(298, 32);
            txtSistemGudang1.TabIndex = 15;
            txtSistemGudang1.TabStop = false;
            // 
            // lblMinGudang1
            // 
            lblMinGudang1.AutoSize = true;
            lblMinGudang1.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMinGudang1.ForeColor = Color.FromArgb(79, 106, 92);
            lblMinGudang1.Location = new Point(20, 365);
            lblMinGudang1.Name = "lblMinGudang1";
            lblMinGudang1.Size = new Size(112, 20);
            lblMinGudang1.TabIndex = 14;
            lblMinGudang1.Text = "Stok minimum";
            // 
            // lblAlasanGudang1
            // 
            lblAlasanGudang1.AutoSize = true;
            lblAlasanGudang1.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlasanGudang1.ForeColor = Color.FromArgb(79, 106, 92);
            lblAlasanGudang1.Location = new Point(20, 296);
            lblAlasanGudang1.Name = "lblAlasanGudang1";
            lblAlasanGudang1.Size = new Size(103, 20);
            lblAlasanGudang1.TabIndex = 13;
            lblAlasanGudang1.Text = "Alasan selisih";
            // 
            // lblSelisihGudang1
            // 
            lblSelisihGudang1.AutoSize = true;
            lblSelisihGudang1.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelisihGudang1.ForeColor = Color.FromArgb(79, 106, 92);
            lblSelisihGudang1.Location = new Point(20, 232);
            lblSelisihGudang1.Name = "lblSelisihGudang1";
            lblSelisihGudang1.Size = new Size(53, 20);
            lblSelisihGudang1.TabIndex = 12;
            lblSelisihGudang1.Text = "Selisih";
            // 
            // lblFIsikGudang1
            // 
            lblFIsikGudang1.AutoSize = true;
            lblFIsikGudang1.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFIsikGudang1.ForeColor = Color.FromArgb(79, 106, 92);
            lblFIsikGudang1.Location = new Point(20, 168);
            lblFIsikGudang1.Name = "lblFIsikGudang1";
            lblFIsikGudang1.Size = new Size(191, 20);
            lblFIsikGudang1.TabIndex = 11;
            lblFIsikGudang1.Text = "Jumlah fisik (hasil hitung)";
            lblFIsikGudang1.Click += label1_Click;
            // 
            // lblSistemGudang1
            // 
            lblSistemGudang1.AutoSize = true;
            lblSistemGudang1.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSistemGudang1.ForeColor = Color.FromArgb(79, 106, 92);
            lblSistemGudang1.Location = new Point(20, 104);
            lblSistemGudang1.Name = "lblSistemGudang1";
            lblSistemGudang1.Size = new Size(90, 20);
            lblSistemGudang1.TabIndex = 10;
            lblSistemGudang1.Text = "Stok sistem\t";
            // 
            // btnOpnameGudang1
            // 
            btnOpnameGudang1.BackColor = Color.FromArgb(42, 127, 80);
            btnOpnameGudang1.FlatAppearance.BorderSize = 0;
            btnOpnameGudang1.FlatStyle = FlatStyle.Flat;
            btnOpnameGudang1.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpnameGudang1.ForeColor = Color.White;
            btnOpnameGudang1.Location = new Point(20, 481);
            btnOpnameGudang1.Name = "btnOpnameGudang1";
            btnOpnameGudang1.Size = new Size(298, 40);
            btnOpnameGudang1.TabIndex = 8;
            btnOpnameGudang1.Text = "Simpan opname";
            btnOpnameGudang1.UseVisualStyleBackColor = false;
            btnOpnameGudang1.Click += btnOpnameGudang1_Click;
            // 
            // btnPengaturanGudang1
            // 
            btnPengaturanGudang1.FlatAppearance.BorderColor = Color.FromArgb(213, 235, 223);
            btnPengaturanGudang1.ForeColor = Color.FromArgb(18, 55, 42);
            btnPengaturanGudang1.Location = new Point(20, 435);
            btnPengaturanGudang1.Name = "btnPengaturanGudang1";
            btnPengaturanGudang1.Size = new Size(298, 40);
            btnPengaturanGudang1.TabIndex = 7;
            btnPengaturanGudang1.Text = "Simpan pengaturan";
            btnPengaturanGudang1.UseVisualStyleBackColor = true;
            btnPengaturanGudang1.Click += btnPengaturanGudang1_Click;
            // 
            // pnlHeaderFormGudang
            // 
            pnlHeaderFormGudang.Angle = 45F;
            pnlHeaderFormGudang.ColorBottom = Color.FromArgb(152, 232, 193);
            pnlHeaderFormGudang.ColorTop = Color.FromArgb(42, 127, 80);
            pnlHeaderFormGudang.Controls.Add(lblInfoGudang1);
            pnlHeaderFormGudang.Controls.Add(pnlJudulFormGudang1);
            pnlHeaderFormGudang.Dock = DockStyle.Top;
            pnlHeaderFormGudang.Location = new Point(0, 0);
            pnlHeaderFormGudang.Name = "pnlHeaderFormGudang";
            pnlHeaderFormGudang.Size = new Size(338, 84);
            pnlHeaderFormGudang.TabIndex = 0;
            // 
            // lblInfoGudang1
            // 
            lblInfoGudang1.AutoSize = true;
            lblInfoGudang1.BackColor = Color.Transparent;
            lblInfoGudang1.Font = new Font("Leelawadee UI", 9.75F);
            lblInfoGudang1.ForeColor = Color.FromArgb(14, 47, 34);
            lblInfoGudang1.Location = new Point(5, 49);
            lblInfoGudang1.Name = "lblInfoGudang1";
            lblInfoGudang1.Size = new Size(163, 23);
            lblInfoGudang1.TabIndex = 1;
            lblInfoGudang1.Text = "Pilih barang di tabel";
            lblInfoGudang1.Click += label2_Click;
            // 
            // pnlJudulFormGudang1
            // 
            pnlJudulFormGudang1.AutoSize = true;
            pnlJudulFormGudang1.BackColor = Color.Transparent;
            pnlJudulFormGudang1.Font = new Font("Leelawadee UI", 13.5F, FontStyle.Bold);
            pnlJudulFormGudang1.ForeColor = Color.FromArgb(14, 47, 34);
            pnlJudulFormGudang1.Location = new Point(1, 14);
            pnlJudulFormGudang1.Name = "pnlJudulFormGudang1";
            pnlJudulFormGudang1.Size = new Size(193, 31);
            pnlJudulFormGudang1.TabIndex = 0;
            pnlJudulFormGudang1.Text = "Pengaturan Stok";
            // 
            // ucStockBarang
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 251, 248);
            Controls.Add(pnlPageGudang);
            Font = new Font("Leelawadee UI", 10.5F);
            Name = "ucStockBarang";
            Size = new Size(1100, 700);
            Load += ucStockBarang_Load;
            VisibleChanged += ucStockBarang_VisibleChanged;
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
            ((System.ComponentModel.ISupportInitialize)nudMinGudang1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFisikGudang1).EndInit();
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
        private Button btnOpnameGudang1;
        private Button btnPengaturanGudang1;
        private ComboBox cmbStatusGudang1;
        private ComboBox cmbKategoriGudang1;
        private TextBox txtCarigudang1;
        private GradientPanel pnlHeaderFormGudang;
        private Label lblInfoGudang1;
        private Label pnlJudulFormGudang1;
        private Label lblSistemGudang1;
        private Label lblFIsikGudang1;
        private Label lblMinGudang1;
        private Label lblAlasanGudang1;
        private Label lblSelisihGudang1;
        private TextBox txtSistemGudang1;
        private TextBox txtSelisih;
        private NumericUpDown nudFisikGudang1;
        private TextBox txtAlasanGudang1;
        private NumericUpDown nudMinGudang1;
        private DataGridViewTextBoxColumn colKode;
        private DataGridViewTextBoxColumn colNama;
        private DataGridViewTextBoxColumn colStok;
        private DataGridViewTextBoxColumn colMin;
        private DataGridViewTextBoxColumn colStatus;
    }
}
