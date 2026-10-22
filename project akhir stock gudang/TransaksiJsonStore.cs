using project_akhir_stock_gudang;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

public static class TransaksiJsonStore
{
    private static readonly string filePath =
        Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "transaksi.json"
        );

    public static List<TransaksiSimpan> Load()
    {
        if (!File.Exists(filePath))
            return new List<TransaksiSimpan>();

        string json = File.ReadAllText(filePath);

        if (string.IsNullOrWhiteSpace(json))
            return new List<TransaksiSimpan>();

        return JsonSerializer.Deserialize<List<TransaksiSimpan>>(json)
               ?? new List<TransaksiSimpan>();
    }

    public static void Save(List<TransaksiSimpan> transaksi)
    {
        string json = JsonSerializer.Serialize(
            transaksi,
            new JsonSerializerOptions
            {
                WriteIndented = true
            }
        );

        File.WriteAllText(filePath, json);
    }

    public static void Tambah(TransaksiSimpan transaksi)
    {
        List<TransaksiSimpan> daftar = Load();
        daftar.Add(transaksi);
        Save(daftar);
    }
}