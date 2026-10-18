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
    public partial class Dashboard_User2 : Form
    {
        private int jumlahbolpoin = 1;
        private int jumlahpensil2B = 1;
        private int jumlahpenghapus = 1;
        private int jumlahtipeX = 1;
        private int jumlahstabilo = 1;
        private int jumlahbukutulis = 1;
        private const decimal HargaBolpoin = 3000;
        private const decimal HargaPensil2B = 2000;
        private const decimal HargaPenghapus = 3500;
        private const decimal HargaTipeX = 6500;
        private const decimal HargaStabilo = 5000;
        private const decimal HargaBukuTulis = 3000;
        private readonly string EmailAktif;
        public Dashboard_User2(string email)
        {
            InitializeComponent();
            EmailAktif = email;
            jumlah_beli_bolpoin.Text = jumlahbolpoin.ToString();
            jumlah_beli_pensil_2B.Text = jumlahpensil2B.ToString();
            jumlah_beli_penghapus.Text = jumlahpenghapus.ToString();
            jumlah_beli_tipe_x.Text = jumlahtipeX.ToString();
            jumlah_beli_tipe_x.Text = jumlahtipeX.ToString();
            jumlah_beli_buku_tulis.Text = jumlahbukutulis.ToString();
        }

        private void kembali_ke_login_Click(object sender, EventArgs e)
        {
            Form1 back = new Form1(EmailAktif);
            back.Show();
            this.Hide();
        }

        private void Dashboard_User2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tombol_alat_gambar_Click(object sender, EventArgs e)
        {
            Dashboard_User1 kembali_alat_gambar = new Dashboard_User1(EmailAktif);
            kembali_alat_gambar.Show();
            this.Hide();
        }

        private void kurang_bolpoin_Click(object sender, EventArgs e)
        {
            if (jumlahbolpoin > 1)
            {
                jumlahbolpoin--;
                jumlah_beli_bolpoin.Text = jumlahbolpoin.ToString();
            }
        }

        private void tambah_bolpoin_Click(object sender, EventArgs e)
        {
            jumlahbolpoin++;
            jumlah_beli_bolpoin.Text = jumlahbolpoin.ToString();
        }

        private void kurang_pensil_2B_Click(object sender, EventArgs e)
        {
            if (jumlahpensil2B > 1)
            {
                jumlahpensil2B--;
                jumlah_beli_pensil_2B.Text = jumlahpensil2B.ToString();
            }
        }

        private void tambah_pensil_2B_Click(object sender, EventArgs e)
        {
            jumlahpensil2B++;
            jumlah_beli_pensil_2B.Text = jumlahpensil2B.ToString();
        }

        private void kurang_krayon_Click(object sender, EventArgs e)
        {
            if (jumlahpenghapus > 1)
            {
                jumlahpenghapus--;
                jumlah_beli_penghapus.Text = jumlahpenghapus.ToString();
            }
        }

        private void tambah_penghapus_Click(object sender, EventArgs e)
        {
            jumlahpenghapus++;
            jumlah_beli_penghapus.Text = jumlahpenghapus.ToString();
        }

        private void kurang_tipe_x_Click(object sender, EventArgs e)
        {
            if (jumlahtipeX > 1)
            {
                jumlahtipeX--;
                jumlah_beli_tipe_x.Text = jumlahtipeX.ToString();
            }
        }

        private void tambah_tipe_x_Click(object sender, EventArgs e)
        {
            jumlahtipeX++;
            jumlah_beli_tipe_x.Text = jumlahtipeX.ToString();
        }

        private void kurang_stabilo_Click(object sender, EventArgs e)
        {
            if (jumlahstabilo > 1)
            {
                jumlahstabilo--;
                jumlah_beli_stabilo.Text = jumlahstabilo.ToString();
            }
        }

        private void tambah_stabilo_Click(object sender, EventArgs e)
        {
            jumlahstabilo++;
            jumlah_beli_stabilo.Text = jumlahstabilo.ToString();
        }

        private void kurang_buku_tulis_Click(object sender, EventArgs e)
        {
            if (jumlahbukutulis > 1)
            {
                jumlahbukutulis--;
                jumlah_beli_buku_tulis.Text = jumlahbukutulis.ToString();
            }
        }

        private void tambah_buku_tulis_Click(object sender, EventArgs e)
        {
            jumlahbukutulis++;
            jumlah_beli_buku_tulis.Text = jumlahbukutulis.ToString();
        }

        private void tombol_perlengkapan_sekolah_Click(object sender, EventArgs e)
        {
            Dashboard_User3 Menuju2 = new Dashboard_User3(EmailAktif);
            Menuju2.Show();
            this.Hide();
        }

        private void tombol_keranjang_Click(object sender, EventArgs e)
        {
            Dashboard_Keranjang menuju8 = new Dashboard_Keranjang(EmailAktif);
            menuju8.Show();
            this.Hide();
        }

        private void beli_bolpoin_Click(object sender, EventArgs e)
        {
            CartJsonStore.Tambah(
            EmailAktif,
            "bolpoin",
            HargaBolpoin,
            jumlahbolpoin
        );

            MessageBox.Show(
                "Bolpoin berhasil ditambahkan ke keranjang."
            );
        }

        private void beli_pensil_2B_Click(object sender, EventArgs e)
        {
            CartJsonStore.Tambah(
            EmailAktif,
            "pensil 2B",
            HargaPensil2B,
            jumlahpensil2B
        );

            MessageBox.Show(
                "Pensil 2B berhasil ditambahkan ke keranjang."
            );
        }

        private void beli_penghapus_Click(object sender, EventArgs e)
        {
            CartJsonStore.Tambah(
            EmailAktif,
            "penghapus",
            HargaPenghapus,
            jumlahpenghapus
        );

            MessageBox.Show(
                "Penghapus berhasil ditambahkan ke keranjang."
            );
        }

        private void beli_tipe_x_Click(object sender, EventArgs e)
        {
            CartJsonStore.Tambah(
            EmailAktif,
            "tipe X",
            HargaTipeX,
            jumlahtipeX
        );

            MessageBox.Show(
                "Tipe X berhasil ditambahkan ke keranjang."
            );
        }

        private void beli_stabilo_Click(object sender, EventArgs e)
        {
            CartJsonStore.Tambah(
            EmailAktif,
            "Stabilo",
            HargaStabilo,
            jumlahstabilo
        );

            MessageBox.Show(
                "Stabilo berhasil ditambahkan ke keranjang."
            );
        }

        private void beli_buku_tulis_Click(object sender, EventArgs e)
        {
            CartJsonStore.Tambah(
            EmailAktif,
            "buku tulis",
            HargaBukuTulis,
            jumlahbukutulis
        );

            MessageBox.Show(
                "Tas berhasil ditambahkan ke keranjang."
            );
        }
    }
}
