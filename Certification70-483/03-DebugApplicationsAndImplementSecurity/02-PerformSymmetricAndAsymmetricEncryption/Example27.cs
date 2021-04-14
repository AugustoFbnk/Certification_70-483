using System;
using System.Security;

namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._02_PerformSymmetricAndAsymmetricEncryption
{

    /// <summary>
    /// Initializing a SecureString
    /// </summary>
    public class Example27
    {

        public static void Start()
        {
            using (SecureString ss = new SecureString())
            {
                Console.Write("Please enter password: ");
                while (true)
                {
                    ConsoleKeyInfo cki = Console.ReadKey(true);
                    if (cki.Key == ConsoleKey.Enter) break;
                    ss.AppendChar(cki.KeyChar);
                    Console.Write("*");
                }
                ss.MakeReadOnly();
            }
        }
    }
}
