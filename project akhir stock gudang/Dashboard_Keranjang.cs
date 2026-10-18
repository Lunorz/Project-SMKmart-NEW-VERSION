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
    public partial class Dashboard_Keranjang : Form
    {
        private readonly string EmailAktif;
        public Dashboard_Keranjang(string email)
        {
            InitializeComponent();
            datakeranjang.CellContentClick -=
             datakeranjang_CellContentClick;
            datakeranjang.CellContentClick +=
              datakeranjang_CellContentClick;
            EmailAktif = email;
            datakeranjang.AutoGenerateColumns = false;
            datakeranjang.AllowUserToAddRows = false;
            datakeranjang.ReadOnly = true;
            datakeranjang.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            datakeranjang.MultiSelect = false;
            kolom_nama.DataPropertyName = nameof(CartItem.Nama);
            kolom_harga.DataPropertyName = nameof(CartItem.Harga);
            kolom_jumlah.DataPropertyName = nameof(CartItem.Jumlah);
            kolom_subtotal.DataPropertyName = nameof(CartItem.Subtotal);

            kolom_subtotal.DefaultCellStyle.Format = "N0";
            kolom_harga.DefaultCellStyle.Format = "N0";

            TampilkanKeranjang();
        }

        private void TampilkanKeranjang()
        {
            var items = CartJsonStore.Load(EmailAktif);

            datakeranjang.DataSource = null;
            datakeranjang.DataSource = items;

            decimal total = items.Sum(item => item.Subtotal);

            label_total.Text =
                "Total: Rp " + total.ToString("N0");
        }

        private void tombol_alat_gambar_Click(object sender, EventArgs e)
        {
            Dashboard_User1 back7 = new Dashboard_User1(EmailAktif);
            back7.Show();
            this.Hide();
        }

        private void Dashboard_Keranjang_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tombol_alat_tulis_Click(object sender, EventArgs e)
        {
            Dashboard_User2 back8 = new Dashboard_User2(EmailAktif);
            back8.Show();
            this.Hide();
        }

        private void tombol_perlengkapan_sekolah_Click(object sender, EventArgs e)
        {
            Dashboard_User3 back9 = new Dashboard_User3(EmailAktif);
            back9.Show();
            this.Hide();
        }

        private void kembali_ke_login_Click(object sender, EventArgs e)
        {
            Form1 back20 = new Form1(EmailAktif);
            back20.Show();
            this.Hide();
        }

        private void checkout_barang_Click(object sender, EventArgs e)
        {
            var item = CartJsonStore.Load(EmailAktif);


            if (item.Count == 0)
            {
                MessageBox.Show("Keranjang masih kosong");
                return;
            }


            decimal total = item.Sum(item => item.Subtotal);

            DialogResult konfirmasi = MessageBox.Show("Total pembayaran : Rp" + total.ToString("N0") + "\nLanjutkan checkout?",
            "Konfirmasi checkout", MessageBoxButtons.YesNo, MessageBoxIcon.Question
            );

            if (konfirmasi != DialogResult.Yes)
                return;


            bool berhasil = CartJsonStore.Checkout(EmailAktif);

            if (berhasil)
            {
                MessageBox.Show("Checkout berhasil,Pesanan tersimpan di riwayat.");
            }

            TampilkanKeranjang();
        }

    
        private void datakeranjang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0 || e.ColumnIndex < 0)
        return;

            string namaKolom =
                datakeranjang.Columns[e.ColumnIndex].Name;

            if (namaKolom != "kurangi_barang_keranjang" &&
                namaKolom != "hapus_barang_keranjang")
                return;

            List<CartItem> items =
                CartJsonStore.Load(EmailAktif);

            if (e.RowIndex >= items.Count)
                return;

            CartItem item = items[e.RowIndex];

            if (namaKolom == "kurangi_barang_keranjang")
            {
                if (item.Jumlah > 1)
                {
                    item.Jumlah--;
                }
                else
                {
                    DialogResult hasil = MessageBox.Show(
                        "Jumlah barang tinggal 1. Hapus barang ini?",
                        "Konfirmasi",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (hasil != DialogResult.Yes)
                        return;

                    items.RemoveAt(e.RowIndex);
                }
            }
            else
            {
                DialogResult hasil = MessageBox.Show(
                    "Hapus " + item.Nama + " dari keranjang?",
                    "Konfirmasi Hapus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (hasil != DialogResult.Yes)
                    return;

                items.RemoveAt(e.RowIndex);
            }

            CartJsonStore.Save(EmailAktif, items);
            TampilkanKeranjang();
        }
    }
}
