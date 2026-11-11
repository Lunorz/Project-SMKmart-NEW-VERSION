using project_akhir_stock_gudang;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace project_akhir_stock_gudang
{
    public static class UserStore
    {
        private static readonly string filePath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, "accounts.json");

        private static readonly JsonSerializerOptions jsonOptions = new()
        {
            WriteIndented = true
        };

        public const string Menunggu = "Menunggu";
        public const string Aktif = "Aktif";
        public const string Diblokir = "Diblokir";
        public const string Ditolak = "Ditolak";

        private static List<UserAccount> LoadInternal()
        {
            if (!File.Exists(filePath))
                return new List<UserAccount>();

            string json = File.ReadAllText(filePath);
            if (string.IsNullOrWhiteSpace(json))
                return new List<UserAccount>();

            return JsonSerializer.Deserialize<List<UserAccount>>(json, jsonOptions)
                   ?? new List<UserAccount>();
        }

        private static void SaveInternal(List<UserAccount> users)
        {
            string json = JsonSerializer.Serialize(users, jsonOptions);
            string tempPath = filePath + ".tmp";
            File.WriteAllText(tempPath, json);
            File.Move(tempPath, filePath, true);
        }

        public static List<UserAccount> GetAll() => LoadInternal();

        public static bool RegisterPending(
            string username, string email, string role, out string message)
        {
            username = (username ?? "").Trim();
            email = (email ?? "").Trim();

            if (username.Length < 3)
            {
                message = "Username minimal 3 karakter.";
                return false;
            }

            // Domain @gmail.com harus menggunakan huruf kecil persis.
            if (!Regex.IsMatch(email, @"^[A-Za-z0-9._%+-]+@gmail\.com$"))
            {
                message = "Gunakan email Gmail dan tulis domain sebagai @gmail.com.";
                return false;
            }

            if (role != "Kasir" && role != "Gudang")
            {
                message = "Pilih role Kasir atau Gudang.";
                return false;
            }

            email = email.ToLowerInvariant();
            List<UserAccount> users = LoadInternal();
            UserAccount? existing = users.FirstOrDefault(u =>
                string.Equals(u.Email, email, StringComparison.OrdinalIgnoreCase));

            if (existing != null)
            {
                if (existing.Status != Ditolak)
                {
                    message = "Email ini sudah terdaftar atau sedang diproses.";
                    return false;
                }

                existing.Username = username;
                existing.Role = role;
                existing.Status = Menunggu;
                existing.TanggalDaftar = DateTime.Now;
                existing.PasswordHash = "";
                existing.PasswordSalt = "";
                SaveInternal(users);
                message = "Pendaftaran ulang berhasil dikirim.";
                return true;
            }

            users.Add(new UserAccount
            {
                Username = username,
                Email = email,
                Role = role,
                Status = Menunggu,
                TanggalDaftar = DateTime.Now
            });

            SaveInternal(users);
            message = "Pendaftaran berhasil. Tunggu persetujuan admin.";
            return true;
        }

        public static bool ApproveAccount(
            string email, string password, out string message)
        {
            List<UserAccount> users = LoadInternal();
            UserAccount? user = users.FirstOrDefault(u =>
                string.Equals(u.Email, email, StringComparison.OrdinalIgnoreCase));

            if (user == null || user.Status != Menunggu)
            {
                message = "Permintaan tidak ditemukan atau sudah diproses.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                message = "Password tidak boleh kosong.";
                return false;
            }

            if (PasswordTools.GetStrengthLevel(password) < 3)
            {
                message = "Password terlalu lemah. Gunakan password tingkat 3 atau 4.";
                return false;
            }

            byte[] salt = RandomNumberGenerator.GetBytes(16);
            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
                password, salt, 210000, HashAlgorithmName.SHA256, 32);

            user.PasswordSalt = Convert.ToBase64String(salt);
            user.PasswordHash = Convert.ToBase64String(hash);
            user.Status = Aktif;
            SaveInternal(users);

            message = "Akun berhasil disetujui dan diaktifkan.";
            return true;
        }

        public static bool RejectAccount(string email, out string message)
        {
            List<UserAccount> users = LoadInternal();
            UserAccount? user = users.FirstOrDefault(u =>
                string.Equals(u.Email, email, StringComparison.OrdinalIgnoreCase));

            if (user == null || user.Status != Menunggu)
            {
                message = "Permintaan tidak ditemukan atau sudah diproses.";
                return false;
            }

            user.Status = Ditolak;
            user.PasswordHash = "";
            user.PasswordSalt = "";
            SaveInternal(users);
            message = "Pendaftaran berhasil ditolak.";
            return true;
        }

        public static bool ToggleBan(string email, out string message)
        {
            List<UserAccount> users = LoadInternal();
            UserAccount? user = users.FirstOrDefault(u =>
                string.Equals(u.Email, email, StringComparison.OrdinalIgnoreCase));

            if (user == null)
            {
                message = "Akun tidak ditemukan.";
                return false;
            }

            if (user.Status == Aktif)
            {
                user.Status = Diblokir;
                message = "Akun berhasil diblokir.";
            }
            else if (user.Status == Diblokir)
            {
                user.Status = Aktif;
                message = "Akun berhasil diaktifkan kembali.";
            }
            else
            {
                message = "Hanya akun Aktif atau Diblokir yang dapat diubah.";
                return false;
            }

            SaveInternal(users);
            return true;
        }

        public static bool TryLogin(
            string email, string password, out UserAccount? account, out string message)
        {
            account = null;
            List<UserAccount> users = LoadInternal();
            UserAccount? user = users.FirstOrDefault(u =>
                string.Equals(u.Email, (email ?? "").Trim(), StringComparison.OrdinalIgnoreCase));

            if (user == null)
            {
                message = "Email atau password salah.";
                return false;
            }

            if (user.Status == Menunggu)
            {
                message = "Akun masih menunggu persetujuan admin.";
                return false;
            }
            if (user.Status == Ditolak)
            {
                message = "Pendaftaran akun ditolak.";
                return false;
            }
            if (user.Status == Diblokir)
            {
                message = "Akun sedang diblokir. Hubungi admin.";
                return false;
            }
            if (user.Status != Aktif || string.IsNullOrEmpty(user.PasswordSalt) ||
                string.IsNullOrEmpty(user.PasswordHash))
            {
                message = "Akun belum siap digunakan.";
                return false;
            }

            try
            {
                byte[] salt = Convert.FromBase64String(user.PasswordSalt);
                byte[] storedHash = Convert.FromBase64String(user.PasswordHash);
                byte[] enteredHash = Rfc2898DeriveBytes.Pbkdf2(
                    password ?? "", salt, 210000, HashAlgorithmName.SHA256, 32);

                if (!CryptographicOperations.FixedTimeEquals(enteredHash, storedHash))
                {
                    message = "Email atau password salah.";
                    return false;
                }
            }
            catch (FormatException)
            {
                message = "Data keamanan akun tidak valid.";
                return false;
            }

            account = user;
            message = "Login berhasil.";
            return true;
        }
    }
}