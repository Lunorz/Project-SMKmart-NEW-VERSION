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
    public partial class ucLogAktivitas : UserControl
    {
        private List<LogAktivitas> semuaLog =
           new List<LogAktivitas>();
        public ucLogAktivitas()
        {
            InitializeComponent();
         


            dtpDari.ValueChanged += FilterBerubah;
            dtpSampai.ValueChanged += FilterBerubah;
            cmbRole.SelectedIndexChanged += FilterBerubah;
            cmbKategori.SelectedIndexChanged += FilterBerubah;
            txtCari.TextChanged += FilterBerubah;


            dgvLog.SelectionChanged += dgvLog_SelectionChanged;

            MuatLog();
        }


        private void MuatLog()
        {
            try
            {
                semuaLog = LogAktivitasJsonStore.Load();

                TampilkanRingkasan();
                TampilkanTabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat log aktivitas.\n\n" + ex.Message,
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void TampilkanRingkasan()
        {
            DateTime hariIni = DateTime.Today;

            List<LogAktivitas> logHariIni = semuaLog
                .Where(x => x.Waktu.Date == hariIni)
                .ToList();


            int totalAktivitas = logHariIni.Count;


            int totalLogin = logHariIni.Count(x =>
                x.Kategori.Equals(
                    "Akses",
                    StringComparison.OrdinalIgnoreCase
                )
                &&
                x.Aktivitas.IndexOf(
                    "login",
                    StringComparison.OrdinalIgnoreCase
                ) >= 0
                &&
                x.Aktivitas.IndexOf(
                    "gagal",
                    StringComparison.OrdinalIgnoreCase
                ) < 0
            );


            int totalGagal = logHariIni.Count(x =>
                x.Aktivitas.IndexOf(
                    "gagal",
                    StringComparison.OrdinalIgnoreCase
                ) >= 0
            );


            int totalUbah = logHariIni.Count(x =>
                x.Kategori.Equals(
                    "Akun",
                    StringComparison.OrdinalIgnoreCase
                )
                ||
                x.Kategori.Equals(
                    "Barang",
                    StringComparison.OrdinalIgnoreCase
                )
                ||
                x.Kategori.Equals(
                    "Stok",
                    StringComparison.OrdinalIgnoreCase
                )
            );

            lblAktivitas.Text = totalAktivitas.ToString("N0");
            lblLogin.Text = totalLogin.ToString("N0");
            lblGagal.Text = totalGagal.ToString("N0");
            lblUbah.Text = totalUbah.ToString("N0");
        }


        private void FilterBerubah(object? sender, EventArgs e)
        {
            TampilkanTabel();
        }


        private List<LogAktivitas> AmbilDataFilter()
        {
            DateTime tanggalAwal = dtpDari.Value.Date;

            DateTime tanggalAkhir =
                dtpSampai.Value.Date.AddDays(1).AddTicks(-1);

            string roleDipilih = cmbRole.Text;
            string kategoriDipilih = cmbKategori.Text;
            string kataKunci = txtCari.Text.Trim();

            IEnumerable<LogAktivitas> hasil = semuaLog;


            hasil = hasil.Where(x =>
                x.Waktu >= tanggalAwal &&
                x.Waktu <= tanggalAkhir
            );


            if (roleDipilih != "Semua role")
            {
                hasil = hasil.Where(x =>
                    string.Equals(
                        x.Role,
                        roleDipilih,
                        StringComparison.OrdinalIgnoreCase
                    )
                );
            }


            if (kategoriDipilih != "Semua kategori")
            {
                hasil = hasil.Where(x =>
                    string.Equals(
                        x.Kategori,
                        kategoriDipilih,
                        StringComparison.OrdinalIgnoreCase
                    )
                );
            }


            if (!string.IsNullOrWhiteSpace(kataKunci))
            {
                hasil = hasil.Where(x =>
                    (x.Pengguna ?? "").Contains(
                        kataKunci,
                        StringComparison.OrdinalIgnoreCase
                    )
                    ||
                    (x.Aktivitas ?? "").Contains(
                        kataKunci,
                        StringComparison.OrdinalIgnoreCase
                    )
                    ||
                    (x.Target ?? "").Contains(
                        kataKunci,
                        StringComparison.OrdinalIgnoreCase
                    )
                );
            }

            return hasil
                .OrderByDescending(x => x.Waktu)
                .ToList();
        }


        private void TampilkanTabel()
        {
            dgvLog.Rows.Clear();

            List<LogAktivitas> hasil = AmbilDataFilter();

            foreach (LogAktivitas item in hasil)
            {
                int index = dgvLog.Rows.Add(
                    item.Waktu.ToString("dd/MM/yyyy HH:mm:ss"),
                    item.Pengguna,
                    item.Role,
                    item.Kategori,
                    item.Aktivitas,
                    item.Target
                );

                dgvLog.Rows[index].Tag = item;
            }

            KosongkanDetail();

            dgvLog.ClearSelection();
        }



        private void pnlKartuGagalDalam_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvLog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvLog_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLog.SelectedRows.Count == 0)
            {
                KosongkanDetail();
                return;
            }

            DataGridViewRow baris = dgvLog.SelectedRows[0];

            if (baris.Tag is not LogAktivitas item)
            {
                KosongkanDetail();
                return;
            }

            txtWaktuD.Text =
                item.Waktu.ToString("dd MMMM yyyy, HH:mm:ss");

            txtPenggunaD.Text = item.Pengguna;
            txtRoleD.Text = item.Role;
            txtKategoriD.Text = item.Kategori;
            txtAktivitasD.Text = item.Aktivitas;

            txtKeteranganD.Text =
                "Target: " + item.Target +
                Environment.NewLine +
                Environment.NewLine +
                item.Keterangan;
        }


        public void RefreshLog()
        {
            MuatLog();
        }

        private void KosongkanDetail()
        {
            txtWaktuD.Clear();
            txtPenggunaD.Clear();
            txtRoleD.Clear();
            txtKategoriD.Clear();
            txtAktivitasD.Clear();
            txtKeteranganD.Clear();
        }
    }
}
