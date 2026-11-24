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
using System.Drawing.Printing;

namespace project_akhir_stock_gudang
{
    public partial class Dashboard_Struck : Form
    {
        private readonly string usernameKasir;
        private Bitmap gambarStrukUntukCetak;
        public Dashboard_Struck()
        {
            InitializeComponent();

            btnTransaksiBaru.Visible = true;

            btnPrint.BringToFront();
            btnTransaksiBaru.BringToFront();

            btnPrint.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnTransaksiBaru.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            AturTampilanDgvStruk();

            string nomor = BuatNomorTransaksi();
            DateTime tanggal = DateTime.Now;

            AturInformasiStruk(nomor, tanggal);

            printDocument1.PrintPage -= DokumenCetak_PrintPage;
            printDocument1.PrintPage += DokumenCetak_PrintPage;

            printPreviewDialog1.Document = printDocument1;
            printDocument1.DefaultPageSettings.PaperSize =
    new PaperSize("Struk 80mm", 315, 500);

            printDocument1.DefaultPageSettings.Margins =
                new Margins(5, 5, 5, 5);

            printDocument1.DefaultPageSettings.Landscape = false;

            printPreviewDialog1.Width = 900;
            printPreviewDialog1.Height = 700;

            btnPrint.Click -= btnPrint_Click;
            btnPrint.Click += btnPrint_Click;

            Resize += (_, _) => AturLayoutStruk();
            AturLayoutStruk();
        }
        private void AturTampilanDgvStruk()
        {
            dgvStruk.SuspendLayout();

            dgvStruk.DataSource = null;
            dgvStruk.Columns.Clear();
            dgvStruk.Rows.Clear();

            dgvStruk.Dock = DockStyle.None;
            dgvStruk.Location = new Point(20, 200);
            dgvStruk.Size = new Size(460, 190);
            dgvStruk.BackgroundColor = Color.White;
            dgvStruk.BorderStyle = BorderStyle.None;
            dgvStruk.GridColor = Color.FromArgb(225, 234, 228);

            dgvStruk.Font = new Font("Leelawadee UI", 9F);
            dgvStruk.ForeColor = Color.FromArgb(51, 51, 51);

            dgvStruk.AutoGenerateColumns = false;
            dgvStruk.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvStruk.RowHeadersVisible = false;
            dgvStruk.AllowUserToAddRows = false;
            dgvStruk.AllowUserToDeleteRows = false;
            dgvStruk.AllowUserToResizeRows = false;
            dgvStruk.ReadOnly = true;
            dgvStruk.MultiSelect = false;

            dgvStruk.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvStruk.EnableHeadersVisualStyles = false;
            dgvStruk.ColumnHeadersHeight = 38;
            dgvStruk.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgvStruk.RowTemplate.Height = 32;
            dgvStruk.ScrollBars = ScrollBars.Both;

            dgvStruk.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(46, 139, 87);

            dgvStruk.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvStruk.ColumnHeadersDefaultCellStyle.Font =
                new Font("Leelawadee UI", 9F, FontStyle.Bold);

            dgvStruk.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvStruk.DefaultCellStyle.BackColor = Color.White;
            dgvStruk.DefaultCellStyle.ForeColor =
                Color.FromArgb(51, 51, 51);

            dgvStruk.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(220, 240, 225);

            dgvStruk.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(40, 80, 50);

            dgvStruk.DefaultCellStyle.Padding =
                new Padding(4, 2, 4, 2);

            dgvStruk.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(240, 255, 240);

            dgvStruk.RowsDefaultCellStyle.WrapMode =
                DataGridViewTriState.False;

            dgvStruk.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colKodeStruk",
                HeaderText = "Kode",
                FillWeight = 65,
                ReadOnly = true
            });

