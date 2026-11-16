using System;

namespace project_akhir_stock_gudang
{
    public class RiwayatHargaJual
    {
        public string KodeBarang { get; set; } = "";
        public string NamaBarang { get; set; } = "";
        public decimal HargaLama { get; set; }
        public decimal HargaBaru { get; set; }
        public DateTime WaktuPerubahan { get; set; }
        public string Admin { get; set; } = "";
        public string Alasan { get; set; } = "";
    }
}