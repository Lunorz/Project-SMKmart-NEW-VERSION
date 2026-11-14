namespace project_akhir_stock_gudang
{
    partial class ucAdminDataUser
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pnlBawah = new Panel();
            pnlKartuTabel = new Panel();
            pnlKartuTabelDalam = new Panel();
            tabUtama = new TabControl();
            tabPermintaan = new TabPage();
            dgvPermintaan = new DataGridView();
            colUsernameP = new DataGridViewTextBoxColumn();
            colEmailP = new DataGridViewTextBoxColumn();
            colRoleP = new DataGridViewTextBoxColumn();
            colTanggalP = new DataGridViewTextBoxColumn();
            colSetujui = new DataGridViewButtonColumn();
            colTolak = new DataGridViewButtonColumn();
            pnlToolbarP = new Panel();
            cmbRoleP = new ComboBox();
            txtCariP = new TextBox();
            tabSemua = new TabPage();
            dgvSemua = new DataGridView();
            colUsernameS = new DataGridViewTextBoxColumn();
            colEmailS = new DataGridViewTextBoxColumn();
            colRoleS = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            btnBanned = new DataGridViewButtonColumn();
            pnlToolbarS = new Panel();
            cmbRoleS = new ComboBox();
            txtCariS = new TextBox();
            pnlGap = new Panel();
            pnlSetujuiLuar = new Panel();
            pnlSetujuiDalam = new Panel();
            cmbRole = new ComboBox();
            lblRole = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            btnSetujui = new Button();
            btnBatal = new Button();
            btnGenerate = new Button();
            prgKekuatan = new ProgressBar();
            txtPassword = new TextBox();
            lblPassword = new Label();
            lblJudul = new Label();
            pnlJarak = new Panel();
            tlpKartu = new TableLayoutPanel();
            pnlKartuTotal = new GradientPanel();
            lblTotal = new Label();
            lblTotalJudul = new Label();
            pnlKartuMenunngu = new Panel();
            lblMenunggu = new Label();
            lblMenungguJudul = new Label();
            pnlKartuAktif = new Panel();
            lblAktif = new Label();
            lblAktifJudul = new Label();
            pnlKartuNonaktif = new Panel();
            lblBanned = new Label();
            lblNnonaktifjudul = new Label();
            pnlBawah.SuspendLayout();
            pnlKartuTabel.SuspendLayout();
            pnlKartuTabelDalam.SuspendLayout();
            tabUtama.SuspendLayout();
            tabPermintaan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPermintaan).BeginInit();
            pnlToolbarP.SuspendLayout();
            tabSemua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSemua).BeginInit();
            pnlToolbarS.SuspendLayout();
            pnlSetujuiLuar.SuspendLayout();
            pnlSetujuiDalam.SuspendLayout();
            tlpKartu.SuspendLayout();
            pnlKartuTotal.SuspendLayout();
            pnlKartuMenunngu.SuspendLayout();
            pnlKartuAktif.SuspendLayout();
            pnlKartuNonaktif.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBawah
            // 
            pnlBawah.BackColor = Color.Transparent;
            pnlBawah.Controls.Add(pnlKartuTabel);
            pnlBawah.Controls.Add(pnlGap);
            pnlBawah.Controls.Add(pnlSetujuiLuar);
            pnlBawah.Dock = DockStyle.Fill;
            pnlBawah.Location = new Point(24, 148);
            pnlBawah.Name = "pnlBawah";
            pnlBawah.Size = new Size(1052, 528);
            pnlBawah.TabIndex = 2;
            // 
            // pnlKartuTabel
            // 
            pnlKartuTabel.BackColor = Color.FromArgb(213, 235, 223);
            pnlKartuTabel.Controls.Add(pnlKartuTabelDalam);
            pnlKartuTabel.Dock = DockStyle.Fill;
            pnlKartuTabel.Location = new Point(0, 0);
            pnlKartuTabel.Name = "pnlKartuTabel";
            pnlKartuTabel.Padding = new Padding(1);
            pnlKartuTabel.Size = new Size(688, 528);
            pnlKartuTabel.TabIndex = 2;
            // 
            // pnlKartuTabelDalam
            // 
            pnlKartuTabelDalam.BackColor = Color.White;
            pnlKartuTabelDalam.Controls.Add(tabUtama);
            pnlKartuTabelDalam.Dock = DockStyle.Fill;
            pnlKartuTabelDalam.Location = new Point(1, 1);
            pnlKartuTabelDalam.Name = "pnlKartuTabelDalam";
            pnlKartuTabelDalam.Size = new Size(686, 526);
            pnlKartuTabelDalam.TabIndex = 0;
            // 
            // tabUtama
            // 
            tabUtama.Controls.Add(tabPermintaan);
            tabUtama.Controls.Add(tabSemua);
            tabUtama.Dock = DockStyle.Fill;
            tabUtama.ItemSize = new Size(220, 38);
            tabUtama.Location = new Point(0, 0);
            tabUtama.Name = "tabUtama";
            tabUtama.SelectedIndex = 0;
            tabUtama.Size = new Size(686, 526);
            tabUtama.SizeMode = TabSizeMode.Fixed;
            tabUtama.TabIndex = 0;
            // 
            // tabPermintaan
            // 
            tabPermintaan.BackColor = Color.White;
            tabPermintaan.Controls.Add(dgvPermintaan);
            tabPermintaan.Controls.Add(pnlToolbarP);
            tabPermintaan.Location = new Point(4, 42);
            tabPermintaan.Name = "tabPermintaan";
            tabPermintaan.Padding = new Padding(3);
            tabPermintaan.Size = new Size(678, 480);
            tabPermintaan.TabIndex = 0;
            tabPermintaan.Text = "Permintaan pendaftaran";
            // 
            // dgvPermintaan
            // 
            dgvPermintaan.AllowUserToAddRows = false;
            dgvPermintaan.AllowUserToDeleteRows = false;
            dgvPermintaan.AllowUserToResizeColumns = false;
            dgvPermintaan.AllowUserToResizeRows = false;
            dgvPermintaan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPermintaan.BackgroundColor = Color.White;
            dgvPermintaan.BorderStyle = BorderStyle.None;
            dgvPermintaan.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPermintaan.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 251, 248);
            dataGridViewCellStyle1.Font = new Font("Leelawadee UI", 10.5F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(79, 106, 92);
            dataGridViewCellStyle1.Padding = new Padding(12, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(245, 251, 248);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(79, 106, 92);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPermintaan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPermintaan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPermintaan.Columns.AddRange(new DataGridViewColumn[] { colUsernameP, colEmailP, colRoleP, colTanggalP, colSetujui, colTolak });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Leelawadee UI", 10.5F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(18, 55, 42);
            dataGridViewCellStyle4.Padding = new Padding(12, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(230, 247, 238);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(18, 55, 42);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvPermintaan.DefaultCellStyle = dataGridViewCellStyle4;
            dgvPermintaan.Dock = DockStyle.Fill;
            dgvPermintaan.EnableHeadersVisualStyles = false;
            dgvPermintaan.GridColor = Color.FromArgb(230, 247, 238);
            dgvPermintaan.Location = new Point(3, 75);
            dgvPermintaan.MultiSelect = false;
            dgvPermintaan.Name = "dgvPermintaan";
            dgvPermintaan.ReadOnly = true;
            dgvPermintaan.RowHeadersVisible = false;
            dgvPermintaan.RowHeadersWidth = 51;
            dgvPermintaan.RowTemplate.Height = 56;
            dgvPermintaan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPermintaan.Size = new Size(672, 402);
            dgvPermintaan.TabIndex = 2;
            dgvPermintaan.CellContentClick += dgvPermintaan_CellContentClick;
            // 
            // colUsernameP
            // 
            colUsernameP.FillWeight = 18F;
            colUsernameP.HeaderText = "username";
            colUsernameP.MinimumWidth = 6;
            colUsernameP.Name = "colUsernameP";
            colUsernameP.ReadOnly = true;
            // 
            // colEmailP
            // 
            colEmailP.FillWeight = 23F;
            colEmailP.HeaderText = "email";
            colEmailP.MinimumWidth = 6;
            colEmailP.Name = "colEmailP";
            colEmailP.ReadOnly = true;
            // 
            // colRoleP
            // 
            colRoleP.FillWeight = 10F;
            colRoleP.HeaderText = "role";
            colRoleP.MinimumWidth = 6;
            colRoleP.Name = "colRoleP";
            colRoleP.ReadOnly = true;
            // 
            // colTanggalP
            // 
            colTanggalP.FillWeight = 13F;
            colTanggalP.HeaderText = "tanggal";
            colTanggalP.MinimumWidth = 6;
            colTanggalP.Name = "colTanggalP";
            colTanggalP.ReadOnly = true;
            // 
            // colSetujui
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(42, 127, 80);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(42, 127, 80);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            colSetujui.DefaultCellStyle = dataGridViewCellStyle2;
            colSetujui.FillWeight = 11F;
            colSetujui.FlatStyle = FlatStyle.Flat;
            colSetujui.HeaderText = "aksi";
            colSetujui.MinimumWidth = 6;
            colSetujui.Name = "colSetujui";
            colSetujui.ReadOnly = true;
            colSetujui.Text = "Setujui";
            colSetujui.UseColumnTextForButtonValue = true;
            // 
            // colTolak
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(169, 50, 38);
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(169, 50, 38);
            colTolak.DefaultCellStyle = dataGridViewCellStyle3;
            colTolak.FillWeight = 11F;
            colTolak.FlatStyle = FlatStyle.Flat;
            colTolak.HeaderText = "";
            colTolak.MinimumWidth = 6;
            colTolak.Name = "colTolak";
            colTolak.ReadOnly = true;
            colTolak.Text = "Tolak";
            colTolak.UseColumnTextForButtonValue = true;
            // 
            // pnlToolbarP
            // 
            pnlToolbarP.Controls.Add(cmbRoleP);
            pnlToolbarP.Controls.Add(txtCariP);
            pnlToolbarP.Dock = DockStyle.Top;
            pnlToolbarP.Location = new Point(3, 3);
            pnlToolbarP.Name = "pnlToolbarP";
            pnlToolbarP.Size = new Size(672, 72);
            pnlToolbarP.TabIndex = 0;
            // 
            // cmbRoleP
            // 
            cmbRoleP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbRoleP.BackColor = Color.White;
            cmbRoleP.FlatStyle = FlatStyle.Flat;
            cmbRoleP.ForeColor = Color.FromArgb(18, 55, 42);
            cmbRoleP.FormattingEnabled = true;
            cmbRoleP.Items.AddRange(new object[] { "semua", "kasir", "gudang" });
            cmbRoleP.Location = new Point(500, 18);
            cmbRoleP.Name = "cmbRoleP";
            cmbRoleP.Size = new Size(150, 31);
            cmbRoleP.TabIndex = 1;
            // 
            // txtCariP
            // 
            txtCariP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCariP.BackColor = Color.White;
            txtCariP.BorderStyle = BorderStyle.FixedSingle;
            txtCariP.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCariP.ForeColor = Color.FromArgb(18, 55, 42);
            txtCariP.Location = new Point(16, 16);
            txtCariP.Name = "txtCariP";
            txtCariP.PlaceholderText = "Cari email atau username";
            txtCariP.Size = new Size(460, 34);
            txtCariP.TabIndex = 0;
            // 
            // tabSemua
            // 
            tabSemua.BackColor = Color.White;
            tabSemua.Controls.Add(dgvSemua);
            tabSemua.Controls.Add(pnlToolbarS);
            tabSemua.Location = new Point(4, 42);
            tabSemua.Name = "tabSemua";
            tabSemua.Padding = new Padding(3);
            tabSemua.Size = new Size(678, 480);
            tabSemua.TabIndex = 1;
            tabSemua.Text = "Semua pengguna";
            // 
            // dgvSemua
            // 
            dgvSemua.AllowUserToAddRows = false;
            dgvSemua.AllowUserToDeleteRows = false;
            dgvSemua.AllowUserToResizeColumns = false;
            dgvSemua.AllowUserToResizeRows = false;
            dgvSemua.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSemua.BackgroundColor = Color.White;
            dgvSemua.BorderStyle = BorderStyle.None;
            dgvSemua.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSemua.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(245, 251, 248);
            dataGridViewCellStyle5.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(79, 106, 92);
            dataGridViewCellStyle5.Padding = new Padding(12, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(245, 251, 248);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(79, 106, 92);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvSemua.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvSemua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSemua.Columns.AddRange(new DataGridViewColumn[] { colUsernameS, colEmailS, colRoleS, status, btnBanned });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Leelawadee UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(18, 55, 42);
            dataGridViewCellStyle7.Padding = new Padding(12, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(230, 247, 238);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(18, 55, 42);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvSemua.DefaultCellStyle = dataGridViewCellStyle7;
            dgvSemua.Dock = DockStyle.Fill;
            dgvSemua.EnableHeadersVisualStyles = false;
            dgvSemua.GridColor = Color.FromArgb(230, 247, 238);
            dgvSemua.Location = new Point(3, 75);
            dgvSemua.MultiSelect = false;
            dgvSemua.Name = "dgvSemua";
            dgvSemua.ReadOnly = true;
            dgvSemua.RowHeadersVisible = false;
            dgvSemua.RowHeadersWidth = 51;
            dgvSemua.RowTemplate.Height = 56;
            dgvSemua.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSemua.Size = new Size(672, 402);
            dgvSemua.TabIndex = 1;
            dgvSemua.CellContentClick += dgvSemua_CellContentClick;
            dgvSemua.CellFormatting += dgvSemua_CellFormatting;
            // 
            // colUsernameS
            // 
            colUsernameS.FillWeight = 18F;
            colUsernameS.HeaderText = "username";
            colUsernameS.MinimumWidth = 6;
            colUsernameS.Name = "colUsernameS";
            colUsernameS.ReadOnly = true;
            // 
            // colEmailS
            // 
            colEmailS.FillWeight = 23F;
            colEmailS.HeaderText = "email";
            colEmailS.MinimumWidth = 6;
            colEmailS.Name = "colEmailS";
            colEmailS.ReadOnly = true;
            // 
            // colRoleS
            // 
            colRoleS.FillWeight = 10F;
            colRoleS.HeaderText = "role";
            colRoleS.MinimumWidth = 6;
            colRoleS.Name = "colRoleS";
            colRoleS.ReadOnly = true;
            // 
            // status
            // 
            status.FillWeight = 13F;
            status.HeaderText = "status";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.ReadOnly = true;
            // 
            // btnBanned
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(169, 50, 38);
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(169, 50, 38);
            btnBanned.DefaultCellStyle = dataGridViewCellStyle6;
            btnBanned.FillWeight = 11F;
            btnBanned.FlatStyle = FlatStyle.Flat;
            btnBanned.HeaderText = "";
            btnBanned.MinimumWidth = 6;
            btnBanned.Name = "btnBanned";
            btnBanned.ReadOnly = true;
            btnBanned.Text = "Tolak";
            btnBanned.UseColumnTextForButtonValue = true;
            // 
            // pnlToolbarS
            // 
            pnlToolbarS.Controls.Add(cmbRoleS);
            pnlToolbarS.Controls.Add(txtCariS);
            pnlToolbarS.Dock = DockStyle.Top;
            pnlToolbarS.Location = new Point(3, 3);
            pnlToolbarS.Name = "pnlToolbarS";
            pnlToolbarS.Size = new Size(672, 72);
            pnlToolbarS.TabIndex = 0;
            // 
            // cmbRoleS
            // 
            cmbRoleS.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbRoleS.BackColor = Color.White;
            cmbRoleS.FlatStyle = FlatStyle.Flat;
            cmbRoleS.ForeColor = Color.FromArgb(18, 55, 42);
            cmbRoleS.FormattingEnabled = true;
            cmbRoleS.Items.AddRange(new object[] { "semua", "kasir", "gudang" });
            cmbRoleS.Location = new Point(500, 18);
            cmbRoleS.Name = "cmbRoleS";
            cmbRoleS.Size = new Size(150, 31);
            cmbRoleS.TabIndex = 2;
            // 
            // txtCariS
            // 
            txtCariS.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCariS.BackColor = Color.White;
            txtCariS.BorderStyle = BorderStyle.FixedSingle;
            txtCariS.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCariS.ForeColor = Color.FromArgb(18, 55, 42);
            txtCariS.Location = new Point(16, 16);
            txtCariS.Name = "txtCariS";
            txtCariS.PlaceholderText = "Cari email atau username";
            txtCariS.Size = new Size(460, 34);
            txtCariS.TabIndex = 1;
            // 
            // pnlGap
            // 
            pnlGap.Dock = DockStyle.Right;
            pnlGap.Location = new Point(688, 0);
            pnlGap.Name = "pnlGap";
            pnlGap.Size = new Size(24, 528);
            pnlGap.TabIndex = 1;
            // 
            // pnlSetujuiLuar
            // 
            pnlSetujuiLuar.BackColor = Color.FromArgb(213, 235, 223);
            pnlSetujuiLuar.Controls.Add(pnlSetujuiDalam);
            pnlSetujuiLuar.Dock = DockStyle.Right;
            pnlSetujuiLuar.Location = new Point(712, 0);
            pnlSetujuiLuar.Name = "pnlSetujuiLuar";
            pnlSetujuiLuar.Padding = new Padding(1);
            pnlSetujuiLuar.Size = new Size(340, 528);
            pnlSetujuiLuar.TabIndex = 0;
            // 
            // pnlSetujuiDalam
            // 
            pnlSetujuiDalam.BackColor = Color.White;
            pnlSetujuiDalam.Controls.Add(cmbRole);
            pnlSetujuiDalam.Controls.Add(lblRole);
            pnlSetujuiDalam.Controls.Add(txtUsername);
            pnlSetujuiDalam.Controls.Add(lblUsername);
            pnlSetujuiDalam.Controls.Add(txtEmail);
            pnlSetujuiDalam.Controls.Add(label1);
            pnlSetujuiDalam.Controls.Add(btnSetujui);
            pnlSetujuiDalam.Controls.Add(btnBatal);
            pnlSetujuiDalam.Controls.Add(btnGenerate);
            pnlSetujuiDalam.Controls.Add(prgKekuatan);
            pnlSetujuiDalam.Controls.Add(txtPassword);
            pnlSetujuiDalam.Controls.Add(lblPassword);
            pnlSetujuiDalam.Dock = DockStyle.Fill;
            pnlSetujuiDalam.Location = new Point(1, 1);
            pnlSetujuiDalam.Name = "pnlSetujuiDalam";
            pnlSetujuiDalam.Size = new Size(338, 526);
            pnlSetujuiDalam.TabIndex = 0;
            // 
            // cmbRole
            // 
            cmbRole.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbRole.BackColor = Color.White;
            cmbRole.ForeColor = Color.FromArgb(18, 55, 42);
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "kasir", "gudang" });
            cmbRole.Location = new Point(20, 236);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(298, 31);
            cmbRole.TabIndex = 12;
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.FromArgb(79, 106, 92);
            lblRole.Location = new Point(20, 213);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(40, 20);
            lblRole.TabIndex = 11;
            lblRole.Text = "Role";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Leelawadee UI", 11F);
            txtUsername.ForeColor = Color.FromArgb(18, 55, 42);
            txtUsername.Location = new Point(20, 178);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(298, 32);
            txtUsername.TabIndex = 10;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(79, 106, 92);
            lblUsername.Location = new Point(20, 155);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(80, 20);
            lblUsername.TabIndex = 9;
            lblUsername.Text = "Username";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Leelawadee UI", 11F);
            txtEmail.ForeColor = Color.FromArgb(18, 55, 42);
            txtEmail.Location = new Point(20, 120);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(298, 32);
            txtEmail.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(79, 106, 92);
            label1.Location = new Point(20, 97);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 7;
            label1.Text = "Email";
            // 
            // btnSetujui
            // 
            btnSetujui.BackColor = Color.FromArgb(42, 127, 80);
            btnSetujui.FlatAppearance.BorderSize = 0;
            btnSetujui.FlatStyle = FlatStyle.Flat;
            btnSetujui.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSetujui.ForeColor = Color.White;
            btnSetujui.Location = new Point(118, 460);
            btnSetujui.Name = "btnSetujui";
            btnSetujui.Size = new Size(200, 40);
            btnSetujui.TabIndex = 6;
            btnSetujui.Text = "Setujui & buat akun";
            btnSetujui.UseMnemonic = false;
            btnSetujui.UseVisualStyleBackColor = false;
            btnSetujui.Click += btnSetujui_Click_1;
            // 
            // btnBatal
            // 
            btnBatal.FlatAppearance.BorderColor = Color.FromArgb(213, 235, 223);
            btnBatal.FlatStyle = FlatStyle.Flat;
            btnBatal.ForeColor = Color.FromArgb(18, 55, 42);
            btnBatal.Location = new Point(20, 460);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(90, 40);
            btnBatal.TabIndex = 5;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += btnBatal_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.FromArgb(230, 247, 238);
            btnGenerate.FlatAppearance.BorderColor = Color.FromArgb(213, 235, 223);
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.ForeColor = Color.FromArgb(31, 107, 66);
            btnGenerate.Location = new Point(20, 414);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(298, 40);
            btnGenerate.TabIndex = 4;
            btnGenerate.Text = "Generate otomatis";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click_1;
            // 
            // prgKekuatan
            // 
            prgKekuatan.Location = new Point(20, 368);
            prgKekuatan.Maximum = 4;
            prgKekuatan.Name = "prgKekuatan";
            prgKekuatan.Size = new Size(298, 8);
            prgKekuatan.Style = ProgressBarStyle.Continuous;
            prgKekuatan.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Leelawadee UI", 11F);
            txtPassword.ForeColor = Color.FromArgb(18, 55, 42);
            txtPassword.Location = new Point(20, 330);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(298, 32);
            txtPassword.TabIndex = 2;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(79, 106, 92);
            lblPassword.Location = new Point(20, 307);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(114, 20);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password akun";
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.BackColor = Color.Transparent;
            lblJudul.Font = new Font("Leelawadee UI", 13.5F, FontStyle.Bold);
            lblJudul.ForeColor = Color.FromArgb(14, 47, 34);
            lblJudul.Location = new Point(20, 16);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(149, 31);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Setujui akun";
            // 
            // pnlJarak
            // 
            pnlJarak.BackColor = Color.Transparent;
            pnlJarak.Dock = DockStyle.Top;
            pnlJarak.Location = new Point(24, 124);
            pnlJarak.Name = "pnlJarak";
            pnlJarak.Size = new Size(1052, 24);
            pnlJarak.TabIndex = 1;
            // 
            // tlpKartu
            // 
            tlpKartu.ColumnCount = 4;
            tlpKartu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpKartu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpKartu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpKartu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpKartu.Controls.Add(pnlKartuTotal, 0, 0);
            tlpKartu.Controls.Add(pnlKartuMenunngu, 1, 0);
            tlpKartu.Controls.Add(pnlKartuAktif, 2, 0);
            tlpKartu.Controls.Add(pnlKartuNonaktif, 3, 0);
            tlpKartu.Dock = DockStyle.Top;
            tlpKartu.Location = new Point(24, 24);
            tlpKartu.Margin = new Padding(0);
            tlpKartu.Name = "tlpKartu";
            tlpKartu.RowCount = 1;
            tlpKartu.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpKartu.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpKartu.Size = new Size(1052, 100);
            tlpKartu.TabIndex = 0;
            // 
            // pnlKartuTotal
            // 
            pnlKartuTotal.Angle = 90F;
            pnlKartuTotal.BackColor = Color.FromArgb(42, 127, 80);
            pnlKartuTotal.ColorBottom = Color.FromArgb(26, 90, 56);
            pnlKartuTotal.ColorTop = Color.FromArgb(38, 119, 74);
            pnlKartuTotal.Controls.Add(lblTotal);
            pnlKartuTotal.Controls.Add(lblTotalJudul);
            pnlKartuTotal.Dock = DockStyle.Fill;
            pnlKartuTotal.Location = new Point(0, 0);
            pnlKartuTotal.Margin = new Padding(0, 0, 16, 0);
            pnlKartuTotal.Name = "pnlKartuTotal";
            pnlKartuTotal.Padding = new Padding(1);
            pnlKartuTotal.Size = new Size(247, 100);
            pnlKartuTotal.TabIndex = 0;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Leelawadee UI", 21F, FontStyle.Bold);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(21, 43);
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
            lblTotalJudul.Location = new Point(21, 19);
            lblTotalJudul.Name = "lblTotalJudul";
            lblTotalJudul.Size = new Size(119, 20);
            lblTotalJudul.TabIndex = 0;
            lblTotalJudul.Text = "Total pengguna";
            // 
            // pnlKartuMenunngu
            // 
            pnlKartuMenunngu.BackColor = Color.White;
            pnlKartuMenunngu.Controls.Add(lblMenunggu);
            pnlKartuMenunngu.Controls.Add(lblMenungguJudul);
            pnlKartuMenunngu.Dock = DockStyle.Fill;
            pnlKartuMenunngu.Location = new Point(263, 0);
            pnlKartuMenunngu.Margin = new Padding(0, 0, 16, 0);
            pnlKartuMenunngu.Name = "pnlKartuMenunngu";
            pnlKartuMenunngu.Padding = new Padding(1);
            pnlKartuMenunngu.Size = new Size(247, 100);
            pnlKartuMenunngu.TabIndex = 1;
            // 
            // lblMenunggu
            // 
            lblMenunggu.AutoSize = true;
            lblMenunggu.Font = new Font("Leelawadee UI", 21F, FontStyle.Bold);
            lblMenunggu.ForeColor = Color.FromArgb(31, 107, 66);
            lblMenunggu.Location = new Point(20, 42);
            lblMenunggu.Name = "lblMenunggu";
            lblMenunggu.Size = new Size(40, 47);
            lblMenunggu.TabIndex = 1;
            lblMenunggu.Text = "0";
            // 
            // lblMenungguJudul
            // 
            lblMenungguJudul.AutoSize = true;
            lblMenungguJudul.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenungguJudul.ForeColor = Color.FromArgb(79, 106, 92);
            lblMenungguJudul.Location = new Point(20, 18);
            lblMenungguJudul.Name = "lblMenungguJudul";
            lblMenungguJudul.Size = new Size(172, 20);
            lblMenungguJudul.TabIndex = 0;
            lblMenungguJudul.Text = "Menunggu persetujuan";
            // 
            // pnlKartuAktif
            // 
            pnlKartuAktif.BackColor = Color.White;
            pnlKartuAktif.Controls.Add(lblAktif);
            pnlKartuAktif.Controls.Add(lblAktifJudul);
            pnlKartuAktif.Dock = DockStyle.Fill;
            pnlKartuAktif.Location = new Point(526, 0);
            pnlKartuAktif.Margin = new Padding(0, 0, 16, 0);
            pnlKartuAktif.Name = "pnlKartuAktif";
            pnlKartuAktif.Padding = new Padding(1);
            pnlKartuAktif.Size = new Size(247, 100);
            pnlKartuAktif.TabIndex = 2;
            // 
            // lblAktif
            // 
            lblAktif.AutoSize = true;
            lblAktif.Font = new Font("Leelawadee UI", 21F, FontStyle.Bold);
            lblAktif.ForeColor = Color.FromArgb(31, 107, 66);
            lblAktif.Location = new Point(20, 42);
            lblAktif.Name = "lblAktif";
            lblAktif.Size = new Size(40, 47);
            lblAktif.TabIndex = 2;
            lblAktif.Text = "0";
            // 
            // lblAktifJudul
            // 
            lblAktifJudul.AutoSize = true;
            lblAktifJudul.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAktifJudul.ForeColor = Color.FromArgb(79, 106, 92);
            lblAktifJudul.Location = new Point(20, 18);
            lblAktifJudul.Name = "lblAktifJudul";
            lblAktifJudul.Size = new Size(82, 20);
            lblAktifJudul.TabIndex = 1;
            lblAktifJudul.Text = "Akun aktif";
            // 
            // pnlKartuNonaktif
            // 
            pnlKartuNonaktif.BackColor = Color.White;
            pnlKartuNonaktif.Controls.Add(lblBanned);
            pnlKartuNonaktif.Controls.Add(lblNnonaktifjudul);
            pnlKartuNonaktif.Dock = DockStyle.Fill;
            pnlKartuNonaktif.Location = new Point(789, 0);
            pnlKartuNonaktif.Margin = new Padding(0, 0, 16, 0);
            pnlKartuNonaktif.Name = "pnlKartuNonaktif";
            pnlKartuNonaktif.Padding = new Padding(1);
            pnlKartuNonaktif.Size = new Size(247, 100);
            pnlKartuNonaktif.TabIndex = 3;
            // 
            // lblBanned
            // 
            lblBanned.AutoSize = true;
            lblBanned.Font = new Font("Leelawadee UI", 21F, FontStyle.Bold);
            lblBanned.ForeColor = Color.FromArgb(31, 107, 66);
            lblBanned.Location = new Point(20, 42);
            lblBanned.Name = "lblBanned";
            lblBanned.Size = new Size(40, 47);
            lblBanned.TabIndex = 2;
            lblBanned.Text = "0";
            // 
            // lblNnonaktifjudul
            // 
            lblNnonaktifjudul.AutoSize = true;
            lblNnonaktifjudul.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNnonaktifjudul.ForeColor = Color.FromArgb(79, 106, 92);
            lblNnonaktifjudul.Location = new Point(20, 18);
            lblNnonaktifjudul.Name = "lblNnonaktifjudul";
            lblNnonaktifjudul.Size = new Size(105, 20);
            lblNnonaktifjudul.TabIndex = 1;
            lblNnonaktifjudul.Text = "Nonaktif/Ban";
            // 
            // ucAdminDataUser
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 251, 248);
            Controls.Add(pnlBawah);
            Controls.Add(pnlJarak);
            Controls.Add(tlpKartu);
            Font = new Font("Leelawadee UI", 10.5F);
            Name = "ucAdminDataUser";
            Padding = new Padding(24);
            Size = new Size(1100, 700);
            Load += ucAdminDataUser_Load;
            pnlBawah.ResumeLayout(false);
            pnlKartuTabel.ResumeLayout(false);
            pnlKartuTabelDalam.ResumeLayout(false);
            tabUtama.ResumeLayout(false);
            tabPermintaan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPermintaan).EndInit();
            pnlToolbarP.ResumeLayout(false);
            pnlToolbarP.PerformLayout();
            tabSemua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSemua).EndInit();
            pnlToolbarS.ResumeLayout(false);
            pnlToolbarS.PerformLayout();
            pnlSetujuiLuar.ResumeLayout(false);
            pnlSetujuiDalam.ResumeLayout(false);
            pnlSetujuiDalam.PerformLayout();
            tlpKartu.ResumeLayout(false);
            pnlKartuTotal.ResumeLayout(false);
            pnlKartuTotal.PerformLayout();
            pnlKartuMenunngu.ResumeLayout(false);
            pnlKartuMenunngu.PerformLayout();
            pnlKartuAktif.ResumeLayout(false);
            pnlKartuAktif.PerformLayout();
            pnlKartuNonaktif.ResumeLayout(false);
            pnlKartuNonaktif.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GradientPanel pnlPage;
        private TableLayoutPanel tlpKartu;
        private GradientPanel pnlKartuTotal;
        private Panel pnlKartuMenunngu;
        private Panel pnlBawah;
        private Panel pnlSetujuiLuar;
        private Panel pnlJarak;
        private Panel pnlKartuNonaktif;
        private Panel pnlKartuAktif;
        private Panel pnlKartuTabel;
        private Panel pnlGap;
        private Panel pnlSetujuiDalam;
        private Panel pnlKartuTabelDalam;
        private TabControl tabUtama;
        private TabPage tabPermintaan;
        private TabPage tabSemua;
        private Label lblTotalJudul;
        private Label lblTotal;
        private Label lblMenungguJudul;
        private Label lblMenunggu;
        private Panel pnlToolbarP;
        private Label lblBanned;
        private Label lblNnonaktifjudul;
        private Label lblAktif;
        private Label lblAktifJudul;
        private TextBox txtCariP;
        private ComboBox cmbRoleP;
        private Panel pnlToolbarS;
        private TextBox txtCariS;
        private ComboBox cmbRoleS;
        private GradientPanel pnlHeaderSetuju;
        private Label lblPassword;
        private Label lblJudul;
        private TextBox txtPassword;
        private ProgressBar prgKekuatan;
        private Button btnSetujui;
        private Button btnBatal;
        private Button btnGenerate;
        private DataGridView dgvSemua;
        private DataGridView dgvPermintaan;
        private DataGridViewTextBoxColumn colUsernameP;
        private DataGridViewTextBoxColumn colEmailP;
        private DataGridViewTextBoxColumn colRoleP;
        private DataGridViewTextBoxColumn colTanggalP;
        private DataGridViewButtonColumn colSetujui;
        private DataGridViewButtonColumn colTolak;
        private DataGridViewTextBoxColumn colUsernameS;
        private DataGridViewTextBoxColumn colEmailS;
        private DataGridViewTextBoxColumn colRoleS;
        private DataGridViewTextBoxColumn status;
        private DataGridViewButtonColumn btnBanned;
        private Label lblUsername;
        private TextBox txtEmail;
        private Label label1;
        private ComboBox cmbRole;
        private Label lblRole;
        private TextBox txtUsername;
    }
}
