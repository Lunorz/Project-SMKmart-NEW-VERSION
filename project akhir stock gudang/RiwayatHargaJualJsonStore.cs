using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace project_akhir_stock_gudang
{
    public static class RiwayatHargaJualJsonStore
    {
        private static readonly string filePath =
            Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "riwayat_harga_jual.json"
            );

        public static List<RiwayatHargaJual> Load()
        {
            if (!File.Exists(filePath))
                return new List<RiwayatHargaJual>();

            string json = File.ReadAllText(filePath);

            return JsonSerializer.Deserialize<List<RiwayatHargaJual>>(json)
                ?? new List<RiwayatHargaJual>();
        }

        public static void Save(List<RiwayatHargaJual> data)
        {
            string json = JsonSerializer.Serialize(
                data,
                new JsonSerializerOptions { WriteIndented = true }
            );

            File.WriteAllText(filePath, json);
        }
    }
}
