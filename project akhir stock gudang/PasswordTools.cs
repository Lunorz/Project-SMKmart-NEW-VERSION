
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace project_akhir_stock_gudang
{
    public static class PasswordTools
    {
      

        public static int GetStrengthLevel(string password)
        {
            if (string.IsNullOrEmpty(password))
                return 0;

            int score = 0;

            if (password.Length >= 8) score++;
            if (password.Length >= 12) score++;
            if (password.Any(char.IsLower)) score++;
            if (password.Any(char.IsUpper)) score++;
            if (password.Any(char.IsDigit)) score++;
            if (password.Any(c => !char.IsLetterOrDigit(c))) score++;
            
            if (score <= 1) return 1;
            if (score == 2) return 2;
            if (score <= 4) return 3;

            return 4;
        }

        
        public static string GeneratePassword(int length = 12)
        {
            if (length < 8)
                throw new ArgumentOutOfRangeException(
                    nameof(length),
                    "Password minimal 8 karakter."
                );

            const string lower = "abcdefghijkmnopqrstuvwxyz";
            const string upper = "ABCDEFGHJKLMNPQRSTUVWXYZ";
            const string numbers = "23456789";
            const string symbols = "!@#$%*?";

            string all = lower + upper + numbers + symbols;

            List<char> chars = new()
            {
                lower[RandomNumberGenerator.GetInt32(lower.Length)],
                upper[RandomNumberGenerator.GetInt32(upper.Length)],
                numbers[RandomNumberGenerator.GetInt32(numbers.Length)],
                symbols[RandomNumberGenerator.GetInt32(symbols.Length)]
            };

            while (chars.Count < length)
            {
                chars.Add(
                    all[RandomNumberGenerator.GetInt32(all.Length)]
                );
            }

            
            for (int i = chars.Count - 1; i > 0; i--)
            {
                int j = RandomNumberGenerator.GetInt32(i + 1);

                (chars[i], chars[j]) = (chars[j], chars[i]);
            }

            return new string(chars.ToArray());
        }
    }
}
