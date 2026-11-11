
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace project_akhir_stock_gudang
{
    public static class ProdukJsonStore
    {
        private static readonly string filePath =
            Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "produk.json"
            );

        public static List<Produk> Load()
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    return new List<Produk>();
                }

                string json = File.ReadAllText(filePath);

                if (string.IsNullOrWhiteSpace(json))
                {
                    return new List<Produk>();
                }

                return JsonSerializer.Deserialize<List<Produk>>(json)
                       ?? new List<Produk>();
            }
            catch (JsonException ex)
            {
                throw new Exception(
                    "Format produk.json tidak valid: " + ex.Message
                );
            }
            catch (IOException ex)
            {
                throw new Exception(
                    "Gagal membaca produk.json: " + ex.Message
                );
            }
        }

        public static void Save(List<Produk> daftarProduk)
        {
            if (daftarProduk == null)
            {
                throw new ArgumentNullException(
                    nameof(daftarProduk)
                );
            }

            try
            {
                string json = JsonSerializer.Serialize(
                    daftarProduk,
                    new JsonSerializerOptions
                    {
                        WriteIndented = true
                    }
                );

                File.WriteAllText(filePath, json);
            }
            catch (IOException ex)
            {
                throw new Exception(
                    "Gagal menyimpan produk.json: " + ex.Message
                );
            }
        }
    }
}
