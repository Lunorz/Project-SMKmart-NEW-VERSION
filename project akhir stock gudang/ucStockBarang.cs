using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_akhir_stock_gudang
{
    public partial class ucStockBarang : UserControl
    {
        private List<Produk> daftarProduk = new List<Produk>();
        private Produk? produkTerpilih = null;
        private bool sedangMemuat = false;
        private string usernamePetugas = "";

        public ucStockBarang(string username = "")
        {
            InitializeComponent();
            usernamePetugas = username;
            txtCarigudang1.TextChanged -=
                 txtCarigudang1_TextChanged;
           

            txtCarigudang1.TextChanged +=
                txtCarigudang1_TextChanged;


            cmbKategoriGudang1.SelectedIndexChanged -=
                cmbKategoriGudang1_SelectedIndexChanged;

            cmbKategoriGudang1.SelectedIndexChanged +=
                cmbKategoriGudang1_SelectedIndexChanged;


            cmbStatusGudang1.SelectedIndexChanged -=
                cmbStatusGudang1_SelectedIndexChanged;

            cmbStatusGudang1.SelectedIndexChanged +=
                cmbStatusGudang1_SelectedIndexChanged;


            dataGridView1.SelectionChanged -=
                dataGridView1_SelectionChanged;

            dataGridView1.SelectionChanged +=
                dataGridView1_SelectionChanged;


            nudFisikGudang1.ValueChanged -=
                nudFisikGudang1_ValueChanged;

            nudFisikGudang1.ValueChanged +=
                nudFisikGudang1_ValueChanged;


            btnPengaturanGudang1.Click -=
                btnPengaturanGudang1_Click;

            btnPengaturanGudang1.Click +=
                btnPengaturanGudang1_Click;

            btnOpnameGudang1.Click -=
                btnOpnameGudang1_Click;

            btnOpnameGudang1.Click +=
                btnOpnameGudang1_Click;


            this.Load -= ucStockBarang_Load;
            this.Load += ucStockBarang_Load;

            this.VisibleChanged += ucStockBarang_VisibleChanged;
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ucStockBarang_Load(object sender, EventArgs e)
        {
            MuatDataBarang();
        }

        private void MuatDataBarang(string kodeTerpilih = "")
        {
            try
            {
                sedangMemuat = true;


                daftarProduk = ProdukJsonStore.Load()
                    ?? new List<Produk>();


                IsiComboBoxKategori();
                IsiComboBoxStatus();


                TampilkanDataBarang();


                if (!string.IsNullOrWhiteSpace(kodeTerpilih))
                {
                    PilihBarang(kodeTerpilih);
                }
                else
                {
                    BersihkanFormPengaturan();
                }


                
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat data barang:\n" + ex.Message,
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                sedangMemuat = false;
            }
        }

        private void IsiComboBoxKategori()
        {
            cmbKategoriGudang1.Items.Clear();

            cmbKategoriGudang1.Items.Add("Semua Kategori");

            var kategori = daftarProduk
                .Where(p =>
                    !p.IsDeleted &&
                    !string.IsNullOrWhiteSpace(p.Kategori))
                .Select(p => p.Kategori)
                .Distinct()
                .OrderBy(k => k)
                .ToList();

            foreach (string item in kategori)
            {
                cmbKategoriGudang1.Items.Add(item);
            }

            cmbKategoriGudang1.SelectedIndex = 0;
        }


        private void IsiComboBoxStatus()
        {
            cmbStatusGudang1.Items.Clear();

            cmbStatusGudang1.Items.Add("Semua Status");
            cmbStatusGudang1.Items.Add("Aman");
            cmbStatusGudang1.Items.Add("Menipis");
            cmbStatusGudang1.Items.Add("Kritis");
            cmbStatusGudang1.Items.Add("Habis");

            cmbStatusGudang1.SelectedIndex = 0;
        }


        private string TentukanStatus(Produk produk)
        {
            if (produk.Stok <= 0)
            {
                return "Habis";
            }

            int batasKritis = (int)Math.Ceiling(
                produk.StokMinimum * 0.5
            );

            if (produk.Stok <= batasKritis)
            {
                return "Kritis";
            }

            if (produk.Stok <= produk.StokMinimum)
            {
                return "Menipis";
            }

            return "Aman";
        }


        private void TampilkanDataBarang()
        {
            dataGridView1.Rows.Clear();

            string pencarian = txtCarigudang1.Text.Trim();

            string kategori =
                cmbKategoriGudang1.SelectedItem?.ToString()
                ?? "Semua Kategori";

            string status =
                cmbStatusGudang1.SelectedItem?.ToString()
                ?? "Semua Status";

            var hasil = daftarProduk

                .Where(p => !p.IsDeleted)


                .Where(p =>
                    string.IsNullOrWhiteSpace(pencarian) ||
                    (p.Kode ?? "").Contains(
                        pencarian,
                        StringComparison.OrdinalIgnoreCase
                    ) ||
                    (p.Nama ?? "").Contains(
                        pencarian,
                        StringComparison.OrdinalIgnoreCase
                    )
                )


                .Where(p =>
                    kategori == "Semua Kategori" ||
                    p.Kategori == kategori
                )


                .Where(p =>
                    status == "Semua Status" ||
                    TentukanStatus(p) == status
                )

                .OrderBy(p => p.Nama)
                .ToList();

            foreach (Produk produk in hasil)
            {
                dataGridView1.Rows.Add(
                    produk.Kode,
                    produk.Nama,
                    produk.Stok,
                    produk.StokMinimum,
                    TentukanStatus(produk)
                );
            }

            dataGridView1.ClearSelection();
        }

        private void txtCarigudang1_TextChanged(object sender, EventArgs e)
        {
            if (sedangMemuat) return;

            TampilkanDataBarang();
        }

        private void cmbKategoriGudang1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sedangMemuat) return;

            TampilkanDataBarang();
        }

        private void cmbStatusGudang1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sedangMemuat) return;

            TampilkanDataBarang();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            if (dataGridView1.CurrentRow.IsNewRow)
                return;

            object nilaiKode =
                dataGridView1.CurrentRow.Cells["colKode"].Value;

            if (nilaiKode == null)
                return;

            string kode = nilaiKode.ToString() ?? "";

            produkTerpilih = daftarProduk.FirstOrDefault(
                p => p.Kode == kode && !p.IsDeleted
            );

            if (produkTerpilih == null)
                return;

            TampilkanPengaturanBarang(produkTerpilih);
        }

        private void TampilkanPengaturanBarang(Produk produk)
        {

            txtSistemGudang1.Text =
                produk.Stok.ToString();


            nudFisikGudang1.Value =
                Math.Min(
                    nudFisikGudang1.Maximum,
                    Math.Max(
                        nudFisikGudang1.Minimum,
                        produk.Stok
                    )
                );


            nudMinGudang1.Value =
                Math.Min(
                    nudMinGudang1.Maximum,
                    Math.Max(
                        nudMinGudang1.Minimum,
                        produk.StokMinimum
                    )
                );


            txtAlasanGudang1.Clear();

            HitungSelisih();
        }


        private void BersihkanFormPengaturan()
        {
            produkTerpilih = null;

            txtSistemGudang1.Clear();
            txtSelisih.Clear();
            txtAlasanGudang1.Clear();

            nudFisikGudang1.Value = 0;
            nudMinGudang1.Value = 0;
        }

        private void nudFisikGudang1_ValueChanged(object sender, EventArgs e)
        {
            HitungSelisih();
        }

        private void HitungSelisih()
        {
            if (produkTerpilih == null)
            {
                txtSelisih.Clear();
                return;
            }

            int stokSistem = produkTerpilih.Stok;

            int jumlahFisik =
                (int)nudFisikGudang1.Value;

            int selisih = jumlahFisik - stokSistem;

            if (selisih > 0)
            {
                txtSelisih.Text = "+" + selisih;
            }
            else
            {
                txtSelisih.Text =
                    selisih.ToString();
            }
        }

        private void btnPengaturanGudang1_Click(object sender, EventArgs e)
        {
            if (produkTerpilih == null)
            {
                MessageBox.Show(
                    "Pilih barang terlebih dahulu dari tabel.",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return;
            }

            int stokMinimum =
                (int)nudMinGudang1.Value;

            try
            {
                produkTerpilih.StokMinimum = stokMinimum;

                ProdukJsonStore.Save(daftarProduk);

                string kode = produkTerpilih.Kode;

                MessageBox.Show(
                    "Pengaturan stok minimum berhasil disimpan.",
                    "Berhasil",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                MuatDataBarang(kode);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menyimpan pengaturan:\n" + ex.Message,
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnOpnameGudang1_Click(object sender, EventArgs e)
        {
            if (produkTerpilih == null)
            {
                MessageBox.Show(
                    "Pilih barang terlebih dahulu dari tabel.",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return;
            }

            int stokSistem = produkTerpilih.Stok;

            int jumlahFisik =
                (int)nudFisikGudang1.Value;

            int selisih = jumlahFisik - stokSistem;

            string alasan = txtAlasanGudang1.Text.Trim();


            if (selisih != 0 && string.IsNullOrWhiteSpace(alasan))
            {
                MessageBox.Show(
                    "Masukkan alasan selisih stok terlebih dahulu.",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtAlasanGudang1.Focus();
                return;
            }

            DialogResult konfirmasi = MessageBox.Show(
                "Apakah kamu yakin ingin menyimpan hasil opname?\n\n" +
                "Stok sistem: " + stokSistem + "\n" +
                "Jumlah fisik: " + jumlahFisik + "\n" +
                "Selisih: " + selisih,
                "Konfirmasi Opname",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (konfirmasi != DialogResult.Yes)
                return;

            try
            {

                produkTerpilih.Stok = jumlahFisik;


                produkTerpilih.JumlahFisikTerakhir = jumlahFisik;

                produkTerpilih.AlasanSelisihTerakhir = alasan;

                produkTerpilih.TanggalOpnameTerakhir =
                    DateTime.Now;


                ProdukJsonStore.Save(daftarProduk);
                if (selisih != 0)
                {
                    KoreksiStokJsonStore.Tambah(new KoreksiStokSimpan
                    {
                        Waktu = DateTime.Now,
                        KodeBarang = produkTerpilih.Kode,
                        NamaBarang = produkTerpilih.Nama,
                        Jumlah = selisih,
                        StokSebelum = stokSistem,
                        StokSesudah = jumlahFisik,
                        Keterangan = alasan,
                        Petugas = usernamePetugas
                    });
                }

                string kode = produkTerpilih.Kode;

                MessageBox.Show(
                    "Hasil opname berhasil disimpan.\n" +
                    "Stok barang sekarang: " + jumlahFisik,
                    "Berhasil",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );


                MuatDataBarang(kode);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menyimpan opname:\n" + ex.Message,
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void PilihBarang(string kode)
        {
            foreach (DataGridViewRow baris in dataGridView1.Rows)
            {
                if (baris.IsNewRow)
                    continue;

                string kodeBaris =
                    baris.Cells["colKode"].Value?.ToString() ?? "";

                if (kodeBaris == kode)
                {
                    baris.Selected = true;

                    dataGridView1.CurrentCell =
                        baris.Cells["colKode"];

                    return;
                }
            }

            BersihkanFormPengaturan();
        }

        public void RefreshDataBarang()
        {
            MuatDataBarang();
        }

        private void ucStockBarang_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                MuatDataBarang();
            }
        }
    }
}

