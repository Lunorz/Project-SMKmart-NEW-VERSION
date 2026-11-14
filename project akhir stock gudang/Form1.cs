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

            if (email == "admin@gmail.com" &&
          password == "Admin758150!")
            {
                MessageBox.Show(
                    "Login admin berhasil.",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                MainFormAdmin admin = new MainFormAdmin();
                admin.Show();

                this.Hide();

                return;
            }


            if (email == "" || password == "")
            {
                MessageBox.Show("email dan password wajib diisi!");
                return;
            }


            {
                bool berhasil = UserStore.TryLogin(
                    textemail.Text.Trim(),
                    textpassword.Text,
                    out UserAccount? akun,
                    out string pesan);

                if (!berhasil)
                {
                    MessageBox.Show(pesan, "Login gagal",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show($"Login berhasil sebagai {akun!.Role}.", "Login berhasil",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (akun == null)
                {
                    MessageBox.Show("Email atau password salah.");
                    return;
                }

                if (akun.Role == "Kasir")
                {
                    Dashboard_kasir dashboard = new Dashboard_kasir(new List<DetailTransaksi>(), akun.Username);
                    dashboard.Show();
                    this.Hide();
                }
                else if (akun.Role == "Gudang")
                {
                    MainFormGudang dashboard = new MainFormGudang(akun.Username);
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Role akun tidak dikenali.");
                }

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
