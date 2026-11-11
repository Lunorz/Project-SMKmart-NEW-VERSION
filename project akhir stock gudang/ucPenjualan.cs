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
    public partial class ucPenjualan : UserControl
    {

        private List<TransaksiSimpan> semuaTransaksi =
            new List<TransaksiSimpan>();


        private List<TransaksiSimpan> transaksiTampil =
            new List<TransaksiSimpan>();

        private readonly CultureInfo budaya =
            new CultureInfo("id-ID");
        public ucPenjualan()
        {
            InitializeComponent();
            cmbKasir2.SelectedIndexChanged +=
               cmbKasir2_SelectedIndexChanged;

            dtpDari2.ValueChanged +=
                dtpDari2_ValueChanged;

            dtpSampai2.ValueChanged +=
                dtpSampai2_ValueChanged;


            txtCari2.TextChanged +=
                txtCari2_TextChanged;


            dgvTransaksi2.SelectionChanged +=
                dgvTransaksi2_SelectionChanged;


            tabUtama2.SelectedIndexChanged +=
                tabUtama2_SelectedIndexChanged;


            this.Load += ucPenjualan_Load;

        }
        private void MuatDataTransaksi()
        {
            try
            {
                semuaTransaksi = TransaksiJsonStore.Load();

                IsiComboBoxKasir();

                TampilkanLaporan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat data transaksi:\n" + ex.Message,
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void IsiComboBoxKasir()
        {
            cmbKasir2.Items.Clear();

            cmbKasir2.Items.Add("Semua Kasir");

            List<string> daftarKasir = semuaTransaksi
                .Where(t =>
                    !string.IsNullOrWhiteSpace(t.UsernameKasir))
                .Select(t => t.UsernameKasir)
                .Distinct()
                .OrderBy(n => n)
                .ToList();

            foreach (string kasir in daftarKasir)
            {
                cmbKasir2.Items.Add(kasir);
            }

            cmbKasir2.SelectedIndex = 0;
        }

        private void TampilkanLaporan()
        {
            if (dtpDari2.Value.Date > dtpSampai2.Value.Date)
            {
                transaksiTampil.Clear();

                dgvTransaksi2.Rows.Clear();
                dgvTerlaris2.Rows.Clear();
                dgvDetail2.Rows.Clear();

                PerbaruiRingkasan(transaksiTampil);

                lblTotalDetail2.Text = "Rp0";

                return;
            }

            DateTime tanggalAwal = dtpDari2.Value.Date;

            DateTime tanggalAkhir =
                dtpSampai2.Value.Date.AddDays(1);

            string kasir =
                cmbKasir2.SelectedItem?.ToString() ?? "Semua Kasir";

            string pencarian = txtCari2.Text.Trim();

            transaksiTampil = semuaTransaksi
                .Where(t =>
                    t.Tanggal >= tanggalAwal &&
                    t.Tanggal < tanggalAkhir
                )
                .Where(t =>
                    kasir == "Semua Kasir" ||
                    t.UsernameKasir == kasir
                )
                .Where(t =>
                    string.IsNullOrWhiteSpace(pencarian) ||
                    (t.NomorTransaksi ?? "").Contains(
                        pencarian,
                        StringComparison.OrdinalIgnoreCase
                    )
                )
                .OrderByDescending(t => t.Tanggal)
                .ToList();

            PerbaruiRingkasan(transaksiTampil);

            TampilkanTabelTransaksi();

            TampilkanBarangTerlaris();

            dgvDetail2.Rows.Clear();

            lblTotalDetail2.Text = "Rp0";
        }
        private void PerbaruiRingkasan(
    List<TransaksiSimpan> data)
        {

            decimal totalPenjualan =
                data.Sum(t => t.TotalPembayaran);


            int jumlahTransaksi = data.Count;


            int jumlahBarang = data
                .Where(t => t.Barang != null)
                .SelectMany(t => t.Barang)
                .Sum(b => b.Jumlah);


            decimal rataRata = jumlahTransaksi > 0
                ? totalPenjualan / jumlahTransaksi
                : 0;

            lblTotal2.Text =
                "Rp" + totalPenjualan.ToString("N0", budaya);

            lblJumlahTrx2.Text =
                jumlahTransaksi.ToString("N0", budaya);

            lblItem2.Text =
                jumlahBarang.ToString("N0", budaya);

            lblRata2.Text =
                "Rp" + rataRata.ToString("N0", budaya);
        }

        private void TampilkanTabelTransaksi()
        {
            dgvTransaksi2.Rows.Clear();

            foreach (TransaksiSimpan transaksi in transaksiTampil)
            {
                int jumlahItem = (transaksi.Barang ??
                    new List<DetailTransaksiSimpan>())
                    .Sum(b => b.Jumlah);

                dgvTransaksi2.Rows.Add(
                    transaksi.NomorTransaksi,
                    transaksi.Tanggal.ToString("dd/MM/yyyy HH:mm"),
                    string.IsNullOrWhiteSpace(transaksi.UsernameKasir)
                        ? "Tidak diketahui"
                        : transaksi.UsernameKasir,
                    jumlahItem,
                    transaksi.TotalPembayaran
                );
            }

            if (dgvTransaksi2.Rows.Count > 0)
            {
                dgvTransaksi2.ClearSelection();

                dgvTransaksi2.Rows[0].Selected = true;

                TampilkanDetailTransaksi(transaksiTampil[0]);
            }
        }
        private void TampilkanDetailTransaksi(
    TransaksiSimpan transaksi)
        {
            dgvDetail2.Rows.Clear();

            decimal total = 0;

            if (transaksi.Barang != null)
            {
                foreach (DetailTransaksiSimpan barang
                    in transaksi.Barang)
                {
                    decimal subtotal =
                        barang.Harga * barang.Jumlah;

                    dgvDetail2.Rows.Add(
                        barang.Nama,
                        barang.Jumlah,
                        subtotal
                    );

                    total += subtotal;
                }
            }

            lblTotalDetail2.Text =
                "Rp" + total.ToString("N0", budaya);
        }
        private void TampilkanBarangTerlaris()
        {
            dgvTerlaris2.Rows.Clear();

            var barangTerlaris = transaksiTampil
                .Where(t => t.Barang != null)
                .SelectMany(t => t.Barang)
                .GroupBy(b => new
                {
                    b.Kode,
                    b.Nama
                })
                .Select(g => new
                {
                    Kode = g.Key.Kode,
                    Nama = g.Key.Nama,
                    Jumlah = g.Sum(b => b.Jumlah),
                    Omzet = g.Sum(b => b.Harga * b.Jumlah)
                })
                .OrderByDescending(b => b.Jumlah)
                .ToList();

            int peringkat = 1;

            foreach (var barang in barangTerlaris)
            {
                dgvTerlaris2.Rows.Add(
                    peringkat,
                    barang.Nama,
                    "-",
                    barang.Jumlah,
                    barang.Omzet
                );

                peringkat++;
            }
        }

        private void pnlTotal2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCari2_TextChanged(object sender, EventArgs e)
        {
            TampilkanLaporan();
        }

        private void cmbKasir2_SelectedIndexChanged(object sender, EventArgs e)
        {
            TampilkanLaporan();
        }

        private void dtpDari2_ValueChanged(object sender, EventArgs e)
        {
            TampilkanLaporan();
        }

        private void dtpSampai2_ValueChanged(object sender, EventArgs e)
        {
            TampilkanLaporan();
        }

        private void dgvTransaksi2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTransaksi2_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTransaksi2.CurrentRow == null)
                return;

            int index = dgvTransaksi2.CurrentRow.Index;

            if (index < 0 || index >= transaksiTampil.Count)
                return;

            TampilkanDetailTransaksi(transaksiTampil[index]);
        }

        private void tabUtama2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabUtama2.SelectedTab == tabTerlaris2)
            {
                TampilkanBarangTerlaris();
            }
        }

        private void ucPenjualan_Load(object sender, EventArgs e)
        {
            MuatDataTransaksi();
        }
    }
}
