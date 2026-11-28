using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace project_akhir_stock_gudang
{
    public partial class Dashboard_kasir : Form
    {

        private List<Produk> daftarProduk = new();
        private List<DetailTransaksi> keranjang = new();
        private string usernameKasir = "";
        private formAkunSayaKasir? halamanAkun;
        public Dashboard_kasir(List<DetailTransaksi> dataKeranjang, string username)
        {
            InitializeComponent();
            UiTheme.ApplyCashierPanelDecoration(panel5);
            UiTheme.DecorateCashierButton(tambah_ke_keranjang, false);
            UiTheme.DecorateCashierButton(menuju_dashboard2);
            UiTheme.DecorateCashierList(listbox_barang);
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.Sizable;
            fotoGir.BringToFront();
            kembali_ke_login2.BringToFront();
            Resize += Dashboard_kasir_Resize;
            AturLayoutResponsif();
            MuatProduk();
            daftarProduk = ProdukJsonStore.Load();
            keranjang = dataKeranjang ?? new List<DetailTransaksi>();
            usernameKasir = username ?? "";

            SiapkanDaftarBarang();
            PerbaruiInfoTransaksi();
            this.AcceptButton = tambah_ke_keranjang;
            this.KeyPreview = true;
            this.KeyDown += Dashboard_kasir_KeyDown;

        }

        private void Dashboard_kasir_Resize(object? sender, EventArgs e)
        {
            AturLayoutResponsif();
        }

        private void AturLayoutResponsif()
        {
            if (ClientSize.Width < 10 || ClientSize.Height < 10)
                return;

            int lebar = ClientSize.Width;
            int tinggi = ClientSize.Height;
            const int tinggiHeader = 102;
            const int tinggiInfo = 133;
            const int jarak = 12;

            panel1.Dock = DockStyle.None;
            panel2.Dock = DockStyle.None;
            panel5.Dock = DockStyle.None;

            panel1.Location = new Point(0, 0);
            panel1.Size = new Size(lebar, tinggiHeader);

            panel2.Location = new Point(0, tinggiHeader);
            panel2.Size = new Size(lebar, tinggiInfo);

            int tinggiKonten = Math.Max(180, tinggi - tinggiHeader - tinggiInfo);
            panel5.Location = new Point(0, tinggiHeader + tinggiInfo);
            panel5.Size = new Size(lebar, tinggiKonten);

            int lebarKartu = Math.Max(250, Math.Min(360, (lebar - 3 * jarak) / 2));
            panel3.Location = new Point(jarak, 19);
            panel3.Size = new Size(lebarKartu, 97);

            panel4.Location = new Point(lebar - lebarKartu - jarak, 19);
            panel4.Size = new Size(lebarKartu, 97);

            int lebarDalam = Math.Max(120, lebar - 2 * jarak);
            label3.Location = new Point(jarak, 18);
            textbox_kategori_barang.Location = new Point(jarak, 47);
            textbox_kategori_barang.Size = new Size(lebarDalam, 42);

            int tinggiFooter = 160;
            int tinggiDaftar = Math.Max(70, tinggiKonten - 47 - 42 - tinggiFooter);
            listbox_barang.Location = new Point(jarak, 101);
            listbox_barang.Size = new Size(lebarDalam, tinggiDaftar);

            int posisiFooter = 101 + tinggiDaftar;
            label4.Location = new Point(jarak, posisiFooter + 7);
            jumlah_beli_barang.Location = new Point(jarak, posisiFooter + 32);
            jumlah_beli_barang.Size = new Size(Math.Max(120, lebarDalam - 162), 48);

            tambah_ke_keranjang.Location = new Point(lebar - jarak - 150, posisiFooter + 32);
            tambah_ke_keranjang.Size = new Size(150, 48);

            menuju_dashboard2.Location = new Point(jarak, tinggiKonten - 60);
            menuju_dashboard2.Size = new Size(lebarDalam, 48);

            panel1.BringToFront();
            panel2.BringToFront();
            panel5.BringToFront();
            panel5.Invalidate();
        }

        private void Dashboard_kasir_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PerbaruiInfoTransaksi()
        {
            DateTime sekarang = DateTime.Now;

            label_tanggal_transaksi.Text =
                sekarang.ToString("dd/MM/yyyy");

            label_nomor_transaksi.Text =
                "TRX" + sekarang.ToString("yyyyMMdd-HHmmss");
        }

        private void SiapkanDaftarBarang()
        {
            listbox_barang.SelectionMode = SelectionMode.One;
            listbox_barang.IntegralHeight = false;
            listbox_barang.DrawMode = DrawMode.OwnerDrawFixed;
            listbox_barang.DrawItem -= listbox_barang_DrawItem;
            listbox_barang.DrawItem += listbox_barang_DrawItem;
            textbox_kategori_barang.TextChanged -= textbox_kategori_barang_TextChanged;
            textbox_kategori_barang.TextChanged += textbox_kategori_barang_TextChanged;

            TampilkanDaftarBarang();
        }
        private void MuatProduk()
        {
            try
            {
                TampilkanDaftarBarang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat produk: " + ex.Message,
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }



        private void TampilkanDaftarBarang()
        {
            string kataKunci = textbox_kategori_barang.Text.Trim();

            listbox_barang.BeginUpdate();
            listbox_barang.Items.Clear();

            foreach (Produk produk in daftarProduk)
            {

                if (produk.IsDeleted)
                {
                    continue;
                }


                bool cocokKategori =
                    produk.Kategori.Contains(
                        kataKunci,
                        StringComparison.OrdinalIgnoreCase
                    );


                bool cocokNama =
                    produk.Nama.Contains(
                        kataKunci,
                        StringComparison.OrdinalIgnoreCase
                    );


                bool cocokKode =
                    produk.Kode.Contains(
                        kataKunci,
                        StringComparison.OrdinalIgnoreCase
                    );


                if (string.IsNullOrWhiteSpace(kataKunci) ||
                    cocokKategori ||
                    cocokNama ||
                    cocokKode)
                {
                    listbox_barang.Items.Add(produk);
                }
            }

            listbox_barang.EndUpdate();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textbox_kategori_barang_TextChanged(object? sender, EventArgs e)
        {
            TampilkanDaftarBarang();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tambah_ke_keranjang_Click(object sender, EventArgs e)
        {
            if (listbox_barang.SelectedItem is not Produk produk)
            {
                MessageBox.Show("Pilih barang terlebih dahulu.");
                return;
            }

            if (!int.TryParse(jumlah_beli_barang.Text.Trim(), out int jumlah) ||
                jumlah <= 0)
            {
                MessageBox.Show("Masukkan jumlah berupa angka bulat lebih dari 0.");
                jumlah_beli_barang.Focus();
                jumlah_beli_barang.SelectAll();
                return;
            }

            DetailTransaksi? itemLama = keranjang.FirstOrDefault(
                x => x.Kode == produk.Kode);

            int jumlahSebelumnya = itemLama?.Jumlah ?? 0;

            if (jumlahSebelumnya + jumlah > produk.Stok)
            {
                MessageBox.Show(
                    $"Stok {produk.Nama} hanya tersedia {produk.Stok} buah.");
                return;
            }
            DialogResult konfirmasi = MessageBox.Show(
           "Apakah Anda yakin ingin menambahkan barang ini ke keranjang?\n\n" +
           "Nama barang: " + produk.Nama + "\n" +
           "Kode barang: " + produk.Kode + "\n" +
           "Harga: Rp" + produk.Harga.ToString("N0") + "\n" +
           "Jumlah: " + jumlah + "\n" +
           "Subtotal: Rp" + ((decimal)produk.Harga * jumlah).ToString("N0"),
           "Konfirmasi Tambah Barang",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question
            );

            if (konfirmasi != DialogResult.Yes)
            {
                return;
            }
            if (itemLama != null)
            {
                itemLama.Jumlah += jumlah;
            }
            else
            {
                keranjang.Add(new DetailTransaksi
                {
                    Kode = produk.Kode,
                    Nama = produk.Nama,
                    Harga = produk.Harga,
                    Jumlah = jumlah
                });
            }

            MessageBox.Show(
         $"{produk.Nama} berhasil ditambahkan sebanyak {jumlah}.",
         "Berhasil",
         MessageBoxButtons.OK,
         MessageBoxIcon.Information);

            jumlah_beli_barang.Clear();
            jumlah_beli_barang.Focus();
        }

        private void jumlah_beli_barang_TextChanged(object sender, EventArgs e)
        {

        }

        private void listbox_barang_DrawItem(
    object? sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.DrawBackground();

            if (listbox_barang.Items[e.Index] is not Produk produk)
                return;

            bool dipilih =
                (e.State & DrawItemState.Selected) != 0;

            Color warnaLatar = dipilih
                ? Color.FromArgb(220, 245, 241)
                : Color.White;

            using (SolidBrush latar = new SolidBrush(warnaLatar))
            {
                e.Graphics.FillRectangle(latar, e.Bounds);
            }

            Rectangle areaNama = new Rectangle(
                e.Bounds.X + 10,
                e.Bounds.Y + 3,
                e.Bounds.Width - 20,
                20);

            Rectangle areaDetail = new Rectangle(
                e.Bounds.X + 10,
                e.Bounds.Y + 24,
                e.Bounds.Width - 20,
                17);

            TextRenderer.DrawText(
                e.Graphics,
                produk.Nama,
                new Font("Segoe UI", 10, FontStyle.Bold),
                areaNama,
                Color.FromArgb(38, 50, 56),
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter |
                TextFormatFlags.EndEllipsis);

            TextRenderer.DrawText(
                e.Graphics,
                $"Rp{produk.Harga:N0}  |  Stok: {produk.Stok}",
                new Font("Segoe UI", 8, FontStyle.Regular),
                areaDetail,
                Color.FromArgb(100, 116, 120),
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter |
                TextFormatFlags.EndEllipsis);

            e.DrawFocusRectangle();
        }

        private void kembali_ke_login2_Click(object sender, EventArgs e)
        {
            Form1 kembali2 = new Form1();
            kembali2.Show();
            this.Hide();
        }

        private void menuju_dashboard2_Click(object sender, EventArgs e)
        {
            Dashboard_kasir2 dashboard2 = new Dashboard_kasir2(keranjang, usernameKasir);
            dashboard2.Show();
            this.Hide();
        }


        private void fotoGir_Click(object sender, EventArgs e)
        {

            UserAccount? akun = UserStore.GetAll()
                .FirstOrDefault(x =>
                    string.Equals(
                        x.Username,
                        usernameKasir,
                        StringComparison.OrdinalIgnoreCase));

            if (akun == null)
            {
                MessageBox.Show("Data akun kasir tidak ditemukan.");
                return;
            }

            if (halamanAkun == null || halamanAkun.IsDisposed)
            {
                halamanAkun = new formAkunSayaKasir(
                    akun.Username,
                    this);
            }

            halamanAkun.Show();
            halamanAkun.BringToFront();

            this.Hide();
        }
        private void Dashboard_kasir_KeyDown(object? sender, KeyEventArgs e)
        {

            if (e.Control && e.KeyCode == Keys.S)
            {
                e.SuppressKeyPress = true;
                textbox_kategori_barang.Focus();
            }

            else if (e.Control && e.KeyCode == Keys.N)
            {
                e.SuppressKeyPress = true;
                menuju_dashboard2.PerformClick();
            }

            else if (e.Control && e.KeyCode == Keys.J)
            {
                e.SuppressKeyPress = true;
                jumlah_beli_barang.Focus();
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                kembali_ke_login2_Click(this, EventArgs.Empty); 
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
