namespace project_akhir_stock_gudang
{
    partial class Dashboard_Struck
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlstruk = new Panel();
            btnTransaksiBaru = new Button();
            dgvStruk = new DataGridView();
            pnlFooterStruk = new Panel();
            lblUcapanStruk = new Label();
            pnlRingkasan = new Panel();
            lblKembalianStruk = new Label();
            lblUangDiterimaStruk = new Label();
            lblTotalStruk = new Label();
            lblMetodeStruk = new Label();
            pnlInfoStruk = new Panel();
            lblTanggalStruk = new Label();
            lblJudulTanggalStruk = new Label();
            LblNomorStruk = new Label();
            lblJudulNomorStruk = new Label();
            pnlHeaderStruck = new Panel();
            lblSlogan = new Label();
            lblNamaToko = new Label();
            btnPrint = new Button();
            pnlstruk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStruk).BeginInit();
            pnlFooterStruk.SuspendLayout();
            pnlRingkasan.SuspendLayout();
            pnlInfoStruk.SuspendLayout();
            pnlHeaderStruck.SuspendLayout();
            SuspendLayout();
            // 
            // pnlstruk
            // 
            pnlstruk.BackColor = Color.White;
            pnlstruk.Controls.Add(btnPrint);
            pnlstruk.Controls.Add(btnTransaksiBaru);
            pnlstruk.Controls.Add(dgvStruk);
            pnlstruk.Controls.Add(pnlFooterStruk);
            pnlstruk.Controls.Add(pnlRingkasan);
            pnlstruk.Controls.Add(pnlInfoStruk);
            pnlstruk.Controls.Add(pnlHeaderStruck);
            pnlstruk.Location = new Point(10, 10);
            pnlstruk.Name = "pnlstruk";
            pnlstruk.Size = new Size(498, 857);
            pnlstruk.TabIndex = 0;
            pnlstruk.Paint += pnlstruk_Paint;
            // 
            // btnTransaksiBaru
            // 
            btnTransaksiBaru.BackColor = Color.SeaGreen;
            btnTransaksiBaru.FlatStyle = FlatStyle.Flat;
            btnTransaksiBaru.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTransaksiBaru.ForeColor = Color.White;
            btnTransaksiBaru.Location = new Point(340, 787);
            btnTransaksiBaru.Name = "btnTransaksiBaru";
            btnTransaksiBaru.Size = new Size(140, 67);
            btnTransaksiBaru.TabIndex = 7;
            btnTransaksiBaru.Text = "Transaksi baru";
            btnTransaksiBaru.UseVisualStyleBackColor = false;
            btnTransaksiBaru.Click += btnTransaksiBaru_Click;
            // 
            // dgvStruk
            // 
            dgvStruk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStruk.Location = new Point(20, 207);
            dgvStruk.Name = "dgvStruk";
            dgvStruk.RowHeadersWidth = 51;
            dgvStruk.Size = new Size(460, 252);
            dgvStruk.TabIndex = 6;
            dgvStruk.CellContentClick += dgvStruk_CellContentClick;
            // 
            // pnlFooterStruk
            // 
            pnlFooterStruk.Controls.Add(lblUcapanStruk);
            pnlFooterStruk.Location = new Point(20, 720);
            pnlFooterStruk.Name = "pnlFooterStruk";
            pnlFooterStruk.Size = new Size(460, 61);
            pnlFooterStruk.TabIndex = 3;
            pnlFooterStruk.Paint += pnlFooterStruk_Paint;
            // 
            // lblUcapanStruk
            // 
            lblUcapanStruk.AutoSize = true;
            lblUcapanStruk.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUcapanStruk.ForeColor = Color.SeaGreen;
            lblUcapanStruk.Location = new Point(3, 10);
            lblUcapanStruk.Name = "lblUcapanStruk";
            lblUcapanStruk.Size = new Size(226, 20);
            lblUcapanStruk.TabIndex = 0;
            lblUcapanStruk.Text = "Terima kasih sudah berbelanja!";
            // 
            // pnlRingkasan
            // 
            pnlRingkasan.BackColor = Color.Honeydew;
            pnlRingkasan.Controls.Add(lblKembalianStruk);
            pnlRingkasan.Controls.Add(lblUangDiterimaStruk);
            pnlRingkasan.Controls.Add(lblTotalStruk);
            pnlRingkasan.Controls.Add(lblMetodeStruk);
            pnlRingkasan.Location = new Point(20, 569);
            pnlRingkasan.Name = "pnlRingkasan";
            pnlRingkasan.Size = new Size(460, 145);
            pnlRingkasan.TabIndex = 2;
            // 
            // lblKembalianStruk
            // 
            lblKembalianStruk.AutoSize = true;
            lblKembalianStruk.Font = new Font("Leelawadee UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKembalianStruk.ForeColor = Color.FromArgb(51, 51, 51);
            lblKembalianStruk.Location = new Point(10, 105);
            lblKembalianStruk.Name = "lblKembalianStruk";
            lblKembalianStruk.Size = new Size(0, 20);
            lblKembalianStruk.TabIndex = 6;
            // 
            // lblUangDiterimaStruk
            // 
            lblUangDiterimaStruk.AutoSize = true;
            lblUangDiterimaStruk.Font = new Font("Leelawadee UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUangDiterimaStruk.ForeColor = Color.FromArgb(51, 51, 51);
            lblUangDiterimaStruk.Location = new Point(10, 77);
            lblUangDiterimaStruk.Name = "lblUangDiterimaStruk";
            lblUangDiterimaStruk.Size = new Size(0, 20);
            lblUangDiterimaStruk.TabIndex = 9;
            // 
            // lblTotalStruk
            // 
            lblTotalStruk.AutoSize = true;
            lblTotalStruk.Font = new Font("Leelawadee UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalStruk.ForeColor = Color.SeaGreen;
            lblTotalStruk.Location = new Point(10, 40);
            lblTotalStruk.Name = "lblTotalStruk";
            lblTotalStruk.Size = new Size(0, 31);
            lblTotalStruk.TabIndex = 6;
            // 
            // lblMetodeStruk
            // 
            lblMetodeStruk.AutoSize = true;
            lblMetodeStruk.Font = new Font("Leelawadee UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMetodeStruk.ForeColor = Color.FromArgb(51, 51, 51);
            lblMetodeStruk.Location = new Point(10, 10);
            lblMetodeStruk.Name = "lblMetodeStruk";
            lblMetodeStruk.Size = new Size(0, 20);
            lblMetodeStruk.TabIndex = 6;
            // 
            // pnlInfoStruk
            // 
            pnlInfoStruk.BackColor = Color.Honeydew;
            pnlInfoStruk.Controls.Add(lblTanggalStruk);
            pnlInfoStruk.Controls.Add(lblJudulTanggalStruk);
            pnlInfoStruk.Controls.Add(LblNomorStruk);
            pnlInfoStruk.Controls.Add(lblJudulNomorStruk);
            pnlInfoStruk.Location = new Point(20, 106);
            pnlInfoStruk.Name = "pnlInfoStruk";
            pnlInfoStruk.Size = new Size(460, 95);
            pnlInfoStruk.TabIndex = 1;
            pnlInfoStruk.Paint += pnlInfoStruk_Paint;
            // 
            // lblTanggalStruk
            // 
            lblTanggalStruk.AutoSize = true;
            lblTanggalStruk.Font = new Font("Leelawadee UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTanggalStruk.ForeColor = Color.FromArgb(51, 51, 51);
            lblTanggalStruk.Location = new Point(145, 38);
            lblTanggalStruk.Name = "lblTanggalStruk";
            lblTanggalStruk.Size = new Size(0, 20);
            lblTanggalStruk.TabIndex = 8;
            // 
            // lblJudulTanggalStruk
            // 
            lblJudulTanggalStruk.AutoSize = true;
            lblJudulTanggalStruk.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudulTanggalStruk.ForeColor = Color.SeaGreen;
            lblJudulTanggalStruk.Location = new Point(10, 38);
            lblJudulTanggalStruk.Name = "lblJudulTanggalStruk";
            lblJudulTanggalStruk.Size = new Size(65, 20);
            lblJudulTanggalStruk.TabIndex = 7;
            lblJudulTanggalStruk.Text = "Tanggal";
            // 
            // LblNomorStruk
            // 
            LblNomorStruk.AutoSize = true;
            LblNomorStruk.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblNomorStruk.ForeColor = Color.FromArgb(51, 51, 51);
            LblNomorStruk.Location = new Point(145, 8);
            LblNomorStruk.Name = "LblNomorStruk";
            LblNomorStruk.Size = new Size(0, 20);
            LblNomorStruk.TabIndex = 6;
            // 
            // lblJudulNomorStruk
            // 
            lblJudulNomorStruk.AutoSize = true;
            lblJudulNomorStruk.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudulNomorStruk.ForeColor = Color.SeaGreen;
            lblJudulNomorStruk.Location = new Point(10, 8);
            lblJudulNomorStruk.Name = "lblJudulNomorStruk";
            lblJudulNomorStruk.Size = new Size(126, 20);
            lblJudulNomorStruk.TabIndex = 5;
            lblJudulNomorStruk.Text = "Nomor transaksi";
            // 
            // pnlHeaderStruck
            // 
            pnlHeaderStruck.BackColor = Color.SeaGreen;
            pnlHeaderStruck.Controls.Add(lblSlogan);
            pnlHeaderStruck.Controls.Add(lblNamaToko);
            pnlHeaderStruck.Location = new Point(20, 15);
            pnlHeaderStruck.Name = "pnlHeaderStruck";
            pnlHeaderStruck.Size = new Size(460, 85);
            pnlHeaderStruck.TabIndex = 0;
            // 
            // lblSlogan
            // 
            lblSlogan.AutoSize = true;
            lblSlogan.Font = new Font("Leelawadee UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSlogan.ForeColor = Color.White;
            lblSlogan.Location = new Point(73, 46);
            lblSlogan.Name = "lblSlogan";
            lblSlogan.Size = new Size(365, 31);
            lblSlogan.TabIndex = 0;
            lblSlogan.Text = "Belanja mudah,harga bersahabat";
            // 
            // lblNamaToko
            // 
            lblNamaToko.AutoSize = true;
            lblNamaToko.BackColor = Color.SeaGreen;
            lblNamaToko.Font = new Font("Leelawadee UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNamaToko.ForeColor = Color.White;
            lblNamaToko.Location = new Point(64, 0);
            lblNamaToko.Name = "lblNamaToko";
            lblNamaToko.Size = new Size(190, 46);
            lblNamaToko.TabIndex = 5;
            lblNamaToko.Text = "ONEMART";
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.SeaGreen;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(194, 787);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(140, 67);
            btnPrint.TabIndex = 8;
            btnPrint.Text = "Print struck";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // Dashboard_Struck
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 879);
            Controls.Add(pnlstruk);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard_Struck";
            Text = "Dashboard_Struck";
            FormClosed += Dashboard_Struck_FormClosed;
            pnlstruk.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStruk).EndInit();
            pnlFooterStruk.ResumeLayout(false);
            pnlFooterStruk.PerformLayout();
            pnlRingkasan.ResumeLayout(false);
            pnlRingkasan.PerformLayout();
            pnlInfoStruk.ResumeLayout(false);
            pnlInfoStruk.PerformLayout();
            pnlHeaderStruck.ResumeLayout(false);
            pnlHeaderStruck.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlstruk;
        private Panel pnlInfoStruk;
        private Panel pnlHeaderStruck;
        private Panel pnlRingkasan;
        private Panel pnlFooterStruk;
        private Label lblNamaToko;
        private Label lblSlogan;
        private Label lblJudulNomorStruk;
        private Label lblJudulTanggalStruk;
        private Label LblNomorStruk;
        private Label lblTanggalStruk;
        private Label lblTotalStruk;
        private Label lblMetodeStruk;
        private Label lblKembalianStruk;
        private Label lblUangDiterimaStruk;
        private Label lblUcapanStruk;
        private DataGridView dgvStruk;
        private Button btnTransaksiBaru;
        private Button btnPrint;
    }
}