using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_akhir_stock_gudang
{
    public class Produk
    {
        public string Kode { get; set; } = "";
        public string Nama { get; set; } = "";
        public string Kategori { get; set; } = "";
        public decimal Harga { get; set; }
        public int Stok { get; set; }

        public override string ToString()
        {
            return $"{Nama} | {Kategori} | Rp{Harga:N0} | Stok: {Stok}";
        }
    }
}
