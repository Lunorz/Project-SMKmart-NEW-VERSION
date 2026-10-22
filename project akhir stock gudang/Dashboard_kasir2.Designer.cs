namespace project_akhir_stock_gudang
{
    partial class Dashboard_kasir2
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
            total_harga = new Label();
            checkout_barang_keranjang = new Button();
            hapus_barang_keranjang = new Button();
            kembali_ke_Dashboard1 = new Button();
            dgvkeranjang = new DataGridView();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvkeranjang).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(total_harga);
            panel1.Controls.Add(checkout_barang_keranjang);
            panel1.Controls.Add(hapus_barang_keranjang);
            panel1.Controls.Add(kembali_ke_Dashboard1);
            panel1.Controls.Add(dgvkeranjang);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(722, 743);
            panel1.TabIndex = 0;
            // 
            // total_harga
            // 
            total_harga.AutoSize = true;
            total_harga.Font = new Font("Leelawadee UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total_harga.Location = new Point(491, 509);
            total_harga.Name = "total_harga";
            total_harga.Size = new Size(0, 31);
            total_harga.TabIndex = 9;
            // 
            // checkout_barang_keranjang
            // 
            checkout_barang_keranjang.BackColor = Color.SeaGreen;
            checkout_barang_keranjang.Font = new Font("Leelawadee UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkout_barang_keranjang.ForeColor = Color.White;
            checkout_barang_keranjang.Location = new Point(12, 665);
            checkout_barang_keranjang.Name = "checkout_barang_keranjang";
            checkout_barang_keranjang.Size = new Size(698, 64);
            checkout_barang_keranjang.TabIndex = 8;
            checkout_barang_keranjang.Text = "Checkout";
            checkout_barang_keranjang.UseVisualStyleBackColor = false;
            checkout_barang_keranjang.Click += checkout_barang_keranjang_Click;
            // 
            // hapus_barang_keranjang
            // 
            hapus_barang_keranjang.BackColor = Color.SeaGreen;
            hapus_barang_keranjang.Font = new Font("Leelawadee UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hapus_barang_keranjang.ForeColor = Color.White;
            hapus_barang_keranjang.Location = new Point(12, 581);
            hapus_barang_keranjang.Name = "hapus_barang_keranjang";
            hapus_barang_keranjang.Size = new Size(325, 68);
            hapus_barang_keranjang.TabIndex = 7;
            hapus_barang_keranjang.Text = "Hapus";
            hapus_barang_keranjang.UseVisualStyleBackColor = false;
            hapus_barang_keranjang.Click += hapus_barang_keranjang_Click;
            // 
            // kembali_ke_Dashboard1
            // 
            kembali_ke_Dashboard1.BackColor = Color.SeaGreen;
            kembali_ke_Dashboard1.Font = new Font("Leelawadee UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kembali_ke_Dashboard1.ForeColor = Color.White;
            kembali_ke_Dashboard1.Location = new Point(385, 581);
            kembali_ke_Dashboard1.Name = "kembali_ke_Dashboard1";
            kembali_ke_Dashboard1.Size = new Size(325, 68);
            kembali_ke_Dashboard1.TabIndex = 6;
            kembali_ke_Dashboard1.Text = "Kembali";
            kembali_ke_Dashboard1.UseVisualStyleBackColor = false;
            kembali_ke_Dashboard1.Click += kembali_ke_Dashboard1_Click;
            // 
            // dgvkeranjang
            // 
            dgvkeranjang.BackgroundColor = Color.White;
            dgvkeranjang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvkeranjang.Location = new Point(12, 93);
            dgvkeranjang.Name = "dgvkeranjang";
            dgvkeranjang.RowHeadersWidth = 51;
            dgvkeranjang.Size = new Size(698, 413);
            dgvkeranjang.TabIndex = 1;
            dgvkeranjang.CellContentClick += dgvkeranjang_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaGreen;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(722, 87);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(395, 50);
            label1.TabIndex = 0;
            label1.Text = "KERANJANG KASIR";
            // 
            // Dashboard_kasir2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 741);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard_kasir2";
            Text = "Dashboard_kasir2";
            FormClosed += Dashboard_kasir2_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvkeranjang).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvkeranjang;
        private Panel panel2;
        private Button kembali_ke_Dashboard1;
        private Button checkout_barang_keranjang;
        private Button hapus_barang_keranjang;
        private Label total_harga;
        private Label label1;
    }
}