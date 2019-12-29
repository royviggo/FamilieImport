using System.Globalization;
using System.IO;
using System.Text;

namespace FamilieImport.Domain.Extensions
{
    public static class StringExtensions
    {
        public static string ToHexString(this byte[] bytes)
        {
            var stringBuilder = new StringBuilder();
            foreach (byte b in bytes)
            {
                stringBuilder.Append(b.ToString("X2"));
            }
            return stringBuilder.ToString();
        }

        public static string ToNormalString(this byte[] bytes)
        {
            return bytes != null ? Encoding.UTF8.GetString(bytes) : null;
        }
    }
}
