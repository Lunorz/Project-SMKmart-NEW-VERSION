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
        private string selectedUsername = "";

        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
        private static extern int SetWindowTheme(IntPtr hWnd, string appName, string idList);
        private string usernameTerpilih = "";
        private bool modeEditPengguna = false;
        private List<UserAccount> semuaDataPengguna = new List<UserAccount>();
        private string usernamePenggunaTerpilih = "";

        private const string AdminLog = "admin";



        public ucAdminDataUser()
        {
            InitializeComponent();
            UiTheme.Apply(this);

            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            ConfigureProgressBar();
            SiapkanFilter();
            ConnectEvents();
            UpdateStrength();
            TampilkanDataUser();
            this.KeyDown += ucAdminDataUser_KeyDown;

        }
        private void CatatLogAkun(
           string aktivitas,
           string target,
           string keterangan)
        {
            try
            {
                LogAktivitasJsonStore.Catat(
                    AdminLog,
                    "Admin",
                    "Akun",
                    aktivitas,
                    target,
                    keterangan
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Operasi akun berhasil, tetapi log gagal disimpan.\n\n" +
                    ex.Message,
                    "Peringatan Log",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
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

            btnBatal.Click -= btnBatal_Click;
            btnBatal.Click += btnBatal_Click;

            btnSetujui.Click -= btnSetujui_Click_1;
            btnSetujui.Click += btnSetujui_Click_1;

            txtPassword.TextChanged -= txtPassword_TextChanged;
            txtPassword.TextChanged += txtPassword_TextChanged;

            dgvSemua.CellClick -= dgvSemua_CellClick;
            dgvSemua.CellClick += dgvSemua_CellClick;

            dgvSemua.CellContentClick -= dgvSemua_CellContentClick;
            dgvSemua.CellContentClick += dgvSemua_CellContentClick;

            dgvSemua.CellFormatting -= dgvSemua_CellFormatting;
            dgvSemua.CellFormatting += dgvSemua_CellFormatting;

            btnGenerate.Click -= btnGenerate_Click_1;
            btnGenerate.Click += btnGenerate_Click_1;

            txtCariS.TextChanged -= txtCariSemua_TextChanged;
            txtCariS.TextChanged += txtCariSemua_TextChanged;

            cmbRoleS.SelectedIndexChanged -= cmbFilterRoleSemua_SelectedIndexChanged;
            cmbRoleS.SelectedIndexChanged += cmbFilterRoleSemua_SelectedIndexChanged;

            cmbRoleS.SelectedIndexChanged -= cmbFilterRoleSemua_SelectedIndexChanged;
            cmbRoleS.SelectedIndexChanged += cmbFilterRoleSemua_SelectedIndexChanged;

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
            usernamePenggunaTerpilih = "";
            usernameTerpilih = "";

            txtUsername.Clear();
            txtPassword.Clear();

            txtUsername.ReadOnly = false;

            cmbRole.Enabled = true;

            if (cmbRole.Items.Count > 0)
                cmbRole.SelectedIndex = 0;

            btnSetujui.Text = "Setujui & buat akun";

            prgKekuatan.Value = 0;

            dgvSemua.ClearSelection();

            PerbaruiKekuatanPassword();
        }


        private void TampilkanDataPenggunaPadaPanel(UserAccount user)
        {
            txtUsername.Text = user.Username;
            txtPassword.Clear();

            cmbRole.SelectedItem = user.Role;

            txtUsername.ReadOnly = true;

            cmbRole.Enabled = false;

            PerbaruiKekuatanPassword();
        }

        private void FilterSemuaPengguna()
        {
            string kataKunci = txtCariS.Text.Trim();
            string roleFilter = cmbRoleS.Text;

            dgvSemua.Rows.Clear();

            var hasil = semuaDataPengguna
                .Where(u =>
                    (u.Username ?? "").Contains(
                        kataKunci,
                        StringComparison.OrdinalIgnoreCase
                    )
                )
                .Where(u =>
                    roleFilter == "Semua Role" ||
                    string.IsNullOrWhiteSpace(roleFilter) ||
                    string.Equals(
                        u.Role,
                        roleFilter,
                        StringComparison.OrdinalIgnoreCase
                    )
                )
                .ToList();

            foreach (var user in hasil)
            {
                int index = dgvSemua.Rows.Add();

                dgvSemua.Rows[index].Cells["colUsernameS"].Value = user.Username;
                dgvSemua.Rows[index].Cells["colRoleS"].Value = user.Role;
                dgvSemua.Rows[index].Cells["status"].Value = user.Status;

                dgvSemua.Rows[index].Cells["btnBanned"].Value =
                    user.Status == UserStore.Diblokir
                        ? "Aktifkan"
                        : "Banned";
            }
        }

        private void SiapkanFilter()
        {

            cmbRole.Items.Clear();
            cmbRole.Items.Add("Kasir");
            cmbRole.Items.Add("Gudang");
            cmbRole.SelectedIndex = 0;



            cmbRoleS.Items.Clear();
            cmbRoleS.Items.Add("Semua Role");
            cmbRoleS.Items.Add("Kasir");
            cmbRoleS.Items.Add("Gudang");
            cmbRoleS.SelectedIndex = 0;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            bool adaIsi =
                !string.IsNullOrWhiteSpace(txtUsername.Text) ||
                !string.IsNullOrWhiteSpace(txtPassword.Text) ||
                modeEditPengguna ||
                false;

            if (adaIsi)
            {
                DialogResult hasil = MessageBox.Show(
                    "Apakah Anda yakin ingin membatalkan proses ini?\n\n" +
                    "Data yang sedang diisi atau perubahan yang belum disimpan " +
                    "akan dikosongkan.",
                    "Konfirmasi Pembatalan",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (hasil != DialogResult.Yes)
                    return;
            }

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


        private void dgvSemua_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dgvSemua.Columns[e.ColumnIndex].Name != "btnBanned")
                return;

            string username = dgvSemua.Rows[e.RowIndex]
                .Cells["colUsernameS"].Value?.ToString() ?? "";

            string role = dgvSemua.Rows[e.RowIndex]
                .Cells["colRoleS"].Value?.ToString() ?? "";

            if (string.IsNullOrWhiteSpace(username))
                return;

            string status = dgvSemua.Rows[e.RowIndex]
                .Cells["status"].Value?.ToString() ?? "";

            bool akanDiblokir = status == UserStore.Aktif;

            string konfirmasi = akanDiblokir
                ? "Apakah kamu yakin ingin memblokir akun ini?"
                : "Apakah kamu yakin ingin mengaktifkan kembali akun ini?";

            DialogResult hasil = MessageBox.Show(
                konfirmasi,
                "Konfirmasi Akun",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (hasil != DialogResult.Yes)
                return;

            bool berhasil = UserStore.ToggleBan(
                username,
                out string pesan
            );

            MessageBox.Show(pesan);

            if (berhasil)
            {
                if (akanDiblokir)
                {
                    CatatLogAkun(
                        "Pemblokiran akun",
                        username,
                        "Admin memblokir akun. Username: " +
                        username + ", Role: " + role
                    );
                }
                else
                {
                    CatatLogAkun(
                        "Pengaktifan akun",
                        username,
                        "Admin mengaktifkan kembali akun. Username: " +
                        username + ", Role: " + role
                    );
                }

                TampilkanDataUser();
                AturModeBuatAkun();
            }
        }



        private void TampilkanDataUser()
        {

            semuaDataPengguna = UserStore.GetAll();


            PerbaruiRingkasan();


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


                if (string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show(
                        "Password baru wajib diisi.",
                        "Peringatan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtPassword.Focus();
                    return;
                }


                bool berhasil = UserStore.UpdatePassword(
                    usernamePenggunaTerpilih,
                    password,
                    out string pesan
                );

                MessageBox.Show(pesan);

                if (berhasil)
                {

                    CatatLogAkun(
                        "Perubahan password pengguna",
                        usernamePenggunaTerpilih,
                        "Admin berhasil mengubah password akun pengguna."
                    );

                    TampilkanDataUser();
                    AturModeBuatAkun();
                }

                return;
            }


            string usernameBaru = txtUsername.Text.Trim();
            string roleBaru = cmbRole.Text;

            DialogResult konfirmasiBuat = MessageBox.Show(
            "Apakah Anda yakin ingin membuat akun baru?\n\n" +
            "Username: " + usernameBaru + "\n" +
            "Role: " + roleBaru,
            "Konfirmasi Pembuatan Akun",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (konfirmasiBuat != DialogResult.Yes)
                return;

            bool akunBerhasil = UserStore.CreateActiveAccount(
                usernameBaru,
                roleBaru,
                password,
                out string pesanAkun
            );

            MessageBox.Show(pesanAkun);

            if (akunBerhasil)
            {
                CatatLogAkun(
                    "Pembuatan akun",
                    usernameBaru,
                    "Admin membuat akun aktif secara langsung. Username: " +
                    usernameBaru +
                    ", Role: " + roleBaru
                );

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

            int totalPengguna = users.Count;

            int aktif = users.Count(u =>
                u.Status == UserStore.Aktif);

            int nonaktif = users.Count(u =>
                u.Status == UserStore.Diblokir);

            int kasir = users.Count(u =>
                string.Equals(u.Role, "Kasir", StringComparison.OrdinalIgnoreCase));

            int gudang = users.Count(u =>
                string.Equals(u.Role, "Gudang", StringComparison.OrdinalIgnoreCase));

            lblTotal.Text = totalPengguna.ToString();
            lblMenunggu.Text = $"{aktif}/{nonaktif}";
            lblAktif.Text = kasir.ToString();
            lblBanned.Text = gudang.ToString();
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

            string username = dgvSemua.Rows[e.RowIndex]
                .Cells["colUsernameS"].Value?.ToString() ?? "";

            if (string.IsNullOrWhiteSpace(username))
                return;


            UserAccount? user = UserStore.GetAll()
                .FirstOrDefault(u =>
                    string.Equals(
                        u.Username,
                        username,
                        StringComparison.OrdinalIgnoreCase));

            if (user == null)
            {
                MessageBox.Show("Data pengguna tidak ditemukan.");
                return;
            }

            modeEditPengguna = true;

            usernamePenggunaTerpilih = user.Username;
            usernameTerpilih = "";


            TampilkanDataPenggunaPadaPanel(user);


            btnSetujui.Text = "Simpan perubahan";


        }

        private void ucAdminDataUser_Load(object sender, EventArgs e)
        {

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ucAdminDataUser_KeyDown(object? sender, KeyEventArgs e)
        {

            if (e.Control && e.KeyCode == Keys.G)
            {
                e.SuppressKeyPress = true;
                btnGenerate.PerformClick();
            }
        }



        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                btnSetujui.PerformClick();
                return true;
            }
            else if (keyData == Keys.Escape)
            {
                btnBatal.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

  
    }
}
