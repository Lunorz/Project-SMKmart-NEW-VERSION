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
    public partial class ucAkunSaya : UserControl
    {
        private readonly string emailAktif;
        private readonly string usernameAktif;
        private readonly string roleAktif;

        private bool syaratPanjang;
        private bool syaratHuruf;
        private bool syaratAngka;
        private bool syaratSimbol;
        private bool syaratBerbeda;
        public ucAkunSaya(string username, string email, string role)
        {
            InitializeComponent();
            emailAktif = email;
            usernameAktif = username;
            roleAktif = role;

            AturTampilanAwal();
            HubungkanEvent();
            TampilkanInformasiAkun();
            PeriksaPassword();
        }

        private void AturTampilanAwal()
        {
            txtLama.UseSystemPasswordChar = true;
            txtBaru.UseSystemPasswordChar = true;
            txtKonfirmasi.UseSystemPasswordChar = true;

            txtUsername.ReadOnly = true;
            txtRoleInfo.ReadOnly = true;
            txtLogin.ReadOnly = true;
            txtGamti.ReadOnly = true;

            prgKekuatan.Minimum = 0;
            prgKekuatan.Maximum = 5;
            prgKekuatan.Value = 0;

            btnSimpan.Enabled = false;
        }

        private void HubungkanEvent()
        {
            txtLama.TextChanged -= Password_TextChanged;
            txtBaru.TextChanged -= Password_TextChanged;
            txtKonfirmasi.TextChanged -= Password_TextChanged;

            txtLama.TextChanged += Password_TextChanged;
            txtBaru.TextChanged += Password_TextChanged;
            txtKonfirmasi.TextChanged += Password_TextChanged;

            btnSimpan.Click -= btnSimpan_Click;
            btnBersihkan.Click -= btnBersihkan_Click;

            btnSimpan.Click += btnSimpan_Click;
            btnBersihkan.Click += btnBersihkan_Click;
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            PeriksaPassword();
        }

        private void PeriksaPassword()
        {
            string lama = txtLama.Text;
            string baru = txtBaru.Text;
            string konfirmasi = txtKonfirmasi.Text;

            syaratPanjang = baru.Length >= 8;

            syaratHuruf =
                baru.Any(char.IsUpper) &&
                baru.Any(char.IsLower);

            syaratAngka = baru.Any(char.IsDigit);

            syaratSimbol =
                baru.Any(c => !char.IsLetterOrDigit(c));

            syaratBerbeda =
                !string.IsNullOrEmpty(lama) &&
                !string.IsNullOrEmpty(baru) &&
                lama != baru;

            AturIndikator(
                lblS1,
                syaratPanjang,
                "Minimal 8 karakter"
            );

            AturIndikator(
                lblS2,
                syaratHuruf,
                "Huruf besar dan kecil"
            );

            AturIndikator(
                lblS3,
                syaratAngka,
                "Minimal satu angka"
            );

            AturIndikator(
                lblS4,
                syaratSimbol,
                "Minimal satu simbol"
            );

            AturIndikator(
                lblS5,
                syaratBerbeda,
                "Berbeda dari pw lama"
            );

            int nilai = 0;

            if (syaratPanjang) nilai++;
            if (syaratHuruf) nilai++;
            if (syaratAngka) nilai++;
            if (syaratSimbol) nilai++;
            if (syaratBerbeda) nilai++;

            prgKekuatan.Value = nilai;

            bool semuaSyarat =
                syaratPanjang &&
                syaratHuruf &&
                syaratAngka &&
                syaratSimbol &&
                syaratBerbeda;

            bool konfirmasiCocok =
                !string.IsNullOrEmpty(konfirmasi) &&
                baru == konfirmasi;

            btnSimpan.Enabled =
                semuaSyarat &&
                konfirmasiCocok &&
                !string.IsNullOrWhiteSpace(lama);
        }

        private void AturIndikator(
            Label label,
            bool terpenuhi,
            string keterangan)
        {
            label.Text =
                (terpenuhi ? "✓ " : "○ ") + keterangan;

            label.ForeColor = terpenuhi
                ? Color.SeaGreen
                : Color.FromArgb(75, 105, 95);
        }

        private void TampilkanInformasiAkun()
        {
            txtUsername.Text = usernameAktif;
            txtRoleInfo.Text = roleAktif;

            DateTime? login = null;
            DateTime? ganti = null;

            if (roleAktif == "Admin")
            {
                login = AdminPasswordStore.GetTerakhirLogin();
                ganti = AdminPasswordStore.GetTerakhirGantiPassword();
            }
            else if (roleAktif == "Gudang")
            {
                UserAccount? akun = UserStore.GetAll()
                    .FirstOrDefault(u =>
                        string.Equals(
                            u.Email,
                            emailAktif,
                            StringComparison.OrdinalIgnoreCase
                        )
                    );

                if (akun != null)
                {
                    login = akun.TerakhirLogin;
                    ganti = akun.TerakhirGantiPassword;
                }
            }

            txtLogin.Text = login.HasValue
                ? login.Value.ToString("dd MMMM yyyy, HH:mm:ss")
                : "Belum tersedia";

            txtGamti.Text = ganti.HasValue
                ? ganti.Value.ToString("dd MMMM yyyy, HH:mm:ss")
                : "Belum pernah";
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
          
            DialogResult hasil = MessageBox.Show(
                "Apakah Anda yakin ingin mengganti password akun ini?",
                "Konfirmasi Ganti Password",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (hasil == DialogResult.Yes)
            {
                PeriksaPassword();

                if (!btnSimpan.Enabled)
                {
                    MessageBox.Show(
                        "Periksa kembali semua kriteria password dan konfirmasi password.",
                        "Peringatan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                bool berhasil;
                string pesan;

                try
                {
                    if (roleAktif == "Admin")
                    {
                        berhasil = AdminPasswordStore.GantiPassword(
                            txtLama.Text,
                            txtBaru.Text,
                            out pesan
                        );
                    }
                    else if (roleAktif == "Gudang")
                    {
                        berhasil = UserStore.GantiPasswordSendiri(
                            emailAktif,
                            txtLama.Text,
                            txtBaru.Text,
                            out pesan
                        );
                    }
                    else
                    {
                        MessageBox.Show(
                            "Role akun belum didukung.",
                            "Peringatan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );

                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Terjadi kesalahan saat mengubah password:\n" +
                        ex.Message,
                        "Kesalahan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return;
                }

                if (!berhasil)
                {
                    MessageBox.Show(
                        pesan,
                        "Gagal mengubah password",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                try
                {
                    LogAktivitasJsonStore.Catat(
                        emailAktif,
                        roleAktif == "Gudang"
                            ? "Pengelola Gudang"
                            : "Admin",
                        "Akun",
                        "Mengubah password",
                        emailAktif,
                        "Pengguna berhasil mengubah password akun sendiri."
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Password berhasil diubah, tetapi log aktivitas gagal dicatat:\n" +
                        ex.Message,
                        "Peringatan Log",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }

                MessageBox.Show(
                    pesan,
                    "Berhasil",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                BersihkanForm();
                TampilkanInformasiAkun();
            }

          
        
       
        }

        private void BersihkanForm()
        {
            txtLama.Clear();
            txtBaru.Clear();
            txtKonfirmasi.Clear();

            PeriksaPassword();

            txtLama.Focus();
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            DialogResult Beersihkan = MessageBox.Show(
           "Apakah Anda yakin ingin mengganti password akun ini?",
            "Konfirmasi Ganti Password",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Warning
            );

            if (Beersihkan == DialogResult.No)
            {
                BersihkanForm();

                MessageBox.Show(
                    "Form berhasil dibersihkan.",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            
        }
    }
}
