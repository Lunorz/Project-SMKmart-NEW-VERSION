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
    public partial class ucLaporanGudang : UserControl
    {
        private List<Produk> daftarProduk = new List<Produk>();
        private List<BarangMasuk> daftarMasuk = new List<BarangMasuk>();
        private List<BarangKeluarSimpan> daftarKeluar = new List<BarangKeluarSimpan>();
        private List<KoreksiStokSimpan> daftarKoreksi = new List<KoreksiStokSimpan>();
        private class AktivitasGudang
        {
            public DateTime Waktu { get; set; }
            public string Kode { get; set; } = "";
            public string Barang { get; set; } = "";
            public string Jenis { get; set; } = "";
            public int Jumlah { get; set; }
            public string Keterangan { get; set; } = "";
            public string Petugas { get; set; } = "";
            public int SisaStok { get; set; }
        }
        public ucLaporanGudang()
        {
            InitializeComponent();

            dtpDari.Value = DateTime.Today;
            dtpSampai.Value = DateTime.Today;

            dtpDari.ValueChanged += Filter_ValueChanged;
            dtpSampai.ValueChanged += Filter_ValueChanged;
            cmbJenis.SelectedIndexChanged += Filter_ValueChanged;
            cmbBarang.SelectedIndexChanged += Filter_ValueChanged;
            cmbPetugas.SelectedIndexChanged += Filter_ValueChanged;

            MuatData();
        }

        private void Filter_ValueChanged(object sender, EventArgs e)
        {
            TampilkanLaporan();
        }

        private bool CocokBarang(string kode)
        {
            string pilihan = cmbBarang.SelectedItem?.ToString() ?? "Semua";

            if (pilihan == "Semua")
                return true;

            return pilihan.StartsWith(
                kode + " - ",
                StringComparison.OrdinalIgnoreCase
            );
        }

        private void MuatData()
        {
            try
            {
                daftarProduk = ProdukJsonStore.Load();
                daftarMasuk = BarangMasukJsonStore.Load();
                daftarKeluar = BarangKeluarJsonStore.Load();
                daftarKoreksi = KoreksiStokJsonStore.Load();

                IsiFilterBarang();
                IsiFilterPetugas();

                TampilkanLaporan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat laporan gudang.\n\n" + ex.Message,
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void IsiFilterBarang()
        {
            string barangTerpilih =
                cmbBarang.SelectedItem?.ToString() ?? "Semua";

            cmbBarang.Items.Clear();
            cmbBarang.Items.Add("Semua");

            foreach (Produk p in daftarProduk.Where(x => !x.IsDeleted))
            {
                cmbBarang.Items.Add(p.Kode + " - " + p.Nama);
            }

            int index = cmbBarang.Items.IndexOf(barangTerpilih);

            cmbBarang.SelectedIndex = index >= 0 ? index : 0;
        }



        private void IsiFilterPetugas()
        {
            string petugasTerpilih =
                cmbPetugas.SelectedItem?.ToString() ?? "Semua";

            var semuaPetugas = daftarMasuk
                .Select(x => x.Petugas)
                .Concat(daftarKeluar.Select(x => x.Petugas))
                .Concat(daftarKoreksi.Select(x => x.Petugas))
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            cmbPetugas.Items.Clear();
            cmbPetugas.Items.Add("Semua");

            foreach (string petugas in semuaPetugas)
            {
                cmbPetugas.Items.Add(petugas);
            }

            int index = cmbPetugas.Items.IndexOf(petugasTerpilih);

            cmbPetugas.SelectedIndex = index >= 0 ? index : 0;
        }



        private List<AktivitasGudang> AmbilSemuaAktivitas()
        {
            List<AktivitasGudang> hasil = new List<AktivitasGudang>();

            
            foreach (BarangMasuk item in daftarMasuk)
            {
                hasil.Add(new AktivitasGudang
                {
                    Waktu = item.Waktu,
                    Kode = item.KodeBarang,
                    Barang = item.NamaBarang,
                    Jenis = "Barang Masuk",
                    Jumlah = item.Jumlah,
                    Keterangan = GabungkanKeterangan(
                        item.AsalBarang,
                        item.NomorSuratJalan,
                        item.Catatan
                    ),
                    Petugas = item.Petugas
                });
            }

            
            foreach (BarangKeluarSimpan item in daftarKeluar)
            {
                hasil.Add(new AktivitasGudang
                {
                    Waktu = item.Waktu,
                    Kode = item.KodeBarang,
                    Barang = item.NamaBarang,
                    Jenis = string.IsNullOrWhiteSpace(item.Jenis)
                        ? "Keluar Manual"
                        : item.Jenis,
                    Jumlah = item.Jumlah,
                    Keterangan = GabungkanKeterangan(
                        item.Alasan,
                        item.Catatan
                    ),
                    Petugas = item.Petugas
                });
            }

            
            foreach (KoreksiStokSimpan item in daftarKoreksi)
            {
                hasil.Add(new AktivitasGudang
                {
                    Waktu = item.Waktu,
                    Kode = item.KodeBarang,
                    Barang = item.NamaBarang,
                    Jenis = "Koreksi Opname",
                    Jumlah = item.Jumlah,
                    Keterangan = item.Keterangan,
                    Petugas = item.Petugas
                });
            }

            return hasil;
        }

        private string GabungkanKeterangan(params string[] bagian)
        {
            return string.Join(
                " | ",
                bagian.Where(x => !string.IsNullOrWhiteSpace(x))
            );
        }

        private List<AktivitasGudang> AmbilAktivitasTerfilter()
        {
            DateTime dari = dtpDari.Value.Date;
            DateTime sampai = dtpSampai.Value.Date.AddDays(1);

            string jenis = cmbJenis.SelectedItem?.ToString() ?? "Semua";
            string petugas = cmbPetugas.SelectedItem?.ToString() ?? "Semua";

            return AmbilSemuaAktivitas()
                .Where(x => x.Waktu >= dari && x.Waktu < sampai)
                .Where(x => CocokBarang(x.Kode))
                .Where(x => jenis == "Semua" || x.Jenis == jenis)
                .Where(x => petugas == "Semua" || x.Petugas == petugas)
                .OrderByDescending(x => x.Waktu)
                .ToList();
        }





        private void TampilkanKartuRingkasan()
        {
            List<AktivitasGudang> aktivitas = AmbilAktivitasTerfilter();

            int totalMasuk = aktivitas
                .Where(x => x.Jenis == "Barang Masuk")
                .Sum(x => x.Jumlah);

            int totalKeluar = aktivitas
                .Where(x => x.Jenis == "Penjualan" ||
                            x.Jenis == "Keluar Manual")
                .Sum(x => x.Jumlah);

            int totalOpname = aktivitas
                .Where(x => x.Jenis == "Koreksi Opname")
                .Sum(x => Math.Abs(x.Jumlah));

            IEnumerable<Produk> produkRestok = daftarProduk
                .Where(x => !x.IsDeleted && x.Stok <= x.StokMinimum);

            if (cmbBarang.SelectedItem?.ToString() != "Semua")
            {
                produkRestok = produkRestok.Where(
                    x => CocokBarang(x.Kode)
                );
            }

            int jumlahRestok = produkRestok.Count();

            lblMasuk.Text = totalMasuk.ToString("N0");
            lblKeluar.Text = totalKeluar.ToString("N0");
            lblOpname.Text = totalOpname.ToString("N0");
            lblRestok.Text = jumlahRestok.ToString("N0");
        }



        private void TampilkanMutasiStok()
        {
            dgvMutasi.Rows.Clear();

            DateTime dari = dtpDari.Value.Date;
            DateTime sampai = dtpSampai.Value.Date.AddDays(1);

            List<AktivitasGudang> semuaAktivitas = AmbilSemuaAktivitas()
                .Where(x => x.Waktu >= dari && x.Waktu < sampai)
                .ToList();

            foreach (Produk produk in daftarProduk.Where(x => !x.IsDeleted))
            {
                if (!CocokBarang(produk.Kode))
                    continue;

                var aktivitasBarang = semuaAktivitas
                    .Where(x => x.Kode == produk.Kode)
                    .ToList();

                int masuk = aktivitasBarang
                    .Where(x => x.Jenis == "Barang Masuk")
                    .Sum(x => x.Jumlah);

                int keluar = aktivitasBarang
                    .Where(x => x.Jenis == "Penjualan" ||
                                x.Jenis == "Keluar Manual")
                    .Sum(x => x.Jumlah);

                int koreksi = aktivitasBarang
                    .Where(x => x.Jenis == "Koreksi Opname")
                    .Sum(x => x.Jumlah);

                int stokAwal = produk.Stok - masuk + keluar - koreksi;

                int stokAkhir = stokAwal + masuk - keluar + koreksi;

                dgvMutasi.Rows.Add(
                    produk.Kode,
                    produk.Nama,
                    stokAwal,
                    masuk,
                    keluar,
                    koreksi,
                    stokAkhir
                );
            }
        }


        private void TampilkanRingkasanBarang()
        {
            dgvRingkasan.Rows.Clear();

            List<AktivitasGudang> aktivitas = AmbilAktivitasTerfilter();

            foreach (AktivitasGudang item in aktivitas)
            {
                Produk produk = daftarProduk.FirstOrDefault(
                    x => x.Kode == item.Kode
                );

                int sisaStok = produk?.Stok ?? 0;

                dgvRingkasan.Rows.Add(
                    item.Waktu.ToString("dd/MM/yyyy HH:mm:ss"),
                    item.Barang,
                    item.Jenis,
                    item.Jumlah,
                    item.Keterangan,
                    item.Petugas,
                    sisaStok
                );
            }
        }


        private void TampilkanLaporan()
        {
            TampilkanKartuRingkasan();
            TampilkanMutasiStok();
            TampilkanRingkasanBarang();
        }

        public void RefreshLaporan()
        {
            MuatData();
        }


    }
}
