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
    public partial class Dashboard_User3 : Form
    {
        private int jumlah_tas = 1;
        private int jumlah_kaos_kaki = 1;
        private int jumlah_sabuk = 1;
        private int jumlah_topi = 1;
        private int jumlah_dasi = 1;
        private int jumlah_kolong_rotan = 1;
        private const decimal HargaTas = 125000;
        private const decimal HargaKaosKaki = 9500;
        private const decimal HargaSabuk = 15000;
        private const decimal HargaTopi = 10000;
        private const decimal HargaDasi = 14000;
        private const decimal HargaKolongRotan = 1000;
        private readonly string EmailAktif;


        public Dashboard_User3(string email)
        {
            InitializeComponent();
            EmailAktif = email;
            jumlah_beli_tas_sekolah.Text = jumlah_tas.ToString();
            jumlah_beli_kaos_kaki.Text = jumlah_kaos_kaki.ToString();
            jumlah_beli_sabuk.Text = jumlah_sabuk.ToString();
            jumlah_beli_topi.Text = jumlah_topi.ToString();
            jumlah_beli_dasi.Text = jumlah_dasi.ToString();
            jumlah_beli_kolong_rotan.Text = jumlah_kolong_rotan.ToString();
        }

        private void Dashboard_User3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tombol_alat_gambar_Click(object sender, EventArgs e)
        {
            Dashboard_User1 kembali1 = new Dashboard_User1(EmailAktif);
            kembali1.Show();
            this.Hide();
        }

        private void tombol_alat_tulis_Click(object sender, EventArgs e)
        {
            Dashboard_User2 kembali2 = new Dashboard_User2(EmailAktif);
            kembali2.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kurang_tas_sekolah_Click(object sender, EventArgs e)
        {
            if (jumlah_tas > 1)
            {
                jumlah_tas--;
                jumlah_beli_tas_sekolah.Text = jumlah_tas.ToString();
            }
        }

        private void tambah_tas_sekolah_Click(object sender, EventArgs e)
        {
            jumlah_tas++;
            jumlah_beli_tas_sekolah.Text = jumlah_tas.ToString();
        }

        private void kurang_kaos_kaki_Click(object sender, EventArgs e)
        {
            if (jumlah_kaos_kaki > 1)
            {
                jumlah_kaos_kaki--;
                jumlah_beli_kaos_kaki.Text = jumlah_kaos_kaki.ToString();
            }
        }

        private void tambah_kaos_kaki_Click(object sender, EventArgs e)
        {
            jumlah_kaos_kaki++;
            jumlah_beli_kaos_kaki.Text = jumlah_kaos_kaki.ToString();
        }

        private void kurang_sabuk_Click(object sender, EventArgs e)
        {
            if (jumlah_sabuk > 1)
            {
                jumlah_sabuk--;
                jumlah_beli_sabuk.Text = jumlah_sabuk.ToString();
            }
        }

        private void tambah_sabuk_Click(object sender, EventArgs e)
        {
            jumlah_sabuk++;
            jumlah_beli_sabuk.Text = jumlah_sabuk.ToString();
        }

        private void kurang_topi_Click(object sender, EventArgs e)
        {
            if (jumlah_topi > 1)
            {
                jumlah_topi--;
                jumlah_beli_topi.Text = jumlah_topi.ToString();
            }
        }

        private void tambah_topi_Click(object sender, EventArgs e)
        {
            jumlah_topi++;
            jumlah_beli_topi.Text = jumlah_topi.ToString();
        }

        private void kurang_dasi_Click(object sender, EventArgs e)
        {
            if (jumlah_dasi > 1)
            {
                jumlah_dasi--;
                jumlah_beli_dasi.Text = jumlah_dasi.ToString();
            }
        }

        private void tambah_dasi_Click(object sender, EventArgs e)
        {
            jumlah_dasi++;
            jumlah_beli_dasi.Text = jumlah_dasi.ToString();
        }

        private void kurang_kolong_rotan_Click(object sender, EventArgs e)
        {
            if (jumlah_kolong_rotan > 1)
            {
                jumlah_kolong_rotan--;
                jumlah_beli_kolong_rotan.Text = jumlah_kolong_rotan.ToString();
            }
        }

        private void tambah_kolong_rotan_Click(object sender, EventArgs e)
        {
            jumlah_kolong_rotan++;
            jumlah_beli_kolong_rotan.Text = jumlah_kolong_rotan.ToString();
        }

        private void kembali_ke_login_Click(object sender, EventArgs e)
        {
            Form1 back3 = new Form1(EmailAktif);
            back3.Show();
            this.Hide();
        }

        private void tombol_keranjang_Click(object sender, EventArgs e)
        {
            Dashboard_Keranjang menuju14 = new Dashboard_Keranjang(EmailAktif);
            menuju14.Show();
            this.Hide();
        }

        private void beli_tas_sekolah_Click(object sender, EventArgs e)
        {
            CartJsonStore.Tambah(
            EmailAktif,
            "Tas Sekolah",
            HargaTas,
            jumlah_tas
        );

            MessageBox.Show(
                "Tas berhasil ditambahkan ke keranjang."
            );
        }

        private void beli_kaos_kaki_Click(object sender, EventArgs e)
        {
            CartJsonStore.Tambah(
            EmailAktif,
            "kaos kaki",
            HargaKaosKaki,
            jumlah_kaos_kaki
        );

            MessageBox.Show(
                "Sabuk berhasil ditambahkan ke keranjang."
            );
        }

        private void beli_sabuk_Click(object sender, EventArgs e)
        {
            CartJsonStore.Tambah(
            EmailAktif,
            "sabuk",
            HargaSabuk,
            jumlah_sabuk
        );

            MessageBox.Show(
                "Sabuk berhasil ditambahkan ke keranjang."
            );
        }

        private void beli_topi_Click(object sender, EventArgs e)
        {
            CartJsonStore.Tambah(
            EmailAktif,
            "topi",
            HargaTopi,
            jumlah_topi
        );

            MessageBox.Show(
                "Topi berhasil ditambahkan ke keranjang."
            );
        }

        private void beli_dasi_Click(object sender, EventArgs e)
        {
            CartJsonStore.Tambah(
            EmailAktif,
            "dasi",
            HargaDasi,
            jumlah_dasi
        );

            MessageBox.Show(
                "Dasi berhasil ditambahkan ke keranjang."
            );
        }

        private void beli_kolong_rotan_Click(object sender, EventArgs e)
        {
            CartJsonStore.Tambah(
            EmailAktif,
            "kolong rotan",
            HargaKolongRotan,
            jumlah_kolong_rotan
        );

            MessageBox.Show(
                "Kolong rotan berhasil ditambahkan ke keranjang."
            );
        }
    }
}
