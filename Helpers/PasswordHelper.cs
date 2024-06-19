using System.Security.Cryptography;
using System.Text;

namespace BBB.Helpers
{
    /// <summary>
    /// Crypt helper for the password
    /// </summary>
    internal class PasswordHelper
    {
        private static readonly int _keySize = 64;
        private static readonly int _iterations = 350000;

        private static readonly HashAlgorithmName _hashAlgorithm = HashAlgorithmName.SHA512;

        /// <summary>
        /// Hashes the specified password.
        /// The hash should be randomly generated with a method such as
        /// RandomNumberGenerator.GetBytes(_keySize), but for simplicity
        /// it is a hard coded string.
        /// </summary>
        /// <param name="password">The password.</param>
        /// <returns>A hash of the given password</returns>
        public static string Hash(string password)
        {
            var salt = Encoding.ASCII.GetBytes("ShouldBeRandom");

            var hash = Rfc2898DeriveBytes.Pbkdf2(Encoding.UTF8.GetBytes(password), salt, _iterations, _hashAlgorithm, _keySize);

            return Convert.ToHexString(hash);
        }
    }
}