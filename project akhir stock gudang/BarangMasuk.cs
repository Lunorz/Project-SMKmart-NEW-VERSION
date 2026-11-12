using System;

namespace project_akhir_stock_gudang
{
    public class BarangMasuk
    {
        public DateTime Waktu { get; set; }

        public string KodeBarang { get; set; } = "";

        public string NamaBarang { get; set; } = "";

        public int Jumlah { get; set; }

        public string AsalBarang { get; set; } = "";

        public string NomorSuratJalan { get; set; } = "";

        public string Catatan { get; set; } = "";

        public string Petugas { get; set; } = "";
    }
}