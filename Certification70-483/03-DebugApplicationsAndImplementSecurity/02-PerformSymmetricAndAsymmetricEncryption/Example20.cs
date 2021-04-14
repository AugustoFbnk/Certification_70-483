using System.Security.Cryptography;
using System.Text;

namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._02_PerformSymmetricAndAsymmetricEncryption
{
    /// <summary>
    /// Using a key container for storing an asymmetric key
    /// </summary>
    public class Example20
    {
        public static void Start()
        {
            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            byte[] dataToEncrypt = ByteConverter.GetBytes("My Secret Data");

            string containerName = "SecretContainer";
            CspParameters csp = new CspParameters() { KeyContainerName = containerName };
            byte[] encryptedData;
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(csp))
            {
                encryptedData = RSA.Encrypt(dataToEncrypt, false);
            }
        }
    }
}
