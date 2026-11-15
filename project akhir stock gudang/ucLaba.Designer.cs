namespace project_akhir_stock_gudang
{
    partial class ucLaba
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            pnlPage = new Panel();
            tlpKartu = new TableLayoutPanel();
            pnlJarak = new Panel();
            pnlBawah = new Panel();
            pnlKartuModal = new GradientPanel();
            pnlKartuPotensi = new Panel();
            pnlKartuNaik = new Panel();
            pnlKartuMargin = new Panel();
            pnlKartuPotensiDalam = new Panel();
            pnlKartuNaikDalam = new Panel();
            PnlKartuMarginDalam = new Panel();
            lblModalJudul = new Label();
            lblMarginJudul = new Label();
            lblNaikDalam = new Label();
            lblPotensiJudul = new Label();
            lblModal = new Label();
            lblPotensi = new Label();
            lblNaik = new Label();
            lblMargin = new Label();
            pnlAturLuar = new Panel();
            pnlGap = new Panel();
            pnlKartuTabel = new Panel();
            pnlKartuTabelDalam = new Panel();
            tabUtama = new TabControl();
            tabDaftar = new TabPage();
            tabLapisan = new TabPage();
            tabRiwayat = new TabPage();
            dgvDaftar = new DataGridView();
            dgvRiwayat = new DataGridView();
            lblCatatanLapisan = new Label();
            colKode = new DataGridViewTextBoxColumn();
            colBarang = new DataGridViewTextBoxColumn();
            colStok = new DataGridViewTextBoxColumn();
            colBeliTerakhir = new DataGridViewTextBoxColumn();
            colJual = new DataGridViewTextBoxColumn();
            colLabaBaru = new DataGridViewTextBoxColumn();
            dgvLapisan = new DataGridView();
            colLapisan = new DataGridViewTextBoxColumn();
            colMasuk = new DataGridViewTextBoxColumn();
            colSisa = new DataGridViewTextBoxColumn();
            colBeli = new DataGridViewTextBoxColumn();
            colJualL = new DataGridViewTextBoxColumn();
            colLaba = new DataGridViewTextBoxColumn();
            colPotensi = new DataGridViewTextBoxColumn();
            colWaktuR = new DataGridViewTextBoxColumn();
            colBarangR = new DataGridViewTextBoxColumn();
            colBeliR = new DataGridViewTextBoxColumn();
            colJualR = new DataGridViewTextBoxColumn();
            colOleh = new DataGridViewTextBoxColumn();
            colAlasan = new DataGridViewTextBoxColumn();
            pnlAturDalam = new Panel();
            pnlHeaderAtur = new GradientPanel();
            lblJudulAtur = new Label();
            lblBeliTerakhir = new Label();
            lblJualBaru = new Label();
            lblJualSekarang = new Label();
            txtBeliTerakhir = new TextBox();
            txtJualSekarang = new TextBox();
            lblAlasan = new Label();
            nudJualBaru = new NumericUpDown();
            pnlPage.SuspendLayout();
            tlpKartu.SuspendLayout();
            pnlBawah.SuspendLayout();
            pnlKartuModal.SuspendLayout();
            pnlKartuPotensi.SuspendLayout();
            pnlKartuNaik.SuspendLayout();
            pnlKartuMargin.SuspendLayout();
            pnlKartuPotensiDalam.SuspendLayout();
            pnlKartuNaikDalam.SuspendLayout();
            PnlKartuMarginDalam.SuspendLayout();
            pnlAturLuar.SuspendLayout();
            pnlKartuTabel.SuspendLayout();
            pnlKartuTabelDalam.SuspendLayout();
            tabUtama.SuspendLayout();
            tabDaftar.SuspendLayout();
            tabLapisan.SuspendLayout();
            tabRiwayat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDaftar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLapisan).BeginInit();
            pnlAturDalam.SuspendLayout();
            pnlHeaderAtur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudJualBaru).BeginInit();
            SuspendLayout();
            // 
            // pnlPage
            // 
            pnlPage.Controls.Add(pnlBawah);
            pnlPage.Controls.Add(pnlJarak);
            pnlPage.Controls.Add(tlpKartu);
            pnlPage.Dock = DockStyle.Fill;
            pnlPage.Location = new Point(0, 0);
            pnlPage.Name = "pnlPage";
            pnlPage.Padding = new Padding(24);
            pnlPage.Size = new Size(1238, 805);
            pnlPage.TabIndex = 0;
            // 
            // tlpKartu
            // 
            tlpKartu.ColumnCount = 4;
            tlpKartu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpKartu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpKartu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpKartu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpKartu.Controls.Add(pnlKartuMargin, 3, 0);
            tlpKartu.Controls.Add(pnlKartuNaik, 2, 0);
            tlpKartu.Controls.Add(pnlKartuModal, 0, 0);
            tlpKartu.Controls.Add(pnlKartuPotensi, 1, 0);
            tlpKartu.Dock = DockStyle.Top;
            tlpKartu.Location = new Point(24, 24);
            tlpKartu.Name = "tlpKartu";
            tlpKartu.RowCount = 1;
            tlpKartu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpKartu.Size = new Size(1190, 100);
            tlpKartu.TabIndex = 0;
            // 
            // pnlJarak
            // 
            pnlJarak.Dock = DockStyle.Top;
            pnlJarak.Location = new Point(24, 124);
            pnlJarak.Name = "pnlJarak";
            pnlJarak.Size = new Size(1190, 24);
            pnlJarak.TabIndex = 1;
            // 
            // pnlBawah
            // 
            pnlBawah.BackColor = Color.Transparent;
            pnlBawah.Controls.Add(pnlKartuTabel);
            pnlBawah.Controls.Add(pnlGap);
            pnlBawah.Controls.Add(pnlAturLuar);
            pnlBawah.Dock = DockStyle.Fill;
            pnlBawah.Location = new Point(24, 148);
            pnlBawah.Name = "pnlBawah";
            pnlBawah.Size = new Size(1190, 633);
            pnlBawah.TabIndex = 2;
            // 
            // pnlKartuModal
            // 
            pnlKartuModal.Angle = 45F;
            pnlKartuModal.ColorBottom = Color.FromArgb(62, 156, 106);
            pnlKartuModal.ColorTop = Color.FromArgb(31, 107, 66);
            pnlKartuModal.Controls.Add(lblModal);
            pnlKartuModal.Controls.Add(lblModalJudul);
            pnlKartuModal.Dock = DockStyle.Fill;
            pnlKartuModal.Location = new Point(0, 0);
            pnlKartuModal.Margin = new Padding(0, 0, 16, 0);
            pnlKartuModal.Name = "pnlKartuModal";
            pnlKartuModal.Size = new Size(281, 100);
            pnlKartuModal.TabIndex = 0;
            // 
            // pnlKartuPotensi
            // 
            pnlKartuPotensi.BackColor = Color.FromArgb(213, 235, 223);
            pnlKartuPotensi.Controls.Add(pnlKartuPotensiDalam);
            pnlKartuPotensi.Dock = DockStyle.Fill;
            pnlKartuPotensi.Location = new Point(297, 0);
            pnlKartuPotensi.Margin = new Padding(0, 0, 16, 0);
            pnlKartuPotensi.Name = "pnlKartuPotensi";
            pnlKartuPotensi.Padding = new Padding(1);
            pnlKartuPotensi.Size = new Size(281, 100);
            pnlKartuPotensi.TabIndex = 1;
            // 
            // pnlKartuNaik
            // 
            pnlKartuNaik.BackColor = Color.FromArgb(213, 235, 223);
            pnlKartuNaik.Controls.Add(pnlKartuNaikDalam);
            pnlKartuNaik.Dock = DockStyle.Fill;
            pnlKartuNaik.Location = new Point(594, 0);
            pnlKartuNaik.Margin = new Padding(0, 0, 16, 0);
            pnlKartuNaik.Name = "pnlKartuNaik";
            pnlKartuNaik.Padding = new Padding(1);
            pnlKartuNaik.Size = new Size(281, 100);
            pnlKartuNaik.TabIndex = 2;
            // 
            // pnlKartuMargin
            // 
            pnlKartuMargin.BackColor = Color.FromArgb(213, 235, 223);
            pnlKartuMargin.Controls.Add(PnlKartuMarginDalam);
            pnlKartuMargin.Dock = DockStyle.Fill;
            pnlKartuMargin.Location = new Point(891, 0);
            pnlKartuMargin.Margin = new Padding(0);
            pnlKartuMargin.Name = "pnlKartuMargin";
            pnlKartuMargin.Padding = new Padding(1);
            pnlKartuMargin.Size = new Size(299, 100);
            pnlKartuMargin.TabIndex = 3;
            // 
            // pnlKartuPotensiDalam
            // 
            pnlKartuPotensiDalam.BackColor = Color.White;
            pnlKartuPotensiDalam.Controls.Add(lblPotensi);
            pnlKartuPotensiDalam.Controls.Add(lblPotensiJudul);
            pnlKartuPotensiDalam.Dock = DockStyle.Fill;
            pnlKartuPotensiDalam.Location = new Point(1, 1);
            pnlKartuPotensiDalam.Name = "pnlKartuPotensiDalam";
            pnlKartuPotensiDalam.Size = new Size(279, 98);
            pnlKartuPotensiDalam.TabIndex = 0;
            // 
            // pnlKartuNaikDalam
            // 
            pnlKartuNaikDalam.BackColor = Color.White;
            pnlKartuNaikDalam.Controls.Add(lblNaik);
            pnlKartuNaikDalam.Controls.Add(lblNaikDalam);
            pnlKartuNaikDalam.Dock = DockStyle.Fill;
            pnlKartuNaikDalam.Location = new Point(1, 1);
            pnlKartuNaikDalam.Name = "pnlKartuNaikDalam";
            pnlKartuNaikDalam.Size = new Size(279, 98);
            pnlKartuNaikDalam.TabIndex = 1;
            // 
            // PnlKartuMarginDalam
            // 
            PnlKartuMarginDalam.BackColor = Color.White;
            PnlKartuMarginDalam.Controls.Add(lblMargin);
            PnlKartuMarginDalam.Controls.Add(lblMarginJudul);
            PnlKartuMarginDalam.Dock = DockStyle.Fill;
            PnlKartuMarginDalam.Location = new Point(1, 1);
            PnlKartuMarginDalam.Name = "PnlKartuMarginDalam";
            PnlKartuMarginDalam.Size = new Size(297, 98);
            PnlKartuMarginDalam.TabIndex = 1;
            // 
            // lblModalJudul
            // 
            lblModalJudul.AutoSize = true;
            lblModalJudul.BackColor = Color.Transparent;
            lblModalJudul.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModalJudul.ForeColor = Color.White;
            lblModalJudul.Location = new Point(20, 18);
            lblModalJudul.Name = "lblModalJudul";
            lblModalJudul.Size = new Size(136, 20);
            lblModalJudul.TabIndex = 0;
            lblModalJudul.Text = "Nilai Stok (modal)";
            // 
            // lblMarginJudul
            // 
            lblMarginJudul.AutoSize = true;
            lblMarginJudul.BackColor = Color.Transparent;
            lblMarginJudul.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMarginJudul.ForeColor = Color.FromArgb(79, 106, 92);
            lblMarginJudul.Location = new Point(20, 18);
            lblMarginJudul.Name = "lblMarginJudul";
            lblMarginJudul.Size = new Size(129, 20);
            lblMarginJudul.TabIndex = 1;
            lblMarginJudul.Text = "Margin Rata-rata";
            // 
            // lblNaikDalam
            // 
            lblNaikDalam.AutoSize = true;
            lblNaikDalam.BackColor = Color.Transparent;
            lblNaikDalam.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNaikDalam.ForeColor = Color.FromArgb(79, 106, 92);
            lblNaikDalam.Location = new Point(20, 18);
            lblNaikDalam.Name = "lblNaikDalam";
            lblNaikDalam.Size = new Size(141, 20);
            lblNaikDalam.TabIndex = 2;
            lblNaikDalam.Text = "Barang Harga Naik\t";
            // 
            // lblPotensiJudul
            // 
            lblPotensiJudul.AutoSize = true;
            lblPotensiJudul.BackColor = Color.Transparent;
            lblPotensiJudul.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPotensiJudul.ForeColor = Color.FromArgb(79, 106, 92);
            lblPotensiJudul.Location = new Point(20, 18);
            lblPotensiJudul.Name = "lblPotensiJudul";
            lblPotensiJudul.Size = new Size(98, 20);
            lblPotensiJudul.TabIndex = 2;
            lblPotensiJudul.Text = "Potensi Laba";
            // 
            // lblModal
            // 
            lblModal.AutoSize = true;
            lblModal.BackColor = Color.Transparent;
            lblModal.Font = new Font("Leelawadee UI", 21F, FontStyle.Bold);
            lblModal.ForeColor = Color.White;
            lblModal.Location = new Point(20, 42);
            lblModal.Name = "lblModal";
            lblModal.Size = new Size(40, 47);
            lblModal.TabIndex = 3;
            lblModal.Text = "0";
            // 
            // lblPotensi
            // 
            lblPotensi.AutoSize = true;
            lblPotensi.BackColor = Color.Transparent;
            lblPotensi.Font = new Font("Leelawadee UI", 21F, FontStyle.Bold);
            lblPotensi.ForeColor = Color.FromArgb(79, 106, 92);
            lblPotensi.Location = new Point(20, 42);
            lblPotensi.Name = "lblPotensi";
            lblPotensi.Size = new Size(40, 47);
            lblPotensi.TabIndex = 4;
            lblPotensi.Text = "0";
            // 
            // lblNaik
            // 
            lblNaik.AutoSize = true;
            lblNaik.BackColor = Color.Transparent;
            lblNaik.Font = new Font("Leelawadee UI", 21F, FontStyle.Bold);
            lblNaik.ForeColor = Color.FromArgb(79, 106, 92);
            lblNaik.Location = new Point(20, 42);
            lblNaik.Name = "lblNaik";
            lblNaik.Size = new Size(40, 47);
            lblNaik.TabIndex = 5;
            lblNaik.Text = "0";
            // 
            // lblMargin
            // 
            lblMargin.AutoSize = true;
            lblMargin.BackColor = Color.Transparent;
            lblMargin.Font = new Font("Leelawadee UI", 21F, FontStyle.Bold);
            lblMargin.ForeColor = Color.FromArgb(79, 106, 92);
            lblMargin.Location = new Point(20, 42);
            lblMargin.Name = "lblMargin";
            lblMargin.Size = new Size(40, 47);
            lblMargin.TabIndex = 5;
            lblMargin.Text = "0";
            // 
            // pnlAturLuar
            // 
            pnlAturLuar.BackColor = Color.FromArgb(213, 235, 223);
            pnlAturLuar.Controls.Add(pnlAturDalam);
            pnlAturLuar.Dock = DockStyle.Right;
            pnlAturLuar.Location = new Point(850, 0);
            pnlAturLuar.Name = "pnlAturLuar";
            pnlAturLuar.Padding = new Padding(1);
            pnlAturLuar.Size = new Size(340, 633);
            pnlAturLuar.TabIndex = 0;
            // 
            // pnlGap
            // 
            pnlGap.Dock = DockStyle.Right;
            pnlGap.Location = new Point(826, 0);
            pnlGap.Name = "pnlGap";
            pnlGap.Size = new Size(24, 633);
            pnlGap.TabIndex = 1;
            // 
            // pnlKartuTabel
            // 
            pnlKartuTabel.BackColor = Color.FromArgb(213, 235, 223);
            pnlKartuTabel.Controls.Add(pnlKartuTabelDalam);
            pnlKartuTabel.Dock = DockStyle.Fill;
            pnlKartuTabel.Location = new Point(0, 0);
            pnlKartuTabel.Name = "pnlKartuTabel";
            pnlKartuTabel.Padding = new Padding(1);
            pnlKartuTabel.Size = new Size(826, 633);
            pnlKartuTabel.TabIndex = 2;
            // 
            // pnlKartuTabelDalam
            // 
            pnlKartuTabelDalam.BackColor = Color.White;
            pnlKartuTabelDalam.Controls.Add(tabUtama);
            pnlKartuTabelDalam.Dock = DockStyle.Fill;
            pnlKartuTabelDalam.Location = new Point(1, 1);
            pnlKartuTabelDalam.Name = "pnlKartuTabelDalam";
            pnlKartuTabelDalam.Size = new Size(824, 631);
            pnlKartuTabelDalam.TabIndex = 0;
            // 
            // tabUtama
            // 
            tabUtama.Controls.Add(tabDaftar);
            tabUtama.Controls.Add(tabLapisan);
            tabUtama.Controls.Add(tabRiwayat);
            tabUtama.Dock = DockStyle.Fill;
            tabUtama.Location = new Point(0, 0);
            tabUtama.Name = "tabUtama";
            tabUtama.SelectedIndex = 0;
            tabUtama.Size = new Size(824, 631);
            tabUtama.TabIndex = 0;
            // 
            // tabDaftar
            // 
            tabDaftar.BackColor = Color.White;
            tabDaftar.Controls.Add(dgvDaftar);
            tabDaftar.Location = new Point(4, 32);
            tabDaftar.Name = "tabDaftar";
            tabDaftar.Padding = new Padding(3);
            tabDaftar.Size = new Size(816, 595);
            tabDaftar.TabIndex = 0;
            tabDaftar.Text = "Daftar Harga";
            // 
            // tabLapisan
            // 
            tabLapisan.BackColor = Color.White;
            tabLapisan.Controls.Add(dgvLapisan);
            tabLapisan.Controls.Add(lblCatatanLapisan);
            tabLapisan.Location = new Point(4, 32);
            tabLapisan.Name = "tabLapisan";
            tabLapisan.Padding = new Padding(3);
            tabLapisan.Size = new Size(816, 595);
            tabLapisan.TabIndex = 1;
            tabLapisan.Text = "\tLapisan Stok";
            // 
            // tabRiwayat
            // 
            tabRiwayat.BackColor = Color.White;
            tabRiwayat.Controls.Add(dgvRiwayat);
            tabRiwayat.Location = new Point(4, 32);
            tabRiwayat.Name = "tabRiwayat";
            tabRiwayat.Padding = new Padding(3);
            tabRiwayat.Size = new Size(816, 595);
            tabRiwayat.TabIndex = 2;
            tabRiwayat.Text = "Riwayat Harga";
            // 
            // dgvDaftar
            // 
            dgvDaftar.AllowUserToAddRows = false;
            dgvDaftar.AllowUserToDeleteRows = false;
            dgvDaftar.AllowUserToOrderColumns = true;
            dgvDaftar.AllowUserToResizeColumns = false;
            dgvDaftar.AllowUserToResizeRows = false;
            dgvDaftar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDaftar.BackgroundColor = Color.White;
            dgvDaftar.BorderStyle = BorderStyle.None;
            dgvDaftar.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDaftar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(245, 251, 248);
            dataGridViewCellStyle7.Font = new Font("Leelawadee UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(79, 106, 92);
            dataGridViewCellStyle7.Padding = new Padding(12, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(245, 251, 248);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(79, 106, 92);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvDaftar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvDaftar.ColumnHeadersHeight = 60;
            dgvDaftar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDaftar.Columns.AddRange(new DataGridViewColumn[] { colKode, colBarang, colStok, colBeliTerakhir, colJual, colLabaBaru });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Leelawadee UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(18, 55, 42);
            dataGridViewCellStyle8.Padding = new Padding(12, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(230, 247, 238);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(18, 55, 42);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvDaftar.DefaultCellStyle = dataGridViewCellStyle8;
            dgvDaftar.Dock = DockStyle.Fill;
            dgvDaftar.EnableHeadersVisualStyles = false;
            dgvDaftar.GridColor = Color.FromArgb(230, 247, 238);
            dgvDaftar.Location = new Point(3, 3);
            dgvDaftar.MultiSelect = false;
            dgvDaftar.Name = "dgvDaftar";
            dgvDaftar.ReadOnly = true;
            dgvDaftar.RowHeadersVisible = false;
            dgvDaftar.RowHeadersWidth = 51;
            dgvDaftar.RowTemplate.Height = 56;
            dgvDaftar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDaftar.Size = new Size(810, 589);
            dgvDaftar.TabIndex = 2;
            // 
            // dgvRiwayat
            // 
            dgvRiwayat.AllowUserToAddRows = false;
            dgvRiwayat.AllowUserToDeleteRows = false;
            dgvRiwayat.AllowUserToOrderColumns = true;
            dgvRiwayat.AllowUserToResizeColumns = false;
            dgvRiwayat.AllowUserToResizeRows = false;
            dgvRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRiwayat.BackgroundColor = Color.White;
            dgvRiwayat.BorderStyle = BorderStyle.None;
            dgvRiwayat.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRiwayat.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(245, 251, 248);
            dataGridViewCellStyle9.Font = new Font("Leelawadee UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(79, 106, 92);
            dataGridViewCellStyle9.Padding = new Padding(12, 0, 0, 0);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(245, 251, 248);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(79, 106, 92);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvRiwayat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvRiwayat.ColumnHeadersHeight = 60;
            dgvRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRiwayat.Columns.AddRange(new DataGridViewColumn[] { colWaktuR, colBarangR, colBeliR, colJualR, colOleh, colAlasan });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("Leelawadee UI", 10.5F);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(18, 55, 42);
            dataGridViewCellStyle10.Padding = new Padding(12, 0, 0, 0);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(230, 247, 238);
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(18, 55, 42);
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dgvRiwayat.DefaultCellStyle = dataGridViewCellStyle10;
            dgvRiwayat.Dock = DockStyle.Fill;
            dgvRiwayat.EnableHeadersVisualStyles = false;
            dgvRiwayat.GridColor = Color.FromArgb(230, 247, 238);
            dgvRiwayat.Location = new Point(3, 3);
            dgvRiwayat.MultiSelect = false;
            dgvRiwayat.Name = "dgvRiwayat";
            dgvRiwayat.ReadOnly = true;
            dgvRiwayat.RowHeadersVisible = false;
            dgvRiwayat.RowHeadersWidth = 51;
            dgvRiwayat.RowTemplate.Height = 56;
            dgvRiwayat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRiwayat.Size = new Size(810, 589);
            dgvRiwayat.TabIndex = 3;
            // 
            // lblCatatanLapisan
            // 
            lblCatatanLapisan.Dock = DockStyle.Bottom;
            lblCatatanLapisan.Font = new Font("Leelawadee UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCatatanLapisan.Location = new Point(3, 548);
            lblCatatanLapisan.Name = "lblCatatanLapisan";
            lblCatatanLapisan.Size = new Size(810, 44);
            lblCatatanLapisan.TabIndex = 0;
            lblCatatanLapisan.Text = "Penjualan mengambil stok dari lapisan (batch) tertua lebih dulu. Laba per unit = harga jual saat ini − harga beli lapisan itu.";
            lblCatatanLapisan.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // colKode
            // 
            colKode.FillWeight = 12F;
            colKode.HeaderText = "Kode";
            colKode.MinimumWidth = 6;
            colKode.Name = "colKode";
            colKode.ReadOnly = true;
            // 
            // colBarang
            // 
            colBarang.FillWeight = 26F;
            colBarang.HeaderText = "Barang";
            colBarang.MinimumWidth = 6;
            colBarang.Name = "colBarang";
            colBarang.ReadOnly = true;
            // 
            // colStok
            // 
            colStok.FillWeight = 9F;
            colStok.HeaderText = "Stok";
            colStok.MinimumWidth = 6;
            colStok.Name = "colStok";
            colStok.ReadOnly = true;
            // 
            // colBeliTerakhir
            // 
            colBeliTerakhir.FillWeight = 18F;
            colBeliTerakhir.HeaderText = "Harga beli terakhir";
            colBeliTerakhir.MinimumWidth = 6;
            colBeliTerakhir.Name = "colBeliTerakhir";
            colBeliTerakhir.ReadOnly = true;
            // 
            // colJual
            // 
            colJual.FillWeight = 17F;
            colJual.HeaderText = "\tHarga jual";
            colJual.MinimumWidth = 6;
            colJual.Name = "colJual";
            colJual.ReadOnly = true;
            // 
            // colLabaBaru
            // 
            colLabaBaru.FillWeight = 18F;
            colLabaBaru.HeaderText = "\tLaba/unit (terbaru)";
            colLabaBaru.MinimumWidth = 6;
            colLabaBaru.Name = "colLabaBaru";
            colLabaBaru.ReadOnly = true;
            // 
            // dgvLapisan
            // 
            dgvLapisan.AllowUserToAddRows = false;
            dgvLapisan.AllowUserToDeleteRows = false;
            dgvLapisan.AllowUserToOrderColumns = true;
            dgvLapisan.AllowUserToResizeColumns = false;
            dgvLapisan.AllowUserToResizeRows = false;
            dgvLapisan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLapisan.BackgroundColor = Color.White;
            dgvLapisan.BorderStyle = BorderStyle.None;
            dgvLapisan.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvLapisan.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(245, 251, 248);
            dataGridViewCellStyle11.Font = new Font("Leelawadee UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = Color.FromArgb(79, 106, 92);
            dataGridViewCellStyle11.Padding = new Padding(12, 0, 0, 0);
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(245, 251, 248);
            dataGridViewCellStyle11.SelectionForeColor = Color.FromArgb(79, 106, 92);
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvLapisan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgvLapisan.ColumnHeadersHeight = 60;
            dgvLapisan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvLapisan.Columns.AddRange(new DataGridViewColumn[] { colLapisan, colMasuk, colSisa, colBeli, colJualL, colLaba, colPotensi });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.White;
            dataGridViewCellStyle12.Font = new Font("Leelawadee UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = Color.FromArgb(18, 55, 42);
            dataGridViewCellStyle12.Padding = new Padding(12, 0, 0, 0);
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(230, 247, 238);
            dataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(18, 55, 42);
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dgvLapisan.DefaultCellStyle = dataGridViewCellStyle12;
            dgvLapisan.Dock = DockStyle.Fill;
            dgvLapisan.EnableHeadersVisualStyles = false;
            dgvLapisan.GridColor = Color.FromArgb(230, 247, 238);
            dgvLapisan.Location = new Point(3, 3);
            dgvLapisan.MultiSelect = false;
            dgvLapisan.Name = "dgvLapisan";
            dgvLapisan.ReadOnly = true;
            dgvLapisan.RowHeadersVisible = false;
            dgvLapisan.RowHeadersWidth = 51;
            dgvLapisan.RowTemplate.Height = 56;
            dgvLapisan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLapisan.Size = new Size(810, 545);
            dgvLapisan.TabIndex = 4;
            // 
            // colLapisan
            // 
            colLapisan.FillWeight = 26F;
            colLapisan.HeaderText = "Lapisan (barang · masuk)";
            colLapisan.MinimumWidth = 6;
            colLapisan.Name = "colLapisan";
            colLapisan.ReadOnly = true;
            // 
            // colMasuk
            // 
            colMasuk.FillWeight = 8F;
            colMasuk.HeaderText = "Masuk";
            colMasuk.MinimumWidth = 6;
            colMasuk.Name = "colMasuk";
            colMasuk.ReadOnly = true;
            // 
            // colSisa
            // 
            colSisa.FillWeight = 8F;
            colSisa.HeaderText = "Sisa";
            colSisa.MinimumWidth = 6;
            colSisa.Name = "colSisa";
            colSisa.ReadOnly = true;
            // 
            // colBeli
            // 
            colBeli.FillWeight = 15F;
            colBeli.HeaderText = "\tHarga beli";
            colBeli.MinimumWidth = 6;
            colBeli.Name = "colBeli";
            colBeli.ReadOnly = true;
            // 
            // colJualL
            // 
            colJualL.FillWeight = 15F;
            colJualL.HeaderText = "\tHarga jual";
            colJualL.MinimumWidth = 6;
            colJualL.Name = "colJualL";
            colJualL.ReadOnly = true;
            // 
            // colLaba
            // 
            colLaba.FillWeight = 16F;
            colLaba.HeaderText = "\tLaba/unit";
            colLaba.MinimumWidth = 6;
            colLaba.Name = "colLaba";
            colLaba.ReadOnly = true;
            // 
            // colPotensi
            // 
            colPotensi.FillWeight = 16F;
            colPotensi.HeaderText = "Potensi laba";
            colPotensi.MinimumWidth = 6;
            colPotensi.Name = "colPotensi";
            colPotensi.ReadOnly = true;
            // 
            // colWaktuR
            // 
            colWaktuR.FillWeight = 16F;
            colWaktuR.HeaderText = "Waktu";
            colWaktuR.MinimumWidth = 6;
            colWaktuR.Name = "colWaktuR";
            colWaktuR.ReadOnly = true;
            // 
            // colBarangR
            // 
            colBarangR.FillWeight = 22F;
            colBarangR.HeaderText = "Barang";
            colBarangR.MinimumWidth = 6;
            colBarangR.Name = "colBarangR";
            colBarangR.ReadOnly = true;
            // 
            // colBeliR
            // 
            colBeliR.FillWeight = 18F;
            colBeliR.HeaderText = "\tHarga beli (lama → baru)";
            colBeliR.MinimumWidth = 6;
            colBeliR.Name = "colBeliR";
            colBeliR.ReadOnly = true;
            // 
            // colJualR
            // 
            colJualR.FillWeight = 18F;
            colJualR.HeaderText = "Harga jual (lama → baru)";
            colJualR.MinimumWidth = 6;
            colJualR.Name = "colJualR";
            colJualR.ReadOnly = true;
            // 
            // colOleh
            // 
            colOleh.FillWeight = 12F;
            colOleh.HeaderText = "Oleh";
            colOleh.MinimumWidth = 6;
            colOleh.Name = "colOleh";
            colOleh.ReadOnly = true;
            // 
            // colAlasan
            // 
            colAlasan.FillWeight = 14F;
            colAlasan.HeaderText = "Alasan";
            colAlasan.MinimumWidth = 6;
            colAlasan.Name = "colAlasan";
            colAlasan.ReadOnly = true;
            // 
            // pnlAturDalam
            // 
            pnlAturDalam.BackColor = Color.White;
            pnlAturDalam.Controls.Add(nudJualBaru);
            pnlAturDalam.Controls.Add(lblAlasan);
            pnlAturDalam.Controls.Add(txtJualSekarang);
            pnlAturDalam.Controls.Add(txtBeliTerakhir);
            pnlAturDalam.Controls.Add(lblJualSekarang);
            pnlAturDalam.Controls.Add(lblJualBaru);
            pnlAturDalam.Controls.Add(lblBeliTerakhir);
            pnlAturDalam.Controls.Add(pnlHeaderAtur);
            pnlAturDalam.Dock = DockStyle.Fill;
            pnlAturDalam.Location = new Point(1, 1);
            pnlAturDalam.Name = "pnlAturDalam";
            pnlAturDalam.Size = new Size(338, 631);
            pnlAturDalam.TabIndex = 0;
            // 
            // pnlHeaderAtur
            // 
            pnlHeaderAtur.Angle = 45F;
            pnlHeaderAtur.ColorBottom = Color.FromArgb(152, 232, 193);
            pnlHeaderAtur.ColorTop = Color.FromArgb(42, 127, 80);
            pnlHeaderAtur.Controls.Add(lblJudulAtur);
            pnlHeaderAtur.Dock = DockStyle.Top;
            pnlHeaderAtur.Location = new Point(0, 0);
            pnlHeaderAtur.Name = "pnlHeaderAtur";
            pnlHeaderAtur.Size = new Size(338, 84);
            pnlHeaderAtur.TabIndex = 0;
            // 
            // lblJudulAtur
            // 
            lblJudulAtur.AutoSize = true;
            lblJudulAtur.BackColor = Color.Transparent;
            lblJudulAtur.Font = new Font("Leelawadee UI", 13.5F, FontStyle.Bold);
            lblJudulAtur.ForeColor = Color.FromArgb(14, 47, 34);
            lblJudulAtur.Location = new Point(20, 16);
            lblJudulAtur.Name = "lblJudulAtur";
            lblJudulAtur.Size = new Size(133, 31);
            lblJudulAtur.TabIndex = 0;
            lblJudulAtur.Text = "Atur Harga";
            // 
            // lblBeliTerakhir
            // 
            lblBeliTerakhir.AutoSize = true;
            lblBeliTerakhir.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBeliTerakhir.ForeColor = Color.FromArgb(79, 106, 92);
            lblBeliTerakhir.Location = new Point(20, 104);
            lblBeliTerakhir.Name = "lblBeliTerakhir";
            lblBeliTerakhir.Size = new Size(139, 20);
            lblBeliTerakhir.TabIndex = 1;
            lblBeliTerakhir.Text = "Harga beli terakhir";
            // 
            // lblJualBaru
            // 
            lblJualBaru.AutoSize = true;
            lblJualBaru.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJualBaru.ForeColor = Color.FromArgb(79, 106, 92);
            lblJualBaru.Location = new Point(20, 232);
            lblJualBaru.Name = "lblJualBaru";
            lblJualBaru.Size = new Size(116, 20);
            lblJualBaru.TabIndex = 2;
            lblJualBaru.Text = "Harga jual baru";
            // 
            // lblJualSekarang
            // 
            lblJualSekarang.AutoSize = true;
            lblJualSekarang.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJualSekarang.ForeColor = Color.FromArgb(79, 106, 92);
            lblJualSekarang.Location = new Point(20, 168);
            lblJualSekarang.Name = "lblJualSekarang";
            lblJualSekarang.Size = new Size(134, 20);
            lblJualSekarang.TabIndex = 4;
            lblJualSekarang.Text = "Harga jual saat ini\t";
            // 
            // txtBeliTerakhir
            // 
            txtBeliTerakhir.BackColor = Color.FromArgb(245, 251, 248);
            txtBeliTerakhir.BorderStyle = BorderStyle.FixedSingle;
            txtBeliTerakhir.Font = new Font("Leelawadee UI", 11F);
            txtBeliTerakhir.ForeColor = Color.FromArgb(79, 106, 92);
            txtBeliTerakhir.Location = new Point(20, 126);
            txtBeliTerakhir.Name = "txtBeliTerakhir";
            txtBeliTerakhir.ReadOnly = true;
            txtBeliTerakhir.Size = new Size(298, 32);
            txtBeliTerakhir.TabIndex = 5;
            // 
            // txtJualSekarang
            // 
            txtJualSekarang.BackColor = Color.FromArgb(245, 251, 248);
            txtJualSekarang.BorderStyle = BorderStyle.FixedSingle;
            txtJualSekarang.Font = new Font("Leelawadee UI", 11F);
            txtJualSekarang.ForeColor = Color.FromArgb(79, 106, 92);
            txtJualSekarang.Location = new Point(20, 190);
            txtJualSekarang.Name = "txtJualSekarang";
            txtJualSekarang.ReadOnly = true;
            txtJualSekarang.Size = new Size(298, 32);
            txtJualSekarang.TabIndex = 6;
            // 
            // lblAlasan
            // 
            lblAlasan.AutoSize = true;
            lblAlasan.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlasan.ForeColor = Color.FromArgb(79, 106, 92);
            lblAlasan.Location = new Point(20, 296);
            lblAlasan.Name = "lblAlasan";
            lblAlasan.Size = new Size(135, 20);
            lblAlasan.TabIndex = 7;
            lblAlasan.Text = "Alasan perubahan";
            // 
            // nudJualBaru
            // 
            nudJualBaru.Increment = new decimal(new int[] { 500, 0, 0, 0 });
            nudJualBaru.Location = new Point(69, 392);
            nudJualBaru.Maximum = new decimal(new int[] { -1530494976, 232830, 0, 0 });
            nudJualBaru.Name = "nudJualBaru";
            nudJualBaru.Size = new Size(298, 31);
            nudJualBaru.TabIndex = 8;
            nudJualBaru.ThousandsSeparator = true;
            // 
            // ucLaba
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 251, 248);
            Controls.Add(pnlPage);
            Font = new Font("Leelawadee UI", 10.5F);
            ForeColor = SystemColors.ControlText;
            Name = "ucLaba";
            Size = new Size(1238, 805);
            pnlPage.ResumeLayout(false);
            tlpKartu.ResumeLayout(false);
            pnlBawah.ResumeLayout(false);
            pnlKartuModal.ResumeLayout(false);
            pnlKartuModal.PerformLayout();
            pnlKartuPotensi.ResumeLayout(false);
            pnlKartuNaik.ResumeLayout(false);
            pnlKartuMargin.ResumeLayout(false);
            pnlKartuPotensiDalam.ResumeLayout(false);
            pnlKartuPotensiDalam.PerformLayout();
            pnlKartuNaikDalam.ResumeLayout(false);
            pnlKartuNaikDalam.PerformLayout();
            PnlKartuMarginDalam.ResumeLayout(false);
            PnlKartuMarginDalam.PerformLayout();
            pnlAturLuar.ResumeLayout(false);
            pnlKartuTabel.ResumeLayout(false);
            pnlKartuTabelDalam.ResumeLayout(false);
            tabUtama.ResumeLayout(false);
            tabDaftar.ResumeLayout(false);
            tabLapisan.ResumeLayout(false);
            tabRiwayat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDaftar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLapisan).EndInit();
            pnlAturDalam.ResumeLayout(false);
            pnlAturDalam.PerformLayout();
            pnlHeaderAtur.ResumeLayout(false);
            pnlHeaderAtur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudJualBaru).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPage;
        private TableLayoutPanel tlpKartu;
        private Panel pnlBawah;
        private Panel pnlJarak;
        private Panel pnlKartuMargin;
        private Panel pnlKartuNaik;
        private GradientPanel pnlKartuModal;
        private Panel pnlKartuPotensi;
        private Panel PnlKartuMarginDalam;
        private Panel pnlKartuNaikDalam;
        private Label lblModalJudul;
        private Panel pnlKartuPotensiDalam;
        private Label lblMarginJudul;
        private Label lblNaikDalam;
        private Label lblModal;
        private Label lblPotensiJudul;
        private Label lblMargin;
        private Label lblNaik;
        private Label lblPotensi;
        private Panel pnlAturLuar;
        private Panel pnlKartuTabel;
        private Panel pnlKartuTabelDalam;
        private Panel pnlGap;
        private TabControl tabUtama;
        private TabPage tabDaftar;
        private TabPage tabLapisan;
        private TabPage tabRiwayat;
        private DataGridView dgvDaftar;
        private Label lblCatatanLapisan;
        private DataGridView dgvRiwayat;
        private DataGridViewTextBoxColumn colKode;
        private DataGridViewTextBoxColumn colBarang;
        private DataGridViewTextBoxColumn colStok;
        private DataGridViewTextBoxColumn colBeliTerakhir;
        private DataGridViewTextBoxColumn colJual;
        private DataGridViewTextBoxColumn colLabaBaru;
        private DataGridView dgvLapisan;
        private DataGridViewTextBoxColumn colLapisan;
        private DataGridViewTextBoxColumn colMasuk;
        private DataGridViewTextBoxColumn colSisa;
        private DataGridViewTextBoxColumn colBeli;
        private DataGridViewTextBoxColumn colJualL;
        private DataGridViewTextBoxColumn colLaba;
        private DataGridViewTextBoxColumn colPotensi;
        private DataGridViewTextBoxColumn colWaktuR;
        private DataGridViewTextBoxColumn colBarangR;
        private DataGridViewTextBoxColumn colBeliR;
        private DataGridViewTextBoxColumn colJualR;
        private DataGridViewTextBoxColumn colOleh;
        private DataGridViewTextBoxColumn colAlasan;
        private Panel pnlAturDalam;
        private GradientPanel pnlHeaderAtur;
        private Label lblJudulAtur;
        private Label lblJualSekarang;
        private Label lblJualBaru;
        private Label lblBeliTerakhir;
        private TextBox txtJualSekarang;
        private TextBox txtBeliTerakhir;
        private NumericUpDown nudJualBaru;
        private Label lblAlasan;
    }
}
