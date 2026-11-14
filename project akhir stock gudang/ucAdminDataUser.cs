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
        private bool modeEditPengguna = false;
        private bool modePersetujuan = false;
        private List<UserAccount> semuaDataPengguna = new List<UserAccount>();
        private string emailPenggunaTerpilih = "";
        public ucAdminDataUser()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            ConfigureProgressBar();
            SiapkanFilter();
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
        private void FilterPermintaan()
        {
            string kataKunci = txtCariP.Text.Trim();
            string role = cmbRoleP.Text;

            dgvPermintaan.Rows.Clear();

            var hasil = semuaDataPengguna
                .Where(u => u.Status == UserStore.Menunggu)
                .Where(u =>
                    (u.Username ?? "").Contains(
                        kataKunci, StringComparison.OrdinalIgnoreCase) ||
                    (u.Email ?? "").Contains(
                        kataKunci, StringComparison.OrdinalIgnoreCase))
                .Where(u =>
                    role == "Semua Role" ||
                    string.IsNullOrWhiteSpace(role) ||
                    u.Role == role)
                .ToList();

            foreach (var user in hasil)
            {
                int index = dgvPermintaan.Rows.Add();

                dgvPermintaan.Rows[index].Cells["colUsernameP"].Value = user.Username;
                dgvPermintaan.Rows[index].Cells["colEmailP"].Value = user.Email;
                dgvPermintaan.Rows[index].Cells["colRoleP"].Value = user.Role;
                dgvPermintaan.Rows[index].Cells["colTanggalP"].Value =
                    user.TanggalDaftar.ToString("dd/MM/yyyy");

                dgvPermintaan.Rows[index].Cells["colSetujui"].Value = "ACC";
                dgvPermintaan.Rows[index].Cells["colTolak"].Value = "Tolak";
            }
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

            btnBatal.Click -= btnBatal_Click;
            btnBatal.Click += btnBatal_Click;

            btnSetujui.Click -= btnSetujui_Click_1;
            btnSetujui.Click += btnSetujui_Click_1;

            txtPassword.TextChanged -= txtPassword_TextChanged;
            txtPassword.TextChanged += txtPassword_TextChanged;

            dgvPermintaan.CellClick -= dgvPermintaan_CellClick;
            dgvPermintaan.CellClick += dgvPermintaan_CellClick;

            dgvPermintaan.CellContentClick -= dgvPermintaan_CellContentClick;
            dgvPermintaan.CellContentClick += dgvPermintaan_CellContentClick;

            dgvSemua.CellClick -= dgvSemua_CellClick;
            dgvSemua.CellClick += dgvSemua_CellClick;

            dgvSemua.CellContentClick -= dgvSemua_CellContentClick;
            dgvSemua.CellContentClick += dgvSemua_CellContentClick;

            dgvSemua.CellFormatting -= dgvSemua_CellFormatting;
            dgvSemua.CellFormatting += dgvSemua_CellFormatting;

            btnGenerate.Click -= btnGenerate_Click_1;
            btnGenerate.Click += btnGenerate_Click_1;

            txtCariP.TextChanged -= txtCariPermintaan_TextChanged;
            txtCariP.TextChanged += txtCariPermintaan_TextChanged;

            cmbRoleP.SelectedIndexChanged -= cmbFilterRolePermintaan_SelectedIndexChanged;
            cmbRoleP.SelectedIndexChanged += cmbFilterRolePermintaan_SelectedIndexChanged;

            txtCariS.TextChanged -= txtCariSemua_TextChanged;
            txtCariS.TextChanged += txtCariSemua_TextChanged;

            cmbRoleS.SelectedIndexChanged -= cmbFilterRoleSemua_SelectedIndexChanged;
            cmbRoleS.SelectedIndexChanged += cmbFilterRoleSemua_SelectedIndexChanged;

            cmbRole.SelectedIndexChanged -= cmbFilterStatus_SelectedIndexChanged;
            cmbRole.SelectedIndexChanged += cmbFilterStatus_SelectedIndexChanged;

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
        private void txtCariPermintaan_TextChanged(object sender, EventArgs e)
        {
            FilterPermintaan();
        }

        private void cmbFilterRolePermintaan_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterPermintaan();
        }

        private void txtCariSemua_TextChanged(object sender, EventArgs e)
        {
            FilterSemuaPengguna();
        }

        private void cmbFilterRoleSemua_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterSemuaPengguna();
        }

        private void cmbFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterSemuaPengguna();
        }

        private void AturModeBuatAkun()
        {
            modeEditPengguna = false;
            modePersetujuan = false;

            emailPenggunaTerpilih = "";
            emailTerpilih = "";

            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();

            txtEmail.ReadOnly = false;
            txtUsername.ReadOnly = false;

            cmbRole.Enabled = true;

            if (cmbRole.Items.Count > 0)
                cmbRole.SelectedIndex = 0;

            btnSetujui.Text = "Setujui & buat akun";

            prgKekuatan.Value = 0;

            dgvPermintaan.ClearSelection();
            dgvSemua.ClearSelection();

            PerbaruiKekuatanPassword();
        }


        private void TampilkanDataPenggunaPadaPanel(UserAccount user)
        {
            txtEmail.Text = user.Email;
            txtUsername.Text = user.Username;
            txtPassword.Clear();

            cmbRole.SelectedItem = user.Role;

            txtEmail.ReadOnly = true;
            txtUsername.ReadOnly = true;

            cmbRole.Enabled = false;

            PerbaruiKekuatanPassword();
        }

        private void FilterSemuaPengguna()
        {
            string kataKunci = txtCariS.Text.Trim();
            string role = cmbRoleS.Text;
            string statusFilter = cmbRole.Text;

            dgvSemua.Rows.Clear();

            var hasil = semuaDataPengguna
                .Where(u => u.Status != UserStore.Menunggu)
                .Where(u =>
                    (u.Username ?? "").Contains(
                        kataKunci,
                        StringComparison.OrdinalIgnoreCase) ||

                    (u.Email ?? "").Contains(
                        kataKunci,
                        StringComparison.OrdinalIgnoreCase))
                .Where(u =>
                    role == "Semua Role" ||
                    string.IsNullOrWhiteSpace(role) ||
                    u.Role == role)
                .Where(u =>
                    statusFilter == "Semua Status" ||
                    string.IsNullOrWhiteSpace(statusFilter) ||
                    u.Status == statusFilter)
                .ToList();

            foreach (var user in hasil)
            {
                int index = dgvSemua.Rows.Add();

                dgvSemua.Rows[index].Cells["colUsernameS"].Value =
                    user.Username;

                dgvSemua.Rows[index].Cells["colEmailS"].Value =
                    user.Email;

                dgvSemua.Rows[index].Cells["colRoleS"].Value =
                    user.Role;

                dgvSemua.Rows[index].Cells["status"].Value =
                    user.Status;

            

                dgvSemua.Rows[index].Cells["btnBanned"].Value =
                    user.Status == UserStore.Diblokir
                        ? "Aktifkan"
                        : "Banned";
            }
        }

        private void SiapkanFilter()
        {

            cmbRoleP.Items.Clear();
            cmbRoleP.Items.Add("Semua Role");

            foreach (var item in cmbRole.Items)
            {
                string role = item?.ToString() ?? "";

                if (!string.IsNullOrWhiteSpace(role) &&
                    !cmbRoleP.Items.Contains(role))
                {
                    cmbRoleP.Items.Add(role);
                }
            }

            cmbRoleP.SelectedIndex = 0;



            cmbRoleS.Items.Clear();
            cmbRoleS.Items.Add("Semua Role");

            foreach (var item in cmbRole.Items)
            {
                string role = item?.ToString() ?? "";

                if (!string.IsNullOrWhiteSpace(role) &&
                    !cmbRoleS.Items.Contains(role))
                {
                    cmbRoleS.Items.Add(role);
                }
            }

            cmbRoleS.SelectedIndex = 0;



            cmbRole.Items.Clear();
            cmbRole.Items.Add("Semua Status");
            cmbRole.Items.Add(UserStore.Aktif);
            cmbRole.Items.Add(UserStore.Diblokir);

            cmbRole.SelectedIndex = 0;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();

            prgKekuatan.Value = 0;




            AturModeBuatAkun();

            MessageBox.Show(
                "Form berhasil dikosongkan.",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
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
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string namaKolom = dgvPermintaan.Columns[e.ColumnIndex].Name;

            if (namaKolom != "colSetujui" && namaKolom != "colTolak")
                return;

            string email = dgvPermintaan.Rows[e.RowIndex]
                .Cells["colEmailP"].Value?.ToString() ?? "";

            if (string.IsNullOrWhiteSpace(email))
                return;

            if (namaKolom == "colSetujui")
            {
                emailTerpilih = email;
                modePersetujuan = true;
                modeEditPengguna = false;

                txtPassword.Clear();

                MessageBox.Show(
                    "Masukkan atau generate password untuk akun ini."
                );

                return;
            }

            if (namaKolom == "colTolak")
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
                        modePersetujuan = false;
                        txtPassword.Clear();
                        TampilkanDataUser();
                    }
                }
            }
        }


        private void dgvSemua_CellContentClick(
       object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            
            if (dgvSemua.Columns[e.ColumnIndex].Name != "btnBanned")
                return;

            string email = dgvSemua.Rows[e.RowIndex]
                .Cells["colEmailS"].Value?.ToString() ?? "";

            if (string.IsNullOrWhiteSpace(email))
                return;

            string status = dgvSemua.Rows[e.RowIndex]
                .Cells["status"].Value?.ToString() ?? "";

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
                bool berhasil = UserStore.ToggleBan(
                    email, out string pesan);

                MessageBox.Show(pesan);

                if (berhasil)
                {
                    TampilkanDataUser();
                    AturModeBuatAkun();
                }
            }
        }


        private void TampilkanDataUser()
        {

            semuaDataPengguna = UserStore.GetAll();


            PerbaruiRingkasan();


            FilterPermintaan();
            FilterSemuaPengguna();
        }



        private void btnGenerate_Click_1(object sender, EventArgs e)
        {
            txtPassword.Text = PasswordTools.GeneratePassword(12);
            PerbaruiKekuatanPassword();
        }

        private void btnSetujui_Click_1(object sender, EventArgs e)
        {

            string password = txtPassword.Text;


            if (modeEditPengguna)
            {
                DialogResult konfirmasi = MessageBox.Show(
                    "Apakah kamu yakin ingin mengubah password pengguna ini?",
                    "Konfirmasi Perubahan Password",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (konfirmasi != DialogResult.Yes)
                    return;

                bool berhasil = UserStore.UpdatePassword(
                    emailPenggunaTerpilih,
                    password,
                    out string pesan
                );

                MessageBox.Show(pesan);

                if (berhasil)
                {
                    TampilkanDataUser();
                    AturModeBuatAkun();
                }

                return;
            }



            if (modePersetujuan)
            {
                if (string.IsNullOrWhiteSpace(emailTerpilih))
                {
                    MessageBox.Show("Pilih pendaftaran terlebih dahulu.");
                    return;
                }

                bool berhasil = UserStore.ApproveAccount(
                    emailTerpilih,
                    password,
                    out string pesan
                );

                MessageBox.Show(pesan);

                if (berhasil)
                {
                    TampilkanDataUser();
                    AturModeBuatAkun();
                }

                return;
            }



            bool akunBerhasil = UserStore.CreateActiveAccount(
                txtUsername.Text,
                txtEmail.Text,
                cmbRole.Text,
                password,
                out string pesanAkun
            );

            MessageBox.Show(pesanAkun);

            if (akunBerhasil)
            {
                TampilkanDataUser();
                AturModeBuatAkun();
            }
        }


        private void dgvSemua_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvSemua.Columns[e.ColumnIndex].Name != "btnBanned")
                return;

            string status = dgvSemua.Rows[e.RowIndex]
                  .Cells["status"].Value?.ToString() ?? "";

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

        private void dgvSemua_CellClick(
       object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;


            if (dgvSemua.Columns[e.ColumnIndex].Name == "btnBanned")
                return;

            string email = dgvSemua.Rows[e.RowIndex]
                .Cells["colEmailS"].Value?.ToString() ?? "";

            if (string.IsNullOrWhiteSpace(email))
                return;


            UserAccount? user = UserStore.GetAll()
                .FirstOrDefault(u =>
                    string.Equals(
                        u.Email,
                        email,
                        StringComparison.OrdinalIgnoreCase));

            if (user == null)
            {
                MessageBox.Show("Data pengguna tidak ditemukan.");
                return;
            }

            modeEditPengguna = true;
            modePersetujuan = false;

            emailPenggunaTerpilih = user.Email;
            emailTerpilih = "";


            TampilkanDataPenggunaPadaPanel(user);


            btnSetujui.Text = "Simpan perubahan";


            dgvPermintaan.ClearSelection();
        }

        private void ucAdminDataUser_Load(object sender, EventArgs e)
        {

        }
    }
}
