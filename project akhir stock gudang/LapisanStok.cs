
using System;

namespace project_akhir_stock_gudang
{
    public class LapisanStok
    {
 
        public string IdLapisan { get; set; } = Guid.NewGuid().ToString();

        public string KodeBarang { get; set; } = "";
        public string NamaBarang { get; set; } = "";

    
        public DateTime TanggalMasuk { get; set; } = DateTime.Now;
        public string Petugas { get; set; } = "";
        public string NomorSuratJalan { get; set; } = "";

      
        public int StokAwal { get; set; }
        public int SisaStok { get; set; }

    
        public decimal HargaBeli { get; set; }
    }
}
