namespace project_akhir_stock_gudang
{
    partial class Dashboard_Keranjang
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_Keranjang));
            panel1 = new Panel();
            panel4 = new Panel();
            label_total = new Label();
            checkout_barang = new Button();
            datakeranjang = new DataGridView();
            kolom_nama = new DataGridViewTextBoxColumn();
            kolom_harga = new DataGridViewTextBoxColumn();
            kolom_jumlah = new DataGridViewTextBoxColumn();
            kolom_subtotal = new DataGridViewTextBoxColumn();
            kurangi_barang_keranjang = new DataGridViewButtonColumn();
            hapus_barang_keranjang = new DataGridViewButtonColumn();
            panel3 = new Panel();
            pictureBox7 = new PictureBox();
            kembali_ke_login = new Label();
            panel2 = new Panel();
            tombol_keranjang = new Button();
            tombol_perlengkapan_sekolah = new Button();
            tombol_alat_tulis = new Button();
            tombol_alat_gambar = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datakeranjang).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(datakeranjang);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(964, 511);
            panel1.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(label_total);
            panel4.Controls.Add(checkout_barang);
            panel4.Location = new Point(259, 442);
            panel4.Name = "panel4";
            panel4.Size = new Size(705, 66);
            panel4.TabIndex = 4;
            // 
            // label_total
            // 
            label_total.AutoSize = true;
            label_total.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_total.Location = new Point(393, 26);
            label_total.Name = "label_total";
            label_total.Size = new Size(0, 23);
            label_total.TabIndex = 4;
            // 
            // checkout_barang
            // 
            checkout_barang.BackColor = Color.Teal;
            checkout_barang.FlatAppearance.BorderSize = 0;
            checkout_barang.FlatStyle = FlatStyle.Flat;
            checkout_barang.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkout_barang.ForeColor = Color.White;
            checkout_barang.Location = new Point(581, 14);
            checkout_barang.Name = "checkout_barang";
            checkout_barang.Size = new Size(108, 49);
            checkout_barang.TabIndex = 3;
            checkout_barang.Text = "checkout";
            checkout_barang.UseVisualStyleBackColor = false;
            checkout_barang.Click += checkout_barang_Click;
            // 
            // datakeranjang
            // 
            datakeranjang.AllowUserToAddRows = false;
            datakeranjang.AllowUserToDeleteRows = false;
            datakeranjang.AllowUserToResizeColumns = false;
            datakeranjang.AllowUserToResizeRows = false;
            datakeranjang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datakeranjang.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Teal;
            dataGridViewCellStyle1.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            datakeranjang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            datakeranjang.ColumnHeadersHeight = 29;
            datakeranjang.Columns.AddRange(new DataGridViewColumn[] { kolom_nama, kolom_harga, kolom_jumlah, kolom_subtotal, kurangi_barang_keranjang, hapus_barang_keranjang });
            datakeranjang.Location = new Point(259, 52);
            datakeranjang.Name = "datakeranjang";
            datakeranjang.ReadOnly = true;
            datakeranjang.RowHeadersVisible = false;
            datakeranjang.RowHeadersWidth = 51;
            datakeranjang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datakeranjang.Size = new Size(705, 392);
            datakeranjang.TabIndex = 2;
            datakeranjang.CellContentClick += datakeranjang_CellContentClick;
            // 
            // kolom_nama
            // 
            dataGridViewCellStyle2.BackColor = Color.Teal;
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Turquoise;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            kolom_nama.DefaultCellStyle = dataGridViewCellStyle2;
            kolom_nama.FillWeight = 71.75698F;
            kolom_nama.HeaderText = "nama";
            kolom_nama.MinimumWidth = 6;
            kolom_nama.Name = "kolom_nama";
            kolom_nama.ReadOnly = true;
            // 
            // kolom_harga
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = Color.Teal;
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.Format = "NO";
            dataGridViewCellStyle3.SelectionBackColor = Color.Turquoise;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            kolom_harga.DefaultCellStyle = dataGridViewCellStyle3;
            kolom_harga.FillWeight = 71.75698F;
            kolom_harga.HeaderText = "harga";
            kolom_harga.MinimumWidth = 6;
            kolom_harga.Name = "kolom_harga";
            kolom_harga.ReadOnly = true;
            // 
            // kolom_jumlah
            // 
            dataGridViewCellStyle4.BackColor = Color.Teal;
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.Turquoise;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            kolom_jumlah.DefaultCellStyle = dataGridViewCellStyle4;
            kolom_jumlah.FillWeight = 71.75698F;
            kolom_jumlah.HeaderText = "jumlah";
            kolom_jumlah.MinimumWidth = 6;
            kolom_jumlah.Name = "kolom_jumlah";
            kolom_jumlah.ReadOnly = true;
            // 
            // kolom_subtotal
            // 
            dataGridViewCellStyle5.BackColor = Color.Teal;
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.Turquoise;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            kolom_subtotal.DefaultCellStyle = dataGridViewCellStyle5;
            kolom_subtotal.FillWeight = 71.75698F;
            kolom_subtotal.HeaderText = "subtotal";
            kolom_subtotal.MinimumWidth = 6;
            kolom_subtotal.Name = "kolom_subtotal";
            kolom_subtotal.ReadOnly = true;
            // 
            // kurangi_barang_keranjang
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.Teal;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Teal;
            dataGridViewCellStyle6.SelectionBackColor = Color.Turquoise;
            dataGridViewCellStyle6.SelectionForeColor = Color.Turquoise;
            kurangi_barang_keranjang.DefaultCellStyle = dataGridViewCellStyle6;
            kurangi_barang_keranjang.FillWeight = 25.42781F;
            kurangi_barang_keranjang.HeaderText = "";
            kurangi_barang_keranjang.MinimumWidth = 6;
            kurangi_barang_keranjang.Name = "kurangi_barang_keranjang";
            kurangi_barang_keranjang.ReadOnly = true;
            kurangi_barang_keranjang.Resizable = DataGridViewTriState.False;
            kurangi_barang_keranjang.SortMode = DataGridViewColumnSortMode.Automatic;
            kurangi_barang_keranjang.Text = "-";
            kurangi_barang_keranjang.ToolTipText = "-";
            kurangi_barang_keranjang.UseColumnTextForButtonValue = true;
            // 
            // hapus_barang_keranjang
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.Teal;
            dataGridViewCellStyle7.ForeColor = Color.Teal;
            dataGridViewCellStyle7.SelectionBackColor = Color.Turquoise;
            dataGridViewCellStyle7.SelectionForeColor = Color.Turquoise;
            hapus_barang_keranjang.DefaultCellStyle = dataGridViewCellStyle7;
            hapus_barang_keranjang.FillWeight = 25.5443F;
            hapus_barang_keranjang.HeaderText = "";
            hapus_barang_keranjang.MinimumWidth = 6;
            hapus_barang_keranjang.Name = "hapus_barang_keranjang";
            hapus_barang_keranjang.ReadOnly = true;
            hapus_barang_keranjang.Resizable = DataGridViewTriState.True;
            hapus_barang_keranjang.SortMode = DataGridViewColumnSortMode.Automatic;
            hapus_barang_keranjang.Text = "🗑️";
            hapus_barang_keranjang.ToolTipText = "🗑️";
            hapus_barang_keranjang.UseColumnTextForButtonValue = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Teal;
            panel3.Controls.Add(pictureBox7);
            panel3.Controls.Add(kembali_ke_login);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(964, 54);
            panel3.TabIndex = 1;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(-2, 0);
            pictureBox7.Margin = new Padding(2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(262, 54);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 1;
            pictureBox7.TabStop = false;
            // 
            // kembali_ke_login
            // 
            kembali_ke_login.AutoSize = true;
            kembali_ke_login.Location = new Point(936, 20);
            kembali_ke_login.Margin = new Padding(2, 0, 2, 0);
            kembali_ke_login.Name = "kembali_ke_login";
            kembali_ke_login.Size = new Size(18, 20);
            kembali_ke_login.TabIndex = 0;
            kembali_ke_login.Text = "X";
            kembali_ke_login.Click += kembali_ke_login_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(tombol_keranjang);
            panel2.Controls.Add(tombol_perlengkapan_sekolah);
            panel2.Controls.Add(tombol_alat_tulis);
            panel2.Controls.Add(tombol_alat_gambar);
            panel2.Location = new Point(0, 52);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(260, 458);
            panel2.TabIndex = 0;
            // 
            // tombol_keranjang
            // 
            tombol_keranjang.BackColor = Color.Teal;
            tombol_keranjang.Font = new Font("Leelawadee UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tombol_keranjang.ForeColor = Color.White;
            tombol_keranjang.Location = new Point(-2, 161);
            tombol_keranjang.Margin = new Padding(2);
            tombol_keranjang.Name = "tombol_keranjang";
            tombol_keranjang.Size = new Size(262, 58);
            tombol_keranjang.TabIndex = 3;
            tombol_keranjang.Text = "Keranjang";
            tombol_keranjang.UseVisualStyleBackColor = false;
            // 
            // tombol_perlengkapan_sekolah
            // 
            tombol_perlengkapan_sekolah.BackColor = Color.White;
            tombol_perlengkapan_sekolah.Font = new Font("Leelawadee UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tombol_perlengkapan_sekolah.ForeColor = Color.Black;
            tombol_perlengkapan_sekolah.Location = new Point(-2, 109);
            tombol_perlengkapan_sekolah.Margin = new Padding(2);
            tombol_perlengkapan_sekolah.Name = "tombol_perlengkapan_sekolah";
            tombol_perlengkapan_sekolah.Size = new Size(262, 54);
            tombol_perlengkapan_sekolah.TabIndex = 2;
            tombol_perlengkapan_sekolah.Text = "Perlengkapan Sekolah";
            tombol_perlengkapan_sekolah.UseVisualStyleBackColor = false;
            tombol_perlengkapan_sekolah.Click += tombol_perlengkapan_sekolah_Click;
            // 
            // tombol_alat_tulis
            // 
            tombol_alat_tulis.BackColor = Color.White;
            tombol_alat_tulis.Font = new Font("Leelawadee UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tombol_alat_tulis.ForeColor = Color.Black;
            tombol_alat_tulis.Location = new Point(-2, 54);
            tombol_alat_tulis.Margin = new Padding(2);
            tombol_alat_tulis.Name = "tombol_alat_tulis";
            tombol_alat_tulis.Size = new Size(262, 58);
            tombol_alat_tulis.TabIndex = 1;
            tombol_alat_tulis.Text = "Alat Tulis";
            tombol_alat_tulis.UseVisualStyleBackColor = false;
            tombol_alat_tulis.Click += tombol_alat_tulis_Click;
            // 
            // tombol_alat_gambar
            // 
            tombol_alat_gambar.BackColor = Color.White;
            tombol_alat_gambar.Font = new Font("Leelawadee UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tombol_alat_gambar.ForeColor = Color.Black;
            tombol_alat_gambar.Location = new Point(2, 6);
            tombol_alat_gambar.Margin = new Padding(2);
            tombol_alat_gambar.Name = "tombol_alat_gambar";
            tombol_alat_gambar.Size = new Size(262, 58);
            tombol_alat_gambar.TabIndex = 0;
            tombol_alat_gambar.Text = "Alat Gambar";
            tombol_alat_gambar.UseVisualStyleBackColor = false;
            tombol_alat_gambar.Click += tombol_alat_gambar_Click;
            // 
            // Dashboard_Keranjang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 511);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Dashboard_Keranjang";
            Text = "Dashboard_Keranjang";
            FormClosed += Dashboard_Keranjang_FormClosed;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datakeranjang).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox7;
        private Label kembali_ke_login;
        private Panel panel2;
        private Button tombol_keranjang;
        private Button tombol_perlengkapan_sekolah;
        private Button tombol_alat_tulis;
        private Button tombol_alat_gambar;
        private Button checkout_barang;
        private DataGridView datakeranjang;
        private Panel panel4;
        private Label label_total;
        private DataGridViewTextBoxColumn kolom_nama;
        private DataGridViewTextBoxColumn kolom_harga;
        private DataGridViewTextBoxColumn kolom_jumlah;
        private DataGridViewTextBoxColumn kolom_subtotal;
        private DataGridViewButtonColumn kurangi_barang_keranjang;
        private DataGridViewButtonColumn hapus_barang_keranjang;
    }
}