using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static project_akhir_stock_gudang.ProdukJsonStore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace project_akhir_stock_gudang
{
    public partial class Dashboard_kasir3 : Form
    {

        private readonly string usernameKasir;
        public Dashboard_kasir3(List<DetailTransaksi> dataKeranjang, string username)
        {
            InitializeComponent();
            UiTheme.ApplyCashierPanelDecoration(panel5);
            UiTheme.ApplyCashierPanelDecoration(panel6);
            FormBorderStyle = FormBorderStyle.Sizable;
            keranjang = dataKeranjang ?? new List<DetailTransaksi>();
            usernameKasir = username ?? "";
            txtUangDiterima.TextChanged +=
           txtUangDiterima_TextChanged;
            SiapkanTabel();
            AturTampilanPembayaran();
            TampilkanBarang();
            AturTampilanTotalPembayaran();
            AturInformasiTransaksi();
            AturFontForm(this);
            UiTheme.DecorateCashierButton(btnBatal, false);
            UiTheme.DecorateCashierButton(btnSelesaikan);
            UiTheme.DecorateCashierGrid(dgvCheckout);

            foreach (DataGridViewColumn kolom in dgvCheckout.Columns)
            {
                kolom.ReadOnly = true;
            }

            panel5.Resize += (_, _) => AturLayoutCheckout();
            panel6.Resize += (_, _) => AturLayoutCheckout();
            AturLayoutCheckout();
        }

        private void AturLayoutCheckout()
        {
            int lebar = Math.Max(240, panel5.ClientSize.Width - 26);
            int tinggiTabel = Math.Max(100, panel5.ClientSize.Height - 82);

            dgvCheckout.Location = new Point(13, 43);
            dgvCheckout.Size = new Size(lebar, tinggiTabel);

            lblTotalPembayaran.AutoSize = true;
            lblTotalPembayaran.Location = new Point(
                Math.Max(12, panel5.ClientSize.Width - lblTotalPembayaran.PreferredWidth - 18),
                panel5.ClientSize.Height - lblTotalPembayaran.PreferredHeight - 12);

            lblUangDiterima.Location = new Point(12, 18);
            txtUangDiterima.Location = new Point(12, 43);
            txtUangDiterima.Size = new Size(Math.Max(180, panel6.ClientSize.Width - 24), 39);
            lblKembalian.Size = new Size(
                Math.Max(180, panel6.ClientSize.Width - 24),
                32);
            lblKembalian.Location = new Point(12, 91);

            btnBatal.Location = new Point(
                Math.Max(12, panel6.ClientSize.Width - 282),
                Math.Max(130, panel6.ClientSize.Height - 70));
            btnSelesaikan.Location = new Point(
                Math.Max(150, panel6.ClientSize.Width - 144),
                Math.Max(130, panel6.ClientSize.Height - 70));
        }
        private DateTime tanggalTransaksi;
        private string nomorTransaksi = "";
        private readonly List<DetailTransaksi> keranjang;
        private bool transaksiSelesai;
        private void AturFontForm(Control parent)
        {
            foreach (Control kontrol in parent.Controls)
            {
                kontrol.Font = new Font(
                    "Leelawadee UI",
                    kontrol.Font.Size,
                    kontrol.Font.Style
                );

                if (kontrol.HasChildren)
                {
                    AturFontForm(kontrol);
                }
            }
        }
        private void AturTampilanDgvCheckout()
        {
            dgvCheckout.SuspendLayout();

            dgvCheckout.BackgroundColor = Color.White;
            dgvCheckout.BorderStyle = BorderStyle.None;
            dgvCheckout.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCheckout.GridColor = Color.FromArgb(225, 238, 229);

            dgvCheckout.EnableHeadersVisualStyles = false;

            dgvCheckout.ColumnHeadersDefaultCellStyle.BackColor =
                Color.SeaGreen;
            dgvCheckout.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;
            dgvCheckout.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvCheckout.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            dgvCheckout.ColumnHeadersDefaultCellStyle.Padding =
                new Padding(10, 0, 5, 0);

            dgvCheckout.ColumnHeadersHeight = 45;
            dgvCheckout.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgvCheckout.DefaultCellStyle.BackColor = Color.White;
            dgvCheckout.DefaultCellStyle.ForeColor =
                Color.FromArgb(40, 60, 48);
            dgvCheckout.DefaultCellStyle.Font =
                new Font("Segoe UI", 10F, FontStyle.Regular);
            dgvCheckout.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(204, 232, 214);
            dgvCheckout.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(30, 75, 48);
            dgvCheckout.DefaultCellStyle.Padding =
                new Padding(10, 4, 5, 4);

            dgvCheckout.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(240, 248, 242);

            dgvCheckout.RowTemplate.Height = 40;
            dgvCheckout.AllowUserToResizeRows = false;
            dgvCheckout.RowHeadersVisible = false;
            dgvCheckout.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvCheckout.MultiSelect = false;
            dgvCheckout.ReadOnly = true;
            dgvCheckout.AllowUserToAddRows = false;
            dgvCheckout.AllowUserToDeleteRows = false;
            dgvCheckout.AutoGenerateColumns = false;
            dgvCheckout.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvCheckout.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.None;

            dgvCheckout.DefaultCellStyle.WrapMode =
                DataGridViewTriState.False;

            dgvCheckout.ShowCellToolTips = true;

            dgvCheckout.ResumeLayout();
        }

        private void AturTampilanPembayaran()
        {




            lblUangDiterima.ForeColor = Color.FromArgb(50, 75, 60);
            lblUangDiterima.Font = new Font(
                "Segoe UI", 10F, FontStyle.Bold);

            txtUangDiterima.BackColor = Color.White;
            txtUangDiterima.ForeColor = Color.FromArgb(40, 65, 48);
            txtUangDiterima.BorderStyle = BorderStyle.FixedSingle;
            txtUangDiterima.Font = new Font(
                "Segoe UI", 11F, FontStyle.Regular);

            lblKembalian.ForeColor = Color.SeaGreen;
            lblKembalian.Font = new Font(
                "Segoe UI", 12F, FontStyle.Bold);

            btnSelesaikan.BackColor = Color.SeaGreen;
            btnSelesaikan.ForeColor = Color.White;
            btnSelesaikan.FlatStyle = FlatStyle.Flat;
            btnSelesaikan.FlatAppearance.BorderSize = 0;
            btnSelesaikan.Font = new Font(
                "Segoe UI", 10F, FontStyle.Bold);
            btnSelesaikan.Cursor = Cursors.Hand;

            btnBatal.BackColor = Color.White;
            btnBatal.ForeColor = Color.SeaGreen;
            btnBatal.FlatStyle = FlatStyle.Flat;
            btnBatal.FlatAppearance.BorderColor = Color.SeaGreen;
            btnBatal.Font = new Font(
                "Segoe UI", 10F, FontStyle.Bold);
            btnBatal.Cursor = Cursors.Hand;
        }

        private void SiapkanTabel()
        {
            dgvCheckout.Columns.Clear();
            dgvCheckout.AutoGenerateColumns = false;
            dgvCheckout.AllowUserToAddRows = false;
            dgvCheckout.AllowUserToDeleteRows = false;
            dgvCheckout.ReadOnly = true;
            dgvCheckout.RowHeadersVisible = false;
            dgvCheckout.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvCheckout.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Kode",
                HeaderText = "Kode",
                DataPropertyName = "Kode",
                Visible = true,
                FillWeight = 80
            });

            dgvCheckout.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nama",
                HeaderText = "Nama Barang",
                FillWeight = 130
            });

            dgvCheckout.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Harga",
                HeaderText = "Harga Satuan",
                FillWeight = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "\"Rp\" #,##0",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            dgvCheckout.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Jumlah",
                HeaderText = "Jumlah",
                FillWeight = 60,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dgvCheckout.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Subtotal",
                HeaderText = "Subtotal",
                FillWeight = 110,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "\"Rp\" #,##0",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            AturTampilanDgvCheckout();
        }

        private void AturTampilanTotalPembayaran()
        {
            lblTotalPembayaran.Font = new Font(
                "Leelawadee UI",
                20F,
                FontStyle.Bold
            );

            lblTotalPembayaran.ForeColor = Color.SeaGreen;
            lblTotalPembayaran.BackColor = Color.White;

            lblTotalPembayaran.TextAlign =
                ContentAlignment.MiddleRight;

            lblTotalPembayaran.AutoSize = false;
            lblTotalPembayaran.Padding = new Padding(10, 5, 15, 5);

            lblTotalPembayaran.BorderStyle = BorderStyle.None;

            lblKembalian.AutoSize = false;
            lblKembalian.BackColor = Color.White;
            lblKembalian.ForeColor = Color.SeaGreen;
            lblKembalian.Font = new Font(
                "Leelawadee UI",
                12F,
                FontStyle.Bold
            );
            lblKembalian.TextAlign = ContentAlignment.MiddleRight;
        }

        private void TampilkanBarang()
        {
            dgvCheckout.Rows.Clear();

            foreach (DetailTransaksi item in keranjang)
            {
                dgvCheckout.Rows.Add(
                    item.Kode,
                    item.Nama,
                    item.Harga,
                    item.Jumlah,
                    item.Harga * item.Jumlah
                );
            }

            lblTotalPembayaran.Text =
                "Rp" + TotalBelanja().ToString("N0");

            HitungKembalian();
        }

        private void AturInformasiTransaksi()
        {
            tanggalTransaksi = DateTime.Now;

            nomorTransaksi = "TRX-" +
                tanggalTransaksi.ToString("yyyyMMdd-HHmmss");

            label_tanggal_transaksi2.Text = tanggalTransaksi.ToString(
                "dd MMMM yyyy, HH:mm",
                new System.Globalization.CultureInfo("id-ID"));

            label_nomor_transaksi2.Text = nomorTransaksi;
        }
        private void Dashboard_kasir3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_kasir3_Load(object sender, EventArgs e)
        {

        }

        private void dgvCheckout_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblJudulMetode_Click(object sender, EventArgs e)
        {

        }

        private decimal TotalBelanja()
        {
            return keranjang.Sum(item => item.Harga * item.Jumlah);
        }


        private void HitungKembalian()
        {
            decimal total = TotalBelanja();

            if (!decimal.TryParse(txtUangDiterima.Text, out decimal uang))
            {
                lblKembalian.Text = "Kembalian: Rp0";
                return;
            }

            decimal kembalian = uang - total;

            if (kembalian < 0)
            {
                lblKembalian.Text = "Kembalian: Kurang Rp" +
                    Math.Abs(kembalian).ToString("N0");
            }
            else
            {
                lblKembalian.Text = "Kembalian: Rp" + kembalian.ToString("N0");
            }
        }


        private void txtUangDiterima_TextChanged(object sender, EventArgs e)
        {
            HitungKembalian();
        }




        private void btnSelesaikan_Click(object sender, EventArgs e)
        {
            decimal total = TotalBelanja();
            decimal uang = total;

            if (keranjang == null || keranjang.Count == 0)
            {
                MessageBox.Show("Keranjang masih kosong!");
                return;
            }

            if (!decimal.TryParse(
                txtUangDiterima.Text.Trim(),
                out uang) || uang < total)
            {
                MessageBox.Show(
                    "Uang diterima tidak valid atau kurang dari total pembayaran."
                );

                txtUangDiterima.Focus();
                return;
            }

            decimal kembalian = uang - total;

            DialogResult konfirmasi = MessageBox.Show(
                "Apakah Anda yakin ingin menyelesaikan transaksi ini?\n\n" +
                "Nomor transaksi: " + nomorTransaksi + "\n" +
                "Kasir: " + usernameKasir + "\n" +
                "Jumlah jenis barang: " + keranjang.Count + "\n" +
                "Total item: " + keranjang.Sum(x => x.Jumlah) + "\n" +
                "Total pembayaran: Rp" + total.ToString("N0") + "\n" +
                "Uang diterima: Rp" + uang.ToString("N0") + "\n" +
                "Kembalian: Rp" + kembalian.ToString("N0") + "\n\n" +
                "Setelah dikonfirmasi, transaksi akan disimpan dan stok barang diperbarui.",
                "Konfirmasi Selesaikan Transaksi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (konfirmasi != DialogResult.Yes)
            {
                return;
            }
            List<Produk> produkTerbaru = new List<Produk>();

            List<LapisanStok> lapisanTerbaru =
                new List<LapisanStok>();

            List<LapisanStok> salinanLapisanLama =
                new List<LapisanStok>();

            Dictionary<string, int> stokLama =
                new Dictionary<string, int>(
                    StringComparer.OrdinalIgnoreCase
                );

            List<DetailTransaksiSimpan> detailTransaksiBaru =
                new List<DetailTransaksiSimpan>();

            bool lapisanSudahDisimpan = false;
            bool stokSudahDisimpan = false;

            TransaksiSimpan transaksi = null;

            try
            {
              
                produkTerbaru = ProdukJsonStore.Load();
                lapisanTerbaru = LapisanStokJsonStore.Load()
                    ?? new List<LapisanStok>();

                if (produkTerbaru == null || produkTerbaru.Count == 0)
                {
                    throw new Exception(
                        "Data produk tidak ditemukan di produk.json."
                    );
                }

                
                salinanLapisanLama = lapisanTerbaru
                    .Select(lapisan => new LapisanStok
                    {
                        IdLapisan = lapisan.IdLapisan,
                        KodeBarang = lapisan.KodeBarang,
                        NamaBarang = lapisan.NamaBarang,
                        TanggalMasuk = lapisan.TanggalMasuk,
                        Petugas = lapisan.Petugas,
                        NomorSuratJalan = lapisan.NomorSuratJalan,
                        StokAwal = lapisan.StokAwal,
                        SisaStok = lapisan.SisaStok,
                        HargaBeli = lapisan.HargaBeli
                    })
                    .ToList();

                
                foreach (var grupBarang in keranjang.GroupBy(
                    barang => barang.Kode,
                    StringComparer.OrdinalIgnoreCase))
                {
                    string kodeProduk = grupBarang.Key;

                    int jumlahDibeli = grupBarang.Sum(
                        barang => barang.Jumlah
                    );

                    if (jumlahDibeli <= 0)
                    {
                        throw new Exception(
                            "Jumlah barang tidak valid untuk kode " +
                            kodeProduk
                        );
                    }

                  
                    Produk produkDitemukan = produkTerbaru.FirstOrDefault(
                        data => string.Equals(
                            data.Kode,
                            kodeProduk,
                            StringComparison.OrdinalIgnoreCase
                        )
                    );

                    if (produkDitemukan == null)
                    {
                        throw new Exception(
                            "Produk dengan kode " + kodeProduk +
                            " tidak ditemukan."
                        );
                    }

                
                    if (produkDitemukan.Stok < jumlahDibeli)
                    {
                        throw new Exception(
                            "Stok barang " + produkDitemukan.Nama +
                            " tidak mencukupi.\n" +
                            "Stok tersedia: " + produkDitemukan.Stok +
                            "\nJumlah dibeli: " + jumlahDibeli
                        );
                    }

                   
                    stokLama[produkDitemukan.Kode] =
                        produkDitemukan.Stok;

                   
                    foreach (DetailTransaksi detailKeranjang in grupBarang)
                    {
                        DetailTransaksiSimpan hasilFIFO =
                            ProsesFIFO(detailKeranjang, lapisanTerbaru);

                        detailTransaksiBaru.Add(hasilFIFO);
                    }

                 
                    produkDitemukan.Stok -= jumlahDibeli;
                }

               
                LapisanStokJsonStore.Save(lapisanTerbaru);
                lapisanSudahDisimpan = true;

               
                ProdukJsonStore.Save(produkTerbaru);
                stokSudahDisimpan = true;

             
                transaksi = new TransaksiSimpan
                {
                    NomorTransaksi = nomorTransaksi,
                    UsernameKasir = usernameKasir,
                    Tanggal = tanggalTransaksi,
                    MetodePembayaran = "Tunai",
                    TotalPembayaran = total,

                    UangDiterima = uang,

                    Kembalian = uang - total,

                    Barang = detailTransaksiBaru,

                    TotalModal = detailTransaksiBaru.Sum(
                        data => data.TotalModal
                    ),

                    TotalLabaKotor = detailTransaksiBaru.Sum(
                        data => data.LabaKotor
                    )
                };

              
                List<TransaksiSimpan> riwayatTransaksi =
                    TransaksiJsonStore.Load()
                    ?? new List<TransaksiSimpan>();

                riwayatTransaksi.Add(transaksi);

                TransaksiJsonStore.Save(riwayatTransaksi);

            
                try
                {
                    List<BarangKeluarSimpan> daftarBarangKeluar =
                        BarangKeluarJsonStore.Load()
                        ?? new List<BarangKeluarSimpan>();

                    foreach (DetailTransaksi detailBarangKeluar in keranjang)
                    {
                        BarangKeluarSimpan dataBarangKeluar =
                            new BarangKeluarSimpan
                            {
                                Waktu = tanggalTransaksi,
                                KodeBarang = detailBarangKeluar.Kode,
                                NamaBarang = detailBarangKeluar.Nama,
                                Jumlah = detailBarangKeluar.Jumlah,
                                Jenis = "Penjualan",
                                Alasan = "Transaksi Kasir",
                                Petugas = usernameKasir,
                                Catatan = "Nomor transaksi: " +
                                          nomorTransaksi
                            };

                        daftarBarangKeluar.Add(dataBarangKeluar);
                    }

                    BarangKeluarJsonStore.Save(daftarBarangKeluar);
                }
                catch (Exception errorBarangKeluar)
                {
                    MessageBox.Show(
                        "Transaksi berhasil disimpan, tetapi pencatatan barang keluar gagal:\n" +
                        errorBarangKeluar.Message,
                        "Peringatan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }

              
                try
                {
                    foreach (var grupLog in keranjang.GroupBy(
                        barang => barang.Kode,
                        StringComparer.OrdinalIgnoreCase))
                    {
                        string kodeLog = grupLog.Key;

                        int jumlahTerjual = grupLog.Sum(
                            barang => barang.Jumlah
                        );

                        Produk produkLog = produkTerbaru.FirstOrDefault(
                            data => string.Equals(
                                data.Kode,
                                kodeLog,
                                StringComparison.OrdinalIgnoreCase
                            )
                        );

                        if (produkLog == null)
                            continue;

                        int stokSebelum = stokLama[produkLog.Kode];
                        int stokSekarang = produkLog.Stok;

                        LogAktivitasJsonStore.Catat(
                            usernameKasir,
                            "Kasir",
                            "Barang Keluar",
                            "Barang keluar melalui penjualan",
                            produkLog.Kode + " - " + produkLog.Nama,
                            "Barang terjual sebanyak " + jumlahTerjual +
                            " unit melalui transaksi " + nomorTransaksi +
                            ". Stok sebelumnya: " + stokSebelum +
                            ". Stok sekarang: " + stokSekarang +
                            ". Pembayaran tunai."
                        );
                    }
                }
                catch (Exception errorLog)
                {
                    MessageBox.Show(
                        "Transaksi berhasil disimpan, tetapi log aktivitas gagal dicatat:\n" +
                        errorLog.Message,
                        "Peringatan Log",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (Exception ex)
            {
             
                if (stokSudahDisimpan)
                {
                    try
                    {
                        foreach (Produk dataProduk in produkTerbaru)
                        {
                            if (stokLama.ContainsKey(dataProduk.Kode))
                            {
                                dataProduk.Stok =
                                    stokLama[dataProduk.Kode];
                            }
                        }

                        ProdukJsonStore.Save(produkTerbaru);
                    }
                    catch (Exception errorRollback)
                    {
                        MessageBox.Show(
                            "Stok gagal dikembalikan:\n" +
                            errorRollback.Message
                        );
                    }
                }

              
                if (lapisanSudahDisimpan)
                {
                    try
                    {
                        LapisanStokJsonStore.Save(salinanLapisanLama);
                    }
                    catch (Exception errorRollbackLapisan)
                    {
                        MessageBox.Show(
                            "Lapisan stok gagal dikembalikan:\n" +
                            errorRollbackLapisan.Message,
                            "Peringatan Pemulihan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    }
                }

                MessageBox.Show(
                    "Gagal menyimpan transaksi:\n" + ex.Message,
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

         
            Dashboard_Struck strukForm = new Dashboard_Struck();

            strukForm.TampilkanStruk(transaksi);

            strukForm.Show();

           
        }

        



        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUangDiterima_TextChanged_1(object sender, EventArgs e)
        {
            HitungKembalian();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Dashboard_kasir2 kembaliform2 = new Dashboard_kasir2(keranjang,usernameKasir);
            kembaliform2.Show();
            this.Hide();
        }


        private DetailTransaksiSimpan ProsesFIFO(
            DetailTransaksi item,
            List<LapisanStok> semuaLapisan)
        {
            int jumlahDibutuhkan = item.Jumlah;
            int jumlahAwal = jumlahDibutuhkan;

            decimal totalModal = 0;

            List<LapisanStok> lapisanProduk = semuaLapisan
                .Where(x =>
                    string.Equals(
                        x.KodeBarang,
                        item.Kode,
                        StringComparison.OrdinalIgnoreCase
                    ) &&
                    x.SisaStok > 0
                )
                .OrderBy(x => x.TanggalMasuk)
                .ThenBy(x => x.IdLapisan)
                .ToList();

            int stokLapisanTersedia = lapisanProduk.Sum(x => x.SisaStok);

            if (stokLapisanTersedia < jumlahDibutuhkan)
            {
                throw new Exception(
                    "Lapisan stok untuk " + item.Nama +
                    " tidak mencukupi.\n" +
                    "Stok lapisan tersedia: " + stokLapisanTersedia +
                    "\nJumlah yang dibutuhkan: " + jumlahDibutuhkan +
                    "\nPastikan stok lama sudah memiliki lapisan awal."
                );
            }

            foreach (LapisanStok lapisan in lapisanProduk)
            {
                if (jumlahDibutuhkan <= 0)
                    break;

                int jumlahDiambil = Math.Min(
                    lapisan.SisaStok,
                    jumlahDibutuhkan
                );

                totalModal += jumlahDiambil * lapisan.HargaBeli;

                lapisan.SisaStok -= jumlahDiambil;

                jumlahDibutuhkan -= jumlahDiambil;
            }

            decimal subtotal = item.Harga * jumlahAwal;

            return new DetailTransaksiSimpan
            {
                Kode = item.Kode,
                Nama = item.Nama,
                Harga = item.Harga,
                Jumlah = jumlahAwal,
                Subtotal = subtotal,
                TotalModal = totalModal,
                HargaModalRataRata = totalModal / jumlahAwal,
                LabaKotor = subtotal - totalModal
            };
        }

    }
}
     