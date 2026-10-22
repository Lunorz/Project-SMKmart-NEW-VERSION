using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace project_akhir_stock_gudang
{
    public partial class Dashboard_kasir : Form
    {
  
        private List<Produk> daftarProduk = new();
        private List<DetailTransaksi> keranjang = new();
        public Dashboard_kasir(List<DetailTransaksi> dataKeranjang)
        {
            InitializeComponent();
            MuatProduk();
            daftarProduk = ProdukJsonStore.Load();
            SiapkanDaftarBarang();
            PerbaruiInfoTransaksi();
           
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
            string kategori = textbox_kategori_barang.Text.Trim();

            listbox_barang.BeginUpdate();
            listbox_barang.Items.Clear();

            foreach (Produk produk in daftarProduk)
            {
                if (string.IsNullOrWhiteSpace(kategori) ||
                    produk.Kategori.Contains(
                        kategori,
                        StringComparison.OrdinalIgnoreCase))
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
            Dashboard_kasir2 dashboard2 = new Dashboard_kasir2(keranjang);
            dashboard2.Show();
            this.Hide();
        }
    }
}
