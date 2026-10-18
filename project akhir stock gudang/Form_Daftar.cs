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
    public partial class Form_Daftar : Form
    {
        private readonly string emailAktif;
        public Form_Daftar()
        {
            InitializeComponent();
        }
        
        private void Form_Daftar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void reg_lihat_password_CheckedChanged(object sender, EventArgs e)
        {
            if (reg_lihat_password.Checked)
            {
                reg_password.UseSystemPasswordChar = false;
            }
            else
            {
                reg_password.UseSystemPasswordChar = true;
            }
        }

        private void kembali_ke_login_Click(object sender, EventArgs e)
        {
            Form1 kembali = new Form1(emailAktif);
            kembali.Show();
            this.Hide();
        }

        private void reg_nama_TextChanged(object sender, EventArgs e)
        {

        }

        private void tombol_login_Click(object sender, EventArgs e)
        {
            string email = reg_email.Text.Trim();
            if (string.IsNullOrWhiteSpace(email) ||
            !System.Text.RegularExpressions.Regex.IsMatch(
             email,
             @"^[A-Za-z0-9._%+-]+@gmail\.com$"))
            {
                MessageBox.Show(
                    "Masukkan email dengan format yang benar dan harus menggunakan @gmail.com!",
                    "Email Tidak Valid",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            string password = reg_password.Text;
            if (email == "" || password == "")
            {
                MessageBox.Show("Email dan password wajib diisi!");
                return;
            }

            bool berhasil = UserStore.Register(email, password);

            if (berhasil)
            {
                MessageBox.Show("Pendaftaran berhasil!silahkan login.");

                Form1 login = new Form1(emailAktif);
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email sudah terdaftar");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void reg_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
