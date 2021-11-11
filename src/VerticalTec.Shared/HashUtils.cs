using System;
using System.Security.Cryptography;
using System.Text;

namespace VerticalTec.Shared
{
    public static class HashUtils
    {
        public static string ToSha1(this string input, bool toUpper = true)
        {
            using (var sha1Hash = SHA1.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha1Hash.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);
                return toUpper ? hash.ToUpper() : hash;
            }
        }
    }
}
