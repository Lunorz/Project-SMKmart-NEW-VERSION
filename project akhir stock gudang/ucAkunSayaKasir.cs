
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace project_akhir_stock_gudang
{
    public partial class ucAkunSayaKasir : UserControl
    {
        private string usernameKasir = "";
        private Dashboard_kasir? dashboardAsal;

        public ucAkunSayaKasir() : this("")
        {
        }

        public ucAkunSayaKasir(string username)
        {
            InitializeComponent();
            UiAkunSaya.Apply(this);

            usernameKasir = username ?? "";

            txtLama.UseSystemPasswordChar = true;
            txtBaru.UseSystemPasswordChar = true;
            txtKonfirmasi.UseSystemPasswordChar = true;

           

            prgKekuatan.Minimum = 0;
            prgKekuatan.Maximum = 5;
            prgKekuatan.Value = 0;

            txtBaru.TextChanged -= txtBaru_TextChanged;
            txtBaru.TextChanged += txtBaru_TextChanged;

            txtLama.TextChanged -= txtLama_TextChanged;
            txtLama.TextChanged += txtLama_TextChanged;

            btnSimpan.Click -= btnSimpan_Click;
            btnSimpan.Click += btnSimpan_Click;

            btnBersihkan.Click -= btnBersihkan_Click;
            btnBersihkan.Click += btnBersihkan_Click;

            lblKembaliKeKasir.Click -= lblKembaliKeKasir_Click;
            lblKembaliKeKasir.Click += lblKembaliKeKasir_Click;

            PeriksaKekuatanPassword();

            if (!string.IsNullOrWhiteSpace(usernameKasir))
            {
                MuatInformasiAkun();
            }
        }

        public void AturUsername(string username)
        {
            usernameKasir = username ?? "";
            MuatInformasiAkun();
        }
        private void MuatInformasiAkun()
        {
            UserAccount? akun = UserStore.GetAll()
                .FirstOrDefault(x =>
                    string.Equals(
                        x.Username,
                        usernameKasir,
                        StringComparison.OrdinalIgnoreCase));

            if (akun == null)
            {
                MessageBox.Show(
                    "Data akun kasir tidak ditemukan.",
                    "Informasi Akun",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            txtUsername.Text = akun.Username;
            txtRoleInfo.Text = akun.Role;

            txtLogin.Text = akun.TerakhirLogin.HasValue
                ? akun.TerakhirLogin.Value.ToString("dd MMMM yyyy, HH:mm:ss")
                : "Belum pernah login";

            txtGamti.Text = akun.TerakhirGantiPassword.HasValue
                ? akun.TerakhirGantiPassword.Value.ToString("dd MMMM yyyy, HH:mm:ss")
                : "Belum pernah mengganti password";
        }

        private void txtBaru_TextChanged(object? sender, EventArgs e)
        {
            PeriksaKekuatanPassword();
        }

        private void txtLama_TextChanged(object? sender, EventArgs e)
        {
            PeriksaKekuatanPassword();
        }

        private void PeriksaKekuatanPassword()
        {
            string password = txtBaru.Text;
            string passwordLama = txtLama.Text;

            bool minimalKarakter = password.Length >= 8;
            bool hurufBesarKecil =
                password.Any(char.IsUpper) &&
                password.Any(char.IsLower);

            bool angka = password.Any(char.IsDigit);

            bool simbol = password.Any(c =>
                !char.IsLetterOrDigit(c));

            bool berbeda = !string.IsNullOrEmpty(passwordLama) &&
                           password != passwordLama;

            AturIndikator(lblS1, minimalKarakter, "Minimal 8 karakter");
            AturIndikator(lblS2, hurufBesarKecil, "Huruf besar dan kecil");
            AturIndikator(lblS3, angka, "Minimal satu angka");
            AturIndikator(lblS4, simbol, "Minimal satu simbol");
            AturIndikator(lblS5, berbeda, "Berbeda dari password lama");

            int nilai = 0;

            if (minimalKarakter) nilai++;
            if (hurufBesarKecil) nilai++;
            if (angka) nilai++;
            if (simbol) nilai++;
            if (berbeda) nilai++;

            prgKekuatan.Value = nilai;
        }

        private void AturIndikator(
            Label label,
            bool terpenuhi,
            string keterangan)
        {
            label.Text = (terpenuhi ? "✓ " : "○ ") + keterangan;

            label.ForeColor = terpenuhi
                ? Color.SeaGreen
                : Color.FromArgb(90, 110, 110);
        }

        private void btnSimpan_Click(object? sender, EventArgs e)
        {
            string passwordLama = txtLama.Text;
            string passwordBaru = txtBaru.Text;
            string konfirmasi = txtKonfirmasi.Text;

            if (string.IsNullOrWhiteSpace(passwordLama))
            {
                MessageBox.Show("Masukkan password lama.");
                txtLama.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(passwordBaru))
            {
                MessageBox.Show("Masukkan password baru.");
                txtBaru.Focus();
                return;
            }

            if (passwordBaru != konfirmasi)
            {
                MessageBox.Show(
                    "Konfirmasi password tidak sesuai.",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtKonfirmasi.Focus();
                txtKonfirmasi.SelectAll();
                return;
            }

            if (prgKekuatan.Value < 5)
            {
                MessageBox.Show(
                    "Password baru belum memenuhi semua persyaratan.",
                    "Password Belum Memenuhi Syarat",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtBaru.Focus();
                return;
            }

            DialogResult konfirmasiSimpan = MessageBox.Show(
                "Apakah kamu yakin ingin mengganti password akun ini?",
                "Konfirmasi Ganti Password",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (konfirmasiSimpan != DialogResult.Yes)
                return;

            bool berhasil = UserStore.GantiPasswordSendiri(
                usernameKasir,
                passwordLama,
                passwordBaru,
                out string pesan);

            if (!berhasil)
            {
                MessageBox.Show(
                    pesan,
                    "Gagal Mengganti Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            MessageBox.Show(
                pesan,
                "Berhasil",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            BersihkanInput();
            MuatInformasiAkun();
        }

        private void btnBersihkan_Click(object? sender, EventArgs e)
        {
            DialogResult hasil = MessageBox.Show(
                "Apakah kamu yakin ingin mengosongkan semua input password?",
                "Konfirmasi Bersihkan",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (hasil != DialogResult.Yes)
                return;

            BersihkanInput();
        }

        private void BersihkanInput()
        {
            txtLama.Clear();
            txtBaru.Clear();
            txtKonfirmasi.Clear();

            prgKekuatan.Value = 0;

            PeriksaKekuatanPassword();

            txtLama.Focus();
        }


        private void lblKembaliKeKasir_Click(object? sender, EventArgs e)
        {
            if (dashboardAsal != null)
            {
                dashboardAsal.Show();
                dashboardAsal.BringToFront();
            }

            Form? formAkun = this.FindForm();

            if (formAkun != null)
            {
                formAkun.Hide();
            }
        }

        public void AturDashboard(Dashboard_kasir dashboard)
        {
            dashboardAsal = dashboard;
        }
    }
}
