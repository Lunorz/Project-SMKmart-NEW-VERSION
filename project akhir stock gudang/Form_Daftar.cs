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
            tombol_daftar.Click -= tombol_daftar_Click;
            tombol_daftar.Click += tombol_daftar_Click;
            cmbRole.Items.Clear();

            cmbRole.Items.Add("Kasir");
            cmbRole.Items.Add("Gudang");

            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.SelectedIndex = -1;
        }

        private void Form_Daftar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        private void tombol_daftar_Click(object sender, EventArgs e)
        {
            string username = reg_username.Text.Trim();
            string email = reg_email.Text.Trim();
            string role = cmbRole.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Lengkapi username, email, dan role terlebih dahulu.",
                    "Pendaftaran", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool berhasil = UserStore.RegisterPending(username, email, role, out string pesan);
            if (!berhasil)
            {
                MessageBox.Show(pesan, "Pendaftaran gagal",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(pesan, "Pendaftaran berhasil",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            reg_username.Clear();
            reg_email.Clear();
            cmbRole.SelectedIndex = -1;
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

        private void reg_username_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
