using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace project_akhir_stock_gudang
{
    public class KoreksiStokSimpan
    {
        public DateTime Waktu { get; set; }

        public string KodeBarang { get; set; } = "";

        public string NamaBarang { get; set; } = "";

     
        public int Jumlah { get; set; }

        public int StokSebelum { get; set; }

        public int StokSesudah { get; set; }

        public string Keterangan { get; set; } = "";

        public string Petugas { get; set; } = "";
    }
}