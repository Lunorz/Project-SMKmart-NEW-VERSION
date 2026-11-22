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
    public partial class ucLaba : UserControl
    {
        private List<Produk> daftarProduk = new List<Produk>();
        private List<LapisanStok> daftarLapisan = new List<LapisanStok>();
        private List<RiwayatHargaJual> daftarRiwayat = new List<RiwayatHargaJual>();

        private string adminAktif = "Admin";
        private Produk produkTerpilih;
        private ToolTip tooltipSimulasi = new ToolTip();
        public ucLaba()
        {
            InitializeComponent();
            UiTheme.Apply(this);
            dgvDaftar.AutoGenerateColumns = false;
            dgvLapisan.AutoGenerateColumns = false;
            dgvRiwayat.AutoGenerateColumns = false;

            dgvDaftar.SelectionChanged += dgvDaftar_SelectionChanged;
            btnSimpanHarga.Click += btnSimpanHarga_Click;
            btnBatal.Click += btnBatal_Click;
            nudJualBaru.ValueChanged += nudJualBaru_ValueChanged;

            MuatSemuaData();
          
        }

        public ucLaba(string username) : this()
        {
            adminAktif = string.IsNullOrWhiteSpace(username)
                ? "Admin"
                : username;
        }

        private void MuatSemuaData()
        {
            try
            {
              
                daftarProduk = ProdukJsonStore.Load()
                    .Where(p => !p.IsDeleted)
                    .ToList();

                daftarLapisan = LapisanStokJsonStore.Load();

                daftarRiwayat = RiwayatHargaJualJsonStore.Load();

                TampilkanDaftarProduk();
                TampilkanLapisan();
                TampilkanRiwayat();

          
                TampilkanRingkasan();

             
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat data:\n" + ex.Message,
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void TampilkanDaftarProduk()
        {
            var data = daftarProduk.Select(p =>
            {
                var lapisanTerakhir = daftarLapisan
                    .Where(l => l.KodeBarang == p.Kode && l.SisaStok > 0)
                    .OrderByDescending(l => l.TanggalMasuk)
                    .FirstOrDefault();

                decimal hargaBeliTerakhir =
                    lapisanTerakhir?.HargaBeli ?? 0;

                decimal labaPerUnit = p.Harga - hargaBeliTerakhir;

                return new
                {
                    Kode = p.Kode,
                    Nama = p.Nama,
                    Stok = p.Stok,
                    HargaBeliTerakhir = hargaBeliTerakhir,
                    Harga = p.Harga,
                    LabaPerUnitTerbaru = labaPerUnit
                };
            }).ToList();

            dgvDaftar.DataSource = null;
            dgvDaftar.DataSource = data;

            dgvDaftar.AllowUserToAddRows = false;
        }



        private void TampilkanLapisan(string kodeBarang = "")
        {
            var query = daftarLapisan
                .Where(l => l.SisaStok > 0);

           
            if (!string.IsNullOrWhiteSpace(kodeBarang))
            {
                query = query.Where(l => l.KodeBarang == kodeBarang);
            }

            var data = query
                .OrderBy(l => l.KodeBarang)
                .ThenBy(l => l.TanggalMasuk)
                .Select(l =>
                {
                    var produk = daftarProduk
                        .FirstOrDefault(p => p.Kode == l.KodeBarang);

                    decimal hargaJual = produk?.Harga ?? 0;
                    decimal totalModal = l.SisaStok * l.HargaBeli;
                    decimal potensiPenjualan = l.SisaStok * hargaJual;
                    decimal potensiLaba = potensiPenjualan - totalModal;

                    return new
                    {
                        l.KodeBarang,
                        l.NamaBarang,
                        l.TanggalMasuk,
                        l.Petugas,
                        l.NomorSuratJalan,
                        l.StokAwal,
                        l.SisaStok,
                        l.HargaBeli,
                        HargaJual = hargaJual,
                        LabaPerUnit = hargaJual - l.HargaBeli,
                        TotalModalTersisa = totalModal,
                        PotensiPenjualan = potensiPenjualan,
                        PotensiLaba = potensiLaba
                    };
                })
                .ToList();

            dgvLapisan.DataSource = null;
            dgvLapisan.DataSource = data;

            string[] kolomRupiah =
            {
        "HargaBeli",
        "HargaJual",
        "TotalModalTersisa",
        "PotensiPenjualan",
        "PotensiLaba"
    };

            foreach (string namaKolom in kolomRupiah)
            {
                if (dgvLapisan.Columns.Contains(namaKolom))
                {
                    dgvLapisan.Columns[namaKolom].DefaultCellStyle.Format = "N0";
                }
            }
        }


        private void TampilkanRiwayat()
        {
            var data = daftarRiwayat
                .OrderByDescending(r => r.WaktuPerubahan)
                .Select(r => new
                {
                    r.KodeBarang,
                    r.NamaBarang,
                    r.HargaLama,
                    r.HargaBaru,
                    r.WaktuPerubahan,
                    r.Admin,
                    r.Alasan
                })
                .ToList();

            dgvRiwayat.DataSource = null;
            dgvRiwayat.DataSource = data;

            if (dgvRiwayat.Columns["HargaLama"] != null)
                dgvRiwayat.Columns["HargaLama"].DefaultCellStyle.Format = "N0";

            if (dgvRiwayat.Columns["HargaBaru"] != null)
                dgvRiwayat.Columns["HargaBaru"].DefaultCellStyle.Format = "N0";
        }

        private void dgvDaftar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDaftar.CurrentRow == null)
                return;

            string kode = Convert.ToString(
                dgvDaftar.CurrentRow.Cells["colKode"].Value
            ) ?? "";

            produkTerpilih = daftarProduk.FirstOrDefault(
                p => p.Kode == kode
            );

            if (produkTerpilih == null)
                return;

            txtJualSekarang.Text = produkTerpilih.Harga.ToString("N0");

            nudJualBaru.Value = Math.Min(
                nudJualBaru.Maximum,
                Math.Max(nudJualBaru.Minimum, produkTerpilih.Harga)
            );

            var lapisanProduk = daftarLapisan
                .Where(l => l.KodeBarang == produkTerpilih.Kode
                         && l.SisaStok > 0)
                .OrderBy(l => l.TanggalMasuk)
                .ToList();

            decimal hargaBeliTerakhir = lapisanProduk
                .OrderByDescending(l => l.TanggalMasuk)
                .Select(l => l.HargaBeli)
                .FirstOrDefault();

            txtBeliTerakhir.Text = hargaBeliTerakhir.ToString("N0");
            TampilkanDampakPerubahanHarga();
            TampilkanLapisan(produkTerpilih.Kode);
        }

        private void btnSimpanHarga_Click(object sender, EventArgs e)
        {
            if (produkTerpilih == null)
            {
                MessageBox.Show("Pilih barang terlebih dahulu.");
                return;
            }

            decimal hargaLama = produkTerpilih.Harga;
            decimal hargaBaru = nudJualBaru.Value;

            if (hargaBaru <= 0)
            {
                MessageBox.Show("Harga jual harus lebih dari 0.");
                return;
            }

            if (hargaBaru == hargaLama)
            {
                MessageBox.Show("Harga baru sama dengan harga sekarang.");
                return;
            }

            string alasan = txtAlasan.Text.Trim();

            if (string.IsNullOrWhiteSpace(alasan))
            {
                MessageBox.Show("Masukkan alasan perubahan harga.");
                txtAlasan.Focus();
                return;
            }

            DialogResult konfirmasi = MessageBox.Show(
                "Yakin ingin mengubah harga jual?\n\n" +
                "Harga lama: Rp" + hargaLama.ToString("N0") + "\n" +
                "Harga baru: Rp" + hargaBaru.ToString("N0"),
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (konfirmasi != DialogResult.Yes)
                return;

            try
            {
                var semuaProduk = ProdukJsonStore.Load();

                var produkDiJson = semuaProduk.FirstOrDefault(
                    p => p.Kode == produkTerpilih.Kode
                );

                if (produkDiJson == null)
                {
                    MessageBox.Show("Barang tidak ditemukan.");
                    return;
                }

                var riwayatBaru = new RiwayatHargaJual
                {
                    KodeBarang = produkTerpilih.Kode,
                    NamaBarang = produkTerpilih.Nama,
                    HargaLama = hargaLama,
                    HargaBaru = hargaBaru,
                    WaktuPerubahan = DateTime.Now,
                    Admin = adminAktif,
                    Alasan = alasan
                };

                produkDiJson.Harga = hargaBaru;


                ProdukJsonStore.Save(semuaProduk);


                daftarRiwayat.Add(riwayatBaru);

                try
                {
                    RiwayatHargaJualJsonStore.Save(daftarRiwayat);
                }
                catch
                {

                    produkDiJson.Harga = hargaLama;
                    ProdukJsonStore.Save(semuaProduk);
                    daftarRiwayat.Remove(riwayatBaru);
                    throw;
                }

                produkTerpilih.Harga = hargaBaru;

                TampilkanDaftarProduk();
                TampilkanRiwayat();
                TampilkanLapisan();
                TampilkanRingkasan();

                txtJualSekarang.Text = hargaBaru.ToString("N0");
                txtAlasan.Clear();

                MessageBox.Show(
                    "Harga jual berhasil diperbarui.",
                    "Berhasil",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal mengubah harga:\n" + ex.Message,
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            bool adaPerubahan =
                !string.IsNullOrWhiteSpace(txtAlasan.Text) ||
                (produkTerpilih != null &&
                 nudJualBaru.Value != produkTerpilih.Harga);

            if (adaPerubahan)
            {
                DialogResult hasil = MessageBox.Show(
                    "Apakah Anda yakin ingin membatalkan perubahan harga?\n\n" +
                    "Alasan dan simulasi harga yang belum disimpan akan dikembalikan.",
                    "Konfirmasi Pembatalan",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (hasil != DialogResult.Yes)
                {
                    return;
                }
            }

            txtAlasan.Clear();

            if (produkTerpilih != null)
            {
                nudJualBaru.Value = Math.Min(
                    nudJualBaru.Maximum,
                    Math.Max(nudJualBaru.Minimum, produkTerpilih.Harga)
                );
            }

            TampilkanDampakPerubahanHarga();
        }

        private decimal HitungTotalModal()
        {
            return daftarLapisan
                .Where(l => l.SisaStok > 0)
                .Sum(l => l.SisaStok * l.HargaBeli);
        }

        private decimal HitungPotensiPenjualan()
        {
            decimal total = 0;

            foreach (var lapisan in daftarLapisan.Where(l => l.SisaStok > 0))
            {
                var produk = daftarProduk.FirstOrDefault(
                    p => p.Kode == lapisan.KodeBarang
                );

                if (produk == null)
                    continue;

                total += lapisan.SisaStok * produk.Harga;
            }

            return total;
        }

        private decimal HitungPotensiLaba()
        {
            return HitungPotensiPenjualan() - HitungTotalModal();
        }

        private int HitungBarangDiAtasModal()
        {
            int jumlah = 0;

            foreach (var produk in daftarProduk)
            {
                var lapisanProduk = daftarLapisan
                    .Where(l => l.KodeBarang == produk.Kode && l.SisaStok > 0)
                    .ToList();

                int totalStok = lapisanProduk.Sum(l => l.SisaStok);

                if (totalStok <= 0)
                    continue;

                decimal totalModal = lapisanProduk.Sum(
                    l => l.SisaStok * l.HargaBeli
                );

                decimal modalRataRata = totalModal / totalStok;

                if (produk.Harga > modalRataRata)
                    jumlah++;
            }

            return jumlah;
        }

        private decimal HitungMargin()
        {
            decimal penjualan = HitungPotensiPenjualan();

            if (penjualan <= 0)
                return 0;

            decimal laba = HitungPotensiLaba();

            return (laba / penjualan) * 100;
        }

        private void TampilkanRingkasan()
        {
            decimal totalModal = HitungTotalModal();
            decimal potensiLaba = HitungPotensiLaba();
            int barangDiAtasModal = HitungBarangDiAtasModal();
            decimal margin = HitungMargin();

            lblModal.Text = "Rp" + totalModal.ToString("N0");

            lblPotensi.Text = "Rp" + potensiLaba.ToString("N0");

            lblNaik.Text = barangDiAtasModal.ToString();

            lblMargin.Text = margin.ToString("N2") + "%";
        }

        private decimal HitungPotensiLabaBaru()
        {
            if (produkTerpilih == null)
                return HitungPotensiLaba();

            decimal totalModal = HitungTotalModal();
            decimal totalPenjualanBaru = 0;

            foreach (var lapisan in daftarLapisan.Where(l => l.SisaStok > 0))
            {
                var produk = daftarProduk.FirstOrDefault(
                    p => p.Kode == lapisan.KodeBarang
                );

                if (produk == null)
                    continue;

                decimal hargaJual = produk.Kode == produkTerpilih.Kode
                    ? nudJualBaru.Value
                    : produk.Harga;

                totalPenjualanBaru += lapisan.SisaStok * hargaJual;
            }

            return totalPenjualanBaru - totalModal;
        }

        private decimal HitungMarginBaru()
        {
            if (produkTerpilih == null)
                return HitungMargin();

            decimal totalPenjualanBaru = 0;

            foreach (var lapisan in daftarLapisan.Where(l => l.SisaStok > 0))
            {
                var produk = daftarProduk.FirstOrDefault(
                    p => p.Kode == lapisan.KodeBarang
                );

                if (produk == null)
                    continue;

                decimal hargaJual = produk.Kode == produkTerpilih.Kode
                    ? nudJualBaru.Value
                    : produk.Harga;

                totalPenjualanBaru += lapisan.SisaStok * hargaJual;
            }

            if (totalPenjualanBaru <= 0)
                return 0;

            decimal labaBaru = totalPenjualanBaru - HitungTotalModal();

            return labaBaru / totalPenjualanBaru * 100;
        }

        private void nudJualBaru_ValueChanged(object sender, EventArgs e)
        {
            TampilkanDampakPerubahanHarga();
        }

        private void TampilkanDampakPerubahanHarga()
        {
            if (produkTerpilih == null)
                return;

            decimal hargaBaru = nudJualBaru.Value;

            var lapisanProduk = daftarLapisan
                .Where(l => l.KodeBarang == produkTerpilih.Kode
                         && l.SisaStok > 0)
                .OrderBy(l => l.TanggalMasuk)
                .ToList();

            if (lapisanProduk.Count == 0)
            {
                lblDamapakLamaNilai.Text = "Tidak ada stok";
                lblDampakBaruNilai.Text = "Tidak ada stok";

                tooltipSimulasi.SetToolTip(
                    lblDamapakLamaNilai,
                    "Belum ada lapisan stok."
                );

                tooltipSimulasi.SetToolTip(
                    lblDampakBaruNilai,
                    "Belum ada lapisan stok."
                );

                return;
            }

           
            var stokLama = lapisanProduk.First();

            decimal labaStokLama = hargaBaru - stokLama.HargaBeli;

            lblDamapakLamaNilai.Text =
                "Rp " + labaStokLama.ToString("N0");

            
            var stokBaru = lapisanProduk.Last();

            decimal labaStokBaru = hargaBaru - stokBaru.HargaBeli;

            lblDampakBaruNilai.Text =
                "Rp " + labaStokBaru.ToString("N0");

         
            var rincian = lapisanProduk.Select((l, index) =>
            {
                decimal labaPerUnit = hargaBaru - l.HargaBeli;
                decimal totalLaba = labaPerUnit * l.SisaStok;

                return
                    $"Lapisan {index + 1}\n" +
                    $"Tanggal masuk: {l.TanggalMasuk:dd MMM yyyy}\n" +
                    $"Stok tersisa: {l.SisaStok}\n" +
                    $"Harga beli: Rp{l.HargaBeli:N0}\n" +
                    $"Harga jual baru: Rp{hargaBaru:N0}\n" +
                    $"Laba/unit: Rp{labaPerUnit:N0}\n" +
                    $"Potensi laba: Rp{totalLaba:N0}";
            });

            string detailSemuaLapisan = string.Join(
                "\n\n--------------------\n\n",
                rincian
            );

            tooltipSimulasi.SetToolTip(
                lblDamapakLamaNilai,
                detailSemuaLapisan
            );

            tooltipSimulasi.SetToolTip(
                lblDampakBaruNilai,
                detailSemuaLapisan
            );
        }


    }
}
