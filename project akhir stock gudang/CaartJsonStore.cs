using project_akhir_stock_gudang;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Xml.Linq;

public static class CartJsonStore
{
    private static readonly string folderPath =
        Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "Data"
        );

    private static string SafeEmail(string email)
    {
        string aman = string.Concat(
            email.Select(c =>
                Path.GetInvalidFileNameChars().Contains(c)
                    ? '_'
                    : c)
        );

        return aman.ToLowerInvariant();
    }

    private static string CartPath(string email)
    {
        Directory.CreateDirectory(folderPath);

        return Path.Combine(
            folderPath,
            $"cart_{SafeEmail(email)}.json"
        );
    }

    private static string HistoryPath(string email)
    {
        Directory.CreateDirectory(folderPath);

        return Path.Combine(
            folderPath,
            $"riwayat_{SafeEmail(email)}.json"
        );
    }

    private static readonly JsonSerializerOptions jsonOptions =
        new JsonSerializerOptions
        {
            WriteIndented = true
        };

    public static List<CartItem> Load(string email)
    {
        string path = CartPath(email);

        if (!File.Exists(path))
            return new List<CartItem>();

        string json = File.ReadAllText(path);

        return JsonSerializer.Deserialize<List<CartItem>>(json)
               ?? new List<CartItem>();
    }

    public static void Save(
        string email,
        List<CartItem> items)
    {
        string json =
            JsonSerializer.Serialize(items, jsonOptions);

        File.WriteAllText(CartPath(email), json);
    }

    public static void Tambah(
        string email,
        string nama,
        decimal harga,
        int jumlah)
    {
        if (jumlah < 1)
            return;

        List<CartItem> items = Load(email);

        CartItem? item = items.FirstOrDefault(
            x => x.Nama == nama
        );

        if (item != null)
        {
            item.Jumlah += jumlah;
        }
        else
        {
            items.Add(new CartItem
            {
                Nama = nama,
                Harga = harga,
                Jumlah = jumlah
            });
        }

        Save(email, items);
    }

    public static void UbahJumlah(
        string email,
        string nama,
        int jumlah)
    {
        List<CartItem> items = Load(email);

        CartItem? item = items.FirstOrDefault(
            x => x.Nama == nama
        );

        if (item == null)
            return;

        if (jumlah <= 0)
            items.Remove(item);
        else
            item.Jumlah = jumlah;

        Save(email, items);
    }

    public static void Hapus(
        string email,
        string nama)
    {
        List<CartItem> items = Load(email);

        items.RemoveAll(x => x.Nama == nama);

        Save(email, items);
    }

    public static void Kosongkan(string email)
    {
        Save(email, new List<CartItem>());
    }

    public static List<OrderHistory> LoadHistory(
        string email)
    {
        string path = HistoryPath(email);

        if (!File.Exists(path))
            return new List<OrderHistory>();

        string json = File.ReadAllText(path);

        return JsonSerializer.Deserialize<List<OrderHistory>>(json)
               ?? new List<OrderHistory>();
    }

    public static bool Checkout(string email)
    {
        List<CartItem> items = Load(email);

        if (items.Count == 0)
            return false;

        List<OrderHistory> history = LoadHistory(email);

        OrderHistory pesanan = new OrderHistory
        {
            NomorPesanan = Guid.NewGuid().ToString("N"),
            Tanggal = DateTime.Now,
            Items = items.Select(item => new CartItem
            {
                Nama = item.Nama,
                Harga = item.Harga,
                Jumlah = item.Jumlah
            }).ToList()
        };

        history.Add(pesanan);

        string json =
            JsonSerializer.Serialize(history, jsonOptions);

        File.WriteAllText(HistoryPath(email), json);

        Kosongkan(email);

        return true;
    }
}