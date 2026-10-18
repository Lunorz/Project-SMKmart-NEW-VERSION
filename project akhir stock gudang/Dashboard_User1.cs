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
    public partial class Dashboard_User1 : Form
    {
        private int jumlahbuku = 1;
        private int jumlahpensil2H = 1;
        private int jumlahkrayon = 1;
        private int jumlahdrawingpen = 1;
        private int jumlahpensilwarna = 1;
        private int jumlahspidolwarna = 1;
        private const decimal HargaBukuGambar = 5000;
        private const decimal HargaPensil2H = 4000;
        private const decimal HargaKrayon = 15000;
        private const decimal HargaDrawingPen = 4000;
        private const decimal HargaPensilWarna = 9000;
        private const decimal HargaSpidol = 12000;
        private readonly string EmailAktif;
        public Dashboard_User1(string email)
        {
            InitializeComponent();
            EmailAktif = email;
            jumlah_beli_buku_gambar.Text = jumlahbuku.ToString();
            jumlah_beli_pensil_2H.Text = jumlahpensil2H.ToString();
            jumlah_beli_krayon.Text = jumlahkrayon.ToString();
            jumlah_beli_drawing_pen.Text = jumlahdrawingpen.ToString();
            jumlah_beli_pensil_warna.Text = jumlahpensilwarna.ToString();
            jumlah_beli_spidol_warna.Text = jumlahspidolwarna.ToString();
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentException(
                    "Email tidak boleh kosong."
                );
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (jumlahbuku > 1)
            {
                jumlahbuku--;
                jumlah_beli_buku_gambar.Text = jumlahbuku.ToString();
            }
        }

        private void jumlah_buku_gambar_Click(object sender, EventArgs e)
        {

        }

        private void kembali_ke_login_Click(object sender, EventArgs e)
        {
            Form1 kembali = new Form1(EmailAktif);
            kembali.Show();
            this.Hide();
        }

        private void tambah_buku_gambar_Click(object sender, EventArgs e)
        {
            jumlahbuku++;
            jumlah_beli_buku_gambar.Text = jumlahbuku.ToString();
        }

        private void kurang_pensil_2H_Click(object sender, EventArgs e)
        {
            if (jumlahpensil2H > 1)
            {
                jumlahpensil2H--;
                jumlah_beli_pensil_2H.Text = jumlahpensil2H.ToString();
            }
        }

        private void tambah_pensil_2H_Click(object sender, EventArgs e)
        {
            jumlahpensil2H++;
            jumlah_beli_pensil_2H.Text = jumlahpensil2H.ToString();
        }

        private void kurang_krayon_Click(object sender, EventArgs e)
        {
            if (jumlahkrayon > 1)
            {
                jumlahkrayon--;
                jumlah_beli_krayon.Text = jumlahkrayon.ToString();
            }
        }

        private void tambah_krayon_Click(object sender, EventArgs e)
        {
            jumlahkrayon++;
            jumlah_beli_krayon.Text = jumlahkrayon.ToString();
        }

        private void Dashboard_User1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void kurang_drawing_pen_Click(object sender, EventArgs e)
        {
            if (jumlahdrawingpen > 1)
            {
                jumlahdrawingpen--;
                jumlah_beli_drawing_pen.Text = jumlahdrawingpen.ToString();
            }
        }

        private void tambah_drawing_pen_Click(object sender, EventArgs e)
        {
            jumlahdrawingpen++;
            jumlah_beli_drawing_pen.Text = jumlahdrawingpen.ToString();
        }

        private void kurang_pensil_warna_Click(object sender, EventArgs e)
        {
            if (jumlahpensilwarna > 1)
            {
                jumlahpensilwarna--;
                jumlah_beli_pensil_warna.Text = jumlahpensilwarna.ToString();
            }
        }

        private void tambah_pensil_warna_Click(object sender, EventArgs e)
        {
            jumlahpensilwarna++;
            jumlah_beli_pensil_warna.Text = jumlahpensilwarna.ToString();
        }

        private void kurang_spidol_warna_Click(object sender, EventArgs e)
        {
            if (jumlahspidolwarna > 1)
            {
                jumlahspidolwarna--;
                jumlah_beli_spidol_warna.Text = jumlahspidolwarna.ToString();
            }
        }

        private void tambah_spidol_warna_Click(object sender, EventArgs e)
        {
            jumlahspidolwarna++;
            jumlah_beli_spidol_warna.Text = jumlahspidolwarna.ToString();
        }

        private void tombol_alat_tulis_Click(object sender, EventArgs e)
        {
            Dashboard_User2 menuju = new Dashboard_User2(EmailAktif);
            menuju.Show();
            this.Hide();
        }

        private void tombol_perlengkapan_sekolah_Click(object sender, EventArgs e)
        {
            Dashboard_User3 menuju5 = new Dashboard_User3(EmailAktif);
            menuju5.Show();
            this.Hide();
        }

        private void tombol_keranjang_Click(object sender, EventArgs e)
        {
            Dashboard_Keranjang menuju15 = new Dashboard_Keranjang(EmailAktif);
            menuju15.Show();
            this.Hide();
        }

        private void beli_buku_gambar_Click(object sender, EventArgs e)
        {
            CartJsonStore.Tambah(
            EmailAktif,
            "buku gambar",
            HargaBukuGambar,
            jumlahbuku
        );

            MessageBox.Show(
                "Buku gambar berhasil ditambahkan ke keranjang."
            );
        }

        private void beli_pensil_2H_Click(object sender, EventArgs e)
        {
            CartJsonStore.Tambah(
            EmailAktif,
            "pensil 2H",
            HargaPensil2H,
            jumlahpensil2H
        );

            MessageBox.Show(
                "Pensil 2H berhasil ditambahkan ke keranjang."
            );
        }

        private void beli_krayon_Click(object sender, EventArgs e)
        {
            CartJsonStore.Tambah(
            EmailAktif,
            "krayon",
            HargaKrayon,
            jumlahkrayon
        );

            MessageBox.Show(
                "Krayon berhasil ditambahkan ke keranjang."
            );
        }

        private void beli_drawing_pen_Click(object sender, EventArgs e)
        {
            CartJsonStore.Tambah(
            EmailAktif,
            "drawinng pen",
            HargaDrawingPen,
            jumlahdrawingpen
        );

            MessageBox.Show(
                "Drawing pen berhasil ditambahkan ke keranjang."
            );
        }

        private void beli_pensil_warna_Click(object sender, EventArgs e)
        {
            CartJsonStore.Tambah(
            EmailAktif,
            "pensil warna",
            HargaPensilWarna,
            jumlahpensilwarna
        );

            MessageBox.Show(
                "Pensil warna berhasil ditambahkan ke keranjang."
            );
        }

        private void beli_spidol_warna_Click(object sender, EventArgs e)
        {
            CartJsonStore.Tambah(
            EmailAktif,
            "spidol warna",
            HargaSpidol,
            jumlahspidolwarna
        );

            MessageBox.Show(
                "Spidol warna berhasil ditambahkan ke keranjang."
            );
        }
    }
}
