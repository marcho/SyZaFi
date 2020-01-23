using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace SyZaFi
{

    public class PwdEncryption
    {
        public const int SALT_SIZE = 24; // size in bytes
        public const int HASH_SIZE = 24; // size in bytes
        public const int ITERATIONS = 10000; // number of pbkdf2 iterations

        public string GenerateHash(string input)
        {
            // Generate a salt
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            byte[] salt = new byte[SALT_SIZE];
            provider.GetBytes(salt);
            if (File.Exists("salt.txt"))
            {
                File.Delete("salt.txt");
            }
            File.WriteAllText("salt.txt", Convert.ToBase64String(salt, 0, salt.Length));


            // Generate the hash
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(input, salt, ITERATIONS);
            return Convert.ToBase64String(pbkdf2.GetBytes(HASH_SIZE), 0, pbkdf2.GetBytes(HASH_SIZE).Length);
        }

        public string GenerateHashOnLogin(string input, byte[] salt)
        {
            // Generate the hash
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(input, salt, ITERATIONS);
            return Convert.ToBase64String(pbkdf2.GetBytes(HASH_SIZE), 0, pbkdf2.GetBytes(HASH_SIZE).Length);
        }
    }
}
