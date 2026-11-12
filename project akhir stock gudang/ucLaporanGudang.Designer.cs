namespace project_akhir_stock_gudang
{
    partial class ucLaporanGudang
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
            pnlPage = new Panel();
            pnlKartuTabel = new Panel();
            pnlJarak2 = new Panel();
            pnlFilterLuar = new Panel();
            pnlFilterDalam = new Panel();
            cmbJenis = new ComboBox();
            dtpSampai = new DateTimePicker();
            dtpDari = new DateTimePicker();
            lblPetugas = new Label();
            lblBarang = new Label();
            lblJenis = new Label();
            lblSampai = new Label();
            lblDari = new Label();
            pnlJarak = new Panel();
            tlpKartu = new TableLayoutPanel();
            pnlKartuRestok = new Panel();
            pnlKartuRestokDalam = new Panel();
            lblRestok = new Label();
            lblRestokJudul = new Label();
            pnlKartuOpname = new Panel();
            pnlKartuOpnameDalam = new Panel();
            lblOpname = new Label();
            lblOpnameJudul = new Label();
            pnlKartuMasuk = new GradientPanel();
            lblMasuk = new Label();
            lblMasukJudul = new Label();
            pnlKartuLuar = new Panel();
            pnlKartuKeluarDalam = new Panel();
            lblKeluar = new Label();
            lblKeluarJudul = new Label();
            cmbPetugas = new ComboBox();
            pnlPage.SuspendLayout();
            pnlFilterLuar.SuspendLayout();
            pnlFilterDalam.SuspendLayout();
            tlpKartu.SuspendLayout();
            pnlKartuRestok.SuspendLayout();
            pnlKartuRestokDalam.SuspendLayout();
            pnlKartuOpname.SuspendLayout();
            pnlKartuOpnameDalam.SuspendLayout();
            pnlKartuMasuk.SuspendLayout();
            pnlKartuLuar.SuspendLayout();
            pnlKartuKeluarDalam.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPage
            // 
            pnlPage.Controls.Add(pnlKartuTabel);
            pnlPage.Controls.Add(pnlJarak2);
            pnlPage.Controls.Add(pnlFilterLuar);
            pnlPage.Controls.Add(pnlJarak);
            pnlPage.Controls.Add(tlpKartu);
            pnlPage.Dock = DockStyle.Fill;
            pnlPage.Location = new Point(0, 0);
            pnlPage.Name = "pnlPage";
            pnlPage.Padding = new Padding(27, 28, 27, 28);
            pnlPage.Size = new Size(1238, 805);
            pnlPage.TabIndex = 0;
            // 
            // pnlKartuTabel
            // 
            pnlKartuTabel.BackColor = Color.FromArgb(213, 235, 223);
            pnlKartuTabel.Dock = DockStyle.Fill;
            pnlKartuTabel.Location = new Point(27, 286);
            pnlKartuTabel.Name = "pnlKartuTabel";
            pnlKartuTabel.Padding = new Padding(1);
            pnlKartuTabel.Size = new Size(1184, 491);
            pnlKartuTabel.TabIndex = 4;
            // 
            // pnlJarak2
            // 
            pnlJarak2.Dock = DockStyle.Top;
            pnlJarak2.Location = new Point(27, 268);
            pnlJarak2.Name = "pnlJarak2";
            pnlJarak2.Size = new Size(1184, 18);
            pnlJarak2.TabIndex = 3;
            // 
            // pnlFilterLuar
            // 
            pnlFilterLuar.BackColor = Color.FromArgb(213, 235, 223);
            pnlFilterLuar.Controls.Add(pnlFilterDalam);
            pnlFilterLuar.Dock = DockStyle.Top;
            pnlFilterLuar.Location = new Point(27, 171);
            pnlFilterLuar.Name = "pnlFilterLuar";
            pnlFilterLuar.Padding = new Padding(1);
            pnlFilterLuar.Size = new Size(1184, 97);
            pnlFilterLuar.TabIndex = 2;
            // 
            // pnlFilterDalam
            // 
            pnlFilterDalam.BackColor = Color.White;
            pnlFilterDalam.Controls.Add(cmbPetugas);
            pnlFilterDalam.Controls.Add(cmbJenis);
            pnlFilterDalam.Controls.Add(dtpSampai);
            pnlFilterDalam.Controls.Add(dtpDari);
            pnlFilterDalam.Controls.Add(lblPetugas);
            pnlFilterDalam.Controls.Add(lblBarang);
            pnlFilterDalam.Controls.Add(lblJenis);
            pnlFilterDalam.Controls.Add(lblSampai);
            pnlFilterDalam.Controls.Add(lblDari);
            pnlFilterDalam.Dock = DockStyle.Fill;
            pnlFilterDalam.Location = new Point(1, 1);
            pnlFilterDalam.Name = "pnlFilterDalam";
            pnlFilterDalam.Size = new Size(1182, 95);
            pnlFilterDalam.TabIndex = 0;
            // 
            // cmbJenis
            // 
            cmbJenis.FormattingEnabled = true;
            cmbJenis.Items.AddRange(new object[] { "Semua jenis ", "Masuk ", "Keluar", "Penjualan", "Opname" });
            cmbJenis.Location = new Point(300, 34);
            cmbJenis.Name = "cmbJenis";
            cmbJenis.Size = new Size(140, 31);
            cmbJenis.TabIndex = 7;
            // 
            // dtpSampai
            // 
            dtpSampai.CustomFormat = "dd MMM yyyy\t";
            dtpSampai.Format = DateTimePickerFormat.Custom;
            dtpSampai.Location = new Point(158, 34);
            dtpSampai.Name = "dtpSampai";
            dtpSampai.Size = new Size(130, 31);
            dtpSampai.TabIndex = 6;
            // 
            // dtpDari
            // 
            dtpDari.CustomFormat = "dd MMM yyyy\t";
            dtpDari.Format = DateTimePickerFormat.Custom;
            dtpDari.Location = new Point(16, 34);
            dtpDari.Name = "dtpDari";
            dtpDari.Size = new Size(130, 31);
            dtpDari.TabIndex = 5;
            // 
            // lblPetugas
            // 
            lblPetugas.AutoSize = true;
            lblPetugas.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPetugas.ForeColor = Color.FromArgb(79, 106, 92);
            lblPetugas.Location = new Point(664, 12);
            lblPetugas.Name = "lblPetugas";
            lblPetugas.Size = new Size(65, 20);
            lblPetugas.TabIndex = 4;
            lblPetugas.Text = "Petugas";
            // 
            // lblBarang
            // 
            lblBarang.AutoSize = true;
            lblBarang.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBarang.ForeColor = Color.FromArgb(79, 106, 92);
            lblBarang.Location = new Point(452, 12);
            lblBarang.Name = "lblBarang";
            lblBarang.Size = new Size(59, 20);
            lblBarang.TabIndex = 3;
            lblBarang.Text = "Barang";
            // 
            // lblJenis
            // 
            lblJenis.AutoSize = true;
            lblJenis.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJenis.ForeColor = Color.FromArgb(79, 106, 92);
            lblJenis.Location = new Point(300, 12);
            lblJenis.Name = "lblJenis";
            lblJenis.Size = new Size(44, 20);
            lblJenis.TabIndex = 2;
            lblJenis.Text = "Jenis";
            // 
            // lblSampai
            // 
            lblSampai.AutoSize = true;
            lblSampai.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSampai.ForeColor = Color.FromArgb(79, 106, 92);
            lblSampai.Location = new Point(158, 12);
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
            lblDari.Location = new Point(18, 14);
            lblDari.Name = "lblDari";
            lblDari.Size = new Size(38, 20);
            lblDari.TabIndex = 0;
            lblDari.Text = "Dari";
            // 
            // pnlJarak
            // 
            pnlJarak.Dock = DockStyle.Top;
            pnlJarak.Location = new Point(27, 143);
            pnlJarak.Name = "pnlJarak";
            pnlJarak.Size = new Size(1184, 28);
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
            tlpKartu.Controls.Add(pnlKartuRestok, 3, 0);
            tlpKartu.Controls.Add(pnlKartuOpname, 2, 0);
            tlpKartu.Controls.Add(pnlKartuMasuk, 0, 0);
            tlpKartu.Controls.Add(pnlKartuLuar, 1, 0);
            tlpKartu.Dock = DockStyle.Top;
            tlpKartu.Location = new Point(27, 28);
            tlpKartu.Name = "tlpKartu";
            tlpKartu.RowCount = 1;
            tlpKartu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpKartu.Size = new Size(1184, 115);
            tlpKartu.TabIndex = 0;
            // 
            // pnlKartuRestok
            // 
            pnlKartuRestok.BackColor = Color.FromArgb(213, 235, 223);
            pnlKartuRestok.Controls.Add(pnlKartuRestokDalam);
            pnlKartuRestok.Location = new Point(888, 0);
            pnlKartuRestok.Margin = new Padding(0);
            pnlKartuRestok.Name = "pnlKartuRestok";
            pnlKartuRestok.Padding = new Padding(1);
            pnlKartuRestok.Size = new Size(278, 115);
            pnlKartuRestok.TabIndex = 3;
            // 
            // pnlKartuRestokDalam
            // 
            pnlKartuRestokDalam.BackColor = Color.White;
            pnlKartuRestokDalam.Controls.Add(lblRestok);
            pnlKartuRestokDalam.Controls.Add(lblRestokJudul);
            pnlKartuRestokDalam.Dock = DockStyle.Fill;
            pnlKartuRestokDalam.Location = new Point(1, 1);
            pnlKartuRestokDalam.Name = "pnlKartuRestokDalam";
            pnlKartuRestokDalam.Size = new Size(276, 113);
            pnlKartuRestokDalam.TabIndex = 1;
            // 
            // lblRestok
            // 
            lblRestok.AutoSize = true;
            lblRestok.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lblRestok.ForeColor = Color.FromArgb(31, 78, 121);
            lblRestok.Location = new Point(22, 48);
            lblRestok.Name = "lblRestok";
            lblRestok.Size = new Size(40, 47);
            lblRestok.TabIndex = 3;
            lblRestok.Text = "0";
            // 
            // lblRestokJudul
            // 
            lblRestokJudul.AutoSize = true;
            lblRestokJudul.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRestokJudul.ForeColor = Color.FromArgb(79, 106, 92);
            lblRestokJudul.Location = new Point(22, 21);
            lblRestokJudul.Name = "lblRestokJudul";
            lblRestokJudul.Size = new Size(147, 20);
            lblRestokJudul.TabIndex = 2;
            lblRestokJudul.Text = "Barang perlu restok";
            // 
            // pnlKartuOpname
            // 
            pnlKartuOpname.BackColor = Color.FromArgb(213, 235, 223);
            pnlKartuOpname.Controls.Add(pnlKartuOpnameDalam);
            pnlKartuOpname.Location = new Point(592, 0);
            pnlKartuOpname.Margin = new Padding(0, 0, 18, 0);
            pnlKartuOpname.Name = "pnlKartuOpname";
            pnlKartuOpname.Padding = new Padding(1);
            pnlKartuOpname.Size = new Size(278, 115);
            pnlKartuOpname.TabIndex = 2;
            // 
            // pnlKartuOpnameDalam
            // 
            pnlKartuOpnameDalam.BackColor = Color.White;
            pnlKartuOpnameDalam.Controls.Add(lblOpname);
            pnlKartuOpnameDalam.Controls.Add(lblOpnameJudul);
            pnlKartuOpnameDalam.Dock = DockStyle.Fill;
            pnlKartuOpnameDalam.Location = new Point(1, 1);
            pnlKartuOpnameDalam.Name = "pnlKartuOpnameDalam";
            pnlKartuOpnameDalam.Size = new Size(276, 113);
            pnlKartuOpnameDalam.TabIndex = 1;
            // 
            // lblOpname
            // 
            lblOpname.AutoSize = true;
            lblOpname.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lblOpname.ForeColor = Color.FromArgb(138, 90, 15);
            lblOpname.Location = new Point(22, 48);
            lblOpname.Name = "lblOpname";
            lblOpname.Size = new Size(40, 47);
            lblOpname.TabIndex = 2;
            lblOpname.Text = "0";
            // 
            // lblOpnameJudul
            // 
            lblOpnameJudul.AutoSize = true;
            lblOpnameJudul.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOpnameJudul.ForeColor = Color.FromArgb(79, 106, 92);
            lblOpnameJudul.Location = new Point(22, 21);
            lblOpnameJudul.Name = "lblOpnameJudul";
            lblOpnameJudul.Size = new Size(122, 20);
            lblOpnameJudul.TabIndex = 1;
            lblOpnameJudul.Text = "Koreksi opname";
            // 
            // pnlKartuMasuk
            // 
            pnlKartuMasuk.Angle = 45F;
            pnlKartuMasuk.ColorBottom = Color.FromArgb(62, 156, 106);
            pnlKartuMasuk.ColorTop = Color.FromArgb(31, 107, 66);
            pnlKartuMasuk.Controls.Add(lblMasuk);
            pnlKartuMasuk.Controls.Add(lblMasukJudul);
            pnlKartuMasuk.Location = new Point(0, 0);
            pnlKartuMasuk.Margin = new Padding(0, 0, 18, 0);
            pnlKartuMasuk.Name = "pnlKartuMasuk";
            pnlKartuMasuk.Size = new Size(278, 115);
            pnlKartuMasuk.TabIndex = 0;
            // 
            // lblMasuk
            // 
            lblMasuk.AutoSize = true;
            lblMasuk.Font = new Font("Leelawadee UI", 21F, FontStyle.Bold);
            lblMasuk.ForeColor = Color.White;
            lblMasuk.Location = new Point(22, 48);
            lblMasuk.Name = "lblMasuk";
            lblMasuk.Size = new Size(40, 47);
            lblMasuk.TabIndex = 1;
            lblMasuk.Text = "0";
            // 
            // lblMasukJudul
            // 
            lblMasukJudul.AutoSize = true;
            lblMasukJudul.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMasukJudul.ForeColor = Color.White;
            lblMasukJudul.Location = new Point(22, 21);
            lblMasukJudul.Name = "lblMasukJudul";
            lblMasukJudul.Size = new Size(95, 20);
            lblMasukJudul.TabIndex = 0;
            lblMasukJudul.Text = "Total Masuk";
            // 
            // pnlKartuLuar
            // 
            pnlKartuLuar.BackColor = Color.FromArgb(213, 235, 223);
            pnlKartuLuar.Controls.Add(pnlKartuKeluarDalam);
            pnlKartuLuar.Location = new Point(296, 0);
            pnlKartuLuar.Margin = new Padding(0, 0, 18, 0);
            pnlKartuLuar.Name = "pnlKartuLuar";
            pnlKartuLuar.Padding = new Padding(1);
            pnlKartuLuar.Size = new Size(278, 115);
            pnlKartuLuar.TabIndex = 1;
            // 
            // pnlKartuKeluarDalam
            // 
            pnlKartuKeluarDalam.BackColor = Color.White;
            pnlKartuKeluarDalam.Controls.Add(lblKeluar);
            pnlKartuKeluarDalam.Controls.Add(lblKeluarJudul);
            pnlKartuKeluarDalam.Dock = DockStyle.Fill;
            pnlKartuKeluarDalam.Location = new Point(1, 1);
            pnlKartuKeluarDalam.Name = "pnlKartuKeluarDalam";
            pnlKartuKeluarDalam.Size = new Size(276, 113);
            pnlKartuKeluarDalam.TabIndex = 0;
            // 
            // lblKeluar
            // 
            lblKeluar.AutoSize = true;
            lblKeluar.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lblKeluar.ForeColor = Color.FromArgb(169, 50, 38);
            lblKeluar.Location = new Point(22, 48);
            lblKeluar.Name = "lblKeluar";
            lblKeluar.Size = new Size(40, 47);
            lblKeluar.TabIndex = 1;
            lblKeluar.Text = "0";
            // 
            // lblKeluarJudul
            // 
            lblKeluarJudul.AutoSize = true;
            lblKeluarJudul.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKeluarJudul.ForeColor = Color.FromArgb(79, 106, 92);
            lblKeluarJudul.Location = new Point(22, 21);
            lblKeluarJudul.Name = "lblKeluarJudul";
            lblKeluarJudul.Size = new Size(106, 20);
            lblKeluarJudul.TabIndex = 0;
            lblKeluarJudul.Text = "Barang keluar";
            lblKeluarJudul.UseWaitCursor = true;
            // 
            // cmbPetugas
            // 
            cmbPetugas.FormattingEnabled = true;
            cmbPetugas.Location = new Point(664, 34);
            cmbPetugas.Name = "cmbPetugas";
            cmbPetugas.Size = new Size(160, 31);
            cmbPetugas.TabIndex = 8;
            // 
            // ucLaporanGudang
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 251, 248);
            Controls.Add(pnlPage);
            Font = new Font("Leelawadee UI", 10.5F);
            Name = "ucLaporanGudang";
            Size = new Size(1238, 805);
            pnlPage.ResumeLayout(false);
            pnlFilterLuar.ResumeLayout(false);
            pnlFilterDalam.ResumeLayout(false);
            pnlFilterDalam.PerformLayout();
            tlpKartu.ResumeLayout(false);
            pnlKartuRestok.ResumeLayout(false);
            pnlKartuRestokDalam.ResumeLayout(false);
            pnlKartuRestokDalam.PerformLayout();
            pnlKartuOpname.ResumeLayout(false);
            pnlKartuOpnameDalam.ResumeLayout(false);
            pnlKartuOpnameDalam.PerformLayout();
            pnlKartuMasuk.ResumeLayout(false);
            pnlKartuMasuk.PerformLayout();
            pnlKartuLuar.ResumeLayout(false);
            pnlKartuKeluarDalam.ResumeLayout(false);
            pnlKartuKeluarDalam.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPage;
        private TableLayoutPanel tlpKartu;
        private Panel pnlJarak2;
        private Panel pnlFilterLuar;
        private Panel pnlJarak;
        private Panel pnlKartuTabel;
        private GradientPanel pnlKartuMasuk;
        private Panel pnlKartuOpname;
        private Panel pnlKartuLuar;
        private Panel pnlKartuRestok;
        private Panel pnlKartuRestokDalam;
        private Panel pnlKartuOpnameDalam;
        private Panel pnlKartuKeluarDalam;
        private Label lblMasukJudul;
        private Label lblKeluarJudul;
        private Label lblRestokJudul;
        private Label lblOpnameJudul;
        private Label lblMasuk;
        private Label lblKeluar;
        private Label lblRestok;
        private Label lblOpname;
        private Panel pnlFilterDalam;
        private Label lblJenis;
        private Label lblSampai;
        private Label lblDari;
        private Label lblPetugas;
        private Label lblBarang;
        private DateTimePicker dtpSampai;
        private DateTimePicker dtpDari;
        private ComboBox cmbJenis;
        private ComboBox cmbPetugas;
    }
}
