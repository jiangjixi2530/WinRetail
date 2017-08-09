using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BaseTool
{
    public class DataEncrypt
    {
        /// <summary>
        /// 关键字
        /// </summary>
        private static string KEY_ENCRYPT = "xigua";
        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="pDecryptStr"></param>
        /// <returns></returns>
        public static string DecryptString(string pDecryptStr)
        {
            DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
            byte[] bytes = new PasswordDeriveBytes(KEY_ENCRYPT, null).GetBytes(8);
            MemoryStream stream = new MemoryStream();
            CryptoStream stream2 = new CryptoStream(stream, provider.CreateDecryptor(bytes, bytes), CryptoStreamMode.Write);
            try
            {
                byte[] buffer = Convert.FromBase64String(pDecryptStr);
                stream2.Write(buffer, 0, buffer.Length);
                stream2.FlushFinalBlock();
                byte[] buffer3 = stream.ToArray();
                return Encoding.UTF8.GetString(buffer3);
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="pEncryptedStr"></param>
        /// <returns></returns>
        public static string EncryptString(string pEncryptedStr)
        {
            DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
            byte[] bytes = new PasswordDeriveBytes(KEY_ENCRYPT, null).GetBytes(8);
            MemoryStream stream = new MemoryStream();
            CryptoStream stream2 = new CryptoStream(stream, provider.CreateEncryptor(bytes, bytes), CryptoStreamMode.Write);
            try
            {
                byte[] buffer = Encoding.UTF8.GetBytes(pEncryptedStr);
                stream2.Write(buffer, 0, buffer.Length);
                stream2.FlushFinalBlock();
                return Convert.ToBase64String(stream.ToArray());
            }
            catch
            {
                return null;
            }
        }
    }
}
