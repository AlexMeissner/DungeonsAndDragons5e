using System.Security.Cryptography;

namespace RestAPI.Controllers
{
    public static class PasswordHasher
    {
        public static byte[] ComputeHash(string password, byte[] salt)
        {
            Rfc2898DeriveBytes hashGenerator = new(password, salt)
            {
                IterationCount = 10101
            };

            return hashGenerator.GetBytes(24);
        }

        public static byte[] GenerateSalt()
        {
            RNGCryptoServiceProvider saltGenerator = new();
            byte[] salt = new byte[24];
            saltGenerator.GetBytes(salt);
            return salt;
        }

        public static bool VerifyPassword(string password, byte[] passwordSalt, byte[] passwordHash)
        {
            byte[] computedHash = ComputeHash(password, passwordSalt);
            return AreHashesEqual(computedHash, passwordHash);
        }

        private static bool AreHashesEqual(byte[] firstHash, byte[] secondHash)
        {
            int minHashLenght = firstHash.Length <= secondHash.Length ? firstHash.Length : secondHash.Length;
            var xor = firstHash.Length ^ secondHash.Length;

            for (int i = 0; i < minHashLenght; i++)
            {
                xor |= firstHash[i] ^ secondHash[i];
            }

            return 0 == xor;
        }
    }
}