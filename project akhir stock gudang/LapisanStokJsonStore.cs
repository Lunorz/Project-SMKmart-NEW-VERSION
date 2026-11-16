
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace project_akhir_stock_gudang
{
    public static class LapisanStokJsonStore
    {
        private static readonly string filePath =
            Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "lapisan_stok.json"
            );

        public static List<LapisanStok> Load()
        {
            if (!File.Exists(filePath))
                return new List<LapisanStok>();

            string json = File.ReadAllText(filePath);

            return JsonSerializer.Deserialize<List<LapisanStok>>(json)
                ?? new List<LapisanStok>();
        }

        public static void Save(List<LapisanStok> data)
        {
            string json = JsonSerializer.Serialize(
                data,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                }
            );

            File.WriteAllText(filePath, json);
        }
    }
}
