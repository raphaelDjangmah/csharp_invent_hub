using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Invent_HUB.csharp_invent_hub.Backend
{
    internal class PwdHashing
    {
        public static string hash(string password)
        {
            string hashedPwd = SHA.GenerateSHA512String(password);
            string truncatedPwd = "$X$d" + hashedPwd.Substring(hashedPwd.Length - 25);
            return truncatedPwd;
        }

        public static bool verifyHash(string password, string dbPassword)
        {

            //hash the password gotten
            string hashed = hash(password);


            //return just the last 
            return (hashed == dbPassword);
        }
    }
}

public class SHA
{

    public static string GenerateSHA512String(string inputString)
    {
        SHA512 sha512 = SHA512Managed.Create();
        byte[] bytes = Encoding.UTF8.GetBytes(inputString);
        byte[] hash = sha512.ComputeHash(bytes);
        return GetStringFromHash(hash);
    }

    private static string GetStringFromHash(byte[] hash)
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < hash.Length; i++)
        {
            result.Append(hash[i].ToString("X2"));
        }
        return result.ToString();
    }

}