            dgvStruk.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNamaStruk",
                HeaderText = "Nama Barang",
                FillWeight = 120,
                ReadOnly = true
            });

            dgvStruk.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colHargaStruk",
                HeaderText = "Harga",
                FillWeight = 85,
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "\"Rp\" #,##0",
                    Alignment =
                        DataGridViewContentAlignment.MiddleRight
                }
            });

            dgvStruk.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colJumlahStruk",
                HeaderText = "Qty",
                FillWeight = 45,
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment =
                        DataGridViewContentAlignment.MiddleCenter
                }
            });

            dgvStruk.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colSubtotalStruk",
                HeaderText = "Subtotal",
                FillWeight = 95,
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "\"Rp\" #,##0",
                    Alignment =
                        DataGridViewContentAlignment.MiddleRight
                }
            });

            dgvStruk.ResumeLayout();
        }

        private string BuatNomorTransaksi()
        {
            List<TransaksiSimpan> daftar = TransaksiJsonStore.Load();

            string tanggalHariIni = DateTime.Now.ToString("yyyyMMdd");

            int nomorBerikutnya = daftar
                .Where(t => t.NomorTransaksi.StartsWith(
                    "TRX-" + tanggalHariIni + "-"))
                .Select(t =>
                {
                    string[] bagian = t.NomorTransaksi.Split('-');

                    if (bagian.Length == 3 &&
                        int.TryParse(bagian[2], out int nomor))
                    {
                        return nomor;
                    }

                    return 0;
                })
                .DefaultIfEmpty(0)
                .Max() + 1;

            return $"TRX-{tanggalHariIni}-{nomorBerikutnya:000}";
        }

        private void AturInformasiStruk(string nomorTransaksi, DateTime tanggal)
        {
            LblNomorStruk.Text = nomorTransaksi;

            lblTanggalStruk.Text =
                tanggal.ToString("dd/MM/yyyy HH:mm:ss");
        }

        public void TampilkanStruk(TransaksiSimpan transaksi)
        {
            if (transaksi == null)
            {
                MessageBox.Show("Data transaksi tidak ditemukan.");
                return;
            }

            LblNomorStruk.Text = transaksi.NomorTransaksi;
            lblTanggalStruk.Text =
                transaksi.Tanggal.ToString("dd/MM/yyyy HH:mm:ss");

            lblTotalStruk.Text =
                "TOTAL: " + transaksi.TotalPembayaran
                    .ToString("C0",
                        System.Globalization.CultureInfo.GetCultureInfo("id-ID"));

            lblUangDiterimaStruk.Text =
                "Uang diterima: " + transaksi.UangDiterima
                    .ToString("C0",
                        System.Globalization.CultureInfo.GetCultureInfo("id-ID"));

            lblKembalianStruk.Text =
                "Kembalian: " + transaksi.Kembalian
                    .ToString("C0",
                        System.Globalization.CultureInfo.GetCultureInfo("id-ID"));

            dgvStruk.Rows.Clear();

            if (transaksi.Barang != null)
            {
                foreach (DetailTransaksiSimpan barang in transaksi.Barang)
                {
                    dgvStruk.Rows.Add(
                        barang.Kode,
                        barang.Nama,
                        barang.Harga,
                        barang.Jumlah,
                        barang.Subtotal
                    );
                }
            }

            pnlstruk.Visible = true;
            pnlstruk.SendToBack();

            btnPrint.Visible = true;
            btnTransaksiBaru.Visible = true;

            btnPrint.BringToFront();
            btnTransaksiBaru.BringToFront();

            AturLayoutStruk();
        }


        private void AturLayoutStruk()
        {
            int margin = 20;
            int jarakTombolPanel = 12;

            int lebarPanel = Math.Max(460, ClientSize.Width - (margin * 2));

            int tinggiTombol = 67;
            int posisiTombolY = ClientSize.Height - margin - tinggiTombol;

            int tinggiPanel = posisiTombolY - jarakTombolPanel - margin;

            pnlstruk.Location = new Point(margin, margin);
            pnlstruk.Size = new Size(lebarPanel, tinggiPanel);

            int lebarDalam = Math.Max(420, lebarPanel - (margin * 2));

            pnlHeaderStruck.Location = new Point(margin, 15);
            pnlHeaderStruck.Size = new Size(lebarDalam, 85);

            pnlInfoStruk.Location = new Point(margin, 106);
            pnlInfoStruk.Size = new Size(lebarDalam, 95);

            dgvStruk.Location = new Point(margin, 207);
            dgvStruk.Size = new Size(
                lebarDalam,
                Math.Max(190, tinggiPanel - 560));

            pnlRingkasan.Location = new Point(
                margin,
                dgvStruk.Bottom + 18);

            pnlRingkasan.Size = new Size(lebarDalam, 145);

            pnlFooterStruk.Location = new Point(
                margin,
                pnlRingkasan.Bottom + 12);

            pnlFooterStruk.Size = new Size(lebarDalam, 61);

            int lebarTombol = 140;
            int jarakAntarTombol = 6;

            int totalLebarTombol = (lebarTombol * 2) + jarakAntarTombol;
            int posisiAwalX = (ClientSize.Width - totalLebarTombol) / 2;

            btnPrint.Size = new Size(lebarTombol, tinggiTombol);
            btnTransaksiBaru.Size = new Size(lebarTombol, tinggiTombol);

            btnPrint.Location = new Point(posisiAwalX, posisiTombolY);

            btnTransaksiBaru.Location = new Point(
                posisiAwalX + lebarTombol + jarakAntarTombol,
                posisiTombolY);

            pnlstruk.SendToBack();

            btnPrint.Visible = true;
            btnTransaksiBaru.Visible = true;

            btnPrint.BringToFront();
            btnTransaksiBaru.BringToFront();
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (!pnlstruk.Visible)
                {
                    MessageBox.Show(
                        "Struk belum tersedia untuk dicetak.",
                        "Peringatan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

              
                pnlstruk.PerformLayout();
                pnlstruk.Refresh();

                dgvStruk.Refresh();

                
                if (gambarStrukUntukCetak != null)
                {
                    gambarStrukUntukCetak.Dispose();
                    gambarStrukUntukCetak = null;
                }

              
                gambarStrukUntukCetak = new Bitmap(
                    pnlstruk.Width,
                    pnlstruk.Height
                );

                pnlstruk.DrawToBitmap(
                    gambarStrukUntukCetak,
                    new Rectangle(
                        0,
                        0,
                        pnlstruk.Width,
                        pnlstruk.Height
                    )
                );

                printPreviewDialog1.Document = printDocument1;

                printPreviewDialog1.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menampilkan pratinjau struk:\n" + ex.Message,
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void DokumenCetak_PrintPage(
         object sender,
         PrintPageEventArgs e)
        {
            if (gambarStrukUntukCetak == null)
            {
                e.HasMorePages = false;
                return;
            }

            Rectangle areaCetak = e.MarginBounds;

            float skala =
                (float)areaCetak.Width / gambarStrukUntukCetak.Width;

            int lebar = areaCetak.Width;

            int tinggi = (int)(
                gambarStrukUntukCetak.Height * skala);

            e.Graphics.DrawImage(
                gambarStrukUntukCetak,
                areaCetak.Left,
                areaCetak.Top,
                lebar,
                tinggi
            );

            e.HasMorePages = false;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (gambarStrukUntukCetak != null)
            {
                gambarStrukUntukCetak.Dispose();
                gambarStrukUntukCetak = null;
            }

            base.OnFormClosed(e);
        }
        private void pnlInfoStruk_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlstruk_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlFooterStruk_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvStruk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dashboard_Struck_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnTransaksiBaru_Click(object sender, EventArgs e)
        {
            Dashboard_kasir dashboardKasirKEMBALI = new Dashboard_kasir(new List<DetailTransaksi>(), usernameKasir);
            dashboardKasirKEMBALI.Show();
            this.Hide();
        }

    
    }
}
