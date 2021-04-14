using System;
using System.Security.Cryptography;

namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._02_PerformSymmetricAndAsymmetricEncryption
{
    /// <summary>
    /// Exporting a public key
    /// </summary>
    public class Example18
    {
        public static void Start()
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            string publicKeyXML = rsa.ToXmlString(false);
            string privateKeyXML = rsa.ToXmlString(true);
            Console.WriteLine(publicKeyXML);
            Console.WriteLine(privateKeyXML);
            Console.ReadKey();
        }
    }
}
