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

            if (email == "admin" && password == "admin758150")
            {
                MessageBox.Show("login berhasil! selamat datang di panel admin");
                panel_admin panel = new panel_admin();
                panel.Show();
                this.Hide();
            }


            if (email == "" || password == "")
            {
                MessageBox.Show("email dan password wajib diisi!");
                return;
            }

            bool valid = UserStore.ValidateLogin(email, password);

            if (UserStore.ValidateLogin(email, password))
            {
                Dashboard_kasir dashboard =
                    new Dashboard_kasir(new List<DetailTransaksi>());

                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email atau password salah.");
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
