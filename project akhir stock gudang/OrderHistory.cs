using project_akhir_stock_gudang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class OrderHistory
{
    public string NomorPesanan { get; set; } = "";
    public DateTime Tanggal { get; set; }
    public List<CartItem> Items { get; set; } = new();

    public decimal Total =>
        Items.Sum(item => item.Subtotal);
}
