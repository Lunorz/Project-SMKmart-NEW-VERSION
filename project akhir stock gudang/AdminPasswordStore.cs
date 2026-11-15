
using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text.Json;

namespace project_akhir_stock_gudang
{
    public static class AdminPasswordStore
    {
        private static readonly string filePath =
            Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "admin_account.json"
            );

        private class AdminData
        {
            public string Email { get; set; } = "admin@gmail.com";
            public string PasswordHash { get; set; } = "";
            public string PasswordSalt { get; set; } = "";
            public DateTime? TerakhirLogin { get; set; }
            public DateTime? TerakhirGantiPassword { get; set; }
        }

        private static AdminData Load()
        {
            if (!File.Exists(filePath))
            {
                AdminData baru = BuatDataAwal();
                Save(baru);
                return baru;
            }

            string json = File.ReadAllText(filePath);

            AdminData? data =
                JsonSerializer.Deserialize<AdminData>(json);

            if (data == null ||
                string.IsNullOrWhiteSpace(data.PasswordHash) ||
                string.IsNullOrWhiteSpace(data.PasswordSalt))
            {
                throw new InvalidDataException(
                    "Data akun Admin tidak valid."
                );
            }

            return data;
        }

        private static AdminData BuatDataAwal()
        {
            // Password awal Admin yang sebelumnya digunakan di Form1.
            const string passwordAwal = "Admin758150!";

            byte[] salt = RandomNumberGenerator.GetBytes(16);

            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
                passwordAwal,
                salt,
                210000,
                HashAlgorithmName.SHA256,
                32
            );

            return new AdminData
            {
                Email = "admin@gmail.com",
                PasswordSalt = Convert.ToBase64String(salt),
                PasswordHash = Convert.ToBase64String(hash)
            };
        }

        private static void Save(AdminData data)
        {
            string json = JsonSerializer.Serialize(
                data,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                }
            );

            string tempPath = filePath + ".tmp";

            File.WriteAllText(tempPath, json);
            File.Move(tempPath, filePath, true);
        }

        private static bool Cocok(
            string password,
            AdminData data)
        {
            byte[] salt =
                Convert.FromBase64String(data.PasswordSalt);

            byte[] hashTersimpan =
                Convert.FromBase64String(data.PasswordHash);

            byte[] hashMasukan = Rfc2898DeriveBytes.Pbkdf2(
                password,
                salt,
                210000,
                HashAlgorithmName.SHA256,
                32
            );

            return CryptographicOperations.FixedTimeEquals(
                hashMasukan,
                hashTersimpan
            );
        }

        public static bool TryLogin(
            string email,
            string password)
        {
            if (!string.Equals(
                email?.Trim(),
                "admin@gmail.com",
                StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            AdminData data = Load();

            if (!Cocok(password ?? "", data))
                return false;

            data.TerakhirLogin = DateTime.Now;
            Save(data);

            return true;
        }

        public static bool GantiPassword(
            string passwordLama,
            string passwordBaru,
            out string message)
        {
            AdminData data = Load();

            if (!Cocok(passwordLama, data))
            {
                message = "Password lama Admin salah.";
                return false;
            }

            if (passwordLama == passwordBaru)
            {
                message = "Password baru harus berbeda dari password lama.";
                return false;
            }

            if (!PasswordMemenuhiSyarat(passwordBaru))
            {
                message = "Password baru belum memenuhi semua kriteria.";
                return false;
            }

            byte[] salt = RandomNumberGenerator.GetBytes(16);

            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
                passwordBaru,
                salt,
                210000,
                HashAlgorithmName.SHA256,
                32
            );

            data.PasswordSalt = Convert.ToBase64String(salt);
            data.PasswordHash = Convert.ToBase64String(hash);
            data.TerakhirGantiPassword = DateTime.Now;

            Save(data);

            message = "Password Admin berhasil diperbarui.";
            return true;
        }

        public static DateTime? GetTerakhirLogin()
        {
            return Load().TerakhirLogin;
        }

        public static DateTime? GetTerakhirGantiPassword()
        {
            return Load().TerakhirGantiPassword;
        }

        private static bool PasswordMemenuhiSyarat(string password)
        {
            return !string.IsNullOrEmpty(password) &&
                   password.Length >= 8 &&
                   password.Any(char.IsLower) &&
                   password.Any(char.IsUpper) &&
                   password.Any(char.IsDigit) &&
                   password.Any(c => !char.IsLetterOrDigit(c));
        }
    }
}
