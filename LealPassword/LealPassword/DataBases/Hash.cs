using System.Security.Cryptography;

namespace LealPassword.DataBases
{
    [System.Serializable]
    internal sealed class Hash
    {
        internal Hash(string unHashedpass)
        {
            Hashed = HashString(unHashedpass);
        }

        internal string Hashed { get; set; }

        internal static string HashString(string unhashedstring)
        {
            var data = System.Text.Encoding.UTF8.GetBytes(unhashedstring);

            using (var hash = SHA512.Create())
            {
                var hashedInputBytes = hash.ComputeHash(data);
                var hashedInputStringBuilder = new System.Text.StringBuilder(128);

                foreach (var b in hashedInputBytes)
                    hashedInputStringBuilder.Append(b.ToString("X2"));

                return hashedInputStringBuilder.ToString();
            }
        }
    }
}