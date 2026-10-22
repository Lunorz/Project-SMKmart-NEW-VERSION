using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_akhir_stock_gudang
{
    public partial class Dashboard_Struck : Form
    {
        public Dashboard_Struck()
        {
            InitializeComponent();
            AturTampilanDgvStruk();
            string nomor = BuatNomorTransaksi();
            DateTime tanggal = DateTime.Now;

            AturInformasiStruk(nomor, tanggal);

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

            lblMetodeStruk.Text =
                "Metode: " + transaksi.MetodePembayaran;

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
            pnlstruk.BringToFront();
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
            Dashboard_kasir dashboardKasirKEMBALI = new Dashboard_kasir(new List<DetailTransaksi>());
            dashboardKasirKEMBALI.Show();
            this.Hide();
        }
    }
}
