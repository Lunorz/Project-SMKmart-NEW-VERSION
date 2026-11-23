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
        private readonly string usernameAktif;
        public Form_Daftar()
        {
            InitializeComponent();
            UiTheme.ApplyAuthDecoration(panel1, pictureBox1);
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
            Form1 kembali = new Form1(usernameAktif);
            kembali.Show();
            this.Hide();
        }

        private void reg_nama_TextChanged(object sender, EventArgs e)
        {

        }

        private void tombol_daftar_Click(object sender, EventArgs e)
        {
            string username = reg_username.Text.Trim();
            string role = cmbRole.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Lengkapi username dan role terlebih dahulu.",
                    "Pendaftaran", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            bool berhasil = UserStore.RegisterPending(
                username,
                role,
                out string pesan
            );

            if (!berhasil)
            {
                MessageBox.Show(
                    pesan,
                    "Pendaftaran gagal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            
            try
            {
                LogAktivitasJsonStore.Catat(
                    username,
                    role,
                    "Akun",
                    "Pendaftaran akun",
                    username,
                    "Pengguna mendaftarkan akun dengan username: " +
                    username
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Pendaftaran berhasil, tetapi log gagal disimpan.\n\n" +
                    ex.Message,
                    "Peringatan Log",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }


            MessageBox.Show(pesan, "Pendaftaran berhasil",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            reg_username.Clear();
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
