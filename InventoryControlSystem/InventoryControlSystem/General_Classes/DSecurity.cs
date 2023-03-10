using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace InventoryControlSystem.General_Classes
{
    public class DSecurity
    {
        const int keySize = 64;
        const int iteration = 35000;
        HashAlgorithmName hashAlgorithmName = HashAlgorithmName.SHA512;

        public static string DataEncryption(string secure, out byte[] salt)
        {
            salt = RandomNumberGenerator.GetBytes(keySize);
            var hash = Rfc2898DeriveBytes.Pbkdf2(Encoding.UTF8.GetBytes(secure), 
                salt, 
                iteration, 
                // FIX ME: HashAlgorithm, 
                keySize);

            return Convert.ToHexString(hash);
        }
    }
}
