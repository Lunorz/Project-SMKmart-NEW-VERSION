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
    public partial class MainFormAdmin : Form
    {
        ucPenjualan? _halPenjualan;
        ucLaporanGudang? _halLaporanGudang;
        ucDashboardAdmin? _halDashboard;

        public MainFormAdmin()
        {
            InitializeComponent();
            btnMenuDashboard_Click(this, EventArgs.Empty);
        }
        ucAdminDataUser? _halUser;
        ucDataBarang? _halBarang;
        ucLogAktivitas? _halLogAktivitas;

        readonly Font _fReg = new("Leelawadee UI", 10.5f);
        readonly Font _fBold = new("Leelawadee UI", 10.5f, FontStyle.Bold);
        void Buka(UserControl halaman, string judul, Button menu)
        {
            halaman.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(halaman);
            lblTopBar10.Text = judul;
            Tandai(menu);
        }
        void Tandai(Button aktif)
        {
            var semua = new[] { btnMenuDashboard, btnMenuUser, btnDataBarang, btnMenuLapPenjualan, btnMenuLapGudang };
            foreach (var b in semua)
            {
                bool on = b == aktif;
                b.BackColor = on ? Color.FromArgb(26, 90, 56) : Color.FromArgb(38, 119, 74);
                b.FlatAppearance.BorderColor = b.BackColor;
                b.ForeColor = on ? Color.White : Color.FromArgb(230, 247, 238);
                b.Font = on ? _fBold : _fReg;
            }
            pnlAktif.Top = aktif.Top + 10;
            pnlAktif.BringToFront();
        }

        private void MainFormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ucAdminDataUser1_Load(object sender, EventArgs e)
        {

        }

        private void btnMenuDashboard_Click(object sender, EventArgs e)
        {
            if (_halDashboard == null)
            {
                _halDashboard = new ucDashboardAdmin();

                _halDashboard.LihatLaporanDiminta += (s, args) =>
                {
                    _halPenjualan ??= new ucPenjualan();

                    Buka(
                        _halPenjualan,
                        "Laporan Penjualan",
                        btnMenuLapPenjualan
                    );
                };
            }

            _halDashboard.RefreshDashboard();

            Buka(
                _halDashboard,
                "Dashboard Admin",
                btnMenuDashboard
            );
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Form1 kembalilagi = new Form1();
            kembalilagi.Show();
            this.Hide();
        }

        private void btnMenuUser_Click(object sender, EventArgs e)
        {
            _halUser ??= new ucAdminDataUser();
            Buka(_halUser, "Data user", btnMenuUser);

        }

        private void btnDataBarang_Click(object sender, EventArgs e)
        {
            _halBarang ??= new ucDataBarang();
            Buka(_halBarang, "Data barang", btnDataBarang);
        }

        private void btnMenuLapPenjualan_Click(object sender, EventArgs e)
        {
            _halPenjualan ??= new ucPenjualan();
            Buka(_halPenjualan, "Laporan penjualan", btnMenuLapPenjualan);
        }

        private void btnMenuLapGudang_Click(object sender, EventArgs e)
        {
            _halLaporanGudang ??= new ucLaporanGudang();

            Buka(
                _halLaporanGudang,
                "Laporan gudang",
                btnMenuLapGudang
            );
        }

        private void btnLogAktivitas_Click(object sender, EventArgs e)
        {
            _halLogAktivitas ??= new ucLogAktivitas();
            Buka(_halLogAktivitas, "Log aktivitas", btnLogAktivitas);
        }
    }
}
