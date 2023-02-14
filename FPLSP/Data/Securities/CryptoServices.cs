using System.Security.Cryptography;
using System.Text;
namespace FPLSP.Data.Securities
{
    public class CryptoServices
    {

        static string FPLSPKey = "#@!_+=|#%^&*()_~PLSPMaiDinhOnTop#@!_+=|#%^&*()_~";

        //mã hóa tham số truyền vào
        public string Encrypt(string toEncrypt)
        {
            byte[] keyArray;
            byte[] ToEncyptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

            string key = FPLSPKey;
            MD5CryptoServiceProvider hashMD5 = new MD5CryptoServiceProvider();
            keyArray = hashMD5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            hashMD5.Clear();
            //
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;
            //
            ICryptoTransform cryptoTransform = tdes.CreateEncryptor();
            byte[] resultArray = cryptoTransform.TransformFinalBlock(ToEncyptArray, 0, ToEncyptArray.Length);
            if (resultArray.ToArray().Any(c => c == '/'))
                tdes.Clear();
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }
        //gải mã hóa
        public string Decrypt(string cipherString)
        {
            byte[] keyArray;
            byte[] ToEncyptArray = Convert.FromBase64String(cipherString);

            string key = FPLSPKey;
            MD5CryptoServiceProvider hashMD5 = new MD5CryptoServiceProvider();
            keyArray = hashMD5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            hashMD5.Clear();
            //
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;
            //
            ICryptoTransform cryptoTransform = tdes.CreateDecryptor();
            byte[] resultArray = cryptoTransform.TransformFinalBlock(ToEncyptArray, 0, ToEncyptArray.Length);
            tdes.Clear();
            return UTF8Encoding.UTF8.GetString(resultArray);
        }
    }
}
