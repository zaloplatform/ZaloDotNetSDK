using System.Security.Cryptography;
using System.Text;

namespace ZaloDotNetSDK
{
    public class MacUtils
    {
        public static string buildMac(string value)
        {
            SHA256 sha256 = SHA256Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(value);
            byte[] hash = sha256.ComputeHash(bytes);
            return GetStringFromHash(hash);
        }
        private static string GetStringFromHash(byte[] hash)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2").ToLower());
            }
            return result.ToString();
        }
    }
}
