using project_akhir_stock_gudang;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text.Json;

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

        public static bool ToggleBan(string username, out string message)
        {
            List<UserAccount> users = LoadInternal();

            UserAccount? user = users.FirstOrDefault(u =>
                string.Equals(
                    u.Username,
                    username,
                    StringComparison.OrdinalIgnoreCase));

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

             
                user.PercobaanLoginGagal = 0;

                message = "Akun berhasil diaktifkan kembali. Percobaan login direset.";
            }
            else
            {
                message = "Status akun tidak dapat diubah.";
                return false;
            }

            SaveInternal(users);

            return true;
        }


        public static bool CreateActiveAccount(
            string username,
            string role,
            string password,
            out string message)
        {
            username = (username ?? "").Trim();

            if (username.Length < 3)
            {
                message = "Username minimal 3 karakter.";
                return false;
            }

            if (role != "Kasir" && role != "Gudang")
            {
                message = "Pilih role Kasir atau Gudang.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                message = "Password tidak boleh kosong.";
                return false;
            }

            if (PasswordTools.GetStrengthLevel(password) < 3)
            {
                message = "Password terlalu lemah. Gunakan tingkat 3 atau 4.";
                return false;
            }

            List<UserAccount> users = LoadInternal();

            bool usernameSudahAda = users.Any(u =>
                string.Equals(
                    u.Username,
                    username,
                    StringComparison.OrdinalIgnoreCase));

            if (usernameSudahAda)
            {
                message = "Username sudah terdaftar.";
                return false;
            }

            byte[] salt = RandomNumberGenerator.GetBytes(16);

            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
                password,
                salt,
                210000,
                HashAlgorithmName.SHA256,
                32);

            users.Add(new UserAccount
            {
                Username = username,
                Role = role,
                Status = Aktif,
                TanggalDaftar = DateTime.Now,
                PasswordSalt = Convert.ToBase64String(salt),
                PasswordHash = Convert.ToBase64String(hash)
            });

            SaveInternal(users);

            message = "Akun baru berhasil dibuat dan diaktifkan.";
            return true;
        }


 

        public static bool UpdatePassword(
    string username,
    string password,
    out string message)
        {
            List<UserAccount> users = LoadInternal();

            UserAccount? user = users.FirstOrDefault(u =>
                string.Equals(
                    u.Username,
                    username,
                    StringComparison.OrdinalIgnoreCase));

            if (user == null)
            {
                message = "Akun tidak ditemukan.";
                return false;
            }

          
            if (user.Status == Diblokir)
            {
                message = "Password tidak dapat diubah karena akun sedang diblokir. Aktifkan akun terlebih dahulu.";
                return false;
            }

            if (user.Status != Aktif)
            {
                message = "Password hanya dapat diubah untuk akun yang aktif.";
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
                password,
                salt,
                210000,
                HashAlgorithmName.SHA256,
                32);

            user.PasswordSalt = Convert.ToBase64String(salt);
            user.PasswordHash = Convert.ToBase64String(hash);

            SaveInternal(users);

            message = "Password berhasil diperbarui.";
            return true;
        }

        public static bool TryLogin(
      string username,
      string password,
      out UserAccount? account,
      out string message)
        {
            account = null;

            List<UserAccount> users = LoadInternal();

            UserAccount? user = users.FirstOrDefault(u =>
                string.Equals(
                    u.Username,
                    (username ?? "").Trim(),
                    StringComparison.OrdinalIgnoreCase));

            if (user == null)
            {
                message = "Username atau password salah.";
                return false;
            }

       
            if (user.Status == Ditolak)
            {
                message = "Pendaftaran akun ditolak.";
                return false;
            }

            if (user.Status == Diblokir)
            {
                message = "Akun telah diblokir. Hubungi admin untuk mengaktifkannya kembali.";
                return false;
            }

            if (user.Status != Aktif ||
                string.IsNullOrEmpty(user.PasswordSalt) ||
                string.IsNullOrEmpty(user.PasswordHash))
            {
                message = "Akun belum siap digunakan.";
                return false;
            }

            try
            {
                byte[] salt = Convert.FromBase64String(user.PasswordSalt);

                byte[] storedHash =
                    Convert.FromBase64String(user.PasswordHash);

                byte[] enteredHash = Rfc2898DeriveBytes.Pbkdf2(
                    password ?? "",
                    salt,
                    210000,
                    HashAlgorithmName.SHA256,
                    32);

          
                if (!CryptographicOperations.FixedTimeEquals(
                    enteredHash, storedHash))
                {
                    user.PercobaanLoginGagal++;

                    if (user.PercobaanLoginGagal >= 3)
                    {
                        user.Status = Diblokir;

                        SaveInternal(users);

                        message = "Password salah 3 kali. Akun telah diblokir. Hubungi admin untuk mengaktifkannya kembali.";
                    }
                    else
                    {
                        int sisa = 3 - user.PercobaanLoginGagal;

                        SaveInternal(users);

                        message = "Password salah. Kesempatan tersisa: "
                                  + sisa + " kali.";
                    }

                    return false;
                }
            }
            catch (FormatException)
            {
                message = "Data keamanan akun tidak valid.";
                return false;
            }

         
            user.PercobaanLoginGagal = 0;
            user.TerakhirLogin = DateTime.Now;

            SaveInternal(users);

            account = user;
            message = "Login berhasil.";

            return true;
        }

        public static bool GantiPasswordSendiri(
        string username,
        string passwordLama,
        string passwordBaru,
        out string message)
        {
            List<UserAccount> users = LoadInternal();

            UserAccount? user = users.FirstOrDefault(u =>
                string.Equals(
                    u.Username,
                    username,
                    StringComparison.OrdinalIgnoreCase
                )
            );

            if (user == null)
            {
                message = "Akun tidak ditemukan.";
                return false;
            }

            if (user.Status != Aktif)
            {
                message = "Password hanya dapat diubah pada akun aktif.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(passwordLama) ||
                string.IsNullOrWhiteSpace(passwordBaru))
            {
                message = "Password lama dan password baru wajib diisi.";
                return false;
            }

            try
            {
                byte[] saltLama =
                    Convert.FromBase64String(user.PasswordSalt);

                byte[] hashTersimpan =
                    Convert.FromBase64String(user.PasswordHash);

                byte[] hashLama = Rfc2898DeriveBytes.Pbkdf2(
                    passwordLama,
                    saltLama,
                    210000,
                    HashAlgorithmName.SHA256,
                    32
                );

                if (!CryptographicOperations.FixedTimeEquals(
                    hashLama, hashTersimpan))
                {
                    message = "Password lama yang kamu masukkan salah.";
                    return false;
                }
            }
            catch (FormatException)
            {
                message = "Data keamanan akun tidak valid.";
                return false;
            }

            if (passwordLama == passwordBaru)
            {
                message = "Password baru harus berbeda dari password lama.";
                return false;
            }


            if (passwordBaru.Length < 8 ||
                !passwordBaru.Any(char.IsLower) ||
                !passwordBaru.Any(char.IsUpper) ||
                !passwordBaru.Any(char.IsDigit) ||
                !passwordBaru.Any(c => !char.IsLetterOrDigit(c)))
            {
                message = "Password baru belum memenuhi semua kriteria.";
                return false;
            }

            byte[] saltBaru = RandomNumberGenerator.GetBytes(16);

            byte[] hashBaru = Rfc2898DeriveBytes.Pbkdf2(
                passwordBaru,
                saltBaru,
                210000,
                HashAlgorithmName.SHA256,
                32
            );

            user.PasswordSalt = Convert.ToBase64String(saltBaru);
            user.PasswordHash = Convert.ToBase64String(hashBaru);
            user.TerakhirGantiPassword = DateTime.Now;

            SaveInternal(users);

            message = "Password berhasil diperbarui.";
            return true;
        }
    }
}