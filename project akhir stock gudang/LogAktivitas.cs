
using System;

namespace project_akhir_stock_gudang
{
    public class LogAktivitas
    {
        public DateTime Waktu { get; set; } = DateTime.Now;

        public string Pengguna { get; set; } = "";

        public string Role { get; set; } = "";

        public string Kategori { get; set; } = "";

        public string Aktivitas { get; set; } = "";

        public string Target { get; set; } = "";

        public string Keterangan { get; set; } = "";
    }
}

