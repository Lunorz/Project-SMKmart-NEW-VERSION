using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace project_akhir_stock_gudang
{
    public class BarangKeluarSimpan
    {
        public DateTime Waktu { get; set; }

        public string KodeBarang { get; set; } = "";

        public string NamaBarang { get; set; } = "";

        public int Jumlah { get; set; }

        public string Jenis { get; set; } = "";

        public string Alasan { get; set; } = "";

        public string Petugas { get; set; } = "";

        public string Catatan { get; set; } = "";
    }
}
