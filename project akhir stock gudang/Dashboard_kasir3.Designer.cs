namespace project_akhir_stock_gudang
{
    partial class Dashboard_kasir3
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            label_tanggal_transaksi2 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            label_nomor_transaksi2 = new Label();
            label1 = new Label();
            panel5 = new Panel();
            lblTotalPembayaran = new Label();
            dgvCheckout = new DataGridView();
            label3 = new Label();
            btnBatal = new Button();
            btnSelesaikan = new Button();
            lblKembalian = new Label();
            lblUangDiterima = new Label();
            panel6 = new Panel();
            flpMetodePembayaran = new FlowLayoutPanel();
            txtUangDiterima = new TextBox();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCheckout).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(686, 70);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(686, 133);
            panel2.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.MediumSeaGreen;
            panel4.Controls.Add(label_tanggal_transaksi2);
            panel4.Controls.Add(label2);
            panel4.ForeColor = SystemColors.ControlText;
            panel4.Location = new Point(422, 19);
            panel4.Name = "panel4";
            panel4.Size = new Size(252, 97);
            panel4.TabIndex = 4;
            // 
            // label_tanggal_transaksi2
            // 
            label_tanggal_transaksi2.AutoSize = true;
            label_tanggal_transaksi2.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_tanggal_transaksi2.ForeColor = Color.White;
            label_tanggal_transaksi2.Location = new Point(12, 32);
            label_tanggal_transaksi2.Name = "label_tanggal_transaksi2";
            label_tanggal_transaksi2.Size = new Size(0, 28);
            label_tanggal_transaksi2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(148, 23);
            label2.TabIndex = 2;
            label2.Text = "tanggal transaksi";
            // 
            // panel3
            // 
            panel3.BackColor = Color.MediumSeaGreen;
            panel3.Controls.Add(label_nomor_transaksi2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(12, 19);
            panel3.Name = "panel3";
            panel3.Size = new Size(252, 97);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // label_nomor_transaksi2
            // 
            label_nomor_transaksi2.AutoSize = true;
            label_nomor_transaksi2.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_nomor_transaksi2.ForeColor = Color.White;
            label_nomor_transaksi2.Location = new Point(13, 32);
            label_nomor_transaksi2.Name = "label_nomor_transaksi2";
            label_nomor_transaksi2.Size = new Size(0, 28);
            label_nomor_transaksi2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 9);
            label1.Name = "label1";
            label1.Size = new Size(139, 23);
            label1.TabIndex = 1;
            label1.Text = "nomor transaksi";
            // 
            // panel5
            // 
            panel5.Controls.Add(lblTotalPembayaran);
            panel5.Controls.Add(dgvCheckout);
            panel5.Controls.Add(label3);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 203);
            panel5.Name = "panel5";
            panel5.Size = new Size(686, 456);
            panel5.TabIndex = 5;
            // 
            // lblTotalPembayaran
            // 
            lblTotalPembayaran.AutoSize = true;
            lblTotalPembayaran.Location = new Point(12, 467);
            lblTotalPembayaran.Name = "lblTotalPembayaran";
            lblTotalPembayaran.Size = new Size(0, 20);
            lblTotalPembayaran.TabIndex = 14;
            // 
            // dgvCheckout
            // 
            dgvCheckout.BackgroundColor = Color.White;
            dgvCheckout.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCheckout.Location = new Point(13, 43);
            dgvCheckout.Name = "dgvCheckout";
            dgvCheckout.ReadOnly = true;
            dgvCheckout.RowHeadersWidth = 51;
            dgvCheckout.Size = new Size(662, 413);
            dgvCheckout.TabIndex = 5;
            dgvCheckout.CellContentClick += dgvCheckout_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 14);
            label3.Name = "label3";
            label3.Size = new Size(126, 23);
            label3.TabIndex = 0;
            label3.Text = "rincian barang";
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(403, 239);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(132, 58);
            btnBatal.TabIndex = 13;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += btnBatal_Click;
            // 
            // btnSelesaikan
            // 
            btnSelesaikan.Location = new Point(541, 239);
            btnSelesaikan.Name = "btnSelesaikan";
            btnSelesaikan.Size = new Size(132, 58);
            btnSelesaikan.TabIndex = 12;
            btnSelesaikan.Text = "Konfirmasi";
            btnSelesaikan.UseVisualStyleBackColor = true;
            btnSelesaikan.Click += btnSelesaikan_Click;
            // 
            // lblKembalian
            // 
            lblKembalian.AutoSize = true;
            lblKembalian.Location = new Point(12, 239);
            lblKembalian.Name = "lblKembalian";
            lblKembalian.Size = new Size(0, 20);
            lblKembalian.TabIndex = 11;
            // 
            // lblUangDiterima
            // 
            lblUangDiterima.AutoSize = true;
            lblUangDiterima.Location = new Point(12, 151);
            lblUangDiterima.Name = "lblUangDiterima";
            lblUangDiterima.Size = new Size(106, 20);
            lblUangDiterima.TabIndex = 10;
            lblUangDiterima.Text = "Uang Diterima";
            // 
            // panel6
            // 
            panel6.Controls.Add(flpMetodePembayaran);
            panel6.Controls.Add(txtUangDiterima);
            panel6.Controls.Add(lblUangDiterima);
            panel6.Controls.Add(lblKembalian);
            panel6.Controls.Add(btnBatal);
            panel6.Controls.Add(btnSelesaikan);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 659);
            panel6.Name = "panel6";
            panel6.Size = new Size(686, 313);
            panel6.TabIndex = 6;
            // 
            // flpMetodePembayaran
            // 
            flpMetodePembayaran.BackColor = Color.White;
            flpMetodePembayaran.Location = new Point(48, 22);
            flpMetodePembayaran.Name = "flpMetodePembayaran";
            flpMetodePembayaran.Padding = new Padding(3);
            flpMetodePembayaran.Size = new Size(590, 115);
            flpMetodePembayaran.TabIndex = 15;
            flpMetodePembayaran.WrapContents = false;
            // 
            // txtUangDiterima
            // 
            txtUangDiterima.BackColor = SystemColors.ControlLight;
            txtUangDiterima.Location = new Point(12, 174);
            txtUangDiterima.Multiline = true;
            txtUangDiterima.Name = "txtUangDiterima";
            txtUangDiterima.PlaceholderText = "Masukkan jumlah";
            txtUangDiterima.Size = new Size(661, 39);
            txtUangDiterima.TabIndex = 14;
            txtUangDiterima.TextChanged += txtUangDiterima_TextChanged_1;
            // 
            // Dashboard_kasir3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 968);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard_kasir3";
            Text = "Dashboard_kasir3";
            FormClosed += Dashboard_kasir3_FormClosed;
            Load += Dashboard_kasir3_Load;
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCheckout).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Label label_tanggal_transaksi2;
        private Label label2;
        private Panel panel3;
        private Label label_nomor_transaksi2;
        private Label label1;
        private Panel panel5;
        private Label label3;
        private DataGridView dgvCheckout;
        private Label lblKembalian;
        private Label lblUangDiterima;
        private Button btnBatal;
        private Button btnSelesaikan;
        private Label lblTotalPembayaran;
        private Panel panel6;
        private TextBox txtUangDiterima;
        private FlowLayoutPanel flpMetodePembayaran;
    }
}