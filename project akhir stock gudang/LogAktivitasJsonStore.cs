
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace project_akhir_stock_gudang
{
    public static class LogAktivitasJsonStore
    {
        private static readonly string filePath =
            Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "log_aktivitas.json"
            );

        public static List<LogAktivitas> Load()
        {
            if (!File.Exists(filePath))
                return new List<LogAktivitas>();

            string json = File.ReadAllText(filePath);

            if (string.IsNullOrWhiteSpace(json))
                return new List<LogAktivitas>();

            return JsonSerializer.Deserialize<List<LogAktivitas>>(
                json,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }
            ) ?? new List<LogAktivitas>();
        }

        public static void Save(List<LogAktivitas> data)
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

        public static void Tambah(LogAktivitas data)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            List<LogAktivitas> daftar = Load();

            daftar.Add(data);

            Save(daftar);
        }

        public static void Catat(
            string pengguna,
            string role,
            string kategori,
            string aktivitas,
            string target,
            string keterangan = "")
        {
            Tambah(new LogAktivitas
            {
                Waktu = DateTime.Now,
                Pengguna = pengguna ?? "",
                Role = role ?? "",
                Kategori = kategori ?? "",
                Aktivitas = aktivitas ?? "",
                Target = target ?? "",
                Keterangan = keterangan ?? ""
            });
        }
    }
}
