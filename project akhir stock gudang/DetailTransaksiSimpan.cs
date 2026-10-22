using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_akhir_stock_gudang
{
    public class DetailTransaksiSimpan
    {
        public string Kode { get; set; } = "";
        public string Nama { get; set; } = "";
        public decimal Harga { get; set; }
        public int Jumlah { get; set; }
        public decimal Subtotal { get; set; }
    }
}
