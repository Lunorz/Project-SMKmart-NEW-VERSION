namespace project_akhir_stock_gudang
{
    partial class ucDataBarang
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlPage1 = new GradientPanel();
            pnlBawah1 = new Panel();
            pnlKartuTabel1 = new Panel();
            pnlKartuTabelDalam1 = new Panel();
            dgvBarang1 = new DataGridView();
            colKode1 = new DataGridViewTextBoxColumn();
            colBarang1 = new DataGridViewTextBoxColumn();
            colKategori1 = new DataGridViewTextBoxColumn();
            colHargaBarang1 = new DataGridViewTextBoxColumn();
            colHapus1 = new DataGridViewButtonColumn();
            pnlToolbar1 = new Panel();
            cmbFilter1 = new ComboBox();
            txtCari1 = new TextBox();
            pnlGap1 = new Panel();
            pnlTambahLuar1 = new Panel();
            pnlTambahDalam1 = new Panel();
            txtHargaBarang = new TextBox();
            lblHargaBarang1 = new Label();
            btnSimpan1 = new Button();
            txtKategori1 = new TextBox();
            lblKatwgori1 = new Label();
            txtNama1 = new TextBox();
            lblNama1 = new Label();
            txtKode1 = new TextBox();
            lblKode1 = new Label();
            pnlHeaderTambah1 = new GradientPanel();
            lblRingkasan1 = new Label();
            lblJudul1 = new Label();
            numStockAwal = new NumericUpDown();
            lblStockAwal = new Label();
            pnlPage1.SuspendLayout();
            pnlBawah1.SuspendLayout();
            pnlKartuTabel1.SuspendLayout();
            pnlKartuTabelDalam1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBarang1).BeginInit();
            pnlToolbar1.SuspendLayout();
            pnlTambahLuar1.SuspendLayout();
            pnlTambahDalam1.SuspendLayout();
            pnlHeaderTambah1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numStockAwal).BeginInit();
            SuspendLayout();
            // 
            // pnlPage1
            // 
            pnlPage1.Angle = 90F;
            pnlPage1.ColorBottom = Color.White;
            pnlPage1.ColorTop = Color.FromArgb(230, 247, 238);
            pnlPage1.Controls.Add(pnlBawah1);
            pnlPage1.Dock = DockStyle.Fill;
            pnlPage1.Location = new Point(0, 0);
            pnlPage1.Name = "pnlPage1";
            pnlPage1.Padding = new Padding(24);
            pnlPage1.Size = new Size(1100, 700);
            pnlPage1.TabIndex = 0;
            // 
            // pnlBawah1
            // 
            pnlBawah1.BackColor = Color.Transparent;
            pnlBawah1.Controls.Add(pnlKartuTabel1);
            pnlBawah1.Controls.Add(pnlGap1);
            pnlBawah1.Controls.Add(pnlTambahLuar1);
            pnlBawah1.Dock = DockStyle.Fill;
            pnlBawah1.Location = new Point(24, 24);
            pnlBawah1.Name = "pnlBawah1";
            pnlBawah1.Size = new Size(1052, 652);
            pnlBawah1.TabIndex = 0;
            // 
            // pnlKartuTabel1
            // 
            pnlKartuTabel1.BackColor = Color.FromArgb(213, 235, 223);
            pnlKartuTabel1.Controls.Add(pnlKartuTabelDalam1);
            pnlKartuTabel1.Dock = DockStyle.Fill;
            pnlKartuTabel1.Location = new Point(0, 0);
            pnlKartuTabel1.Name = "pnlKartuTabel1";
            pnlKartuTabel1.Padding = new Padding(1);
            pnlKartuTabel1.Size = new Size(688, 652);
            pnlKartuTabel1.TabIndex = 2;
            // 
            // pnlKartuTabelDalam1
            // 
            pnlKartuTabelDalam1.BackColor = Color.White;
            pnlKartuTabelDalam1.Controls.Add(dgvBarang1);
            pnlKartuTabelDalam1.Controls.Add(pnlToolbar1);
            pnlKartuTabelDalam1.Dock = DockStyle.Fill;
            pnlKartuTabelDalam1.Location = new Point(1, 1);
            pnlKartuTabelDalam1.Name = "pnlKartuTabelDalam1";
            pnlKartuTabelDalam1.Size = new Size(686, 650);
            pnlKartuTabelDalam1.TabIndex = 0;
            // 
            // dgvBarang1
            // 
            dgvBarang1.AllowUserToAddRows = false;
            dgvBarang1.AllowUserToDeleteRows = false;
            dgvBarang1.AllowUserToOrderColumns = true;
            dgvBarang1.AllowUserToResizeColumns = false;
            dgvBarang1.AllowUserToResizeRows = false;
            dgvBarang1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBarang1.BackgroundColor = Color.White;
            dgvBarang1.BorderStyle = BorderStyle.None;
            dgvBarang1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBarang1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(245, 251, 248);
            dataGridViewCellStyle3.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(79, 106, 92);
            dataGridViewCellStyle3.Padding = new Padding(12, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(245, 251, 248);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(79, 106, 92);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvBarang1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvBarang1.ColumnHeadersHeight = 40;
            dgvBarang1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBarang1.Columns.AddRange(new DataGridViewColumn[] { colKode1, colBarang1, colKategori1, colHargaBarang1, colHapus1 });
            dgvBarang1.Dock = DockStyle.Fill;
            dgvBarang1.EnableHeadersVisualStyles = false;
            dgvBarang1.GridColor = Color.FromArgb(230, 247, 238);
            dgvBarang1.Location = new Point(0, 72);
            dgvBarang1.MultiSelect = false;
            dgvBarang1.Name = "dgvBarang1";
            dgvBarang1.ReadOnly = true;
            dgvBarang1.RowHeadersVisible = false;
            dgvBarang1.RowHeadersWidth = 51;
            dgvBarang1.RowTemplate.Height = 56;
            dgvBarang1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBarang1.Size = new Size(686, 578);
            dgvBarang1.TabIndex = 1;
            dgvBarang1.CellClick += dgvBarang1_CellClick;
            dgvBarang1.CellContentClick += dgvBarang1_CellContentClick;
            // 
            // colKode1
            // 
            colKode1.FillWeight = 60F;
            colKode1.HeaderText = "kode";
            colKode1.MinimumWidth = 6;
            colKode1.Name = "colKode1";
            colKode1.ReadOnly = true;
            // 
            // colBarang1
            // 
            colBarang1.FillWeight = 150F;
            colBarang1.HeaderText = "nama barang";
            colBarang1.MinimumWidth = 6;
            colBarang1.Name = "colBarang1";
            colBarang1.ReadOnly = true;
            // 
            // colKategori1
            // 
            colKategori1.HeaderText = "kategori";
            colKategori1.MinimumWidth = 6;
            colKategori1.Name = "colKategori1";
            colKategori1.ReadOnly = true;
            // 
            // colHargaBarang1
            // 
            colHargaBarang1.HeaderText = "Harga";
            colHargaBarang1.MinimumWidth = 6;
            colHargaBarang1.Name = "colHargaBarang1";
            colHargaBarang1.ReadOnly = true;
            // 
            // colHapus1
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(169, 50, 38);
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(169, 50, 38);
            colHapus1.DefaultCellStyle = dataGridViewCellStyle4;
            colHapus1.FlatStyle = FlatStyle.Flat;
            colHapus1.HeaderText = "aksi";
            colHapus1.MinimumWidth = 6;
            colHapus1.Name = "colHapus1";
            colHapus1.ReadOnly = true;
            colHapus1.Text = "Hapus";
            colHapus1.UseColumnTextForButtonValue = true;
            // 
            // pnlToolbar1
            // 
            pnlToolbar1.Controls.Add(cmbFilter1);
            pnlToolbar1.Controls.Add(txtCari1);
            pnlToolbar1.Dock = DockStyle.Top;
            pnlToolbar1.Location = new Point(0, 0);
            pnlToolbar1.Name = "pnlToolbar1";
            pnlToolbar1.Size = new Size(686, 72);
            pnlToolbar1.TabIndex = 0;
            // 
            // cmbFilter1
            // 
            cmbFilter1.BackColor = Color.White;
            cmbFilter1.FlatStyle = FlatStyle.Flat;
            cmbFilter1.ForeColor = Color.FromArgb(18, 55, 42);
            cmbFilter1.FormattingEnabled = true;
            cmbFilter1.Location = new Point(500, 18);
            cmbFilter1.Name = "cmbFilter1";
            cmbFilter1.Size = new Size(170, 31);
            cmbFilter1.TabIndex = 1;
            cmbFilter1.SelectedIndexChanged += cmbFilter1_SelectedIndexChanged;
            // 
            // txtCari1
            // 
            txtCari1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCari1.BackColor = Color.White;
            txtCari1.BorderStyle = BorderStyle.FixedSingle;
            txtCari1.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCari1.ForeColor = Color.FromArgb(18, 55, 42);
            txtCari1.Location = new Point(16, 16);
            txtCari1.Name = "txtCari1";
            txtCari1.Size = new Size(460, 34);
            txtCari1.TabIndex = 0;
            txtCari1.TextChanged += txtCari1_TextChanged;
            // 
            // pnlGap1
            // 
            pnlGap1.Dock = DockStyle.Right;
            pnlGap1.Location = new Point(688, 0);
            pnlGap1.Name = "pnlGap1";
            pnlGap1.Size = new Size(24, 652);
            pnlGap1.TabIndex = 1;
            // 
            // pnlTambahLuar1
            // 
            pnlTambahLuar1.BackColor = Color.FromArgb(213, 235, 223);
            pnlTambahLuar1.Controls.Add(pnlTambahDalam1);
            pnlTambahLuar1.Dock = DockStyle.Right;
            pnlTambahLuar1.Location = new Point(712, 0);
            pnlTambahLuar1.Name = "pnlTambahLuar1";
            pnlTambahLuar1.Padding = new Padding(1);
            pnlTambahLuar1.Size = new Size(340, 652);
            pnlTambahLuar1.TabIndex = 0;
            // 
            // pnlTambahDalam1
            // 
            pnlTambahDalam1.BackColor = Color.White;
            pnlTambahDalam1.Controls.Add(lblStockAwal);
            pnlTambahDalam1.Controls.Add(numStockAwal);
            pnlTambahDalam1.Controls.Add(txtHargaBarang);
            pnlTambahDalam1.Controls.Add(lblHargaBarang1);
            pnlTambahDalam1.Controls.Add(btnSimpan1);
            pnlTambahDalam1.Controls.Add(txtKategori1);
            pnlTambahDalam1.Controls.Add(lblKatwgori1);
            pnlTambahDalam1.Controls.Add(txtNama1);
            pnlTambahDalam1.Controls.Add(lblNama1);
            pnlTambahDalam1.Controls.Add(txtKode1);
            pnlTambahDalam1.Controls.Add(lblKode1);
            pnlTambahDalam1.Controls.Add(pnlHeaderTambah1);
            pnlTambahDalam1.Dock = DockStyle.Fill;
            pnlTambahDalam1.Location = new Point(1, 1);
            pnlTambahDalam1.Name = "pnlTambahDalam1";
            pnlTambahDalam1.Size = new Size(338, 650);
            pnlTambahDalam1.TabIndex = 0;
            // 
            // txtHargaBarang
            // 
            txtHargaBarang.BackColor = Color.White;
            txtHargaBarang.BorderStyle = BorderStyle.FixedSingle;
            txtHargaBarang.Font = new Font("Leelawadee UI", 11F);
            txtHargaBarang.ForeColor = Color.FromArgb(18, 55, 42);
            txtHargaBarang.Location = new Point(20, 321);
            txtHargaBarang.Name = "txtHargaBarang";
            txtHargaBarang.Size = new Size(298, 32);
            txtHargaBarang.TabIndex = 9;
            // 
            // lblHargaBarang1
            // 
            lblHargaBarang1.AutoSize = true;
            lblHargaBarang1.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHargaBarang1.ForeColor = Color.FromArgb(79, 106, 92);
            lblHargaBarang1.Location = new Point(20, 298);
            lblHargaBarang1.Name = "lblHargaBarang1";
            lblHargaBarang1.Size = new Size(51, 20);
            lblHargaBarang1.TabIndex = 8;
            lblHargaBarang1.Text = "Harga";
            // 
            // btnSimpan1
            // 
            btnSimpan1.BackColor = Color.FromArgb(42, 127, 80);
            btnSimpan1.FlatAppearance.BorderSize = 0;
            btnSimpan1.FlatStyle = FlatStyle.Flat;
            btnSimpan1.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan1.ForeColor = Color.White;
            btnSimpan1.Location = new Point(20, 448);
            btnSimpan1.Name = "btnSimpan1";
            btnSimpan1.Size = new Size(298, 40);
            btnSimpan1.TabIndex = 7;
            btnSimpan1.Text = "Simpan barang";
            btnSimpan1.UseVisualStyleBackColor = false;
            btnSimpan1.Click += btnSimpan1_Click;
            // 
            // txtKategori1
            // 
            txtKategori1.BackColor = Color.White;
            txtKategori1.BorderStyle = BorderStyle.FixedSingle;
            txtKategori1.Font = new Font("Leelawadee UI", 11F);
            txtKategori1.ForeColor = Color.FromArgb(18, 55, 42);
            txtKategori1.Location = new Point(20, 254);
            txtKategori1.Name = "txtKategori1";
            txtKategori1.Size = new Size(298, 32);
            txtKategori1.TabIndex = 6;
            // 
            // lblKatwgori1
            // 
            lblKatwgori1.AutoSize = true;
            lblKatwgori1.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKatwgori1.ForeColor = Color.FromArgb(79, 106, 92);
            lblKatwgori1.Location = new Point(20, 231);
            lblKatwgori1.Name = "lblKatwgori1";
            lblKatwgori1.Size = new Size(69, 20);
            lblKatwgori1.TabIndex = 5;
            lblKatwgori1.Text = "Kategori";
            // 
            // txtNama1
            // 
            txtNama1.BackColor = Color.White;
            txtNama1.BorderStyle = BorderStyle.FixedSingle;
            txtNama1.Font = new Font("Leelawadee UI", 11F);
            txtNama1.ForeColor = Color.FromArgb(18, 55, 42);
            txtNama1.Location = new Point(20, 190);
            txtNama1.MaxLength = 60;
            txtNama1.Name = "txtNama1";
            txtNama1.Size = new Size(298, 32);
            txtNama1.TabIndex = 4;
            txtNama1.TextChanged += txtNama1_TextChanged;
            // 
            // lblNama1
            // 
            lblNama1.AutoSize = true;
            lblNama1.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNama1.ForeColor = Color.FromArgb(79, 106, 92);
            lblNama1.Location = new Point(20, 168);
            lblNama1.Name = "lblNama1";
            lblNama1.Size = new Size(104, 20);
            lblNama1.TabIndex = 3;
            lblNama1.Text = "Nama barang";
            // 
            // txtKode1
            // 
            txtKode1.BackColor = Color.FromArgb(245, 251, 248);
            txtKode1.BorderStyle = BorderStyle.FixedSingle;
            txtKode1.Font = new Font("Leelawadee UI", 11F);
            txtKode1.ForeColor = Color.FromArgb(79, 106, 92);
            txtKode1.Location = new Point(20, 126);
            txtKode1.Name = "txtKode1";
            txtKode1.PlaceholderText = "Terisi otomatis setelah memilih kategori";
            txtKode1.ReadOnly = true;
            txtKode1.Size = new Size(298, 32);
            txtKode1.TabIndex = 2;
            txtKode1.TabStop = false;
            // 
            // lblKode1
            // 
            lblKode1.AutoSize = true;
            lblKode1.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKode1.ForeColor = Color.FromArgb(79, 106, 92);
            lblKode1.Location = new Point(20, 104);
            lblKode1.Name = "lblKode1";
            lblKode1.Size = new Size(98, 20);
            lblKode1.TabIndex = 1;
            lblKode1.Text = "Kode barang";
            // 
            // pnlHeaderTambah1
            // 
            pnlHeaderTambah1.Angle = 45F;
            pnlHeaderTambah1.ColorBottom = Color.FromArgb(152, 232, 193);
            pnlHeaderTambah1.ColorTop = Color.FromArgb(42, 127, 80);
            pnlHeaderTambah1.Controls.Add(lblRingkasan1);
            pnlHeaderTambah1.Controls.Add(lblJudul1);
            pnlHeaderTambah1.Dock = DockStyle.Top;
            pnlHeaderTambah1.Location = new Point(0, 0);
            pnlHeaderTambah1.Name = "pnlHeaderTambah1";
            pnlHeaderTambah1.Size = new Size(338, 84);
            pnlHeaderTambah1.TabIndex = 0;
            // 
            // lblRingkasan1
            // 
            lblRingkasan1.AutoSize = true;
            lblRingkasan1.BackColor = Color.Transparent;
            lblRingkasan1.Font = new Font("Leelawadee UI", 9.75F);
            lblRingkasan1.ForeColor = Color.FromArgb(14, 47, 34);
            lblRingkasan1.Location = new Point(20, 50);
            lblRingkasan1.Name = "lblRingkasan1";
            lblRingkasan1.Size = new Size(216, 23);
            lblRingkasan1.TabIndex = 1;
            lblRingkasan1.Text = "Isi data barang lalu simpan";
            // 
            // lblJudul1
            // 
            lblJudul1.AutoSize = true;
            lblJudul1.BackColor = Color.Transparent;
            lblJudul1.Font = new Font("Leelawadee UI", 13.5F, FontStyle.Bold);
            lblJudul1.ForeColor = Color.FromArgb(14, 47, 34);
            lblJudul1.Location = new Point(20, 16);
            lblJudul1.Name = "lblJudul1";
            lblJudul1.Size = new Size(182, 31);
            lblJudul1.TabIndex = 0;
            lblJudul1.Text = "Tambah Barang";
            // 
            // numStockAwal
            // 
            numStockAwal.Location = new Point(20, 388);
            numStockAwal.Name = "numStockAwal";
            numStockAwal.Size = new Size(298, 31);
            numStockAwal.TabIndex = 10;
            // 
            // lblStockAwal
            // 
            lblStockAwal.AutoSize = true;
            lblStockAwal.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStockAwal.ForeColor = Color.FromArgb(79, 106, 92);
            lblStockAwal.Location = new Point(20, 365);
            lblStockAwal.Name = "lblStockAwal";
            lblStockAwal.Size = new Size(83, 20);
            lblStockAwal.TabIndex = 11;
            lblStockAwal.Text = "Stock awal";
            // 
            // ucDataBarang
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 251, 248);
            Controls.Add(pnlPage1);
            Font = new Font("Leelawadee UI", 10.5F);
            Name = "ucDataBarang";
            Size = new Size(1100, 700);
            pnlPage1.ResumeLayout(false);
            pnlBawah1.ResumeLayout(false);
            pnlKartuTabel1.ResumeLayout(false);
            pnlKartuTabelDalam1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBarang1).EndInit();
            pnlToolbar1.ResumeLayout(false);
            pnlToolbar1.PerformLayout();
            pnlTambahLuar1.ResumeLayout(false);
            pnlTambahDalam1.ResumeLayout(false);
            pnlTambahDalam1.PerformLayout();
            pnlHeaderTambah1.ResumeLayout(false);
            pnlHeaderTambah1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numStockAwal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GradientPanel pnlPage1;
        private Panel pnlBawah1;
        private Panel pnlTambahLuar1;
        private Panel pnlTambahDalam1;
        private GradientPanel pnlHeaderTambah1;
        private Panel pnlKartuTabel1;
        private Panel pnlKartuTabelDalam1;
        private Panel pnlGap1;
        private Panel pnlToolbar1;
        private TextBox txtCari1;
        private ComboBox cmbFilter1;
        private DataGridView dgvBarang1;
        private Label lblRingkasan1;
        private Label lblJudul1;
        private Label lblKode1;
        private Label lblNama1;
        private TextBox txtKode1;
        private TextBox txtNama1;
        private TextBox txtKategori1;
        private Label lblKatwgori1;
        private Button btnSimpan1;
        private Label lblHargaBarang1;
        private DataGridViewTextBoxColumn colKode1;
        private DataGridViewTextBoxColumn colBarang1;
        private DataGridViewTextBoxColumn colKategori1;
        private DataGridViewTextBoxColumn colHargaBarang1;
        private DataGridViewButtonColumn colHapus1;
        private TextBox txtHargaBarang;
        private Label lblStockAwal;
        private NumericUpDown numStockAwal;
    }
}
