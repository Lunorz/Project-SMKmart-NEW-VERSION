namespace project_akhir_stock_gudang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UiTheme.ApplyAuthDecoration(panel1, pictureBox1);
        }

        public Form1(string username)
        {
            InitializeComponent();
            this.AcceptButton = tombol_login;
            UiTheme.ApplyAuthDecoration(panel1, pictureBox1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lihat_password_CheckedChanged(object sender, EventArgs e)
        {
            if (lihat_password.Checked)
            {
                textpassword.UseSystemPasswordChar = false;
            }
            else
            {
                textpassword.UseSystemPasswordChar = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tombol_batal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tombol_login_Click(object sender, EventArgs e)
        {
            string username = textusername.Text.Trim();
            string password = textpassword.Text;

          
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                CatatLogLogin(
                    username,
                    "Tidak diketahui",
                    "Login gagal",
                    "Username atau password belum diisi."
                );

                MessageBox.Show(
                    "Username dan password wajib diisi!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (username.Equals(
            "admin",
            StringComparison.OrdinalIgnoreCase))
            {
                bool loginAdmin = false;

                try
                {
                    loginAdmin = AdminPasswordStore.TryLogin(
                        username,
                        password
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Gagal membaca data akun Admin:\n" + ex.Message,
                        "Kesalahan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return;
                }

                if (loginAdmin)
                {
                    CatatLogLogin(
                        username,
                        "Admin",
                        "Login berhasil",
                        "Admin berhasil masuk ke aplikasi."
                    );

                    MessageBox.Show(
                        "Login admin berhasil.",
                        "Informasi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    MainFormAdmin admin = new MainFormAdmin(username);
                    admin.Show();

                    this.Hide();
                    return;
                }

                CatatLogLogin(
                    username,
                    "Admin",
                    "Login gagal",
                    "Password Admin salah."
                );

                MessageBox.Show(
                    "Username atau password Admin salah.",
                    "Login gagal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }


            bool berhasil = UserStore.TryLogin(
                username,
                password,
                out UserAccount? akun,
                out string pesan
            );

            if (!berhasil)
            {
                CatatLogLogin(
                    username,
                    "Tidak diketahui",
                    "Login gagal",
                    pesan
                );

                MessageBox.Show(
                    pesan,
                    "Login gagal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (akun == null)
            {
                CatatLogLogin(
                    username,
                    "Tidak diketahui",
                    "Login gagal",
                    "Data akun tidak ditemukan."
                );

                MessageBox.Show("Data akun tidak ditemukan.");
                return;
            }

            CatatLogLogin(
                username,
                akun.Role,
                "Login berhasil",
                "Pengguna berhasil masuk ke aplikasi."
            );

            MessageBox.Show(
                $"Login berhasil sebagai {akun.Role}.",
                "Login berhasil",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            if (akun.Role == "Kasir")
            {
                Dashboard_kasir dashboard =
                    new Dashboard_kasir(
                        new List<DetailTransaksi>(),
                        akun.Username
                    );

                dashboard.Show();
                this.Hide();
            }
            else if (akun.Role == "Gudang")
            {
                MainFormGudang dashboard =
                    new MainFormGudang(akun.Username);

                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Role akun tidak dikenali.");
            }

                 
        }
      
        

      
        private void CatatLogLogin(
            string pengguna,
            string role,
            string aktivitas,
            string keterangan)
        {
            try
            {
                LogAktivitasJsonStore.Catat(
                    pengguna,
                    role,
                    "Akses",
                    aktivitas,
                    pengguna,
                    keterangan
                );

               
            
            }

            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menyimpan log aktivitas.\n\n" + ex.Message,
                    "Kesalahan Log",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textnama_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
