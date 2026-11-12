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
            cmbBarangGudang2.SelectedIndex = -1;

            nudJumlahGudang2.Value = 0;

            txtAsalGudang2.Clear();

            txtSJGudang2.Clear();

            txtCatatanGudang2.Clear();

            cmbBarangGudang2.Focus();
        }

        private void btnSimpanGudang2_Click(object sender, EventArgs e)
        {

            if (cmbBarangGudang2.SelectedItem == null)
            {
                MessageBox.Show(
                    "Silakan pilih barang terlebih dahulu."
                );
                cmbBarangGudang2.Focus();
                return;
            }


            Produk produkDipilih =
                cmbBarangGudang2.SelectedItem as Produk;

            if (produkDipilih == null)
            {
                MessageBox.Show("Data produk tidak valid.");
                return;
            }

            int jumlah = (int)nudJumlahGudang2.Value;

            if (jumlah <= 0)
            {
                MessageBox.Show(
                    "Jumlah barang masuk harus lebih dari 0."
                );
                nudJumlahGudang2.Focus();
                return;
            }


            string asal = txtAsalGudang2.Text.Trim();

            if (string.IsNullOrWhiteSpace(asal))
            {
                MessageBox.Show(
                    "Asal barang harus diisi."
                );
                txtAsalGudang2.Focus();
                return;
            }


            string nomorSurat = txtSJGudang2.Text.Trim();

            if (string.IsNullOrWhiteSpace(nomorSurat))
            {
                MessageBox.Show(
                    "Nomor surat jalan harus diisi."
                );
                txtSJGudang2.Focus();
                return;
            }

            try
            {

                List<Produk> produkTerbaru =
                    ProdukJsonStore.Load();

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


                BarangMasuk dataBaru = new BarangMasuk
                {
                    Waktu = DateTime.Now,
                    KodeBarang = produk.Kode,
                    NamaBarang = produk.Nama,
                    Jumlah = jumlah,
                    AsalBarang = asal,
                    NomorSuratJalan = nomorSurat,
                    Catatan = txtCatatanGudang2.Text.Trim(),
                    Petugas = usernamePetugas
                };


                produk.Stok += jumlah;


                ProdukJsonStore.Save(produkTerbaru);


                riwayatBarangMasuk =
                    BarangMasukJsonStore.Load();

                riwayatBarangMasuk.Add(dataBaru);

                BarangMasukJsonStore.Save(
                    riwayatBarangMasuk
                );


                MuatProduk();

                TampilkanRiwayatBarangMasuk();

                BersihkanFormBarangMasuk();

                MessageBox.Show(
                    "Barang masuk berhasil disimpan.\n" +
                    "Stok " + produk.Nama +
                    " bertambah sebanyak " + jumlah + " unit.",
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
    }
}
    

