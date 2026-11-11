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
            keranjang = dataKeranjang ?? new List<DetailTransaksi>();
            usernameKasir = username ?? "";
            txtUangDiterima.TextChanged +=
           txtUangDiterima_TextChanged;
            SiapkanTabel();
            AturTampilanPembayaran();
            TampilkanBarang();
            AturTampilanTotalPembayaran();
            BuatKartuMetodePembayaran();
            AturInformasiTransaksi();
            AturFontForm(this);
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

        private string metodePembayaranTerpilih = "";

        private void BuatKartuMetodePembayaran()
        {
            flpMetodePembayaran.Controls.Clear();

            flpMetodePembayaran.BackColor = Color.White;
            flpMetodePembayaran.FlowDirection = FlowDirection.LeftToRight;
            flpMetodePembayaran.WrapContents = false;
            flpMetodePembayaran.AutoScroll = false;
            flpMetodePembayaran.Padding = new Padding(5);

            TambahKartuMetode("Tunai", "Pembayaran langsung");
            TambahKartuMetode("Transfer Bank", "Melalui rekening");
            TambahKartuMetode("QRIS", "Pembayaran kode QR");

            PilihMetodePembayaran("Tunai");
        }

        private void TambahKartuMetode(string metode, string deskripsi)
        {
            Panel kartu = new Panel
            {
                Name = "kartu" + metode.Replace(" ", ""),
                Width = 180,
                Height = 90,
                Margin = new Padding(6),
                Padding = new Padding(6),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Cursor = Cursors.Hand,
                Tag = metode
            };

            Label lblNama = new Label
            {
                Text = metode,
                Font = new Font("Leelawadee UI", 11F, FontStyle.Bold),
                ForeColor = Color.SeaGreen,
                Dock = DockStyle.Top,
                Height = 35,
                TextAlign = ContentAlignment.MiddleCenter,
                Cursor = Cursors.Hand
            };

            Label lblDeskripsi = new Label
            {
                Text = deskripsi,
                Font = new Font("Leelawadee UI", 9F),
                ForeColor = Color.DimGray,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Cursor = Cursors.Hand
            };

            kartu.Controls.Add(lblDeskripsi);
            kartu.Controls.Add(lblNama);

            kartu.Click += (s, e) => PilihMetodePembayaran(metode);
            lblNama.Click += (s, e) => PilihMetodePembayaran(metode);
            lblDeskripsi.Click += (s, e) => PilihMetodePembayaran(metode);

            flpMetodePembayaran.Controls.Add(kartu);
        }

        private void PilihMetodePembayaran(string metode)
        {
            metodePembayaranTerpilih = metode;

            foreach (Control kontrol in flpMetodePembayaran.Controls)
            {
                if (kontrol is Panel kartu)
                {
                    bool dipilih = kartu.Tag?.ToString() == metode;

                    kartu.BackColor = dipilih
                        ? Color.FromArgb(225, 245, 238)
                        : Color.White;

                    kartu.Padding = new Padding(6);
                    kartu.BorderStyle = BorderStyle.FixedSingle;

                    foreach (Control isi in kartu.Controls)
                    {
                        if (isi is Label label)
                        {
                            label.ForeColor = dipilih
                                ? Color.FromArgb(0, 120, 90)
                                : Color.DimGray;
                        }
                    }

                    kartu.Invalidate();
                }
            }

            AturPembayaran();
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

        private void cmbMetodePembayaran_SelectedIndexChanged(object sender, EventArgs e)
        {
            AturPembayaran();
        }
        private decimal TotalBelanja()
        {
            return keranjang.Sum(item => item.Harga * item.Jumlah);
        }


        private void AturPembayaran()
        {
            bool tunai = metodePembayaranTerpilih == "Tunai";

            txtUangDiterima.Enabled = tunai;

            lblUangDiterima.ForeColor = tunai
                ? Color.SeaGreen
                : Color.Gray;

            if (!tunai)
            {
                txtUangDiterima.Clear();
                lblKembalian.Text = "Tidak Berlaku";
            }
            else
            {
                HitungKembalian();
            }


        }


        private void HitungKembalian()
        {
            if (metodePembayaranTerpilih != "Tunai")
            {
                lblKembalian.Text = "Tidak berlaku";
                return;
            }

            decimal total = TotalBelanja();

            if (!decimal.TryParse(txtUangDiterima.Text, out decimal uang))
            {
                lblKembalian.Text = "Rp0";
                return;
            }

            decimal kembalian = uang - total;

            if (kembalian < 0)
            {
                lblKembalian.Text = "Kurang Rp" +
                    Math.Abs(kembalian).ToString("N0");
            }
            else
            {
                lblKembalian.Text = "Rp" + kembalian.ToString("N0");
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

            if (string.IsNullOrWhiteSpace(metodePembayaranTerpilih))
            {
                MessageBox.Show("Silakan pilih metode pembayaran.");
                return;
            }

          
            if (metodePembayaranTerpilih == "Tunai")
            {
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
            }

           
            List<Produk> produkTerbaru = new List<Produk>();

            Dictionary<string, int> stokLama =
                new Dictionary<string, int>();

            bool stokSudahDisimpan = false;

          
            TransaksiSimpan transaksi = null;

            try
            {
               
                produkTerbaru = ProdukJsonStore.Load();

                if (produkTerbaru == null || produkTerbaru.Count == 0)
                {
                    throw new Exception(
                        "Data produk tidak ditemukan di produk.json."
                    );
                }

              
                foreach (DetailTransaksi item in keranjang)
                {
                    if (item.Jumlah <= 0)
                    {
                        throw new Exception(
                            "Jumlah barang tidak valid: " + item.Nama
                        );
                    }

                    Produk produk = produkTerbaru.FirstOrDefault(p =>
                        string.Equals(
                            p.Kode,
                            item.Kode,
                            StringComparison.OrdinalIgnoreCase
                        )
                    );

                    if (produk == null)
                    {
                        throw new Exception(
                            "Produk dengan kode " + item.Kode +
                            " tidak ditemukan di produk.json."
                        );
                    }

                    if (produk.Stok < item.Jumlah)
                    {
                        throw new Exception(
                            "Stok barang " + produk.Nama +
                            " tidak mencukupi.\n" +
                            "Stok tersedia: " + produk.Stok +
                            "\nJumlah dibeli: " + item.Jumlah
                        );
                    }

                    
                    if (!stokLama.ContainsKey(produk.Kode))
                    {
                        stokLama.Add(produk.Kode, produk.Stok);
                    }

                   
                    produk.Stok -= item.Jumlah;
                }

               
                ProdukJsonStore.Save(produkTerbaru);

                stokSudahDisimpan = true;

              
                transaksi = new TransaksiSimpan
                {
                    NomorTransaksi = nomorTransaksi,

                    UsernameKasir = usernameKasir,

                    Tanggal = tanggalTransaksi,

                    MetodePembayaran = metodePembayaranTerpilih,

                    TotalPembayaran = total,

                    UangDiterima = uang,

                    Kembalian = metodePembayaranTerpilih == "Tunai"
                        ? uang - total
                        : 0,

                    Barang = keranjang.Select(item =>
                        new DetailTransaksiSimpan
                        {
                            Kode = item.Kode,
                            Nama = item.Nama,
                            Harga = item.Harga,
                            Jumlah = item.Jumlah,
                            Subtotal = item.Harga * item.Jumlah
                        }
                    ).ToList()
                };

               
                List<TransaksiSimpan> riwayat =
                    TransaksiJsonStore.Load();

              
                riwayat.Add(transaksi);

             
                TransaksiJsonStore.Save(riwayat);
                try
                {
                    List<BarangKeluarSimpan> daftarBarangKeluar =
                        BarangKeluarJsonStore.Load();

                    foreach (DetailTransaksi item in keranjang)
                    {
                        BarangKeluarSimpan barangKeluar =
                            new BarangKeluarSimpan
                            {
                                Waktu = tanggalTransaksi,

                                KodeBarang = item.Kode,

                                NamaBarang = item.Nama,

                                Jumlah = item.Jumlah,

                                Jenis = "Penjualan",

                                Alasan = "Transaksi Kasir",

                                Petugas = usernameKasir,

                                Catatan = "Nomor transaksi: " + nomorTransaksi
                            };

                        daftarBarangKeluar.Add(barangKeluar);
                    }

                    BarangKeluarJsonStore.Save(daftarBarangKeluar);
                }
                catch (Exception errorBarangKeluar)
                {
                    MessageBox.Show(
                        "Transaksi berhasil disimpan, tetapi pencatatan barang keluar gagal:\n"
                        + errorBarangKeluar.Message
                    );
                }
            }
            catch (Exception ex)
            {
                
                if (stokSudahDisimpan)
                {
                    try
                    {
                        foreach (Produk produk in produkTerbaru)
                        {
                            if (stokLama.ContainsKey(produk.Kode))
                            {
                                produk.Stok = stokLama[produk.Kode];
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

            this.Hide();
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
    }
}
     