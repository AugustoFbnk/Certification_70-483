using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._02_PerformSymmetricAndAsymmetricEncryption
{
    /// <summary>
    /// Getting the value of a SecureString
    /// </summary>
    public class Example28
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

                ConvertToUnsecureString(ss);
            }
        }

        public static void ConvertToUnsecureString(SecureString securePassword)
        {
            IntPtr unmanagedString = IntPtr.Zero;
            try
            {
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(securePassword);
                Console.WriteLine(Marshal.PtrToStringUni(unmanagedString));
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }
    }
}
