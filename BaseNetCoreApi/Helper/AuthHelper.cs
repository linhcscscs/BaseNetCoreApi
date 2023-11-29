using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace BaseNetCoreApi.Helper
{
    public static class AuthHelper
    {
        public static string MD5(string value)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(value);
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] result = md5.ComputeHash(bytes);
                for (int i = 0; i < result.Length; i++)
                {
                    sb.Append(result[i].ToString("x2"));
                }
            }
            catch
            { return value; }
            return sb.ToString();
        }
        public static string GetByClaim(ClaimsPrincipal principal , string claimName)
        {
            return principal.FindFirst(claimName)?.Value ?? "";
        }
    }
}
