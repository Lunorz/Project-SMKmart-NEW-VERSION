using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace project_akhir_stock_gudang
{
    public partial class Dashboard_kasir2 : Form
    {
        private readonly List<DetailTransaksi> keranjang;
        private readonly List<Produk> daftarProduk;
        public Dashboard_kasir2(List<DetailTransaksi> dataKeranjang)
        {
            InitializeComponent();
            keranjang = dataKeranjang;
            daftarProduk = ProdukJsonStore.Load();

            SiapkanKeranjang();
            TampilkanKeranjang();
        }

        private void SiapkanKeranjang()
        {
            dgvkeranjang.Columns.Clear();
            dgvkeranjang.AutoGenerateColumns = false;
            dgvkeranjang.AllowUserToAddRows = false;
            dgvkeranjang.ReadOnly = false;
            dgvkeranjang.MultiSelect = false;
            dgvkeranjang.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvkeranjang.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvkeranjang.Columns.Add("Kode", "Kode");
            dgvkeranjang.Columns.Add("Nama", "Nama Barang");
            dgvkeranjang.Columns.Add("Harga", "Harga");
            dgvkeranjang.Columns.Add("Jumlah", "Jumlah");
            dgvkeranjang.Columns.Add("Subtotal", "Subtotal");

            dgvkeranjang.Columns["Kode"]!.Visible = true;
            dgvkeranjang.Columns["Harga"]!.ReadOnly = true;
            dgvkeranjang.Columns["Subtotal"]!.ReadOnly = true;

            dgvkeranjang.Columns["Harga"]!.DefaultCellStyle.Format = "N0";
            dgvkeranjang.Columns["Subtotal"]!.DefaultCellStyle.Format = "N0";

            dgvkeranjang.CellEndEdit -= dgvkeranjang_CellEndEdit;
            dgvkeranjang.CellEndEdit += dgvkeranjang_CellEndEdit;

            kembali_ke_Dashboard1.Click -= kembali_ke_Dashboard1_Click;
            kembali_ke_Dashboard1.Click += kembali_ke_Dashboard1_Click;

            hapus_barang_keranjang.Click -= hapus_barang_keranjang_Click;
            hapus_barang_keranjang.Click += hapus_barang_keranjang_Click;
        }

        private void TampilkanKeranjang()
        {
            dgvkeranjang.Rows.Clear();

            decimal total = 0;

            foreach (DetailTransaksi item in keranjang)
            {
                decimal subtotal = item.Harga * item.Jumlah;

                dgvkeranjang.Rows.Add(
                    item.Kode,
                    item.Nama,
                    item.Harga,
                    item.Jumlah,
                    subtotal);

                total += subtotal;
            }

            total_harga.Text = "Total: Rp" + total.ToString("N0");
        }
        private void Dashboard_kasir2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dgvkeranjang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvkeranjang_CellEndEdit(
        object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            DataGridViewRow baris = dgvkeranjang.Rows[e.RowIndex];

            string kodeLama =
                baris.Cells["Kode"].Value?.ToString() ?? "";

            DetailTransaksi? item = keranjang.FirstOrDefault(
                x => x.Kode == kodeLama);

            if (item == null)
                return;

            string kolom =
                dgvkeranjang.Columns[e.ColumnIndex].Name;

            if (kolom == "Nama")
            {
                string namaInput =
                    baris.Cells["Nama"].Value?.ToString()?.Trim() ?? "";

                Produk? produkBaru = daftarProduk.FirstOrDefault(
                    p => string.Equals(
                        p.Nama,
                        namaInput,
                        StringComparison.OrdinalIgnoreCase));

                if (produkBaru == null)
                {
                    MessageBox.Show(
                        "Nama barang tidak ditemukan di produk.json.");

                    TampilkanKeranjang();
                    return;
                }

                int jumlahProdukLain = keranjang
                    .Where(x => x.Kode == produkBaru.Kode && x != item)
                    .Sum(x => x.Jumlah);

                if (item.Jumlah + jumlahProdukLain > produkBaru.Stok)
                {
                    MessageBox.Show("Jumlah melebihi stok yang tersedia.");
                    TampilkanKeranjang();
                    return;
                }

                item.Kode = produkBaru.Kode;
                item.Nama = produkBaru.Nama;
                item.Harga = produkBaru.Harga;
            }
            else if (kolom == "Jumlah")
            {
                string input =
                    baris.Cells["Jumlah"].Value?.ToString() ?? "";

                if (!int.TryParse(input, out int jumlahBaru) ||
                    jumlahBaru <= 0)
                {
                    MessageBox.Show(
                        "Jumlah harus berupa angka bulat lebih dari 0.");

                    TampilkanKeranjang();
                    return;
                }

                Produk? produk = daftarProduk.FirstOrDefault(
                    p => p.Kode == item.Kode);

                if (produk == null)
                {
                    MessageBox.Show("Data produk tidak ditemukan.");
                    TampilkanKeranjang();
                    return;
                }

                int jumlahProdukLain = keranjang
                    .Where(x => x.Kode == item.Kode && x != item)
                    .Sum(x => x.Jumlah);

                if (jumlahBaru + jumlahProdukLain > produk.Stok)
                {
                    MessageBox.Show("Jumlah melebihi stok yang tersedia.");
                    TampilkanKeranjang();
                    return;
                }

                item.Jumlah = jumlahBaru;

            }

            TampilkanKeranjang();
        }

        private void hapus_barang_keranjang_Click(object sender, EventArgs e)
        {
            if (dgvkeranjang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih barang yang ingin dihapus.");
                return;
            }

            string kode = dgvkeranjang.SelectedRows[0]
                .Cells["Kode"].Value?.ToString() ?? "";

            string nama = dgvkeranjang.SelectedRows[0]
                .Cells["Nama"].Value?.ToString() ?? "";

            DetailTransaksi? item = keranjang.FirstOrDefault(
                x => x.Kode == kode && x.Nama == nama);

            if (item == null)
                return;

            DialogResult hasil = MessageBox.Show(
                $"Hapus {item.Nama} dari keranjang?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (hasil == DialogResult.Yes)
            {
                keranjang.Remove(item);
                TampilkanKeranjang();
            }
        }

        private void kembali_ke_Dashboard1_Click(object sender, EventArgs e)
        {
            Dashboard_kasir kembali_ke_kategori = new Dashboard_kasir(new List<DetailTransaksi>());
            kembali_ke_kategori.Show();
            this.Hide();
        }

        private void checkout_barang_keranjang_Click(object sender, EventArgs e)
        {
            if (keranjang.Count == 0)
            {
                MessageBox.Show(
                    "Keranjang masih kosong!",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            if (keranjang != null)
            {
                using Dashboard_kasir3 formCheckout = new Dashboard_kasir3(keranjang);
                formCheckout.ShowDialog();
                this.Hide();

            }
         
        }
    }
}
