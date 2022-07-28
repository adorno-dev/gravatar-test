using System.Security.Cryptography;
using System.Text;

namespace Gravatar
{
    public static class GravatarExtension
    {
        public static string ToGravatar(this string email, int size = 64)
        {
            if (string.IsNullOrEmpty(email))
                return string.Empty;

            var sb = new StringBuilder();            
            
            using (var md5 = MD5.Create())
            {
                var emailBytes = Encoding.ASCII.GetBytes(email);
                var hashBytes = md5.ComputeHash(emailBytes);

                foreach (var t in hashBytes)
                    sb.Append(t.ToString("X2"));
            }
            
            return $"https://gravatar.com/avatar/{sb.ToString().ToLower()}?s={size}";
        }
    }
}