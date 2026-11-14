using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_akhir_stock_gudang
{
    public class UserAccount
    {
        public string Username { get; set; } = "";
        public string Email { get; set; } = "";
        public string Role { get; set; } = "";
        public string Status { get; set; } = "";
        public DateTime TanggalDaftar { get; set; } = DateTime.Now;
        public string PasswordHash { get; set; } = "";
        public string PasswordSalt { get; set; } = "";
        public int PercobaanLoginGagal { get; set; } = 0;
    }
}


