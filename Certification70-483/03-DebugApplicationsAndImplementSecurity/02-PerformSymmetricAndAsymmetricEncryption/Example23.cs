using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._02_PerformSymmetricAndAsymmetricEncryption
{
    /// <summary>
    /// Using SHA256Managed to calculate a hash code
    /// </summary>
    public class Example23
    {
        public static void Start()
        {
            UnicodeEncoding byteConverter = new UnicodeEncoding();
            SHA256 sha256 = SHA256.Create();
            string data = "A paragraph of text";
            byte[] hashA = sha256.ComputeHash(byteConverter.GetBytes(data));

            data = "A paragraph of changed text";
            byte[] hashB = sha256.ComputeHash(byteConverter.GetBytes(data));
            data = "A paragraph of text";
            byte[] hashC = sha256.ComputeHash(byteConverter.GetBytes(data));
            Console.WriteLine(hashA.SequenceEqual(hashB)); // Displays: false
            Console.WriteLine(hashA.SequenceEqual(hashC)); // Displays: true
        }
    }
}
