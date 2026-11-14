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
    public partial class ucDashboardAdmin : UserControl
    {
        private List<TransaksiSimpan> daftarTransaksi = new List<TransaksiSimpan>();
        private List<Produk> daftarProduk = new List<Produk>();
        private List<BarangMasuk> daftarMasuk = new List<BarangMasuk>();
        private List<BarangKeluarSimpan> daftarKeluar = new List<BarangKeluarSimpan>();
        private List<KoreksiStokSimpan> daftarKoreksi = new List<KoreksiStokSimpan>();
        public event EventHandler? LihatLaporanDiminta;
        private class AktivitasDashboard
        {
            public DateTime Waktu { get; set; }
            public string Teks { get; set; } = "";
        }
        public ucDashboardAdmin()
        {
            InitializeComponent();
            MuatDashboard();
            btnLihatLaporan.Click += (s, e) =>
            {
                LihatLaporanDiminta?.Invoke(this, EventArgs.Empty);
            };
        }



        private void TampilkanKartuDashboard()
        {
            DateTime hariIni = DateTime.Today;


            List<TransaksiSimpan> transaksiHariIni = daftarTransaksi
                .Where(x => x.Tanggal.Date == hariIni)
                .ToList();


            decimal pendapatanHariIni = transaksiHariIni
                .Sum(x => x.TotalPembayaran);


            int jumlahTransaksi = transaksiHariIni.Count;


            int menungguPersetujuan = UserStore.GetAll()
                .Count(x => x.Status == UserStore.Menunggu);


            int stokMenipis = daftarProduk
                .Count(x =>
                    !x.IsDeleted &&
                    x.Stok <= x.StokMinimum
                );


            lblJual.Text = "Rp " + pendapatanHariIni.ToString("N0");
            lblTrx.Text = jumlahTransaksi.ToString("N0");
            lblUser.Text = menungguPersetujuan.ToString("N0");
            lblStok.Text = stokMenipis.ToString("N0");
        }


        private void TampilkanTransaksiTerbaru()
        {
            dgvTransaksi.Rows.Clear();

            List<TransaksiSimpan> transaksiTerbaru = daftarTransaksi
                .OrderByDescending(x => x.Tanggal)
                .Take(5)
                .ToList();

            int nomor = 1;

            foreach (TransaksiSimpan item in transaksiTerbaru)
            {
                int jumlahItem = item.Barang?.Count ?? 0;

                dgvTransaksi.Rows.Add(
                    item.NomorTransaksi,
                    item.Tanggal.ToString("dd/MM/yyyy HH:mm"),
                    item.UsernameKasir,
                    jumlahItem,
                    "Rp " + item.TotalPembayaran.ToString("N0")
                );

                nomor++;
            }
        }



        private void TampilkanAktivitasGudang()
        {
            lstAktivitas.Items.Clear();

            List<AktivitasDashboard> aktivitas =
                new List<AktivitasDashboard>();


            foreach (BarangMasuk item in daftarMasuk)
            {
                aktivitas.Add(new AktivitasDashboard
                {
                    Waktu = item.Waktu,
                    Teks = $"{item.Waktu:HH:mm}   Masuk +{item.Jumlah} {item.NamaBarang}"
                });
            }


            foreach (BarangKeluarSimpan item in daftarKeluar)
            {
                string jenis = string.IsNullOrWhiteSpace(item.Jenis)
                    ? "Keluar Manual"
                    : item.Jenis;

                string teks;

                if (jenis == "Penjualan")
                {
                    teks = $"{item.Waktu:HH:mm}   Penjualan -{item.Jumlah} {item.NamaBarang}";
                }
                else
                {
                    teks = $"{item.Waktu:HH:mm}   Keluar -{item.Jumlah} {item.NamaBarang}";
                }

                aktivitas.Add(new AktivitasDashboard
                {
                    Waktu = item.Waktu,
                    Teks = teks
                });
            }


            foreach (KoreksiStokSimpan item in daftarKoreksi)
            {
                string jumlah = item.Jumlah > 0
                    ? "+" + item.Jumlah
                    : item.Jumlah.ToString();

                aktivitas.Add(new AktivitasDashboard
                {
                    Waktu = item.Waktu,
                    Teks = $"{item.Waktu:HH:mm}   Opname {item.NamaBarang} ({jumlah})"
                });
            }


            List<AktivitasDashboard> aktivitasTerbaru = aktivitas
                .OrderByDescending(x => x.Waktu)
                .Take(10)
                .ToList();

            foreach (AktivitasDashboard item in aktivitasTerbaru)
            {
                lstAktivitas.Items.Add(item.Teks);
            }

            if (lstAktivitas.Items.Count == 0)
            {
                lstAktivitas.Items.Add("Belum ada aktivitas gudang.");
            }
        }



        private void MuatDashboard()
        {
            try
            {
                daftarTransaksi = TransaksiJsonStore.Load();
                daftarProduk = ProdukJsonStore.Load();
                daftarMasuk = BarangMasukJsonStore.Load();
                daftarKeluar = BarangKeluarJsonStore.Load();
                daftarKoreksi = KoreksiStokJsonStore.Load();

                TampilkanKartuDashboard();
                TampilkanTransaksiTerbaru();
                TampilkanAktivitasGudang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat data Dashboard Admin.\n\n" + ex.Message,
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        public void RefreshDashboard()
        {
            MuatDashboard();
        }

        private void btnLihatLaporan_Click(object sender, EventArgs e)
        {

        }
    }
}
