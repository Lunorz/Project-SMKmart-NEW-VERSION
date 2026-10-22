using project_akhir_stock_gudang;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

public static class ProdukJsonStore
{
    private static readonly string filePath =
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "produk.json");

    public static List<Produk> Load()
    {
       
        if (!File.Exists(filePath))
        {
            MessageBox.Show("File produk.json tidak ditemukan.");
            return new List<Produk>(); 
        }
          

        string json = File.ReadAllText(filePath);
       

        if (string.IsNullOrWhiteSpace(json))
        {
            return new List<Produk>();
        }
        try
        {
            return JsonSerializer.Deserialize<List<Produk>>(json) ?? new List<Produk>();
        }
        catch (JsonException)
        {
            // Kembalikan list kosong jika isi JSON tidak valid
            return new List<Produk>();
        }

        return JsonSerializer.Deserialize<List<Produk>>(json)
               ?? new List<Produk>();
    }

    public static void Save(List<Produk> produk)
    {
        string json = JsonSerializer.Serialize(
            produk,
            new JsonSerializerOptions { WriteIndented = true }
        );

        File.WriteAllText(filePath, json);
    }
    public class TransaksiSimpan
    {
        public string NomorTransaksi { get; set; } = "";
        public DateTime Tanggal { get; set; }
        public string MetodePembayaran { get; set; } = "";
        public decimal TotalPembayaran { get; set; }
        public decimal UangDiterima { get; set; }
        public decimal Kembalian { get; set; }

        public List<DetailTransaksiSimpan> Barang { get; set; } = new();
    }

 
}