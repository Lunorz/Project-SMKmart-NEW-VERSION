using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace project_akhir_stock_gudang
{
    public static class BarangMasukJsonStore
    {
        private static readonly string filePath =
            Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "barang_masuk.json"
            );

        public static List<BarangMasuk> Load()
        {
            if (!File.Exists(filePath))
                return new List<BarangMasuk>();

            string json = File.ReadAllText(filePath);

            if (string.IsNullOrWhiteSpace(json))
                return new List<BarangMasuk>();

            return JsonSerializer.Deserialize<List<BarangMasuk>>(json)
                   ?? new List<BarangMasuk>();
        }

        public static void Save(List<BarangMasuk> daftar)
        {
            if (daftar == null)
                throw new ArgumentNullException(nameof(daftar));

            string json = JsonSerializer.Serialize(
                daftar,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                }
            );

            File.WriteAllText(filePath, json);
        }
    }
}
