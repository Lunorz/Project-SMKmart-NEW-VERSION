namespace project_akhir_stock_gudang
{
    public partial class Form1 : Form
    {
        private readonly string EmailAktif;
        public Form1()
        {
            InitializeComponent();
            
        }

        public Form1(string email)
        {
            InitializeComponent();
            EmailAktif = email;
            this.AcceptButton = tombol_login;
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
            string email = textemail.Text.Trim();
            string password = textpassword.Text;

          
            if (string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password))
            {
                CatatLogLogin(
                    email,
                    "Tidak diketahui",
                    "Login gagal",
                    "Email atau password belum diisi."
                );

                MessageBox.Show(
                    "Email dan password wajib diisi!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

       
            if (email == "admin@gmail.com")
            {
                if (password == "Admin758150!")
                {
                    CatatLogLogin(
                        email,
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

                    MainFormAdmin admin = new MainFormAdmin(email);
                    admin.Show();

                    this.Hide();
                    return;
                }
            }

           
            bool berhasil = UserStore.TryLogin(
                email,
                password,
                out UserAccount? akun,
                out string pesan
            );

            if (!berhasil)
            {
                CatatLogLogin(
                    email,
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
                    email,
                    "Tidak diketahui",
                    "Login gagal",
                    "Data akun tidak ditemukan."
                );

                MessageBox.Show("Data akun tidak ditemukan.");
                return;
            }

            CatatLogLogin(
                email,
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
                    new MainFormGudang(akun.Username, email);

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
            Form_Daftar daftar = new Form_Daftar();
            daftar.Show();
            this.Hide();
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
