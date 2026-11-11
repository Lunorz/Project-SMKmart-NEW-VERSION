using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_akhir_stock_gudang
{
    public class TransaksiSimpan
    {
        public string NomorTransaksi { get; set; } = "";


        public string UsernameKasir { get; set; } = "";

        public DateTime Tanggal { get; set; }

        public string MetodePembayaran { get; set; } = "";

        public decimal TotalPembayaran { get; set; }

        public decimal UangDiterima { get; set; }

        public decimal Kembalian { get; set; }

        public List<DetailTransaksiSimpan> Barang { get; set; }
            = new List<DetailTransaksiSimpan>();
    }
}
