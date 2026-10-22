public class DetailTransaksi
{
    public string Kode { get; set; } = "";
    public string Nama { get; set; } = "";
    public decimal Harga { get; set; }
    public int Jumlah { get; set; }

    public decimal Subtotal => Harga * Jumlah;
}