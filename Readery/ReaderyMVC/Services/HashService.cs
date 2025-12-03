using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ReaderyMVC.Services
{
    public static class HashService
    {
        public static byte[] GerarHashBytes(string senha)
        {
            using (SHA256 sha = SHA256.Create())
            {
                return sha.ComputeHash(Encoding.UTF8.GetBytes(senha));
            }
        }
    }
}