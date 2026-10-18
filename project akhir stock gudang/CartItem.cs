using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_akhir_stock_gudang
{
    public class CartItem
    {
        public string Nama { get; set; } = "";
        public decimal Harga { get; set; }
        public int Jumlah { get; set; } = 1;

        public decimal Subtotal => Harga * Jumlah;
    }
}
