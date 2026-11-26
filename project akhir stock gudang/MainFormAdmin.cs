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
        private readonly string usernameAktif;

        public MainFormAdmin(string username)
        {
            InitializeComponent();
            usernameAktif = username;
            btnMenuDashboard_Click(this, EventArgs.Empty);
            UiTheme.DecorateHeader(pnlTopBar);
            this.CancelButton = btnKeluar;  
            this.KeyPreview = true;
            this.KeyDown += MainFormAdmin_KeyDown;
        }
        ucAdminDataUser? _halUser;
        ucDataBarang? _halBarang;
        ucLogAktivitas? _halLogAktivitas;
        ucAkunSaya? _halLogAkun;
        ucLaba? _halLaba;

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
            var semua = new[] { btnMenuDashboard, btnMenuUser, btnDataBarang, btnMenuLapPenjualan, btnMenuLapGudang,btnLaba, btnLogAktivitas, btnPengaturan };
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
            DialogResult hasil = MessageBox.Show(
           "Apakah Anda yakin ingin keluar dari aplikasi?",
           "Konfirmasi Keluar",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (hasil == DialogResult.Yes)
            {
                try
                {
                    LogAktivitasJsonStore.Catat(
                        usernameAktif,
                        "Admin",
                        "Autentikasi",
                        "Logout",
                        "Sistem",
                        "Admin keluar dari aplikasi."
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Gagal mencatat aktivitas logout:\n" + ex.Message,
                        "Peringatan Log",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                Form1 kembalilagi = new Form1();
                kembalilagi.Show();
                this.Hide();

            }

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
            _halLogAktivitas.RefreshLog();

            Buka(_halLogAktivitas, "Log aktivitas", btnLogAktivitas);
        }

        private void btnPengaturan_Click(object sender, EventArgs e)
        {
            _halLogAkun ??= new ucAkunSaya("admin",
            "admin",
            "Admin");


            Buka(_halLogAkun, "Akun Saya", btnPengaturan);
        }

        private void btnLaba_Click(object sender, EventArgs e)
        {
            _halLaba ??= new ucLaba();
            Buka(_halLaba, "Laba", btnLaba);
        }

        private void MainFormAdmin_KeyDown(object? sender, KeyEventArgs e)
        {

            if (e.Control && e.KeyCode == Keys.D1)
            {
                e.SuppressKeyPress = true;
                btnMenuUser.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.D2)
            {
                e.SuppressKeyPress = true;
                btnDataBarang.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.D3)
            {
                e.SuppressKeyPress = true;
                btnMenuLapPenjualan.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.D4)
            {
                e.SuppressKeyPress = true;
                btnMenuLapGudang.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.D6)
            {
                e.SuppressKeyPress = true;
                btnLogAktivitas.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.D7)
            {
                e.SuppressKeyPress = true;
                btnPengaturan.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.D5)
            {
                e.SuppressKeyPress = true;
                btnLaba.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.D0)
            {
                e.SuppressKeyPress = true;
                btnMenuDashboard.PerformClick();
            }
        }
    }
}
