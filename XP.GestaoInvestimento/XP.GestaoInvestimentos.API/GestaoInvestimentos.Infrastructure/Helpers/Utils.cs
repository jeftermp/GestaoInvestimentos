using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace HCor.Helpers
{
    public class Utils
    {
        public static string Oracle_To_Date(DateTime? data)
        {
            return " TO_DATE('" + Convert.ToDateTime(data).ToString("dd/MM/yyyy") + "' ,'DD/MM/YYYY') ";
        }

        public static string GetCurrentMethod([CallerMemberName] string callerName = "")
        {
            return callerName;
        }
        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        public static string EncryptURL(string url, string key)
        {
            String pubB64 = key;
            String text = "abcdefg123456";
            byte[] textBytes = System.Text.Encoding.UTF8.GetBytes(url);
            byte[] publicKeyBytes = Convert.FromBase64String(pubB64);

            var keyLengthBits = 1024;  // need to know length of public key in advance!
            byte[] exponent = new byte[3];
            byte[] modulus = new byte[keyLengthBits / 8];
            Array.Copy(publicKeyBytes, publicKeyBytes.Length - exponent.Length, exponent, 0, exponent.Length);
            Array.Copy(publicKeyBytes, publicKeyBytes.Length - exponent.Length - 2 - modulus.Length, modulus, 0, modulus.Length);

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            RSAParameters rsaKeyInfo = rsa.ExportParameters(false);
            rsaKeyInfo.Modulus = modulus;
            rsaKeyInfo.Exponent = exponent;
            rsa.ImportParameters(rsaKeyInfo);

            byte[] encrypted = rsa.Encrypt(textBytes, RSAEncryptionPadding.Pkcs1);
            Console.WriteLine(Convert.ToBase64String(encrypted));

            return "";
        }

        public static string ConvertPdfToBase64(string filePath)
        {
            // Lê o conteúdo do arquivo em um array de bytes
            byte[] pdfBytes = File.ReadAllBytes(filePath);

            // Converte o array de bytes para uma string em base 64
            string base64String = Convert.ToBase64String(pdfBytes);

            return base64String;
        }

        public static bool IsNumber(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            foreach (char c in input)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
