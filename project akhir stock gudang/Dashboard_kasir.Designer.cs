namespace project_akhir_stock_gudang
{
    partial class Dashboard_kasir
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
            label6 = new Label();
            label5 = new Label();
            kembali_ke_login2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            label_tanggal_transaksi = new Label();
            label2 = new Label();
            panel3 = new Panel();
            label_nomor_transaksi = new Label();
            panel5 = new Panel();
            menuju_dashboard2 = new Button();
            tambah_ke_keranjang = new Button();
            jumlah_beli_barang = new TextBox();
            label4 = new Label();
            listbox_barang = new ListBox();
            textbox_kategori_barang = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(kembali_ke_login2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(686, 102);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.MediumSeaGreen;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(21, 59);
            label6.Name = "label6";
            label6.Size = new Size(310, 25);
            label6.TabIndex = 12;
            label6.Text = "Cari dan pilih  barang untuk transaksi ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(319, 50);
            label5.TabIndex = 11;
            label5.Text = "DATA BARANG";
            // 
            // kembali_ke_login2
            // 
            kembali_ke_login2.AutoSize = true;
            kembali_ke_login2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kembali_ke_login2.Location = new Point(656, 9);
            kembali_ke_login2.Margin = new Padding(2, 0, 2, 0);
            kembali_ke_login2.Name = "kembali_ke_login2";
            kembali_ke_login2.Size = new Size(19, 20);
            kembali_ke_login2.TabIndex = 10;
            kembali_ke_login2.Text = "X";
            kembali_ke_login2.Click += kembali_ke_login2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 9);
            label1.Name = "label1";
            label1.Size = new Size(142, 23);
            label1.TabIndex = 1;
            label1.Text = "Nomor transaksi";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Honeydew;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = SystemColors.Control;
            panel2.Location = new Point(0, 102);
            panel2.Name = "panel2";
            panel2.Size = new Size(686, 133);
            panel2.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.MediumSeaGreen;
            panel4.Controls.Add(label_tanggal_transaksi);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(422, 19);
            panel4.Name = "panel4";
            panel4.Size = new Size(252, 97);
            panel4.TabIndex = 4;
            // 
            // label_tanggal_transaksi
            // 
            label_tanggal_transaksi.AutoSize = true;
            label_tanggal_transaksi.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_tanggal_transaksi.Location = new Point(12, 32);
            label_tanggal_transaksi.Name = "label_tanggal_transaksi";
            label_tanggal_transaksi.Size = new Size(0, 28);
            label_tanggal_transaksi.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MediumSeaGreen;
            label2.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(151, 23);
            label2.TabIndex = 2;
            label2.Text = "Tanggal transaksi";
            label2.Click += label2_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MediumSeaGreen;
            panel3.Controls.Add(label_nomor_transaksi);
            panel3.Controls.Add(label1);
            panel3.ForeColor = SystemColors.ControlText;
            panel3.Location = new Point(12, 19);
            panel3.Name = "panel3";
            panel3.Size = new Size(261, 97);
            panel3.TabIndex = 3;
            // 
            // label_nomor_transaksi
            // 
            label_nomor_transaksi.AutoSize = true;
            label_nomor_transaksi.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_nomor_transaksi.ForeColor = Color.White;
            label_nomor_transaksi.Location = new Point(13, 32);
            label_nomor_transaksi.Name = "label_nomor_transaksi";
            label_nomor_transaksi.Size = new Size(0, 28);
            label_nomor_transaksi.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Honeydew;
            panel5.Controls.Add(menuju_dashboard2);
            panel5.Controls.Add(tambah_ke_keranjang);
            panel5.Controls.Add(jumlah_beli_barang);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(listbox_barang);
            panel5.Controls.Add(textbox_kategori_barang);
            panel5.Controls.Add(label3);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 235);
            panel5.Name = "panel5";
            panel5.Size = new Size(686, 645);
            panel5.TabIndex = 4;
            panel5.Paint += panel5_Paint;
            // 
            // menuju_dashboard2
            // 
            menuju_dashboard2.BackColor = Color.SeaGreen;
            menuju_dashboard2.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuju_dashboard2.ForeColor = Color.White;
            menuju_dashboard2.Location = new Point(12, 569);
            menuju_dashboard2.Name = "menuju_dashboard2";
            menuju_dashboard2.Size = new Size(662, 52);
            menuju_dashboard2.TabIndex = 6;
            menuju_dashboard2.Text = "Selanjutnya";
            menuju_dashboard2.UseVisualStyleBackColor = false;
            menuju_dashboard2.Click += menuju_dashboard2_Click;
            // 
            // tambah_ke_keranjang
            // 
            tambah_ke_keranjang.BackColor = Color.MediumSeaGreen;
            tambah_ke_keranjang.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tambah_ke_keranjang.ForeColor = Color.White;
            tambah_ke_keranjang.Location = new Point(542, 502);
            tambah_ke_keranjang.Name = "tambah_ke_keranjang";
            tambah_ke_keranjang.Size = new Size(132, 51);
            tambah_ke_keranjang.TabIndex = 5;
            tambah_ke_keranjang.Text = "Tambah";
            tambah_ke_keranjang.UseVisualStyleBackColor = false;
            tambah_ke_keranjang.Click += tambah_ke_keranjang_Click;
            // 
            // jumlah_beli_barang
            // 
            jumlah_beli_barang.BackColor = Color.White;
            jumlah_beli_barang.Location = new Point(25, 502);
            jumlah_beli_barang.Multiline = true;
            jumlah_beli_barang.Name = "jumlah_beli_barang";
            jumlah_beli_barang.PlaceholderText = "Masukkan jumlah";
            jumlah_beli_barang.Size = new Size(498, 51);
            jumlah_beli_barang.TabIndex = 4;
            jumlah_beli_barang.TextChanged += jumlah_beli_barang_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(25, 476);
            label4.Name = "label4";
            label4.Size = new Size(68, 23);
            label4.TabIndex = 3;
            label4.Text = "Jumlah";
            // 
            // listbox_barang
            // 
            listbox_barang.BackColor = Color.White;
            listbox_barang.BorderStyle = BorderStyle.FixedSingle;
            listbox_barang.DrawMode = DrawMode.OwnerDrawFixed;
            listbox_barang.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listbox_barang.ForeColor = Color.FromArgb(38, 50, 56);
            listbox_barang.FormattingEnabled = true;
            listbox_barang.IntegralHeight = false;
            listbox_barang.ItemHeight = 45;
            listbox_barang.Location = new Point(12, 101);
            listbox_barang.Name = "listbox_barang";
            listbox_barang.Size = new Size(662, 349);
            listbox_barang.TabIndex = 2;
            listbox_barang.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textbox_kategori_barang
            // 
            textbox_kategori_barang.BackColor = Color.White;
            textbox_kategori_barang.ForeColor = SystemColors.ControlText;
            textbox_kategori_barang.Location = new Point(12, 49);
            textbox_kategori_barang.Multiline = true;
            textbox_kategori_barang.Name = "textbox_kategori_barang";
            textbox_kategori_barang.PlaceholderText = "Masukkan kategori barang";
            textbox_kategori_barang.Size = new Size(662, 46);
            textbox_kategori_barang.TabIndex = 1;
            textbox_kategori_barang.TextChanged += textbox_kategori_barang_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(12, 23);
            label3.Name = "label3";
            label3.Size = new Size(146, 23);
            label3.TabIndex = 0;
            label3.Text = "Kategori barang ";
            label3.Click += label3_Click;
            // 
            // Dashboard_kasir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 880);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard_kasir";
            Text = "Dashboard_kasir";
            FormClosed += Dashboard_kasir_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Panel panel4;
        private Label label_tanggal_transaksi;
        private Label label_nomor_transaksi;
        private Panel panel5;
        private Label label3;
        private TextBox textbox_kategori_barang;
        private ListBox listbox_barang;
        private Label label4;
        private Button tambah_ke_keranjang;
        private TextBox jumlah_beli_barang;
        private Label kembali_ke_login2;
        private Button menuju_dashboard2;
        private Label label5;
        private Label label6;
    }
}