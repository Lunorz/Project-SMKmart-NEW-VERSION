using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_akhir_stock_gudang
{
    public partial class ucDataBarang : UserControl
    {
        private List<Produk> daftarProduk = new List<Produk>();
        private string? kodeProdukDiedit = null;
        private string emailAdmin = "admin@gmail.com";
        public ucDataBarang()
        {
            InitializeComponent();
            this.Load -= ucDataBarang_Load;
            this.Load += ucDataBarang_Load;

            btnSimpan1.Click -= btnSimpan1_Click;
            btnSimpan1.Click += btnSimpan1_Click;

            txtCari1.TextChanged -= txtCari1_TextChanged;
            txtCari1.TextChanged += txtCari1_TextChanged;

            cmbFilter1.SelectedIndexChanged -= cmbFilter1_SelectedIndexChanged;
            cmbFilter1.SelectedIndexChanged += cmbFilter1_SelectedIndexChanged;

            dgvBarang1.CellContentClick -= dgvBarang1_CellContentClick;
            dgvBarang1.CellContentClick += dgvBarang1_CellContentClick;

            dgvBarang1.CellClick -= dgvBarang1_CellClick;
            dgvBarang1.CellClick += dgvBarang1_CellClick;
        }
        private void ucDataBarang_Load(object sender, EventArgs e)
        {
            txtKode1.ReadOnly = true;

            MuatDataProduk();

            MuatKategori();
            TampilkanDataProduk();
            numStockAwal.Minimum = 0;
            numStockAwal.Maximum = 1000000;
            numStockAwal.Value = 0;
            numStockAwal.DecimalPlaces = 0;
            numStockAwal.Increment = 1;
        }
        private void MuatDataProduk()
        {
            try
            {
                daftarProduk = ProdukJsonStore.Load();

                if (daftarProduk == null)
                {
                    daftarProduk = new List<Produk>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat data produk:\n" + ex.Message,
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                daftarProduk = new List<Produk>();
            }
        }
        private void TampilkanDataProduk()
        {
            string pencarian = txtCari1.Text.Trim();

            string kategoriDipilih =
                cmbFilter1.SelectedItem?.ToString() ?? "Semua Kategori";

            dgvBarang1.Rows.Clear();

            foreach (Produk produk in daftarProduk)
            {

                bool cocokPencarian =
                    produk.Kode.Contains(
                        pencarian,
                        StringComparison.OrdinalIgnoreCase
                    )
                    ||
                    produk.Nama.Contains(
                        pencarian,
                        StringComparison.OrdinalIgnoreCase
                    );


                bool cocokKategori =
                    kategoriDipilih == "Semua Kategori"
                    ||
                    produk.Kategori.Equals(
                        kategoriDipilih,
                        StringComparison.OrdinalIgnoreCase
                    );

                if (!cocokPencarian || !cocokKategori)
                {
                    continue;
                }

                int index = dgvBarang1.Rows.Add();

                DataGridViewRow baris =
                    dgvBarang1.Rows[index];

                baris.Cells["colKode1"].Value = produk.Kode;
                baris.Cells["colBarang1"].Value = produk.Nama;
                baris.Cells["colKategori1"].Value = produk.Kategori;

                baris.Cells["colHargaBarang1"].Value =
                    "Rp" + produk.Harga.ToString("N0");


                baris.Cells["colHapus1"].Value =
                    produk.IsDeleted ? "Pulihkan" : "Hapus";


                baris.Tag = produk.Kode;


                baris.DefaultCellStyle.ForeColor =
                    produk.IsDeleted
                    ? System.Drawing.Color.Gray
                    : System.Drawing.Color.Black;
            }
        }
        private void MuatKategori()
        {
            string kategoriSebelumnya =
                cmbFilter1.SelectedItem?.ToString()
                ?? "Semua Kategori";

            cmbFilter1.Items.Clear();

            cmbFilter1.Items.Add("Semua Kategori");

            List<string> kategori = daftarProduk
                .Select(p => p.Kategori)
                .Where(k => !string.IsNullOrWhiteSpace(k))
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .OrderBy(k => k)
                .ToList();

            foreach (string item in kategori)
            {
                cmbFilter1.Items.Add(item);
            }

            int index = cmbFilter1.Items.IndexOf(kategoriSebelumnya);

            cmbFilter1.SelectedIndex =
                index >= 0 ? index : 0;
        }
        private string BuatKodeBarang(string kategori)
        {
            string prefix = new string(
                kategori
                    .Where(char.IsLetterOrDigit)
                    .Take(3)
                    .ToArray()
            ).ToUpperInvariant();

            if (string.IsNullOrWhiteSpace(prefix))
            {
                prefix = "BRG";
            }

            int nomor = 1;

            string kodeBaru;

            do
            {
                kodeBaru = prefix + nomor.ToString("D3");
                nomor++;

            } while (daftarProduk.Any(
                p => p.Kode.Equals(
                    kodeBaru,
                    StringComparison.OrdinalIgnoreCase
                )
            ));

            return kodeBaru;
        }

        private void btnSimpan1_Click(object sender, EventArgs e)
        {
            string nama = txtNama1.Text.Trim();
            string kategori = txtKategori1.Text.Trim();
            string hargaText = txtHargaBarang.Text.Trim();


            if (string.IsNullOrWhiteSpace(nama))
            {
                MessageBox.Show("Nama barang harus diisi.");
                txtNama1.Focus();
                return;
            }


            if (string.IsNullOrWhiteSpace(kategori))
            {
                MessageBox.Show("Kategori barang harus diisi.");
                txtKategori1.Focus();
                return;
            }


            if (!decimal.TryParse(
                hargaText,
                System.Globalization.NumberStyles.Number,
                System.Globalization.CultureInfo.CurrentCulture,
                out decimal harga
            ) || harga <= 0)
            {
                MessageBox.Show("Harga harus berupa angka lebih dari 0.");
                txtHargaBarang.Focus();
                return;
            }



            if (kodeProdukDiedit != null)
            {
                Produk? produk = daftarProduk.FirstOrDefault(
                    p => p.Kode == kodeProdukDiedit
                );

                if (produk == null)
                {
                    MessageBox.Show("Barang yang ingin diedit tidak ditemukan.");
                    return;
                }


                bool namaSudahAda = daftarProduk.Any(
                    p => p.Kode != kodeProdukDiedit &&
                         !p.IsDeleted &&
                         p.Nama.Equals(
                             nama,
                             StringComparison.OrdinalIgnoreCase
                         ) &&
                         p.Kategori.Equals(
                             kategori,
                             StringComparison.OrdinalIgnoreCase
                         )
                );

                if (namaSudahAda)
                {
                    MessageBox.Show(
                        "Nama barang tersebut sudah digunakan dalam kategori yang sama."
                    );
                    return;
                }


                string namaLama = produk.Nama;
                string kategoriLama = produk.Kategori;
                decimal hargaLama = produk.Harga;

                try
                {

                    produk.Nama = nama;
                    produk.Kategori = kategori;
                    produk.Harga = harga;

                    ProdukJsonStore.Save(daftarProduk);
                    LogAktivitasJsonStore.Catat(
                    emailAdmin,
                   "Barang",
                   "Mengubah data barang",
                    produk.Kode + " - " + produk.Nama,
                   "Admin mengubah data barang. " +
                   "Nama: " + namaLama + " menjadi " + produk.Nama +
                   "; Kategori: " + kategoriLama + " menjadi " + produk.Kategori +
                   "; Harga: Rp" + hargaLama.ToString("N0") +
                   " menjadi Rp" + produk.Harga.ToString("N0")
                    );

                    MuatKategori();
                    TampilkanDataProduk();
                    BersihkanInput();

                    MessageBox.Show(
                        "Data barang berhasil diperbarui!",
                        "Berhasil",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                catch (Exception ex)
                {

                    produk.Nama = namaLama;
                    produk.Kategori = kategoriLama;
                    produk.Harga = hargaLama;

                    MessageBox.Show(
                        "Gagal memperbarui barang:\n" + ex.Message,
                        "Kesalahan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }

                return;
            }



            bool barangSudahAda = daftarProduk.Any(
                p => !p.IsDeleted &&
                     p.Nama.Equals(
                         nama,
                         StringComparison.OrdinalIgnoreCase
                     ) &&
                     p.Kategori.Equals(
                         kategori,
                         StringComparison.OrdinalIgnoreCase
                     )
            );

            if (barangSudahAda)
            {
                MessageBox.Show(
                    "Barang dengan nama dan kategori tersebut sudah tersedia."
                );
                return;
            }

            string kode = BuatKodeBarang(kategori);

            Produk produkBaru = new Produk
            {
                Kode = kode,
                Nama = nama,
                Kategori = kategori,
                Harga = harga,
                Stok = (int)numStockAwal.Value,

                IsDeleted = false
            };

            try
            {
                daftarProduk.Add(produkBaru);

                ProdukJsonStore.Save(daftarProduk);

                LogAktivitasJsonStore.Catat(
                emailAdmin,
                "Admin",
                "Barang",
                "Menambahkan produk",
                 produkBaru.Kode + " - " + produkBaru.Nama,
                 "Admin menambahkan produk baru dengan kategori " +
                 produkBaru.Kategori +
                 " dan harga Rp" +
                 produkBaru.Harga.ToString("N0")
                 );


                MuatKategori();
                TampilkanDataProduk();
                BersihkanInput();

                MessageBox.Show(
                    "Barang berhasil ditambahkan!\nKode: " + kode,
                    "Berhasil",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                daftarProduk.Remove(produkBaru);

                MessageBox.Show(
                    "Gagal menyimpan barang:\n" + ex.Message,
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void dgvBarang1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            if (dgvBarang1.Columns[e.ColumnIndex].Name != "colHapus1")
            {
                return;
            }

            string kode = Convert.ToString(
                dgvBarang1.Rows[e.RowIndex].Tag
            ) ?? "";

            Produk? produk = daftarProduk.FirstOrDefault(
                p => p.Kode == kode
            );

            if (produk == null)
            {
                MessageBox.Show("Data barang tidak ditemukan.");
                return;
            }

            if (!produk.IsDeleted)
            {
                DialogResult konfirmasi = MessageBox.Show(
                    "Apakah kamu yakin ingin menghapus barang ini?\n" +
                    "Barang tidak akan muncul di Dashboard Kasir.",
                    "Konfirmasi Hapus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (konfirmasi != DialogResult.Yes)
                {
                    return;
                }

                produk.IsDeleted = true;
            }
            else
            {
                DialogResult konfirmasi = MessageBox.Show(
                    "Pulihkan barang ini agar muncul kembali di Kasir?",
                    "Konfirmasi Pulihkan",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (konfirmasi != DialogResult.Yes)
                {
                    return;
                }

                produk.IsDeleted = false;
            }
            try
            {
                ProdukJsonStore.Save(daftarProduk);

                if (produk.IsDeleted)
                {
                    LogAktivitasJsonStore.Catat(
                        emailAdmin,
                        "Admin",
                        "Barang",
                        "Menonaktifkan produk",
                        produk.Kode + " - " + produk.Nama,
                        "Admin menonaktifkan produk. Produk tidak lagi muncul di Dashboard Kasir."
                    );
                }
                else
                {
                    LogAktivitasJsonStore.Catat(
                        emailAdmin,
                        "Admin",
                        "Barang",
                        "Mengaktifkan kembali produk",
                        produk.Kode + " - " + produk.Nama,
                        "Admin mengaktifkan kembali produk agar muncul di Dashboard Kasir."
                    );
                }

                TampilkanDataProduk();
            }
            catch (Exception ex)
            {
                produk.IsDeleted = !produk.IsDeleted;

                MessageBox.Show(
                    "Gagal memperbarui status barang:\n" + ex.Message,
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void txtCari1_TextChanged(object sender, EventArgs e)
        {
            TampilkanDataProduk();
        }

        private void cmbFilter1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TampilkanDataProduk();
        }
        private void BersihkanInput()
        {
            txtKode1.Clear();
            txtNama1.Clear();
            txtKategori1.Clear();
            txtHargaBarang.Clear();

            numStockAwal.Value = 0;
            numStockAwal.Enabled = true;
         

            kodeProdukDiedit = null;

            btnSimpan1.Text = "Simpan barang";

            txtNama1.Focus();
        }

        private void dgvBarang1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;


            if (dgvBarang1.Columns[e.ColumnIndex].Name == "colHapus1")
                return;

            DataGridViewRow baris = dgvBarang1.Rows[e.RowIndex];

            string kode = Convert.ToString(baris.Tag) ?? "";

            Produk? produk = daftarProduk.FirstOrDefault(
                p => p.Kode == kode
            );

            if (produk == null)
                return;


            if (produk.IsDeleted)
            {
                MessageBox.Show(
                    "Pulihkan barang terlebih dahulu sebelum mengeditnya."
                );
                return;
            }


            kodeProdukDiedit = produk.Kode;

            txtKode1.Text = produk.Kode;
            txtNama1.Text = produk.Nama;
            txtKategori1.Text = produk.Kategori;
            txtHargaBarang.Text = produk.Harga.ToString();

         
            numStockAwal.Value = Math.Min(
                numStockAwal.Maximum,
                Math.Max(numStockAwal.Minimum, produk.Stok)
            );

            
            numStockAwal.Enabled = false;


            txtKode1.ReadOnly = true;


            btnSimpan1.Text = "Simpan perubahan";
        }

        private void txtNama1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
