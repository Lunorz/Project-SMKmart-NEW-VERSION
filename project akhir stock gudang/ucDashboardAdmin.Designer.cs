namespace project_akhir_stock_gudang
{
    partial class ucDashboardAdmin
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
            pnlPage = new Panel();
            pnlKartuTabel = new Panel();
            pnlKartuTabelDalam = new Panel();
            dgvTransaksi = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colWaktu = new DataGridViewTextBoxColumn();
            colKasir = new DataGridViewTextBoxColumn();
            colItem = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            pnlJudulTransaksi = new Panel();
            btnLihatLaporan = new Button();
            lblTransaksiJudulTerbaru = new Label();
            pnlGap = new Panel();
            pnlKanan = new Panel();
            pnlAktivitasLuar = new Panel();
            pnllAktivitasDalam = new Panel();
            lstAktivitas = new ListBox();
            lblAktivitas = new Label();
            pnlJarakKanan = new Panel();
            tlpKartu = new TableLayoutPanel();
            pnlKartuJual = new GradientPanel();
            lblJual = new Label();
            lblJualJudul = new Label();
            pnlKartuTrx = new Panel();
            pnlKartuTrxDalam = new Panel();
            lblTrx = new Label();
            lblTrxJudul = new Label();
            pnlKartuUser = new Panel();
            pnlKartuUserDalam = new Panel();
            lblUser = new Label();
            lblUserJudul = new Label();
            pnlKartuStok = new Panel();
            pnlKartuStokDalam = new Panel();
            lblStok = new Label();
            lblStokJudul = new Label();
            pnlPage.SuspendLayout();
            pnlKartuTabel.SuspendLayout();
            pnlKartuTabelDalam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransaksi).BeginInit();
            pnlJudulTransaksi.SuspendLayout();
            pnlKanan.SuspendLayout();
            pnlAktivitasLuar.SuspendLayout();
            pnllAktivitasDalam.SuspendLayout();
            tlpKartu.SuspendLayout();
            pnlKartuJual.SuspendLayout();
            pnlKartuTrx.SuspendLayout();
            pnlKartuTrxDalam.SuspendLayout();
            pnlKartuUser.SuspendLayout();
            pnlKartuUserDalam.SuspendLayout();
            pnlKartuStok.SuspendLayout();
            pnlKartuStokDalam.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPage
            // 
            pnlPage.Controls.Add(pnlKartuTabel);
            pnlPage.Controls.Add(pnlGap);
            pnlPage.Controls.Add(pnlKanan);
            pnlPage.Controls.Add(tlpKartu);
            pnlPage.Dock = DockStyle.Fill;
            pnlPage.Location = new Point(0, 0);
            pnlPage.Name = "pnlPage";
            pnlPage.Padding = new Padding(28, 29, 28, 29);
            pnlPage.Size = new Size(1320, 840);
            pnlPage.TabIndex = 0;
            // 
            // pnlKartuTabel
            // 
            pnlKartuTabel.BackColor = Color.FromArgb(213, 235, 223);
            pnlKartuTabel.Controls.Add(pnlKartuTabelDalam);
            pnlKartuTabel.Dock = DockStyle.Fill;
            pnlKartuTabel.Location = new Point(28, 129);
            pnlKartuTabel.Name = "pnlKartuTabel";
            pnlKartuTabel.Padding = new Padding(1);
            pnlKartuTabel.Size = new Size(900, 682);
            pnlKartuTabel.TabIndex = 3;
            // 
            // pnlKartuTabelDalam
            // 
            pnlKartuTabelDalam.BackColor = Color.White;
            pnlKartuTabelDalam.Controls.Add(dgvTransaksi);
            pnlKartuTabelDalam.Controls.Add(pnlJudulTransaksi);
            pnlKartuTabelDalam.Dock = DockStyle.Fill;
            pnlKartuTabelDalam.Location = new Point(1, 1);
            pnlKartuTabelDalam.Name = "pnlKartuTabelDalam";
            pnlKartuTabelDalam.Size = new Size(898, 680);
            pnlKartuTabelDalam.TabIndex = 0;
            // 
            // dgvTransaksi
            // 
            dgvTransaksi.AllowUserToAddRows = false;
            dgvTransaksi.AllowUserToDeleteRows = false;
            dgvTransaksi.AllowUserToResizeColumns = false;
            dgvTransaksi.AllowUserToResizeRows = false;
            dgvTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransaksi.BackgroundColor = Color.White;
            dgvTransaksi.BorderStyle = BorderStyle.None;
            dgvTransaksi.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTransaksi.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 251, 248);
            dataGridViewCellStyle1.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(79, 106, 92);
            dataGridViewCellStyle1.Padding = new Padding(12, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(245, 251, 248);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(79, 106, 92);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTransaksi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTransaksi.ColumnHeadersHeight = 40;
            dgvTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTransaksi.Columns.AddRange(new DataGridViewColumn[] { colNo, colWaktu, colKasir, colItem, colTotal });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Leelawadee UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(18, 55, 42);
            dataGridViewCellStyle2.Padding = new Padding(12, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(230, 247, 238);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(18, 55, 42);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTransaksi.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTransaksi.Dock = DockStyle.Fill;
            dgvTransaksi.EnableHeadersVisualStyles = false;
            dgvTransaksi.GridColor = Color.FromArgb(230, 247, 238);
            dgvTransaksi.Location = new Point(0, 52);
            dgvTransaksi.MultiSelect = false;
            dgvTransaksi.Name = "dgvTransaksi";
            dgvTransaksi.ReadOnly = true;
            dgvTransaksi.RowHeadersVisible = false;
            dgvTransaksi.RowHeadersWidth = 51;
            dgvTransaksi.RowTemplate.Height = 56;
            dgvTransaksi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransaksi.Size = new Size(898, 628);
            dgvTransaksi.TabIndex = 1;
            // 
            // colNo
            // 
            colNo.FillWeight = 20F;
            colNo.HeaderText = "\tNo. Transaksi";
            colNo.MinimumWidth = 6;
            colNo.Name = "colNo";
            colNo.ReadOnly = true;
            // 
            // colWaktu
            // 
            colWaktu.FillWeight = 24F;
            colWaktu.HeaderText = "Waktu";
            colWaktu.MinimumWidth = 6;
            colWaktu.Name = "colWaktu";
            colWaktu.ReadOnly = true;
            // 
            // colKasir
            // 
            colKasir.FillWeight = 22F;
            colKasir.HeaderText = "Kasir";
            colKasir.MinimumWidth = 6;
            colKasir.Name = "colKasir";
            colKasir.ReadOnly = true;
            // 
            // colItem
            // 
            colItem.FillWeight = 10F;
            colItem.HeaderText = "Item";
            colItem.MinimumWidth = 6;
            colItem.Name = "colItem";
            colItem.ReadOnly = true;
            // 
            // colTotal
            // 
            colTotal.FillWeight = 22F;
            colTotal.HeaderText = "total";
            colTotal.MinimumWidth = 6;
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            // 
            // pnlJudulTransaksi
            // 
            pnlJudulTransaksi.Controls.Add(btnLihatLaporan);
            pnlJudulTransaksi.Controls.Add(lblTransaksiJudulTerbaru);
            pnlJudulTransaksi.Dock = DockStyle.Top;
            pnlJudulTransaksi.Location = new Point(0, 0);
            pnlJudulTransaksi.Name = "pnlJudulTransaksi";
            pnlJudulTransaksi.Size = new Size(898, 52);
            pnlJudulTransaksi.TabIndex = 0;
            // 
            // btnLihatLaporan
            // 
            btnLihatLaporan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLihatLaporan.BackColor = Color.FromArgb(230, 247, 238);
            btnLihatLaporan.FlatAppearance.BorderColor = Color.FromArgb(213, 235, 22);
            btnLihatLaporan.FlatStyle = FlatStyle.Flat;
            btnLihatLaporan.Font = new Font("Leelawadee UI", 10F);
            btnLihatLaporan.ForeColor = Color.FromArgb(31, 107, 66);
            btnLihatLaporan.Location = new Point(556, 10);
            btnLihatLaporan.Name = "btnLihatLaporan";
            btnLihatLaporan.Size = new Size(120, 32);
            btnLihatLaporan.TabIndex = 1;
            btnLihatLaporan.Text = "Lihat laporan";
            btnLihatLaporan.UseVisualStyleBackColor = false;
            btnLihatLaporan.Click += btnLihatLaporan_Click;
            // 
            // lblTransaksiJudulTerbaru
            // 
            lblTransaksiJudulTerbaru.AutoSize = true;
            lblTransaksiJudulTerbaru.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTransaksiJudulTerbaru.ForeColor = Color.FromArgb(18, 55, 42);
            lblTransaksiJudulTerbaru.Location = new Point(16, 14);
            lblTransaksiJudulTerbaru.Name = "lblTransaksiJudulTerbaru";
            lblTransaksiJudulTerbaru.Size = new Size(180, 28);
            lblTransaksiJudulTerbaru.TabIndex = 0;
            lblTransaksiJudulTerbaru.Text = "Transaksi Terbaru";
            // 
            // pnlGap
            // 
            pnlGap.Dock = DockStyle.Right;
            pnlGap.Location = new Point(928, 129);
            pnlGap.Name = "pnlGap";
            pnlGap.Size = new Size(24, 682);
            pnlGap.TabIndex = 2;
            // 
            // pnlKanan
            // 
            pnlKanan.Controls.Add(pnlAktivitasLuar);
            pnlKanan.Controls.Add(pnlJarakKanan);
            pnlKanan.Dock = DockStyle.Right;
            pnlKanan.Location = new Point(952, 129);
            pnlKanan.Name = "pnlKanan";
            pnlKanan.Size = new Size(340, 682);
            pnlKanan.TabIndex = 1;
            // 
            // pnlAktivitasLuar
            // 
            pnlAktivitasLuar.BackColor = Color.FromArgb(213, 235, 223);
            pnlAktivitasLuar.Controls.Add(pnllAktivitasDalam);
            pnlAktivitasLuar.Dock = DockStyle.Fill;
            pnlAktivitasLuar.Location = new Point(0, 16);
            pnlAktivitasLuar.Name = "pnlAktivitasLuar";
            pnlAktivitasLuar.Padding = new Padding(1);
            pnlAktivitasLuar.Size = new Size(340, 666);
            pnlAktivitasLuar.TabIndex = 2;
            // 
            // pnllAktivitasDalam
            // 
            pnllAktivitasDalam.BackColor = Color.White;
            pnllAktivitasDalam.Controls.Add(lstAktivitas);
            pnllAktivitasDalam.Controls.Add(lblAktivitas);
            pnllAktivitasDalam.Dock = DockStyle.Fill;
            pnllAktivitasDalam.Location = new Point(1, 1);
            pnllAktivitasDalam.Name = "pnllAktivitasDalam";
            pnllAktivitasDalam.Padding = new Padding(12, 0, 12, 12);
            pnllAktivitasDalam.Size = new Size(338, 664);
            pnllAktivitasDalam.TabIndex = 0;
            // 
            // lstAktivitas
            // 
            lstAktivitas.BackColor = Color.White;
            lstAktivitas.BorderStyle = BorderStyle.None;
            lstAktivitas.Dock = DockStyle.Fill;
            lstAktivitas.ForeColor = Color.FromArgb(18, 55, 42);
            lstAktivitas.FormattingEnabled = true;
            lstAktivitas.IntegralHeight = false;
            lstAktivitas.ItemHeight = 23;
            lstAktivitas.Location = new Point(12, 40);
            lstAktivitas.Name = "lstAktivitas";
            lstAktivitas.SelectionMode = SelectionMode.None;
            lstAktivitas.Size = new Size(314, 612);
            lstAktivitas.TabIndex = 1;
            // 
            // lblAktivitas
            // 
            lblAktivitas.Dock = DockStyle.Top;
            lblAktivitas.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAktivitas.Location = new Point(12, 0);
            lblAktivitas.Name = "lblAktivitas";
            lblAktivitas.Size = new Size(314, 40);
            lblAktivitas.TabIndex = 0;
            lblAktivitas.Text = "Aktivitas Gudang Terbaru";
            lblAktivitas.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlJarakKanan
            // 
            pnlJarakKanan.Dock = DockStyle.Top;
            pnlJarakKanan.Location = new Point(0, 0);
            pnlJarakKanan.Name = "pnlJarakKanan";
            pnlJarakKanan.Size = new Size(340, 16);
            pnlJarakKanan.TabIndex = 1;
            // 
            // tlpKartu
            // 
            tlpKartu.BackColor = Color.Transparent;
            tlpKartu.ColumnCount = 4;
            tlpKartu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpKartu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpKartu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpKartu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpKartu.Controls.Add(pnlKartuJual, 0, 0);
            tlpKartu.Controls.Add(pnlKartuTrx, 1, 0);
            tlpKartu.Controls.Add(pnlKartuUser, 2, 0);
            tlpKartu.Controls.Add(pnlKartuStok, 3, 0);
            tlpKartu.Dock = DockStyle.Top;
            tlpKartu.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tlpKartu.Location = new Point(28, 29);
            tlpKartu.Name = "tlpKartu";
            tlpKartu.RowCount = 1;
            tlpKartu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpKartu.Size = new Size(1264, 100);
            tlpKartu.TabIndex = 0;
            // 
            // pnlKartuJual
            // 
            pnlKartuJual.Angle = 45F;
            pnlKartuJual.BackColor = Color.FromArgb(31, 107, 66);
            pnlKartuJual.ColorBottom = Color.FromArgb(62, 156, 106);
            pnlKartuJual.ColorTop = Color.FromArgb(31, 107, 66);
            pnlKartuJual.Controls.Add(lblJual);
            pnlKartuJual.Controls.Add(lblJualJudul);
            pnlKartuJual.Dock = DockStyle.Fill;
            pnlKartuJual.Location = new Point(0, 0);
            pnlKartuJual.Margin = new Padding(0, 0, 16, 0);
            pnlKartuJual.Name = "pnlKartuJual";
            pnlKartuJual.Size = new Size(300, 100);
            pnlKartuJual.TabIndex = 0;
            // 
            // lblJual
            // 
            lblJual.AutoSize = true;
            lblJual.BackColor = Color.Transparent;
            lblJual.Font = new Font("Leelawadee UI", 21F, FontStyle.Bold);
            lblJual.ForeColor = Color.White;
            lblJual.Location = new Point(20, 42);
            lblJual.Name = "lblJual";
            lblJual.Size = new Size(40, 47);
            lblJual.TabIndex = 1;
            lblJual.Text = "0";
            // 
            // lblJualJudul
            // 
            lblJualJudul.AutoSize = true;
            lblJualJudul.BackColor = Color.Transparent;
            lblJualJudul.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJualJudul.ForeColor = Color.White;
            lblJualJudul.Location = new Point(20, 18);
            lblJualJudul.Name = "lblJualJudul";
            lblJualJudul.Size = new Size(132, 20);
            lblJualJudul.TabIndex = 0;
            lblJualJudul.Text = "Penjualan Hari Ini\t";
            // 
            // pnlKartuTrx
            // 
            pnlKartuTrx.BackColor = Color.FromArgb(213, 235, 223);
            pnlKartuTrx.Controls.Add(pnlKartuTrxDalam);
            pnlKartuTrx.Dock = DockStyle.Fill;
            pnlKartuTrx.Location = new Point(316, 0);
            pnlKartuTrx.Margin = new Padding(0, 0, 16, 0);
            pnlKartuTrx.Name = "pnlKartuTrx";
            pnlKartuTrx.Padding = new Padding(1);
            pnlKartuTrx.Size = new Size(300, 100);
            pnlKartuTrx.TabIndex = 1;
            // 
            // pnlKartuTrxDalam
            // 
            pnlKartuTrxDalam.BackColor = Color.White;
            pnlKartuTrxDalam.Controls.Add(lblTrx);
            pnlKartuTrxDalam.Controls.Add(lblTrxJudul);
            pnlKartuTrxDalam.Dock = DockStyle.Fill;
            pnlKartuTrxDalam.Location = new Point(1, 1);
            pnlKartuTrxDalam.Name = "pnlKartuTrxDalam";
            pnlKartuTrxDalam.Size = new Size(298, 98);
            pnlKartuTrxDalam.TabIndex = 2;
            // 
            // lblTrx
            // 
            lblTrx.AutoSize = true;
            lblTrx.BackColor = Color.Transparent;
            lblTrx.Font = new Font("Leelawadee UI", 21F, FontStyle.Bold);
            lblTrx.Location = new Point(20, 42);
            lblTrx.Name = "lblTrx";
            lblTrx.Size = new Size(40, 47);
            lblTrx.TabIndex = 2;
            lblTrx.Text = "0";
            // 
            // lblTrxJudul
            // 
            lblTrxJudul.AutoSize = true;
            lblTrxJudul.BackColor = Color.Transparent;
            lblTrxJudul.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrxJudul.Location = new Point(20, 18);
            lblTrxJudul.Name = "lblTrxJudul";
            lblTrxJudul.Size = new Size(130, 20);
            lblTrxJudul.TabIndex = 1;
            lblTrxJudul.Text = "Transaksi Hari Ini";
            // 
            // pnlKartuUser
            // 
            pnlKartuUser.BackColor = Color.FromArgb(213, 235, 223);
            pnlKartuUser.Controls.Add(pnlKartuUserDalam);
            pnlKartuUser.Dock = DockStyle.Fill;
            pnlKartuUser.Location = new Point(632, 0);
            pnlKartuUser.Margin = new Padding(0, 0, 16, 0);
            pnlKartuUser.Name = "pnlKartuUser";
            pnlKartuUser.Padding = new Padding(1);
            pnlKartuUser.Size = new Size(300, 100);
            pnlKartuUser.TabIndex = 2;
            // 
            // pnlKartuUserDalam
            // 
            pnlKartuUserDalam.BackColor = Color.White;
            pnlKartuUserDalam.Controls.Add(lblUser);
            pnlKartuUserDalam.Controls.Add(lblUserJudul);
            pnlKartuUserDalam.Dock = DockStyle.Fill;
            pnlKartuUserDalam.Location = new Point(1, 1);
            pnlKartuUserDalam.Name = "pnlKartuUserDalam";
            pnlKartuUserDalam.Size = new Size(298, 98);
            pnlKartuUserDalam.TabIndex = 0;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.Transparent;
            lblUser.Font = new Font("Leelawadee UI", 21F, FontStyle.Bold);
            lblUser.Location = new Point(20, 42);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(40, 47);
            lblUser.TabIndex = 2;
            lblUser.Text = "0";
            // 
            // lblUserJudul
            // 
            lblUserJudul.AutoSize = true;
            lblUserJudul.BackColor = Color.Transparent;
            lblUserJudul.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserJudul.Location = new Point(20, 18);
            lblUserJudul.Name = "lblUserJudul";
            lblUserJudul.Size = new Size(172, 20);
            lblUserJudul.TabIndex = 1;
            lblUserJudul.Text = "Menunggu Persetujuan";
            // 
            // pnlKartuStok
            // 
            pnlKartuStok.BackColor = Color.FromArgb(213, 235, 223);
            pnlKartuStok.Controls.Add(pnlKartuStokDalam);
            pnlKartuStok.Dock = DockStyle.Fill;
            pnlKartuStok.Location = new Point(951, 3);
            pnlKartuStok.Name = "pnlKartuStok";
            pnlKartuStok.Padding = new Padding(1);
            pnlKartuStok.Size = new Size(310, 94);
            pnlKartuStok.TabIndex = 3;
            // 
            // pnlKartuStokDalam
            // 
            pnlKartuStokDalam.BackColor = Color.White;
            pnlKartuStokDalam.Controls.Add(lblStok);
            pnlKartuStokDalam.Controls.Add(lblStokJudul);
            pnlKartuStokDalam.Dock = DockStyle.Fill;
            pnlKartuStokDalam.Location = new Point(1, 1);
            pnlKartuStokDalam.Name = "pnlKartuStokDalam";
            pnlKartuStokDalam.Size = new Size(308, 92);
            pnlKartuStokDalam.TabIndex = 0;
            // 
            // lblStok
            // 
            lblStok.AutoSize = true;
            lblStok.BackColor = Color.Transparent;
            lblStok.Font = new Font("Leelawadee UI", 21F, FontStyle.Bold);
            lblStok.Location = new Point(20, 42);
            lblStok.Name = "lblStok";
            lblStok.Size = new Size(40, 47);
            lblStok.TabIndex = 2;
            lblStok.Text = "0";
            // 
            // lblStokJudul
            // 
            lblStokJudul.AutoSize = true;
            lblStokJudul.BackColor = Color.Transparent;
            lblStokJudul.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStokJudul.Location = new Point(20, 18);
            lblStokJudul.Name = "lblStokJudul";
            lblStokJudul.Size = new Size(99, 20);
            lblStokJudul.TabIndex = 1;
            lblStokJudul.Text = "Stok Menipis\t";
            // 
            // ucDashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 251, 248);
            Controls.Add(pnlPage);
            Font = new Font("Leelawadee UI", 10.5F);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ucDashboardAdmin";
            Size = new Size(1320, 840);
            pnlPage.ResumeLayout(false);
            pnlKartuTabel.ResumeLayout(false);
            pnlKartuTabelDalam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTransaksi).EndInit();
            pnlJudulTransaksi.ResumeLayout(false);
            pnlJudulTransaksi.PerformLayout();
            pnlKanan.ResumeLayout(false);
            pnlAktivitasLuar.ResumeLayout(false);
            pnllAktivitasDalam.ResumeLayout(false);
            tlpKartu.ResumeLayout(false);
            pnlKartuJual.ResumeLayout(false);
            pnlKartuJual.PerformLayout();
            pnlKartuTrx.ResumeLayout(false);
            pnlKartuTrxDalam.ResumeLayout(false);
            pnlKartuTrxDalam.PerformLayout();
            pnlKartuUser.ResumeLayout(false);
            pnlKartuUserDalam.ResumeLayout(false);
            pnlKartuUserDalam.PerformLayout();
            pnlKartuStok.ResumeLayout(false);
            pnlKartuStokDalam.ResumeLayout(false);
            pnlKartuStokDalam.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPage;
        private TableLayoutPanel tlpKartu;
        private GradientPanel pnlKartuJual;
        private Panel pnlKartuTrx;
        private Panel pnlKartuUser;
        private Panel pnlKartuTrxDalam;
        private Panel pnlKartuUserDalam;
        private Panel pnlKartuStok;
        private Panel pnlKartuStokDalam;
        private Label lblJual;
        private Label lblJualJudul;
        private Label lblTrx;
        private Label lblTrxJudul;
        private Label lblUser;
        private Label lblUserJudul;
        private Label lblStok;
        private Label lblStokJudul;
        private Panel pnlGap;
        private Panel pnlKanan;
        private Panel pnlKartuTabel;
        private Panel pnlKartuTabelDalam;
        private Panel pnlJudulTransaksi;
        private Label lblTransaksiJudulTerbaru;
        private DataGridView dgvTransaksi;
        private Button btnLihatLaporan;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colWaktu;
        private DataGridViewTextBoxColumn colKasir;
        private DataGridViewTextBoxColumn colItem;
        private DataGridViewTextBoxColumn colTotal;
        private Panel pnlAktivitasLuar;
        private Panel pnlJarakKanan;
        private Panel pnllAktivitasDalam;
        private ListBox lstAktivitas;
        private Label lblAktivitas;
    }
}
