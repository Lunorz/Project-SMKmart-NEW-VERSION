using project_akhir_stock_gudang;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

public static class UserStore
{
    private static readonly string filePath =
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.json");

    public static List<UserAccount> LoadUsers()
    {
        if (!File.Exists(filePath))
        {
            return new List<UserAccount>();
        }

        try
        {
            string json = File.ReadAllText(filePath);

            if (string.IsNullOrWhiteSpace(json))
            {
                return new List<UserAccount>();
            }

            return JsonSerializer.Deserialize<List<UserAccount>>(json)
                   ?? new List<UserAccount>();
        }
        catch
        {
            return new List<UserAccount>();
        }
    }

    public static void SaveUsers(List<UserAccount> users)
    {
        string json = JsonSerializer.Serialize(
            users,
            new JsonSerializerOptions
            {
                WriteIndented = true
            }
        );

        File.WriteAllText(filePath, json);
    }

    public static bool Register(string email, string password)
    {
        List<UserAccount> users = LoadUsers();

        bool emailSudahAda = users.Any(
            user => string.Equals(
                user.Email,
                email,
                StringComparison.OrdinalIgnoreCase
            )
        );

        if (emailSudahAda)
        {
            MessageBox.Show(
                "Email sudah terdaftar. Silakan gunakan email lain.",
                "Pendaftaran Gagal",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return false;
        }

        UserAccount userBaru = new UserAccount
        {
            Email = email,
            Password = password
        };

        users.Add(userBaru);

        SaveUsers(users);

        return true;
    }

    public static bool ValidateLogin(string email, string password)
    {
        List<UserAccount> users = LoadUsers();

        return users.Any(
            user =>
                string.Equals(
                    user.Email,
                    email,
                    StringComparison.OrdinalIgnoreCase
                )
                && user.Password == password
        );
    }
}