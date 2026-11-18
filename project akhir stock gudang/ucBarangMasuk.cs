using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace project_akhir_stock_gudang
{
    public partial class ucBarangMasuk : UserControl
    {
        private List<Produk> daftarProduk = new List<Produk>();

        private string usernamePetugas = "";



        private List<BarangMasuk> riwayatBarangMasuk =
            new List<BarangMasuk>();
        public ucBarangMasuk(string username)
        {
            InitializeComponent();
            usernamePetugas = username;
            InisialisasiBarangMasuk();
        }

        private void InisialisasiBarangMasuk()
        {

            nudJumlahGudang2.Minimum = 0;
            nudJumlahGudang2.Maximum = 1000000;
            nudJumlahGudang2.Value = 0;


            cmbPerriodeGudang2.Items.Clear();
            cmbPerriodeGudang2.Items.Add("Hari Ini");
            cmbPerriodeGudang2.Items.Add("7 Hari Terakhir");
            cmbPerriodeGudang2.Items.Add("30 Hari Terakhir");
            cmbPerriodeGudang2.Items.Add("Semua");

            cmbPerriodeGudang2.SelectedIndex = 3;


            MuatProduk();


            MuatRiwayatBarangMasuk();


            txtCariGudang2.TextChanged +=
                txtCariGudang2_TextChanged;

            cmbPerriodeGudang2.SelectedIndexChanged +=
                cmbPerriodeGudang2_SelectedIndexChanged;

            btnBersihkanGudang2.Click +=
                btnBersihkanGudang2_Click;

            btnSimpanGudang2.Click +=
                btnSimpanGudang2_Click;
        }

        private void MuatProduk()
        {
            try
            {
                daftarProduk = ProdukJsonStore.Load();

                daftarProduk = daftarProduk
                    .Where(p => !p.IsDeleted)
                    .ToList();

                cmbBarangGudang2.DataSource = null;

                cmbBarangGudang2.DisplayMember = "Nama";
                cmbBarangGudang2.ValueMember = "Kode";

                cmbBarangGudang2.DataSource = daftarProduk;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat data produk:\n" + ex.Message,
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void MuatRiwayatBarangMasuk()
        {
            try
            {
                riwayatBarangMasuk =
                    BarangMasukJsonStore.Load();

                TampilkanRiwayatBarangMasuk();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat riwayat barang masuk:\n" + ex.Message
                );
            }
        }

        private void TampilkanRiwayatBarangMasuk()
        {
            dataGridView1.Rows.Clear();

            IEnumerable<BarangMasuk> data =
                riwayatBarangMasuk;


            DateTime hariIni = DateTime.Today;

            if (cmbPerriodeGudang2.Text == "Hari Ini")
            {
                data = data.Where(x =>
                    x.Waktu.Date == hariIni);
            }
            else if (cmbPerriodeGudang2.Text == "7 Hari Terakhir")
            {
                DateTime batas = hariIni.AddDays(-6);

                data = data.Where(x =>
                    x.Waktu.Date >= batas &&
                    x.Waktu.Date <= hariIni);
            }
            else if (cmbPerriodeGudang2.Text == "30 Hari Terakhir")
            {
                DateTime batas = hariIni.AddDays(-29);

                data = data.Where(x =>
                    x.Waktu.Date >= batas &&
                    x.Waktu.Date <= hariIni);
            }


            string kataKunci =
                txtCariGudang2.Text.Trim();

            if (!string.IsNullOrWhiteSpace(kataKunci))
            {
                data = data.Where(x =>
                    x.NamaBarang.Contains(
                        kataKunci,
                        StringComparison.OrdinalIgnoreCase
                    )
                    ||
                    x.AsalBarang.Contains(
                        kataKunci,
                        StringComparison.OrdinalIgnoreCase
                    )
                );
            }


            foreach (BarangMasuk item in data.OrderByDescending(x => x.Waktu))
            {
                dataGridView1.Rows.Add(
                item.Waktu.ToString("dd/MM/yyyy HH:mm"),
                item.NamaBarang,
                item.Jumlah,
                item.HargaBeli.ToString("N0"),
                 item.AsalBarang,
                 item.NomorSuratJalan
                 );
                
            }
        }

        private void txtCariGudang2_TextChanged(object sender, EventArgs e)
        {
            TampilkanRiwayatBarangMasuk();
        }

        private void cmbPerriodeGudang2_SelectedIndexChanged(object sender, EventArgs e)
        {
            TampilkanRiwayatBarangMasuk();
        }

        private void btnBersihkanGudang2_Click(object sender, EventArgs e)
        {
            bool adaIsi =
                cmbBarangGudang2.SelectedIndex != -1 ||
                nudJumlahGudang2.Value != 0 ||
                nudHargaBeli.Value != 0 ||
                !string.IsNullOrWhiteSpace(txtAsalGudang2.Text) ||
                !string.IsNullOrWhiteSpace(txtSJGudang2.Text) ||
                !string.IsNullOrWhiteSpace(txtCatatanGudang2.Text);

            if (adaIsi)
            {
                DialogResult hasil = MessageBox.Show(
                    "Apakah Anda yakin ingin mengosongkan seluruh form barang masuk?\n\n" +
                    "Data yang belum disimpan akan hilang.",
                    "Konfirmasi Bersihkan Form",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (hasil != DialogResult.Yes)
                {
                    return;
                }
            }

            cmbBarangGudang2.SelectedIndex = -1;
            nudJumlahGudang2.Value = 0;
            nudHargaBeli.Value = 0;
            txtAsalGudang2.Clear();
            txtSJGudang2.Clear();
            txtCatatanGudang2.Clear();

            cmbBarangGudang2.Focus();
        }


        private void btnSimpanGudang2_Click(object sender, EventArgs e)
        {
            if (cmbBarangGudang2.SelectedItem == null)
            {
                MessageBox.Show("Silakan pilih barang terlebih dahulu.");
                cmbBarangGudang2.Focus();
                return;
            }

            Produk produkDipilih = cmbBarangGudang2.SelectedItem as Produk;

            if (produkDipilih == null)
            {
                MessageBox.Show("Data produk tidak valid.");
                return;
            }

            int jumlah = (int)nudJumlahGudang2.Value;

            if (jumlah <= 0)
            {
                MessageBox.Show("Jumlah barang masuk harus lebih dari 0.");
                nudJumlahGudang2.Focus();
                return;
            }

            decimal hargaBeli = nudHargaBeli.Value;

            if (hargaBeli <= 0)
            {
                MessageBox.Show("Harga beli harus lebih dari 0.");
                nudHargaBeli.Focus();
                return;
            }

            string asal = txtAsalGudang2.Text.Trim();

            if (string.IsNullOrWhiteSpace(asal))
            {
                MessageBox.Show("Asal barang harus diisi.");
                txtAsalGudang2.Focus();
                return;
            }

            string nomorSurat = txtSJGudang2.Text.Trim();

            if (string.IsNullOrWhiteSpace(nomorSurat))
            {
                MessageBox.Show("Nomor surat jalan harus diisi.");
                txtSJGudang2.Focus();
                return;
            }
            DialogResult konfirmasi = MessageBox.Show(
            "Apakah Anda yakin ingin menyimpan data barang masuk ini?\n\n" +
            "Nama barang: " + produkDipilih.Nama + "\n" +
            "Jumlah masuk: " + jumlah + " unit\n" +
            "Harga beli/unit: Rp" + hargaBeli.ToString("N0") + "\n" +
            "Total pembelian: Rp" + (hargaBeli * jumlah).ToString("N0") + "\n" +
            "Asal barang: " + asal + "\n" +
            "Nomor surat jalan: " + nomorSurat,
            "Konfirmasi Barang Masuk",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (konfirmasi != DialogResult.Yes)
            {
                return;
            }
            try
            {
                
                List<Produk> produkTerbaru = ProdukJsonStore.Load();

                Produk produk = produkTerbaru.FirstOrDefault(
                    p => p.Kode == produkDipilih.Kode
                );

                if (produk == null || produk.IsDeleted)
                {
                    MessageBox.Show(
                        "Produk tidak ditemukan atau sudah tidak aktif."
                    );

                    MuatProduk();
                    return;
                }

                if (produk.Stok > int.MaxValue - jumlah)
                {
                    MessageBox.Show("Jumlah stok terlalu besar.");
                    return;
                }

                int stokSebelum = produk.Stok;
                DateTime waktuMasuk = DateTime.Now;

              
                BarangMasuk dataBaru = new BarangMasuk
                {
                    Waktu = waktuMasuk,
                    KodeBarang = produk.Kode,
                    NamaBarang = produk.Nama,
                    Jumlah = jumlah,
                    HargaBeli = hargaBeli,
                    AsalBarang = asal,
                    NomorSuratJalan = nomorSurat,
                    Catatan = txtCatatanGudang2.Text.Trim(),
                    Petugas = usernamePetugas
                };

               
                LapisanStok lapisanBaru = new LapisanStok
                {
                    IdLapisan = Guid.NewGuid().ToString(),
                    KodeBarang = produk.Kode,
                    NamaBarang = produk.Nama,
                    TanggalMasuk = waktuMasuk,
                    Petugas = usernamePetugas,
                    NomorSuratJalan = nomorSurat,
                    StokAwal = jumlah,
                    SisaStok = jumlah,
                    HargaBeli = hargaBeli
                };

              
                produk.Stok += jumlah;

               
                List<LapisanStok> semuaLapisan =
                    LapisanStokJsonStore.Load();

                semuaLapisan.Add(lapisanBaru);

                LapisanStokJsonStore.Save(semuaLapisan);

             
                riwayatBarangMasuk = BarangMasukJsonStore.Load();
                riwayatBarangMasuk.Add(dataBaru);

                BarangMasukJsonStore.Save(riwayatBarangMasuk);

               
                ProdukJsonStore.Save(produkTerbaru);

               
                try
                {
                    LogAktivitasJsonStore.Catat(
                        usernamePetugas,
                        "Pengelola Gudang",
                        "Barang Masuk",
                        "Mencatat barang masuk",
                        produk.Kode + " - " + produk.Nama,
                        "Petugas mencatat barang masuk sebanyak " +
                        jumlah + " unit dari " + asal +
                        ". Harga beli per unit: Rp" +
                        hargaBeli.ToString("N0") +
                        ". Total pembelian: Rp" +
                        (hargaBeli * jumlah).ToString("N0") +
                        ". Nomor surat jalan: " + nomorSurat +
                        ". Stok sebelumnya: " + stokSebelum +
                        ". Stok sekarang: " + produk.Stok +
                        ". Catatan: " + txtCatatanGudang2.Text.Trim()
                    );
                }
                catch (Exception errorLog)
                {
                    MessageBox.Show(
                        "Barang masuk berhasil disimpan, tetapi log aktivitas gagal dicatat:\n" +
                        errorLog.Message,
                        "Peringatan Log",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }

                MuatProduk();
                TampilkanRiwayatBarangMasuk();
                BersihkanFormBarangMasuk();

                MessageBox.Show(
                    "Barang masuk berhasil disimpan.\n\n" +
                    "Nama barang: " + produk.Nama +
                    "\nJumlah masuk: " + jumlah +
                    "\nHarga beli/unit: Rp" + hargaBeli.ToString("N0") +
                    "\nTotal pembelian: Rp" + (hargaBeli * jumlah).ToString("N0") +
                    "\nStok sekarang: " + produk.Stok,
                    "Berhasil",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menyimpan barang masuk:\n" + ex.Message,
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void BersihkanFormBarangMasuk()
        {
            cmbBarangGudang2.SelectedIndex = -1;
            nudJumlahGudang2.Value = 0;
            txtAsalGudang2.Clear();
            txtSJGudang2.Clear();
            txtCatatanGudang2.Clear();
        }

        private void cmbBarangGudang2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblAsalGudang2_Click(object sender, EventArgs e)
        {

        }

        private void nudJumlahGudang2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
    

