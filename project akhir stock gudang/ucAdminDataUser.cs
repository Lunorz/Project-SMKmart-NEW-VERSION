using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_akhir_stock_gudang
{
    public partial class ucAdminDataUser : UserControl
    {
        private string selectedEmail = "";

        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
        private static extern int SetWindowTheme(IntPtr hWnd, string appName, string idList);
        private string emailTerpilih = "";
        public ucAdminDataUser()
        {
            InitializeComponent();
            ConfigureProgressBar();
            ConnectEvents();

            UpdateStrength();

            TampilkanDataUser();
        }
        private void ConfigureProgressBar()
        {
            prgKekuatan.Minimum = 0;
            prgKekuatan.Maximum = 4;
            prgKekuatan.Value = 0;
            prgKekuatan.Style = ProgressBarStyle.Continuous;
        }
        private void UpdateStrength()
        {
            int level = PasswordTools.GetStrengthLevel(txtPassword.Text);

            prgKekuatan.Value = level;
        }
        private void RefreshData()
        {
            TampilkanDataUser();
        }
        private void ConnectEvents()
        {
            btnGenerate.Click -= btnGenerate_Click;
            btnGenerate.Click += btnGenerate_Click;

            btnBatal.Click -= btnBatal_Click;
            btnBatal.Click += btnBatal_Click;

            btnSetujui.Click -= btnSetujui_Click;
            btnSetujui.Click += btnSetujui_Click;

            txtPassword.TextChanged -= txtPassword_TextChanged;
            txtPassword.TextChanged += txtPassword_TextChanged;

            dgvPermintaan.CellClick -= dgvPermintaan_CellClick;
            dgvPermintaan.CellClick += dgvPermintaan_CellClick;

            dgvPermintaan.CellContentClick -= dgvPermintaan_CellContentClick;
            dgvPermintaan.CellContentClick += dgvPermintaan_CellContentClick;

            dgvSemua.CellContentClick -= dgvSemua_CellContentClick;
            dgvSemua.CellContentClick += dgvSemua_CellContentClick;

            dgvSemua.CellFormatting -= dgvSemua_CellFormatting;
            dgvSemua.CellFormatting += dgvSemua_CellFormatting;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            const string hurufBesar = "ABCDEFGHJKLMNPQRSTUVWXYZ";
            const string hurufKecil = "abcdefghijkmnopqrstuvwxyz";
            const string angka = "23456789";
            const string simbol = "!@#$%";

            string semuaKarakter = hurufBesar + hurufKecil + angka + simbol;

            Random random = new Random();

            string password = "";


            password += hurufBesar[random.Next(hurufBesar.Length)];
            password += hurufKecil[random.Next(hurufKecil.Length)];
            password += angka[random.Next(angka.Length)];
            password += simbol[random.Next(simbol.Length)];


            for (int i = 0; i < 8; i++)
            {
                password += semuaKarakter[random.Next(semuaKarakter.Length)];
            }


            password = new string(password.OrderBy(x => random.Next()).ToArray());

            txtPassword.Text = password;
            CekKekuatanPassword();
        }
        private void CekKekuatanPassword()
        {
            string password = txtPassword.Text;

            int skor = 0;

            if (password.Length >= 8)
                skor++;

            if (password.Any(char.IsUpper))
                skor++;

            if (password.Any(char.IsLower))
                skor++;

            if (password.Any(char.IsDigit))
                skor++;

            if (password.Any(c => !char.IsLetterOrDigit(c)))
                skor++;

            prgKekuatan.Maximum = 4;

            if (password.Length == 0)
            {
                prgKekuatan.Value = 0;


            }
            else if (skor <= 2)
            {
                prgKekuatan.Value = 1;


            }
            else if (skor == 3)
            {
                prgKekuatan.Value = 2;


            }
            else if (skor == 4)
            {
                prgKekuatan.Value = 3;


            }
            else
            {
                prgKekuatan.Value = 4;


            }
        }


        private void btnBatal_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();

            prgKekuatan.Value = 0;



            dgvPermintaan.ClearSelection();

            MessageBox.Show(
                "Proses persetujuan dibatalkan.",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            PerbaruiKekuatanPassword();
        }



        private void btnSetujui_Click(object sender, EventArgs e)
        {

        }


        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            CekKekuatanPassword();
            PerbaruiKekuatanPassword();
        }


        private void dgvPermintaan_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            emailTerpilih = dgvPermintaan.Rows[e.RowIndex]
                .Cells["colEmailP"].Value?.ToString() ?? "";

            if (string.IsNullOrWhiteSpace(emailTerpilih))
                return;

            txtPassword.Clear();
        }

        private void dgvPermintaan_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex < 0)
                    return;

                string email = dgvPermintaan.Rows[e.RowIndex]
                    .Cells["colEmailP"].Value?.ToString() ?? "";

                if (string.IsNullOrWhiteSpace(email))
                    return;

                string namaKolom = dgvPermintaan.Columns[e.ColumnIndex].Name;


                if (namaKolom == "colSetujui")
                {
                    emailTerpilih = email;

                    if (string.IsNullOrWhiteSpace(txtPassword.Text))
                    {
                        MessageBox.Show("Masukkan atau generate password terlebih dahulu.");
                        return;
                    }

                    bool berhasil = UserStore.ApproveAccount(
                        emailTerpilih,
                        txtPassword.Text,
                        out string pesan
                    );

                    MessageBox.Show(pesan);

                    if (berhasil)
                    {
                        emailTerpilih = "";
                        txtPassword.Clear();
                        TampilkanDataUser();
                    }
                }

                
                else if (namaKolom == "colTolak")
                {
                    DialogResult hasil = MessageBox.Show(
                        "Apakah kamu yakin ingin menolak pendaftaran ini?",
                        "Konfirmasi Penolakan",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (hasil == DialogResult.Yes)
                    {
                        bool berhasil = UserStore.RejectAccount(
                            email,
                            out string pesan
                        );

                        MessageBox.Show(pesan);

                        if (berhasil)
                        {
                            emailTerpilih = "";
                            txtPassword.Clear();
                            TampilkanDataUser();
                        }
                    }
                }

            }
        }


        private void dgvSemua_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvSemua.Columns[e.ColumnIndex].Name != "btnBanned")
                return;

            string email = dgvSemua.Rows[e.RowIndex]
                .Cells["colEmailS"].Value?.ToString() ?? "";

            if (string.IsNullOrWhiteSpace(email))
                return;

            string status = dgvSemua.Rows[e.RowIndex]
                .Cells["Status"].Value?.ToString() ?? "";

            string konfirmasi = status == UserStore.Aktif
                ? "Apakah kamu yakin ingin memblokir akun ini?"
                : "Apakah kamu yakin ingin mengaktifkan kembali akun ini?";

            DialogResult hasil = MessageBox.Show(
                konfirmasi,
                "Konfirmasi Akun",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (hasil == DialogResult.Yes)
            {
                bool berhasil = UserStore.ToggleBan(email, out string pesan);

                MessageBox.Show(pesan);

                if (berhasil)
                {
                    TampilkanDataUser();
                }
            }
        }


        private void TampilkanDataUser()
        {
            List<UserAccount> semuaUser = UserStore.GetAll();


            dgvPermintaan.Rows.Clear();

            foreach (UserAccount user in semuaUser)
            {
                if (user.Status == UserStore.Menunggu)
                {
                    dgvPermintaan.Rows.Add(
                        user.Username,
                        user.Email,
                        user.Role,
                        user.TanggalDaftar.ToString("dd/MM/yyyy")
                    );
                }
                PerbaruiRingkasan();
            }


            dgvSemua.Rows.Clear();

            foreach (UserAccount user in semuaUser)
            {
                if (user.Status != UserStore.Menunggu)
                {
                    dgvSemua.Rows.Add(
                        user.Username,
                        user.Email,
                        user.Role,
                        user.Status,
                        user.TanggalDaftar.ToString("dd/MM/yyyy")
                    );
                }
            }
        }

        private void btnGenerate_Click_1(object sender, EventArgs e)
        {
            txtPassword.Text = PasswordTools.GeneratePassword(12);
            PerbaruiKekuatanPassword();
        }

        private void btnSetujui_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emailTerpilih))
            {
                MessageBox.Show("Pilih permintaan pendaftaran terlebih dahulu.");
                return;
            }

            bool berhasil = UserStore.ApproveAccount(
                emailTerpilih,
                txtPassword.Text,
                out string pesan
            );

            MessageBox.Show(pesan);

            if (berhasil)
            {
                emailTerpilih = "";
                txtPassword.Clear();
                TampilkanDataUser();
            }
        }

        private void dgvSemua_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvSemua.Columns[e.ColumnIndex].Name != "btnBanned")
                return;

            string status = dgvSemua.Rows[e.RowIndex]
                .Cells["Status"].Value?.ToString() ?? "";

            if (status == UserStore.Aktif)
            {
                e.Value = "Banned";
            }
            else if (status == UserStore.Diblokir)
            {
                e.Value = "Aktifkan";
            }
        }
        private void PerbaruiRingkasan()
        {
            List<UserAccount> users = UserStore.GetAll();

            int totalPengguna = users.Count(u =>
                u.Status == UserStore.Menunggu ||
                u.Status == UserStore.Aktif ||
                u.Status == UserStore.Diblokir);

            int menunggu = users.Count(u =>
                u.Status == UserStore.Menunggu);

            int aktif = users.Count(u =>
                u.Status == UserStore.Aktif);

            int banned = users.Count(u =>
                u.Status == UserStore.Diblokir);

            lblTotal.Text = totalPengguna.ToString();
            lblMenunggu.Text = menunggu.ToString();
            lblAktif.Text = aktif.ToString();
            lblBanned.Text = banned.ToString();
        }
        private void PerbaruiKekuatanPassword()
        {
            string password = txtPassword.Text;

            int level = PasswordTools.GetStrengthLevel(password);

            prgKekuatan.Value = level;

            switch (level)
            {
                case 0:
                    prgKekuatan.ForeColor = Color.Gray;
                    break;

                case 1:
                    prgKekuatan.ForeColor = Color.Red;
                    break;

                case 2:
                    prgKekuatan.ForeColor = Color.Orange;
                    break;

                case 3:
                    prgKekuatan.ForeColor = Color.Gold;
                    break;

                case 4:
                    prgKekuatan.ForeColor = Color.Green;
                    break;
            }
        }

    
    }
}
