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
    
    public partial class ucBarangKeluar : UserControl
    {
        private List<Produk> daftarProduk = new List<Produk>();

        private List<BarangKeluarSimpan> daftarBarangKeluar =
            new List<BarangKeluarSimpan>();

        private string usernamePetugas = "";
        public ucBarangKeluar(string username)
        {
            InitializeComponent();
            usernamePetugas = username;

            AturComboBox();
            AturDataGridView();
            MuatBarangDariAdmin();
            MuatRiwayatBarangKeluar();
            txtCariGudang3.TextChanged -= txtCariGudang3_TextChanged;
            txtCariGudang3.TextChanged += txtCariGudang3_TextChanged;

            cmbJenisGudang3.SelectedIndexChanged -= cmbJenisGudang3_SelectedIndexChanged;
            cmbJenisGudang3.SelectedIndexChanged += cmbJenisGudang3_SelectedIndexChanged;

            btnSimpanGudang3.Click -= btnSimpanGudang3_Click;
            btnSimpanGudang3.Click += btnSimpanGudang3_Click;

            btnBersihkanGudang3.Click -= btnBersihkanGudang3_Click;
            btnBersihkanGudang3.Click += btnBersihkanGudang3_Click;
        }

        private void AturComboBox()
        {

            cmbJenisGudang3.Items.Clear();

            cmbJenisGudang3.Items.Add("Semua");
            cmbJenisGudang3.Items.Add("Penjualan");
            cmbJenisGudang3.Items.Add("Keluar Manual");

            cmbJenisGudang3.SelectedIndex = 0;


            cmbAlasanGudang3.Items.Clear();

            cmbAlasanGudang3.Items.Add("Barang rusak");
            cmbAlasanGudang3.Items.Add("Kedaluwarsa");
            cmbAlasanGudang3.Items.Add("Dikembalikan ke pemasok");
            cmbAlasanGudang3.Items.Add("Kehilangan");
            cmbAlasanGudang3.Items.Add("Lainnya");

            cmbAlasanGudang3.SelectedIndex = -1;
        }

        private void MuatBarangDariAdmin()
        {
            daftarProduk = ProdukJsonStore.Load()
                .Where(p => !p.IsDeleted)
                .ToList();

            cmbBarangGudang3.DataSource = null;

            cmbBarangGudang3.DataSource = daftarProduk;
            cmbBarangGudang3.DisplayMember = "Nama";
            cmbBarangGudang3.ValueMember = "Kode";

            cmbBarangGudang3.SelectedIndex = -1;
        }

        private void AturDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;

            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.MultiSelect = false;
        }

        private void MuatRiwayatBarangKeluar()
        {
            daftarBarangKeluar = BarangKeluarJsonStore.Load();

            TampilkanRiwayatBarangKeluar();
        }

        private void TampilkanRiwayatBarangKeluar()
        {
            dataGridView1.Rows.Clear();

            string kataKunci = txtCariGudang3.Text.Trim().ToLower();

            string jenis = cmbJenisGudang3.Text;

            var hasil = daftarBarangKeluar
                .Where(x =>
                    jenis == "Semua" ||
                    x.Jenis == jenis
                )
                .Where(x =>
                    string.IsNullOrWhiteSpace(kataKunci) ||
                    x.NamaBarang.ToLower().Contains(kataKunci) ||
                    x.Alasan.ToLower().Contains(kataKunci)
                )
                .OrderByDescending(x => x.Waktu)
                .ToList();

            foreach (var item in hasil)
            {
                dataGridView1.Rows.Add(
                    item.Waktu.ToString("dd/MM/yyyy HH:mm"),
                    item.NamaBarang,
                    item.Jumlah,
                    item.Alasan,
                    item.Petugas
                );
            }
        }



        private void cmbBarangGudang3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCariGudang3_TextChanged(object sender, EventArgs e)
        {
            TampilkanRiwayatBarangKeluar();
        }

        private void cmbJenisGudang3_SelectedIndexChanged(object sender, EventArgs e)
        {
            TampilkanRiwayatBarangKeluar();
        }

        private void btnSimpanGudang3_Click(object sender, EventArgs e)
        {
            try
            {
                Produk barangDipilih =
                    cmbBarangGudang3.SelectedItem as Produk;

                if (barangDipilih == null)
                {
                    MessageBox.Show("Pilih barang terlebih dahulu.");
                    return;
                }

                int jumlah = (int)nudJumlahGudang3.Value;

                if (jumlah <= 0)
                {
                    MessageBox.Show("Jumlah keluar harus lebih dari 0.");
                    return;
                }

                if (cmbAlasanGudang3.SelectedIndex == -1)
                {
                    MessageBox.Show("Pilih alasan barang keluar.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(usernamePetugas))
                {
                    MessageBox.Show(
                        "Username petugas belum tersedia. " +
                        "Pastikan halaman dibuka dengan username petugas."
                    );
                    return;
                }


                List<Produk> produkTerbaru = ProdukJsonStore.Load();

                Produk produk = produkTerbaru.FirstOrDefault(
                    p => p.Kode == barangDipilih.Kode
                );

                if (produk == null || produk.IsDeleted)
                {
                    MessageBox.Show("Barang tidak ditemukan atau sudah tidak aktif.");
                    return;
                }

                if (jumlah > produk.Stok)
                {
                    MessageBox.Show(
                        "Stok tidak mencukupi.\n" +
                        "Stok tersedia: " + produk.Stok
                    );
                    return;
                }


             
                int stokSebelum = produk.Stok;

              
                produk.Stok -= jumlah;

             
                ProdukJsonStore.Save(produkTerbaru);


                BarangKeluarSimpan dataBaru =
                    new BarangKeluarSimpan
                    {
                        Waktu = DateTime.Now,
                        KodeBarang = produk.Kode,
                        NamaBarang = produk.Nama,
                        Jumlah = jumlah,
                        Jenis = "Keluar Manual",
                        Alasan = cmbAlasanGudang3.Text,
                        Petugas = usernamePetugas,
                        Catatan = txtCatatanGudang3.Text.Trim()
                    };

                BarangKeluarJsonStore.Tambah(dataBaru);
              
                try
                {
                    LogAktivitasJsonStore.Catat(
                        usernamePetugas,
                        "Pengelola Gudang",
                        "Barang Keluar",
                        "Pengeluaran barang manual",
                        produk.Kode + " - " + produk.Nama,
                        "Petugas mengeluarkan barang sebanyak " +
                        jumlah + " unit. " +
                        "Alasan: " + cmbAlasanGudang3.Text +
                        ". Stok sebelumnya: " + stokSebelum +
                        ". Stok sekarang: " + produk.Stok +
                        ". Catatan: " + txtCatatanGudang3.Text.Trim()
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Barang keluar berhasil disimpan, tetapi log aktivitas gagal dicatat:\n" +
                        ex.Message,
                        "Peringatan Log",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }


                MuatBarangDariAdmin();
                MuatRiwayatBarangKeluar();
                BersihkanForm();

                MessageBox.Show(
                    "Barang keluar berhasil disimpan dan stok telah diperbarui.",
                    "Berhasil",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menyimpan barang keluar: " + ex.Message,
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnBersihkanGudang3_Click(object sender, EventArgs e)
        {
            BersihkanForm();
        }

        private void BersihkanForm()
        {
            cmbBarangGudang3.SelectedIndex = -1;
            cmbAlasanGudang3.SelectedIndex = -1;

            nudJumlahGudang3.Value = 0;

            txtCatatanGudang3.Clear();
        }

        private void ucBarangKeluar_Load(object sender, EventArgs e)
        {
           
        }
    }
}
