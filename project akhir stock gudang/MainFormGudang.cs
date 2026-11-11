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
    public partial class MainFormGudang : Form
    {
        ucDashboardGudang? _dash;
        ucBarangMasuk? _masuk;
        ucBarangKeluar? _keluar;
        ucStockBarang? _stok;

        private string username;
        private string usernamePetugas;

        readonly Font _fReg = new("Leelawadee UI", 10.5f, FontStyle.Regular);
        readonly Font _fBold = new("Leelawadee UI", 10.5f, FontStyle.Bold);
        public MainFormGudang(string username)
        {
            InitializeComponent();
            btnMenuDashboardGudangMainform_Click(this, EventArgs.Empty);
            usernamePetugas = username ?? "";
        }


        private void MainFormGudang_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        void Buka(UserControl halaman, string judul, Button menu)
        {
            halaman.Dock = DockStyle.Fill;
            pnlContentGudangMainform.Controls.Clear();
            pnlContentGudangMainform.Controls.Add(halaman);
            lblJudulGudangMainform.Text = judul;

            foreach (var b in new[] { btnMenuDashboardGudangMainform, btnMenuMasukGudangMainform, btnMenuKeluarGudangMainform, btnMenuStokGudangMainform })
            {
                bool aktif = b == menu;
                b.BackColor = aktif ? Color.FromArgb(26, 90, 56) : Color.FromArgb(38, 119, 74);
                b.FlatAppearance.BorderColor = b.BackColor;
                b.ForeColor = aktif ? Color.White : Color.FromArgb(230, 247, 238);
                b.Font = aktif ? _fBold : _fReg;
            }
            pnlAktifGudangMainform.Top = menu.Top + 10;
            pnlAktifGudangMainform.BringToFront();
        }

        void Pindah(string tujuan)
        {
            if (tujuan == "masuk") btnMenuMasukGudangMainform_Click(this, EventArgs.Empty);
            else if (tujuan == "keluar") btnMenuKeluarGudangMainform_Click(this, EventArgs.Empty);
            else if (tujuan == "stok") btnMenuStokGudangMainform_Click(this, EventArgs.Empty);
        }

        private void btnMenuDashboardGudangMainform_Click(object sender, EventArgs e)
        {
            if (_dash == null)
            {
                _dash = new ucDashboardGudang();
                _dash.Navigasi += Pindah;
            }
            Buka(_dash, "Dashboard Gudang", btnMenuDashboardGudangMainform);
        }

        private void btnMenuMasukGudangMainform_Click(object sender, EventArgs e)
        {
            _masuk ??= new ucBarangMasuk();
            Buka(_masuk, "Barang Masuk", btnMenuMasukGudangMainform);
        }

        private void btnMenuKeluarGudangMainform_Click(object sender, EventArgs e)
        {
            _keluar ??= new ucBarangKeluar(usernamePetugas);
            Buka(_keluar, "Barang Keluar", btnMenuKeluarGudangMainform);
        }

        private void btnMenuStokGudangMainform_Click(object sender, EventArgs e)
        {
            _stok ??= new ucStockBarang();
            Buka(_stok, "Stock Barang", btnMenuStokGudangMainform);

        }

        private void btmMenuKeluar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Keluar dari aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Form1 keluar100 = new Form1();
                keluar100.Show();
                this.Hide();
            }

        }

        private void pnlSideBarGudangMainform_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
