namespace project_akhir_stock_gudang
{
    partial class ucLogAktivitas
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
            pnlBawah = new Panel();
            pnlKartuTabel = new Panel();
            pnlKartuTabelDalam = new Panel();
            dgvLog = new DataGridView();
            colWaktu = new DataGridViewTextBoxColumn();
            colPengguna = new DataGridViewTextBoxColumn();
            colRole = new DataGridViewTextBoxColumn();
            colKategori = new DataGridViewTextBoxColumn();
            colAktivitas = new DataGridViewTextBoxColumn();
            colTarget = new DataGridViewTextBoxColumn();
            pnlGap = new Panel();
            pnlDetailLuar = new Panel();
            PnlDetailDalam = new Panel();
            txtAktivitasD = new TextBox();
            txtKeteranganD = new TextBox();
            txtKategoriD = new TextBox();
            txtRoleD = new TextBox();
            txtPenggunaD = new TextBox();
            txtWaktuD = new TextBox();
            lblCatatanD = new Label();
            lblKeteranganD = new Label();
            lblKategoriD = new Label();
            lblPenggunaD = new Label();
            lblAktivitas = new Label();
            lblRoleD = new Label();
            lblWaktuD = new Label();
            pnlHeaderDetai = new Panel();
            lblJudulD = new Label();
            pnlJarak2 = new Panel();
            pnlFilterLuar = new Panel();
            pnlFilterDalam = new Panel();
            txtCari = new TextBox();
            cmbKategori = new ComboBox();
            cmbRole = new ComboBox();
            dtpSampai = new DateTimePicker();
            dtpDari = new DateTimePicker();
            lblRole = new Label();
            lblKategori = new Label();
            lblCari = new Label();
            lblSampai = new Label();
            lblDari = new Label();
            pnlJarak = new Panel();
            tlpKartu = new TableLayoutPanel();
            pnlKartuUbah = new Panel();
            pnlKartuUbahDalam = new Panel();
            lblUbah = new Label();
            lblUbahJudul = new Label();
            pnlKartuGagal = new Panel();
            pnlKartuGagalDalam = new Panel();
            lblGagal = new Label();
            lblGagalJudul = new Label();
            pnlKartuTotal = new GradientPanel();
            lblTotal = new Label();
            lblTotalJudul = new Label();
            pnlKartuLogin = new Panel();
            pnlKartuLoginDalam = new Panel();
            lblLogin = new Label();
            lblLoginJudul = new Label();
            pnlPage.SuspendLayout();
            pnlBawah.SuspendLayout();
            pnlKartuTabel.SuspendLayout();
            pnlKartuTabelDalam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLog).BeginInit();
            pnlDetailLuar.SuspendLayout();
            PnlDetailDalam.SuspendLayout();
            pnlHeaderDetai.SuspendLayout();
            pnlFilterLuar.SuspendLayout();
            pnlFilterDalam.SuspendLayout();
            tlpKartu.SuspendLayout();
            pnlKartuUbah.SuspendLayout();
            pnlKartuUbahDalam.SuspendLayout();
            pnlKartuGagal.SuspendLayout();
            pnlKartuGagalDalam.SuspendLayout();
            pnlKartuTotal.SuspendLayout();
            pnlKartuLogin.SuspendLayout();
            pnlKartuLoginDalam.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPage
            // 
            pnlPage.Controls.Add(pnlBawah);
            pnlPage.Controls.Add(pnlJarak2);
            pnlPage.Controls.Add(pnlFilterLuar);
            pnlPage.Controls.Add(pnlJarak);
            pnlPage.Controls.Add(tlpKartu);
            pnlPage.Dock = DockStyle.Fill;
            pnlPage.Location = new Point(0, 0);
            pnlPage.Name = "pnlPage";
            pnlPage.Padding = new Padding(24);
            pnlPage.Size = new Size(1100, 700);
            pnlPage.TabIndex = 0;
            // 
            // pnlBawah
            // 
            pnlBawah.Controls.Add(pnlKartuTabel);
            pnlBawah.Controls.Add(pnlGap);
            pnlBawah.Controls.Add(pnlDetailLuar);
            pnlBawah.Dock = DockStyle.Fill;
            pnlBawah.Location = new Point(24, 248);
            pnlBawah.Name = "pnlBawah";
            pnlBawah.Size = new Size(1052, 428);
            pnlBawah.TabIndex = 4;
            // 
            // pnlKartuTabel
            // 
            pnlKartuTabel.BackColor = Color.FromArgb(213, 235, 223);
            pnlKartuTabel.Controls.Add(pnlKartuTabelDalam);
            pnlKartuTabel.Dock = DockStyle.Fill;
            pnlKartuTabel.Location = new Point(0, 0);
            pnlKartuTabel.Name = "pnlKartuTabel";
            pnlKartuTabel.Padding = new Padding(1);
            pnlKartuTabel.Size = new Size(688, 428);
            pnlKartuTabel.TabIndex = 2;
            // 
            // pnlKartuTabelDalam
            // 
            pnlKartuTabelDalam.BackColor = Color.White;
            pnlKartuTabelDalam.Controls.Add(dgvLog);
            pnlKartuTabelDalam.Dock = DockStyle.Fill;
            pnlKartuTabelDalam.Location = new Point(1, 1);
            pnlKartuTabelDalam.Name = "pnlKartuTabelDalam";
            pnlKartuTabelDalam.Size = new Size(686, 426);
            pnlKartuTabelDalam.TabIndex = 0;
            // 
            // dgvLog
            // 
            dgvLog.AllowUserToAddRows = false;
            dgvLog.AllowUserToDeleteRows = false;
            dgvLog.AllowUserToResizeColumns = false;
            dgvLog.AllowUserToResizeRows = false;
            dgvLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLog.BackgroundColor = Color.White;
            dgvLog.BorderStyle = BorderStyle.None;
            dgvLog.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvLog.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 251, 248);
            dataGridViewCellStyle1.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(79, 106, 92);
            dataGridViewCellStyle1.Padding = new Padding(12, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(245, 251, 248);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(79, 106, 92);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLog.ColumnHeadersHeight = 40;
            dgvLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvLog.Columns.AddRange(new DataGridViewColumn[] { colWaktu, colPengguna, colRole, colKategori, colAktivitas, colTarget });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Leelawadee UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(18, 55, 42);
            dataGridViewCellStyle2.Padding = new Padding(12, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(230, 247, 238);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(18, 55, 42);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvLog.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLog.Dock = DockStyle.Fill;
            dgvLog.EnableHeadersVisualStyles = false;
            dgvLog.GridColor = Color.FromArgb(230, 247, 238);
            dgvLog.Location = new Point(0, 0);
            dgvLog.MultiSelect = false;
            dgvLog.Name = "dgvLog";
            dgvLog.ReadOnly = true;
            dgvLog.RowHeadersVisible = false;
            dgvLog.RowHeadersWidth = 51;
            dgvLog.RowTemplate.Height = 52;
            dgvLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLog.Size = new Size(686, 426);
            dgvLog.TabIndex = 0;
            dgvLog.CellContentClick += dgvLog_CellContentClick;
            dgvLog.SelectionChanged += dgvLog_SelectionChanged;
            // 
            // colWaktu
            // 
            colWaktu.FillWeight = 16F;
            colWaktu.HeaderText = "Waktu";
            colWaktu.MinimumWidth = 6;
            colWaktu.Name = "colWaktu";
            colWaktu.ReadOnly = true;
            // 
            // colPengguna
            // 
            colPengguna.FillWeight = 15F;
            colPengguna.HeaderText = "Pengguna";
            colPengguna.MinimumWidth = 6;
            colPengguna.Name = "colPengguna";
            colPengguna.ReadOnly = true;
            // 
            // colRole
            // 
            colRole.FillWeight = 9F;
            colRole.HeaderText = "Role";
            colRole.MinimumWidth = 6;
            colRole.Name = "colRole";
            colRole.ReadOnly = true;
            // 
            // colKategori
            // 
            colKategori.FillWeight = 15F;
            colKategori.HeaderText = "Kategori";
            colKategori.MinimumWidth = 6;
            colKategori.Name = "colKategori";
            colKategori.ReadOnly = true;
            // 
            // colAktivitas
            // 
            colAktivitas.FillWeight = 25F;
            colAktivitas.HeaderText = "Aktivitas";
            colAktivitas.MinimumWidth = 6;
            colAktivitas.Name = "colAktivitas";
            colAktivitas.ReadOnly = true;
            // 
            // colTarget
            // 
            colTarget.FillWeight = 20F;
            colTarget.HeaderText = "Target";
            colTarget.MinimumWidth = 6;
            colTarget.Name = "colTarget";
            colTarget.ReadOnly = true;
            // 
            // pnlGap
            // 
            pnlGap.Dock = DockStyle.Right;
            pnlGap.Location = new Point(688, 0);
            pnlGap.Name = "pnlGap";
            pnlGap.Size = new Size(24, 428);
            pnlGap.TabIndex = 1;
            // 
            // pnlDetailLuar
            // 
            pnlDetailLuar.BackColor = Color.FromArgb(213, 235, 223);
            pnlDetailLuar.Controls.Add(PnlDetailDalam);
            pnlDetailLuar.Dock = DockStyle.Right;
            pnlDetailLuar.Location = new Point(712, 0);
            pnlDetailLuar.Name = "pnlDetailLuar";
            pnlDetailLuar.Padding = new Padding(1);
            pnlDetailLuar.Size = new Size(340, 428);
            pnlDetailLuar.TabIndex = 0;
            // 
            // PnlDetailDalam
            // 
            PnlDetailDalam.BackColor = Color.White;
            PnlDetailDalam.Controls.Add(txtAktivitasD);
            PnlDetailDalam.Controls.Add(txtKeteranganD);
            PnlDetailDalam.Controls.Add(txtKategoriD);
            PnlDetailDalam.Controls.Add(txtRoleD);
            PnlDetailDalam.Controls.Add(txtPenggunaD);
            PnlDetailDalam.Controls.Add(txtWaktuD);
            PnlDetailDalam.Controls.Add(lblCatatanD);
            PnlDetailDalam.Controls.Add(lblKeteranganD);
            PnlDetailDalam.Controls.Add(lblKategoriD);
            PnlDetailDalam.Controls.Add(lblPenggunaD);
            PnlDetailDalam.Controls.Add(lblAktivitas);
            PnlDetailDalam.Controls.Add(lblRoleD);
            PnlDetailDalam.Controls.Add(lblWaktuD);
            PnlDetailDalam.Controls.Add(pnlHeaderDetai);
            PnlDetailDalam.Dock = DockStyle.Fill;
            PnlDetailDalam.Location = new Point(1, 1);
            PnlDetailDalam.Name = "PnlDetailDalam";
            PnlDetailDalam.Size = new Size(338, 426);
            PnlDetailDalam.TabIndex = 0;
            // 
            // txtAktivitasD
            // 
            txtAktivitasD.BackColor = Color.FromArgb(245, 251, 248);
            txtAktivitasD.BorderStyle = BorderStyle.FixedSingle;
            txtAktivitasD.Font = new Font("Leelawadee UI", 11F);
            txtAktivitasD.ForeColor = Color.FromArgb(79, 106, 92);
            txtAktivitasD.Location = new Point(20, 242);
            txtAktivitasD.Name = "txtAktivitasD";
            txtAktivitasD.ReadOnly = true;
            txtAktivitasD.Size = new Size(298, 32);
            txtAktivitasD.TabIndex = 23;
            // 
            // txtKeteranganD
            // 
            txtKeteranganD.BackColor = Color.FromArgb(245, 251, 248);
            txtKeteranganD.BorderStyle = BorderStyle.FixedSingle;
            txtKeteranganD.Font = new Font("Leelawadee UI", 11F);
            txtKeteranganD.ForeColor = Color.FromArgb(79, 106, 92);
            txtKeteranganD.Location = new Point(20, 300);
            txtKeteranganD.Multiline = true;
            txtKeteranganD.Name = "txtKeteranganD";
            txtKeteranganD.ReadOnly = true;
            txtKeteranganD.ScrollBars = ScrollBars.Vertical;
            txtKeteranganD.Size = new Size(298, 80);
            txtKeteranganD.TabIndex = 22;
            // 
            // txtKategoriD
            // 
            txtKategoriD.BackColor = Color.FromArgb(245, 251, 248);
            txtKategoriD.BorderStyle = BorderStyle.FixedSingle;
            txtKategoriD.Font = new Font("Leelawadee UI", 11F);
            txtKategoriD.ForeColor = Color.FromArgb(79, 106, 92);
            txtKategoriD.Location = new Point(183, 184);
            txtKategoriD.Name = "txtKategoriD";
            txtKategoriD.ReadOnly = true;
            txtKategoriD.Size = new Size(135, 32);
            txtKategoriD.TabIndex = 21;
            // 
            // txtRoleD
            // 
            txtRoleD.BackColor = Color.FromArgb(245, 251, 248);
            txtRoleD.BorderStyle = BorderStyle.FixedSingle;
            txtRoleD.Font = new Font("Leelawadee UI", 11F);
            txtRoleD.ForeColor = Color.FromArgb(79, 106, 92);
            txtRoleD.Location = new Point(20, 184);
            txtRoleD.Name = "txtRoleD";
            txtRoleD.ReadOnly = true;
            txtRoleD.Size = new Size(135, 32);
            txtRoleD.TabIndex = 20;
            // 
            // txtPenggunaD
            // 
            txtPenggunaD.BackColor = Color.FromArgb(245, 251, 248);
            txtPenggunaD.BorderStyle = BorderStyle.FixedSingle;
            txtPenggunaD.Font = new Font("Leelawadee UI", 11F);
            txtPenggunaD.ForeColor = Color.FromArgb(79, 106, 92);
            txtPenggunaD.Location = new Point(183, 126);
            txtPenggunaD.Name = "txtPenggunaD";
            txtPenggunaD.ReadOnly = true;
            txtPenggunaD.Size = new Size(135, 32);
            txtPenggunaD.TabIndex = 19;
            // 
            // txtWaktuD
            // 
            txtWaktuD.BackColor = Color.FromArgb(245, 251, 248);
            txtWaktuD.BorderStyle = BorderStyle.FixedSingle;
            txtWaktuD.Font = new Font("Leelawadee UI", 11F);
            txtWaktuD.ForeColor = Color.FromArgb(79, 106, 92);
            txtWaktuD.Location = new Point(20, 126);
            txtWaktuD.Name = "txtWaktuD";
            txtWaktuD.ReadOnly = true;
            txtWaktuD.Size = new Size(135, 32);
            txtWaktuD.TabIndex = 18;
            // 
            // lblCatatanD
            // 
            lblCatatanD.AutoSize = true;
            lblCatatanD.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCatatanD.ForeColor = Color.FromArgb(79, 106, 92);
            lblCatatanD.Location = new Point(20, 398);
            lblCatatanD.Name = "lblCatatanD";
            lblCatatanD.Size = new Size(268, 20);
            lblCatatanD.TabIndex = 17;
            lblCatatanD.Text = "Log tidak dapat diubah atau dihapus.";
            // 
            // lblKeteranganD
            // 
            lblKeteranganD.AutoSize = true;
            lblKeteranganD.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKeteranganD.ForeColor = Color.FromArgb(79, 106, 92);
            lblKeteranganD.Location = new Point(20, 278);
            lblKeteranganD.Name = "lblKeteranganD";
            lblKeteranganD.Size = new Size(90, 20);
            lblKeteranganD.TabIndex = 16;
            lblKeteranganD.Text = "Keterangan";
            // 
            // lblKategoriD
            // 
            lblKategoriD.AutoSize = true;
            lblKategoriD.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKategoriD.ForeColor = Color.FromArgb(79, 106, 92);
            lblKategoriD.Location = new Point(183, 162);
            lblKategoriD.Name = "lblKategoriD";
            lblKategoriD.Size = new Size(69, 20);
            lblKategoriD.TabIndex = 15;
            lblKategoriD.Text = "Kategori";
            // 
            // lblPenggunaD
            // 
            lblPenggunaD.AutoSize = true;
            lblPenggunaD.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPenggunaD.ForeColor = Color.FromArgb(79, 106, 92);
            lblPenggunaD.Location = new Point(183, 104);
            lblPenggunaD.Name = "lblPenggunaD";
            lblPenggunaD.Size = new Size(79, 20);
            lblPenggunaD.TabIndex = 14;
            lblPenggunaD.Text = "Pengguna";
            // 
            // lblAktivitas
            // 
            lblAktivitas.AutoSize = true;
            lblAktivitas.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAktivitas.ForeColor = Color.FromArgb(79, 106, 92);
            lblAktivitas.Location = new Point(20, 220);
            lblAktivitas.Name = "lblAktivitas";
            lblAktivitas.Size = new Size(71, 20);
            lblAktivitas.TabIndex = 13;
            lblAktivitas.Text = "Aktivitas";
            // 
            // lblRoleD
            // 
            lblRoleD.AutoSize = true;
            lblRoleD.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoleD.ForeColor = Color.FromArgb(79, 106, 92);
            lblRoleD.Location = new Point(20, 162);
            lblRoleD.Name = "lblRoleD";
            lblRoleD.Size = new Size(40, 20);
            lblRoleD.TabIndex = 12;
            lblRoleD.Text = "Role";
            // 
            // lblWaktuD
            // 
            lblWaktuD.AutoSize = true;
            lblWaktuD.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWaktuD.ForeColor = Color.FromArgb(79, 106, 92);
            lblWaktuD.Location = new Point(20, 104);
            lblWaktuD.Name = "lblWaktuD";
            lblWaktuD.Size = new Size(55, 20);
            lblWaktuD.TabIndex = 11;
            lblWaktuD.Text = "Waktu";
            // 
            // pnlHeaderDetai
            // 
            pnlHeaderDetai.BackColor = Color.FromArgb(92, 199, 150);
            pnlHeaderDetai.Controls.Add(lblJudulD);
            pnlHeaderDetai.Dock = DockStyle.Top;
            pnlHeaderDetai.Location = new Point(0, 0);
            pnlHeaderDetai.Name = "pnlHeaderDetai";
            pnlHeaderDetai.Size = new Size(338, 84);
            pnlHeaderDetai.TabIndex = 10;
            // 
            // lblJudulD
            // 
            lblJudulD.AutoSize = true;
            lblJudulD.Font = new Font("Leelawadee UI", 13F, FontStyle.Bold);
            lblJudulD.ForeColor = Color.FromArgb(14, 47, 34);
            lblJudulD.Location = new Point(20, 16);
            lblJudulD.Name = "lblJudulD";
            lblJudulD.Size = new Size(168, 30);
            lblJudulD.TabIndex = 0;
            lblJudulD.Text = "Detail aktivitas";
            // 
            // pnlJarak2
            // 
            pnlJarak2.Dock = DockStyle.Top;
            pnlJarak2.Location = new Point(24, 232);
            pnlJarak2.Name = "pnlJarak2";
            pnlJarak2.Size = new Size(1052, 16);
            pnlJarak2.TabIndex = 3;
            // 
            // pnlFilterLuar
            // 
            pnlFilterLuar.BackColor = Color.FromArgb(213, 235, 223);
            pnlFilterLuar.Controls.Add(pnlFilterDalam);
            pnlFilterLuar.Dock = DockStyle.Top;
            pnlFilterLuar.Location = new Point(24, 148);
            pnlFilterLuar.Name = "pnlFilterLuar";
            pnlFilterLuar.Padding = new Padding(1);
            pnlFilterLuar.Size = new Size(1052, 84);
            pnlFilterLuar.TabIndex = 2;
            // 
            // pnlFilterDalam
            // 
            pnlFilterDalam.BackColor = Color.White;
            pnlFilterDalam.Controls.Add(txtCari);
            pnlFilterDalam.Controls.Add(cmbKategori);
            pnlFilterDalam.Controls.Add(cmbRole);
            pnlFilterDalam.Controls.Add(dtpSampai);
            pnlFilterDalam.Controls.Add(dtpDari);
            pnlFilterDalam.Controls.Add(lblRole);
            pnlFilterDalam.Controls.Add(lblKategori);
            pnlFilterDalam.Controls.Add(lblCari);
            pnlFilterDalam.Controls.Add(lblSampai);
            pnlFilterDalam.Controls.Add(lblDari);
            pnlFilterDalam.Dock = DockStyle.Fill;
            pnlFilterDalam.Location = new Point(1, 1);
            pnlFilterDalam.Name = "pnlFilterDalam";
            pnlFilterDalam.Size = new Size(1050, 82);
            pnlFilterDalam.TabIndex = 0;
            // 
            // txtCari
            // 
            txtCari.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCari.BackColor = Color.White;
            txtCari.BorderStyle = BorderStyle.FixedSingle;
            txtCari.Font = new Font("Leelawadee UI", 11F);
            txtCari.ForeColor = Color.FromArgb(18, 55, 42);
            txtCari.Location = new Point(584, 34);
            txtCari.Name = "txtCari";
            txtCari.PlaceholderText = "\tPengguna, aktivitas, atau target";
            txtCari.Size = new Size(310, 32);
            txtCari.TabIndex = 9;
            // 
            // cmbKategori
            // 
            cmbKategori.BackColor = Color.White;
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Items.AddRange(new object[] { "Semua kategori", "Akses", "Akun", "Barang", "Stok", "Penjualan", "Laporan" });
            cmbKategori.Location = new Point(422, 34);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(150, 31);
            cmbKategori.TabIndex = 8;
            // 
            // cmbRole
            // 
            cmbRole.BackColor = Color.White;
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Semua role", "Kasir", "Gudang", "Admin" });
            cmbRole.Location = new Point(280, 34);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(130, 31);
            cmbRole.TabIndex = 7;
            // 
            // dtpSampai
            // 
            dtpSampai.CustomFormat = "dd MMM yyyy\t";
            dtpSampai.Format = DateTimePickerFormat.Custom;
            dtpSampai.Location = new Point(148, 34);
            dtpSampai.Name = "dtpSampai";
            dtpSampai.Size = new Size(120, 31);
            dtpSampai.TabIndex = 6;
            // 
            // dtpDari
            // 
            dtpDari.CustomFormat = "dd MMM yyyy\t";
            dtpDari.Format = DateTimePickerFormat.Custom;
            dtpDari.Location = new Point(16, 34);
            dtpDari.Name = "dtpDari";
            dtpDari.Size = new Size(120, 31);
            dtpDari.TabIndex = 5;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.FromArgb(79, 106, 92);
            lblRole.Location = new Point(280, 12);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(40, 20);
            lblRole.TabIndex = 4;
            lblRole.Text = "Role";
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKategori.ForeColor = Color.FromArgb(79, 106, 92);
            lblKategori.Location = new Point(422, 12);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(69, 20);
            lblKategori.TabIndex = 3;
            lblKategori.Text = "Kategori";
            // 
            // lblCari
            // 
            lblCari.AutoSize = true;
            lblCari.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCari.ForeColor = Color.FromArgb(79, 106, 92);
            lblCari.Location = new Point(584, 12);
            lblCari.Name = "lblCari";
            lblCari.Size = new Size(36, 20);
            lblCari.TabIndex = 2;
            lblCari.Text = "Cari";
            // 
            // lblSampai
            // 
            lblSampai.AutoSize = true;
            lblSampai.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSampai.ForeColor = Color.FromArgb(79, 106, 92);
            lblSampai.Location = new Point(148, 12);
            lblSampai.Name = "lblSampai";
            lblSampai.Size = new Size(60, 20);
            lblSampai.TabIndex = 1;
            lblSampai.Text = "Sampai";
            // 
            // lblDari
            // 
            lblDari.AutoSize = true;
            lblDari.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDari.ForeColor = Color.FromArgb(79, 106, 92);
            lblDari.Location = new Point(16, 12);
            lblDari.Name = "lblDari";
            lblDari.Size = new Size(38, 20);
            lblDari.TabIndex = 0;
            lblDari.Text = "Dari";
            // 
            // pnlJarak
            // 
            pnlJarak.Dock = DockStyle.Top;
            pnlJarak.Location = new Point(24, 124);
            pnlJarak.Name = "pnlJarak";
            pnlJarak.Size = new Size(1052, 24);
            pnlJarak.TabIndex = 1;
            // 
            // tlpKartu
            // 
            tlpKartu.BackColor = Color.Transparent;
            tlpKartu.ColumnCount = 4;
            tlpKartu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpKartu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpKartu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpKartu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpKartu.Controls.Add(pnlKartuUbah, 3, 0);
            tlpKartu.Controls.Add(pnlKartuGagal, 2, 0);
            tlpKartu.Controls.Add(pnlKartuTotal, 0, 0);
            tlpKartu.Controls.Add(pnlKartuLogin, 1, 0);
            tlpKartu.Dock = DockStyle.Top;
            tlpKartu.Location = new Point(24, 24);
            tlpKartu.Name = "tlpKartu";
            tlpKartu.RowCount = 1;
            tlpKartu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpKartu.Size = new Size(1052, 100);
            tlpKartu.TabIndex = 0;
            // 
            // pnlKartuUbah
            // 
            pnlKartuUbah.BackColor = Color.FromArgb(213, 235, 223);
            pnlKartuUbah.Controls.Add(pnlKartuUbahDalam);
            pnlKartuUbah.Dock = DockStyle.Fill;
            pnlKartuUbah.Location = new Point(789, 0);
            pnlKartuUbah.Margin = new Padding(0);
            pnlKartuUbah.Name = "pnlKartuUbah";
            pnlKartuUbah.Padding = new Padding(1);
            pnlKartuUbah.Size = new Size(263, 100);
            pnlKartuUbah.TabIndex = 3;
            // 
            // pnlKartuUbahDalam
            // 
            pnlKartuUbahDalam.BackColor = Color.White;
            pnlKartuUbahDalam.Controls.Add(lblUbah);
            pnlKartuUbahDalam.Controls.Add(lblUbahJudul);
            pnlKartuUbahDalam.Dock = DockStyle.Fill;
            pnlKartuUbahDalam.Location = new Point(1, 1);
            pnlKartuUbahDalam.Name = "pnlKartuUbahDalam";
            pnlKartuUbahDalam.Size = new Size(261, 98);
            pnlKartuUbahDalam.TabIndex = 1;
            // 
            // lblUbah
            // 
            lblUbah.AutoSize = true;
            lblUbah.BackColor = Color.Transparent;
            lblUbah.Font = new Font("Leelawadee UI", 21F, FontStyle.Bold);
            lblUbah.Location = new Point(20, 42);
            lblUbah.Name = "lblUbah";
            lblUbah.Size = new Size(40, 47);
            lblUbah.TabIndex = 2;
            lblUbah.Text = "0";
            // 
            // lblUbahJudul
            // 
            lblUbahJudul.AutoSize = true;
            lblUbahJudul.BackColor = Color.Transparent;
            lblUbahJudul.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUbahJudul.Location = new Point(20, 18);
            lblUbahJudul.Name = "lblUbahJudul";
            lblUbahJudul.Size = new Size(121, 20);
            lblUbahJudul.TabIndex = 1;
            lblUbahJudul.Text = "Perubahan Data\t";
            // 
            // pnlKartuGagal
            // 
            pnlKartuGagal.BackColor = Color.FromArgb(213, 235, 223);
            pnlKartuGagal.Controls.Add(pnlKartuGagalDalam);
            pnlKartuGagal.Dock = DockStyle.Fill;
            pnlKartuGagal.Location = new Point(526, 0);
            pnlKartuGagal.Margin = new Padding(0, 0, 16, 0);
            pnlKartuGagal.Name = "pnlKartuGagal";
            pnlKartuGagal.Padding = new Padding(1);
            pnlKartuGagal.Size = new Size(247, 100);
            pnlKartuGagal.TabIndex = 2;
            // 
            // pnlKartuGagalDalam
            // 
            pnlKartuGagalDalam.BackColor = Color.White;
            pnlKartuGagalDalam.Controls.Add(lblGagal);
            pnlKartuGagalDalam.Controls.Add(lblGagalJudul);
            pnlKartuGagalDalam.Dock = DockStyle.Fill;
            pnlKartuGagalDalam.Location = new Point(1, 1);
            pnlKartuGagalDalam.Name = "pnlKartuGagalDalam";
            pnlKartuGagalDalam.Size = new Size(245, 98);
            pnlKartuGagalDalam.TabIndex = 1;
            pnlKartuGagalDalam.Paint += pnlKartuGagalDalam_Paint;
            // 
            // lblGagal
            // 
            lblGagal.AutoSize = true;
            lblGagal.BackColor = Color.Transparent;
            lblGagal.Font = new Font("Leelawadee UI", 21F, FontStyle.Bold);
            lblGagal.Location = new Point(20, 42);
            lblGagal.Name = "lblGagal";
            lblGagal.Size = new Size(40, 47);
            lblGagal.TabIndex = 2;
            lblGagal.Text = "0";
            // 
            // lblGagalJudul
            // 
            lblGagalJudul.AutoSize = true;
            lblGagalJudul.BackColor = Color.Transparent;
            lblGagalJudul.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGagalJudul.Location = new Point(20, 18);
            lblGagalJudul.Name = "lblGagalJudul";
            lblGagalJudul.Size = new Size(90, 20);
            lblGagalJudul.TabIndex = 1;
            lblGagalJudul.Text = "Login gagal";
            // 
            // pnlKartuTotal
            // 
            pnlKartuTotal.Angle = 45F;
            pnlKartuTotal.BackColor = Color.FromArgb(31, 107, 66);
            pnlKartuTotal.ColorBottom = Color.FromArgb(62, 156, 106);
            pnlKartuTotal.ColorTop = Color.FromArgb(31, 107, 66);
            pnlKartuTotal.Controls.Add(lblTotal);
            pnlKartuTotal.Controls.Add(lblTotalJudul);
            pnlKartuTotal.Dock = DockStyle.Fill;
            pnlKartuTotal.Location = new Point(0, 0);
            pnlKartuTotal.Margin = new Padding(0, 0, 16, 0);
            pnlKartuTotal.Name = "pnlKartuTotal";
            pnlKartuTotal.Size = new Size(247, 100);
            pnlKartuTotal.TabIndex = 0;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Leelawadee UI", 21F, FontStyle.Bold);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(20, 42);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(40, 47);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "0";
            // 
            // lblTotalJudul
            // 
            lblTotalJudul.AutoSize = true;
            lblTotalJudul.BackColor = Color.Transparent;
            lblTotalJudul.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalJudul.ForeColor = Color.White;
            lblTotalJudul.Location = new Point(20, 18);
            lblTotalJudul.Name = "lblTotalJudul";
            lblTotalJudul.Size = new Size(123, 20);
            lblTotalJudul.TabIndex = 0;
            lblTotalJudul.Text = "Aktivitas hari ini\t";
            // 
            // pnlKartuLogin
            // 
            pnlKartuLogin.BackColor = Color.FromArgb(213, 235, 223);
            pnlKartuLogin.Controls.Add(pnlKartuLoginDalam);
            pnlKartuLogin.Dock = DockStyle.Fill;
            pnlKartuLogin.Location = new Point(263, 0);
            pnlKartuLogin.Margin = new Padding(0, 0, 16, 0);
            pnlKartuLogin.Name = "pnlKartuLogin";
            pnlKartuLogin.Padding = new Padding(1);
            pnlKartuLogin.Size = new Size(247, 100);
            pnlKartuLogin.TabIndex = 1;
            // 
            // pnlKartuLoginDalam
            // 
            pnlKartuLoginDalam.BackColor = Color.White;
            pnlKartuLoginDalam.Controls.Add(lblLogin);
            pnlKartuLoginDalam.Controls.Add(lblLoginJudul);
            pnlKartuLoginDalam.Dock = DockStyle.Fill;
            pnlKartuLoginDalam.Location = new Point(1, 1);
            pnlKartuLoginDalam.Name = "pnlKartuLoginDalam";
            pnlKartuLoginDalam.Size = new Size(245, 98);
            pnlKartuLoginDalam.TabIndex = 0;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Leelawadee UI", 21F, FontStyle.Bold);
            lblLogin.Location = new Point(20, 42);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(40, 47);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "0";
            // 
            // lblLoginJudul
            // 
            lblLoginJudul.AutoSize = true;
            lblLoginJudul.BackColor = Color.Transparent;
            lblLoginJudul.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginJudul.Location = new Point(20, 18);
            lblLoginJudul.Name = "lblLoginJudul";
            lblLoginJudul.Size = new Size(100, 20);
            lblLoginJudul.TabIndex = 1;
            lblLoginJudul.Text = "Login hari ini";
            // 
            // ucLogAktivitas
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 251, 248);
            Controls.Add(pnlPage);
            Font = new Font("Leelawadee UI", 10.5F);
            Name = "ucLogAktivitas";
            Size = new Size(1100, 700);
            pnlPage.ResumeLayout(false);
            pnlBawah.ResumeLayout(false);
            pnlKartuTabel.ResumeLayout(false);
            pnlKartuTabelDalam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLog).EndInit();
            pnlDetailLuar.ResumeLayout(false);
            PnlDetailDalam.ResumeLayout(false);
            PnlDetailDalam.PerformLayout();
            pnlHeaderDetai.ResumeLayout(false);
            pnlHeaderDetai.PerformLayout();
            pnlFilterLuar.ResumeLayout(false);
            pnlFilterDalam.ResumeLayout(false);
            pnlFilterDalam.PerformLayout();
            tlpKartu.ResumeLayout(false);
            pnlKartuUbah.ResumeLayout(false);
            pnlKartuUbahDalam.ResumeLayout(false);
            pnlKartuUbahDalam.PerformLayout();
            pnlKartuGagal.ResumeLayout(false);
            pnlKartuGagalDalam.ResumeLayout(false);
            pnlKartuGagalDalam.PerformLayout();
            pnlKartuTotal.ResumeLayout(false);
            pnlKartuTotal.PerformLayout();
            pnlKartuLogin.ResumeLayout(false);
            pnlKartuLoginDalam.ResumeLayout(false);
            pnlKartuLoginDalam.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPage;
        private TableLayoutPanel tlpKartu;
        private Panel pnlJarak2;
        private Panel pnlFilterLuar;
        private Panel pnlJarak;
        private Panel pnlBawah;
        private GradientPanel pnlKartuTotal;
        private Panel pnlKartuLogin;
        private Panel pnlKartuUbah;
        private Panel pnlKartuGagal;
        private Panel pnlKartuUbahDalam;
        private Panel pnlKartuGagalDalam;
        private Label lblTotal;
        private Label lblTotalJudul;
        private Panel pnlKartuLoginDalam;
        private Label lblLoginJudul;
        private Label lblUbahJudul;
        private Label lblGagalJudul;
        private Label lblUbah;
        private Label lblGagal;
        private Label lblLogin;
        private Panel pnlFilterDalam;
        private Label lblRole;
        private Label lblKategori;
        private Label lblCari;
        private Label lblSampai;
        private Label lblDari;
        private DateTimePicker dtpSampai;
        private DateTimePicker dtpDari;
        private ComboBox cmbRole;
        private ComboBox cmbKategori;
        private Panel pnlGap;
        private Panel pnlDetailLuar;
        private TextBox txtCari;
        private Panel pnlKartuTabel;
        private Panel pnlKartuTabelDalam;
        private DataGridView dgvLog;
        private DataGridViewTextBoxColumn colWaktu;
        private DataGridViewTextBoxColumn colPengguna;
        private DataGridViewTextBoxColumn colRole;
        private DataGridViewTextBoxColumn colKategori;
        private DataGridViewTextBoxColumn colAktivitas;
        private DataGridViewTextBoxColumn colTarget;
        private Panel PnlDetailDalam;
        private Panel pnlHeaderDetai;
        private Label lblJudulD;
        private Label lblRoleD;
        private Label lblWaktuD;
        private Label lblKeteranganD;
        private Label lblKategoriD;
        private Label lblPenggunaD;
        private Label lblAktivitas;
        private TextBox txtWaktuD;
        private Label lblCatatanD;
        private TextBox txtKeteranganD;
        private TextBox txtKategoriD;
        private TextBox txtRoleD;
        private TextBox txtPenggunaD;
        private TextBox txtAktivitasD;
    }
}
