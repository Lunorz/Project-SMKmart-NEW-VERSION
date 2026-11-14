using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace project_akhir_stock_gudang
{
    public static class KoreksiStokJsonStore
    {
        private static readonly string filePath =
            Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "koreksi_stok.json"
            );

        public static List<KoreksiStokSimpan> Load()
        {
            if (!File.Exists(filePath))
                return new List<KoreksiStokSimpan>();

            string json = File.ReadAllText(filePath);

            if (string.IsNullOrWhiteSpace(json))
                return new List<KoreksiStokSimpan>();

            return JsonSerializer.Deserialize<List<KoreksiStokSimpan>>(json)
                   ?? new List<KoreksiStokSimpan>();
        }

        public static void Save(List<KoreksiStokSimpan> data)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            string json = JsonSerializer.Serialize(
                data,
                new JsonSerializerOptions
                {
                    WriteIndented = true    
                }
            );

            File.WriteAllText(filePath, json);
        }

        public static void Tambah(KoreksiStokSimpan data)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            List<KoreksiStokSimpan> daftar = Load();

            daftar.Add(data);

            Save(daftar);
        }
    }
}
