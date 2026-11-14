namespace project_akhir_stock_gudang
{
    partial class ucHargaBatch
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
            pnlStat1 = new GradientPanel();
            pnlStat2 = new Panel();
            pnlStat4 = new Panel();
            pnlStat3 = new Panel();
            lblNilaiStokJudul = new Label();
            lblNilaiStok = new Label();
            lblPotensiJudul = new Label();
            lblBarangNaikJudul = new Label();
            lblBatchAktifJudul = new Label();
            lblPotensiLaba = new Label();
            lblBarangNaik = new Label();
            lblBatchAktif = new Label();
            pnlDaftar = new Panel();
            txtCari = new TextBox();
            cmbStatus = new ComboBox();
            lsBarang = new ListView();
            colBarang = new ColumnHeader();
            ColStok = new ColumnHeader();
            colModalTerakhir = new ColumnHeader();
            colHargaJual = new ColumnHeader();
            colStatus = new ColumnHeader();
            pnlBatch = new Panel();
            pnlHeaderBatch = new GradientPanel();
            lblJudul = new Label();
            lblSub = new Label();
            lvBatch = new ListView();
            pnlStat1.SuspendLayout();
            pnlStat2.SuspendLayout();
            pnlStat4.SuspendLayout();
            pnlStat3.SuspendLayout();
            pnlDaftar.SuspendLayout();
            pnlBatch.SuspendLayout();
            pnlHeaderBatch.SuspendLayout();
            SuspendLayout();
            // 
            // pnlStat1
            // 
            pnlStat1.Angle = 90F;
            pnlStat1.ColorBottom = Color.FromArgb(31, 107, 67);
            pnlStat1.ColorTop = Color.FromArgb(58, 152, 99);
            pnlStat1.Controls.Add(lblNilaiStok);
            pnlStat1.Controls.Add(lblNilaiStokJudul);
            pnlStat1.Location = new Point(36, 27);
            pnlStat1.Name = "pnlStat1";
            pnlStat1.Size = new Size(244, 100);
            pnlStat1.TabIndex = 0;
            // 
            // pnlStat2
            // 
            pnlStat2.BackColor = Color.White;
            pnlStat2.Controls.Add(lblPotensiLaba);
            pnlStat2.Controls.Add(lblPotensiJudul);
            pnlStat2.Location = new Point(297, 27);
            pnlStat2.Name = "pnlStat2";
            pnlStat2.Size = new Size(244, 100);
            pnlStat2.TabIndex = 1;
            // 
            // pnlStat4
            // 
            pnlStat4.BackColor = Color.White;
            pnlStat4.Controls.Add(lblBatchAktif);
            pnlStat4.Controls.Add(lblBatchAktifJudul);
            pnlStat4.Location = new Point(819, 27);
            pnlStat4.Name = "pnlStat4";
            pnlStat4.Size = new Size(244, 100);
            pnlStat4.TabIndex = 2;
            // 
            // pnlStat3
            // 
            pnlStat3.BackColor = Color.White;
            pnlStat3.Controls.Add(lblBarangNaik);
            pnlStat3.Controls.Add(lblBarangNaikJudul);
            pnlStat3.Location = new Point(558, 27);
            pnlStat3.Name = "pnlStat3";
            pnlStat3.Size = new Size(244, 100);
            pnlStat3.TabIndex = 3;
            // 
            // lblNilaiStokJudul
            // 
            lblNilaiStokJudul.AutoSize = true;
            lblNilaiStokJudul.BackColor = Color.Transparent;
            lblNilaiStokJudul.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNilaiStokJudul.Location = new Point(24, 20);
            lblNilaiStokJudul.Name = "lblNilaiStokJudul";
            lblNilaiStokJudul.Size = new Size(172, 20);
            lblNilaiStokJudul.TabIndex = 4;
            lblNilaiStokJudul.Text = "Total nilai stok (modal)\t";
            // 
            // lblNilaiStok
            // 
            lblNilaiStok.AutoSize = true;
            lblNilaiStok.BackColor = Color.Transparent;
            lblNilaiStok.Font = new Font("Leelawadee UI", 21F, FontStyle.Bold);
            lblNilaiStok.Location = new Point(20, 42);
            lblNilaiStok.Name = "lblNilaiStok";
            lblNilaiStok.Size = new Size(40, 47);
            lblNilaiStok.TabIndex = 4;
            lblNilaiStok.Text = "0";
            // 
            // lblPotensiJudul
            // 
            lblPotensiJudul.AutoSize = true;
            lblPotensiJudul.BackColor = Color.Transparent;
            lblPotensiJudul.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPotensiJudul.Location = new Point(29, 20);
            lblPotensiJudul.Name = "lblPotensiJudul";
            lblPotensiJudul.Size = new Size(128, 20);
            lblPotensiJudul.TabIndex = 5;
            lblPotensiJudul.Text = "Potensi laba stok";
            // 
            // lblBarangNaikJudul
            // 
            lblBarangNaikJudul.AutoSize = true;
            lblBarangNaikJudul.BackColor = Color.Transparent;
            lblBarangNaikJudul.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBarangNaikJudul.Location = new Point(23, 20);
            lblBarangNaikJudul.Name = "lblBarangNaikJudul";
            lblBarangNaikJudul.Size = new Size(136, 20);
            lblBarangNaikJudul.TabIndex = 5;
            lblBarangNaikJudul.Text = "Barang naik harga";
            // 
            // lblBatchAktifJudul
            // 
            lblBatchAktifJudul.AutoSize = true;
            lblBatchAktifJudul.BackColor = Color.Transparent;
            lblBatchAktifJudul.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBatchAktifJudul.Location = new Point(23, 20);
            lblBatchAktifJudul.Name = "lblBatchAktifJudul";
            lblBatchAktifJudul.Size = new Size(85, 20);
            lblBatchAktifJudul.TabIndex = 5;
            lblBatchAktifJudul.Text = "Batch aktif";
            // 
            // lblPotensiLaba
            // 
            lblPotensiLaba.AutoSize = true;
            lblPotensiLaba.BackColor = Color.Transparent;
            lblPotensiLaba.Font = new Font("Leelawadee UI", 21F, FontStyle.Bold);
            lblPotensiLaba.Location = new Point(23, 42);
            lblPotensiLaba.Name = "lblPotensiLaba";
            lblPotensiLaba.Size = new Size(40, 47);
            lblPotensiLaba.TabIndex = 6;
            lblPotensiLaba.Text = "0";
            // 
            // lblBarangNaik
            // 
            lblBarangNaik.AutoSize = true;
            lblBarangNaik.BackColor = Color.Transparent;
            lblBarangNaik.Font = new Font("Leelawadee UI", 21F, FontStyle.Bold);
            lblBarangNaik.Location = new Point(23, 42);
            lblBarangNaik.Name = "lblBarangNaik";
            lblBarangNaik.Size = new Size(40, 47);
            lblBarangNaik.TabIndex = 6;
            lblBarangNaik.Text = "0";
            // 
            // lblBatchAktif
            // 
            lblBatchAktif.AutoSize = true;
            lblBatchAktif.BackColor = Color.Transparent;
            lblBatchAktif.Font = new Font("Leelawadee UI", 21F, FontStyle.Bold);
            lblBatchAktif.Location = new Point(23, 42);
            lblBatchAktif.Name = "lblBatchAktif";
            lblBatchAktif.Size = new Size(40, 47);
            lblBatchAktif.TabIndex = 6;
            lblBatchAktif.Text = "0";
            // 
            // pnlDaftar
            // 
            pnlDaftar.BackColor = Color.White;
            pnlDaftar.Controls.Add(lsBarang);
            pnlDaftar.Controls.Add(cmbStatus);
            pnlDaftar.Controls.Add(txtCari);
            pnlDaftar.ForeColor = Color.FromArgb(27, 43, 34);
            pnlDaftar.Location = new Point(36, 152);
            pnlDaftar.Name = "pnlDaftar";
            pnlDaftar.Size = new Size(505, 513);
            pnlDaftar.TabIndex = 4;
            // 
            // txtCari
            // 
            txtCari.BackColor = Color.White;
            txtCari.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCari.ForeColor = Color.FromArgb(27, 43, 34);
            txtCari.Location = new Point(24, 16);
            txtCari.Name = "txtCari";
            txtCari.PlaceholderText = "Cari kode atau nama barang";
            txtCari.Size = new Size(300, 34);
            txtCari.TabIndex = 0;
            // 
            // cmbStatus
            // 
            cmbStatus.BackColor = Color.White;
            cmbStatus.ForeColor = Color.FromArgb(27, 43, 34);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Sema status ", "Harga naik", "Harga turun" });
            cmbStatus.Location = new Point(336, 18);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(150, 31);
            cmbStatus.TabIndex = 1;
            // 
            // lsBarang
            // 
            lsBarang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lsBarang.BackColor = Color.White;
            lsBarang.BorderStyle = BorderStyle.None;
            lsBarang.Columns.AddRange(new ColumnHeader[] { colBarang, ColStok, colModalTerakhir, colHargaJual, colStatus });
            lsBarang.ForeColor = Color.FromArgb(27, 43, 34);
            lsBarang.FullRowSelect = true;
            lsBarang.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lsBarang.Location = new Point(0, 66);
            lsBarang.MultiSelect = false;
            lsBarang.Name = "lsBarang";
            lsBarang.OwnerDraw = true;
            lsBarang.Size = new Size(505, 447);
            lsBarang.TabIndex = 2;
            lsBarang.UseCompatibleStateImageBehavior = false;
            lsBarang.View = View.Details;
            // 
            // colBarang
            // 
            colBarang.Text = "Barang";
            colBarang.Width = 162;
            // 
            // ColStok
            // 
            ColStok.Text = "Stok";
            ColStok.Width = 55;
            // 
            // colModalTerakhir
            // 
            colModalTerakhir.Text = "Modal terakhir";
            colModalTerakhir.Width = 110;
            // 
            // colHargaJual
            // 
            colHargaJual.Text = "HargaJual";
            colHargaJual.Width = 95;
            // 
            // colStatus
            // 
            colStatus.Text = "Status";
            colStatus.Width = 90;
            // 
            // pnlBatch
            // 
            pnlBatch.BackColor = Color.White;
            pnlBatch.Controls.Add(lvBatch);
            pnlBatch.Controls.Add(pnlHeaderBatch);
            pnlBatch.Location = new Point(581, 152);
            pnlBatch.Name = "pnlBatch";
            pnlBatch.Size = new Size(500, 513);
            pnlBatch.TabIndex = 5;
            // 
            // pnlHeaderBatch
            // 
            pnlHeaderBatch.Angle = 45F;
            pnlHeaderBatch.ColorBottom = Color.FromArgb(143, 227, 181);
            pnlHeaderBatch.ColorTop = Color.FromArgb(31, 107, 67);
            pnlHeaderBatch.Controls.Add(lblSub);
            pnlHeaderBatch.Controls.Add(lblJudul);
            pnlHeaderBatch.Location = new Point(0, 0);
            pnlHeaderBatch.Name = "pnlHeaderBatch";
            pnlHeaderBatch.Size = new Size(500, 83);
            pnlHeaderBatch.TabIndex = 0;
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.BackColor = Color.Transparent;
            lblJudul.Font = new Font("Leelawadee UI", 15F, FontStyle.Bold);
            lblJudul.ForeColor = Color.White;
            lblJudul.Location = new Point(27, 15);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(261, 35);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Batch stok dan harga";
            // 
            // lblSub
            // 
            lblSub.AutoSize = true;
            lblSub.BackColor = Color.Transparent;
            lblSub.ForeColor = Color.White;
            lblSub.Location = new Point(27, 48);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(214, 25);
            lblSub.TabIndex = 1;
            lblSub.Text = "Text Pilih barang di daftar";
            // 
            // lvBatch
            // 
            lvBatch.BorderStyle = BorderStyle.None;
            lvBatch.ForeColor = Color.FromArgb(27, 43, 34);
            lvBatch.FullRowSelect = true;
            lvBatch.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvBatch.Location = new Point(0, 95);
            lvBatch.MultiSelect = false;
            lvBatch.Name = "lvBatch";
            lvBatch.Size = new Size(500, 120);
            lvBatch.TabIndex = 1;
            lvBatch.UseCompatibleStateImageBehavior = false;
            // 
            // ucHargaBatch
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 251, 246);
            Controls.Add(pnlBatch);
            Controls.Add(pnlDaftar);
            Controls.Add(pnlStat3);
            Controls.Add(pnlStat4);
            Controls.Add(pnlStat2);
            Controls.Add(pnlStat1);
            Font = new Font("Leelawadee UI", 10.5F);
            Name = "ucHargaBatch";
            Size = new Size(1100, 700);
            pnlStat1.ResumeLayout(false);
            pnlStat1.PerformLayout();
            pnlStat2.ResumeLayout(false);
            pnlStat2.PerformLayout();
            pnlStat4.ResumeLayout(false);
            pnlStat4.PerformLayout();
            pnlStat3.ResumeLayout(false);
            pnlStat3.PerformLayout();
            pnlDaftar.ResumeLayout(false);
            pnlDaftar.PerformLayout();
            pnlBatch.ResumeLayout(false);
            pnlHeaderBatch.ResumeLayout(false);
            pnlHeaderBatch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GradientPanel pnlStat1;
        private Panel pnlStat2;
        private Label lblNilaiStokJudul;
        private Panel pnlStat4;
        private Panel pnlStat3;
        private Label lblNilaiStok;
        private Label lblPotensiJudul;
        private Label lblBatchAktifJudul;
        private Label lblBarangNaikJudul;
        private Label lblPotensiLaba;
        private Label lblBatchAktif;
        private Label lblBarangNaik;
        private Panel pnlDaftar;
        private TextBox txtCari;
        private ComboBox cmbStatus;
        private ListView lsBarang;
        private ColumnHeader colBarang;
        private ColumnHeader ColStok;
        private ColumnHeader colModalTerakhir;
        private ColumnHeader colHargaJual;
        private ColumnHeader colStatus;
        private Panel pnlBatch;
        private GradientPanel pnlHeaderBatch;
        private Label lblSub;
        private Label lblJudul;
        private ListView lvBatch;
    }
}
