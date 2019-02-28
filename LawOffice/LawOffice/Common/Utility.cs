using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawOffice
{
    public static class Utility
    {
        public static bool UserAdmin;
        public static string Hash(string password)
        {
            byte[] bytes = new UTF8Encoding().GetBytes(password);
            byte[] hashBytes = System.Security.Cryptography.MD5.Create().ComputeHash(bytes);
            return Convert.ToBase64String(hashBytes);
        }
    }
}
