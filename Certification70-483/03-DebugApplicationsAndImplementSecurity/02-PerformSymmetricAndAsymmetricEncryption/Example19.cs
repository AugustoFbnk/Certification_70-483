using System;
using System.Security.Cryptography;
using System.Text;

namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._02_PerformSymmetricAndAsymmetricEncryption
{
    /// <summary>
    /// Using a public and private key to encrypt and decrypt data
    /// </summary>
    public class Example19
    {
        public static void Start()
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            string publicKeyXML = rsa.ToXmlString(false);
            string privateKeyXML = rsa.ToXmlString(true);


            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            byte[] dataToEncrypt = ByteConverter.GetBytes("My Secret Data");
            byte[] encryptedData;
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.FromXmlString(publicKeyXML);
                encryptedData = RSA.Encrypt(dataToEncrypt, false);
            }
            byte[] decryptedData;
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.FromXmlString(privateKeyXML);
                decryptedData = RSA.Decrypt(encryptedData, false);
            }
            string decryptedString = ByteConverter.GetString(decryptedData);
            Console.WriteLine(decryptedString); // Displays: My Secret Data!
        }
    }
}
