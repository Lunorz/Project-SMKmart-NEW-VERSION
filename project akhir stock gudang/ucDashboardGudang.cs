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
    public partial class ucDashboardGudang : UserControl
    {
        private List<Produk> daftarProduk = new List<Produk>();

        private List<BarangMasuk> daftarBarangMasuk =
            new List<BarangMasuk>();

        private List<BarangKeluarSimpan> daftarBarangKeluar =
            new List<BarangKeluarSimpan>();


        public event EventHandler BukaBarangMasukDiminta;
        public event EventHandler BukaBarangKeluarDiminta;
        public event EventHandler BukaStokOpnameDiminta;
        public ucDashboardGudang()
        {
            InitializeComponent();


            this.Load -= ucDashboardGudang_Load;
            this.Load += ucDashboardGudang_Load;

            this.VisibleChanged -= ucDashboardGudang_VisibleChanged;
            this.VisibleChanged += ucDashboardGudang_VisibleChanged;

            btnMasukGudang4.Click -= btnMasukGudang4_Click;
            btnMasukGudang4.Click += btnMasukGudang4_Click;

            btnKeluarGudang4.Click -= btnKeluarGudang4_Click;
            btnKeluarGudang4.Click += btnKeluarGudang4_Click;

            btnOpnameGudang4.Click -= btnOpnameGudang4_Click;
            btnOpnameGudang4.Click += btnOpnameGudang4_Click;
        }

        public event Action<string>? Navigasi;

        void btnMasuk_Click(object sender, EventArgs e) => Navigasi?.Invoke("masuk");
        void btnKeluar_Click(object sender, EventArgs e) => Navigasi?.Invoke("keluar");
        void btnOpname_Click(object sender, EventArgs e) => Navigasi?.Invoke("stok");

        private void ucDashboardGudang_Load(object sender, EventArgs e)
        {
            MuatDashboard();
        }

        private void ucDashboardGudang_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                MuatDashboard();
            }
        }

        public void MuatDashboard()
        {
            try
            {
                daftarProduk = ProdukJsonStore.Load()
                    ?? new List<Produk>();

                daftarBarangMasuk = BarangMasukJsonStore.Load()
                    ?? new List<BarangMasuk>();

                daftarBarangKeluar = BarangKeluarJsonStore.Load()
                    ?? new List<BarangKeluarSimpan>();

                HitungRingkasanDashboard();

                TampilkanPeringatanStok();

                TampilkanAktivitasTerbaru();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat Dashboard Gudang:\n" + ex.Message,
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
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

        private void HitungRingkasanDashboard()
        {
            var produkAktif = daftarProduk
                .Where(p => !p.IsDeleted)
                .ToList();


            int totalJenis = produkAktif.Count;


            long totalStok = produkAktif.Sum(
                p => (long)p.Stok
            );


            int totalMenipis = produkAktif.Count(
                p => TentukanStatus(p) != "Aman"
            );

            DateTime hariIni = DateTime.Today;


            int totalMasuk = daftarBarangMasuk
                .Where(x => x.Waktu.Date == hariIni)
                .Sum(x => x.Jumlah);


            int totalKeluar = daftarBarangKeluar
                .Where(x => x.Waktu.Date == hariIni)
                .Sum(x => x.Jumlah);


            lblJenisGudang4.Text = totalJenis.ToString();

            lblStokGudang4.Text = totalStok.ToString("N0");

            lblMenipisGudang4.Text = totalMenipis.ToString();

            lblHarianGudang4.Text =
                "+" + totalMasuk + " / -" + totalKeluar;
        }

        private void TampilkanPeringatanStok()
        {
            dgvPeringatanGudang4.Rows.Clear();

            var produkPeringatan = daftarProduk
                .Where(p => !p.IsDeleted)
                .Where(p => TentukanStatus(p) != "Aman")
                .OrderBy(p => p.Stok)
                .ThenBy(p => p.Nama)
                .ToList();

            foreach (Produk produk in produkPeringatan)
            {
                string status = TentukanStatus(produk);

                long targetStok = (long)produk.StokMinimum * 2;

                long saranRestok = Math.Max(
                    0,
                    targetStok - produk.Stok
                );

                dgvPeringatanGudang4.Rows.Add(
                    produk.Nama,
                    produk.Stok,
                    produk.StokMinimum,
                    status,
                    "+" + saranRestok + " unit"
                );
            }
        }

        private void TampilkanAktivitasTerbaru()
        {
            lstAktivitasGudang4.Items.Clear();

            var aktivitas = new List<(DateTime Waktu, string Keterangan)>();


            foreach (BarangMasuk item in daftarBarangMasuk)
            {
                aktivitas.Add((
                    item.Waktu,
                    "Masuk +" + item.Jumlah + " " + item.NamaBarang
                ));
            }


            foreach (BarangKeluarSimpan item in daftarBarangKeluar)
            {
                string keterangan;

                if (item.Jenis == "Penjualan")
                {
                    keterangan =
                        "Penjualan -" + item.Jumlah + " " + item.NamaBarang;
                }
                else
                {
                    keterangan =
                        "Keluar -" + item.Jumlah + " " + item.NamaBarang;

                    if (!string.IsNullOrWhiteSpace(item.Alasan))
                    {
                        keterangan += " (" + item.Alasan + ")";
                    }
                }

                aktivitas.Add((
                    item.Waktu,
                    keterangan
                ));
            }

            var aktivitasTerbaru = aktivitas
                .OrderByDescending(x => x.Waktu)
                .Take(5)
                .ToList();

            foreach (var item in aktivitasTerbaru)
            {
                lstAktivitasGudang4.Items.Add(
                    item.Waktu.ToString("HH:mm") +
                    "    " +
                    item.Keterangan
                );
            }
        }

        private void btnMasukGudang4_Click(object sender, EventArgs e)
        {
            Navigasi?.Invoke("masuk");
        }

        private void btnKeluarGudang4_Click(object sender, EventArgs e)
        {
            Navigasi?.Invoke("keluar");
        }

        private void btnOpnameGudang4_Click(object sender, EventArgs e)
        {
            Navigasi?.Invoke("stok");
        }
    }
}
