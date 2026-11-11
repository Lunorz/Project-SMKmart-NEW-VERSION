
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace project_akhir_stock_gudang
{
    public static class BarangKeluarJsonStore
    {
        private static readonly string filePath =
            Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "barang_keluar.json"
            );

        public static List<BarangKeluarSimpan> Load()
        {
            if (!File.Exists(filePath))
                return new List<BarangKeluarSimpan>();

            string json = File.ReadAllText(filePath);

            if (string.IsNullOrWhiteSpace(json))
                return new List<BarangKeluarSimpan>();

            return JsonSerializer.Deserialize<List<BarangKeluarSimpan>>(json)
                   ?? new List<BarangKeluarSimpan>();
        }

        public static void Save(List<BarangKeluarSimpan> data)
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

        public static void Tambah(BarangKeluarSimpan data)
        {
            List<BarangKeluarSimpan> daftar = Load();

            daftar.Add(data);

            Save(daftar);
        }

        public static void CatatPenjualan(List<DetailTransaksiSimpan> barang,string usernameKasir,DateTime waktuTransaksi)
        {
            List<BarangKeluarSimpan> daftar = Load();

            foreach (var item in barang)
            {
                daftar.Add(new BarangKeluarSimpan
                {
                    Waktu = waktuTransaksi,
                    KodeBarang = item.Kode,
                    NamaBarang = item.Nama,
                    Jumlah = item.Jumlah,
                    Jenis = "Penjualan",
                    Alasan = "Penjualan",
                    Petugas = usernameKasir,
                    Catatan = ""
                });
            }
        }
    }
}
