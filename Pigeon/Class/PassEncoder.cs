using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Pigeon.PassCode
{
    public class PassEncoder
    {
        #region Private/Protected
        protected static readonly byte[] IV = ASCIIEncoding.ASCII.GetBytes("7ht7i9k6grt6uhg5");
        protected static readonly byte[] Key = ASCIIEncoding.ASCII.GetBytes("5ljdrfpogje5iogj");
        private static RijndaelManaged GetAesInstance()
        {
            RijndaelManaged aes = new RijndaelManaged();
            aes.Key = PassEncoder.Key;
            aes.IV = PassEncoder.IV;

            return aes;
        }
        #endregion

        #region Public Static Methods
        /// <summary>
        /// Pozwala zaszyfrować parametr tekstowy, 
        /// zwraca zaszyfrowany tekst
        /// </summary>
        /// <param name="_pass"></param>
        /// <returns></returns>
        public static string Encode(string _pass)
        {
            var aes = GetAesInstance();
            string encrypted = "";
            using(MemoryStream stream = new MemoryStream())
            {
                using(CryptoStream cs = new CryptoStream(stream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    using(StreamWriter writer = new StreamWriter(cs))
                    {
                        writer.Write(_pass);
                    }
                }
                encrypted = Convert.ToBase64String(stream.ToArray());
            }

            return encrypted;
        }

        /// <summary>
        /// Pozwala odszyfrować, wcześniej zaszyfrowany ciąg znaków, 
        /// zwraca odszyfrowany tekst
        /// </summary>
        /// <param name="_code"></param>
        /// <returns></returns>
        public static string Decode(string _code)
        {
            var aes = GetAesInstance();
            string decrypted = "";
            try
            {
                using (MemoryStream stream = new MemoryStream(Convert.FromBase64String(_code)))
                {
                    using (CryptoStream cs = new CryptoStream(stream, aes.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        using (StreamReader reader = new StreamReader(cs))
                        {
                            decrypted = reader.ReadToEnd();
                        }
                    }
                }
            }
            catch(Exception exception)
            {

            }

            return decrypted;
        }
        #endregion
    }
}
