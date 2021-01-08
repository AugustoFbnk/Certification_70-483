using System;

namespace Certification70_483._01_ManageProgramFlow._05_ImplementExceptionHandling
{
    /// <summary>
    /// Using Environment.FailFast
    /// </summary>
    public static class Example92
    {
        public static void Start()
        {
            string s = Console.ReadLine();
            try
            {
                int i = int.Parse(s);
                if (i == 42) Environment.FailFast("Special number entered");
            }
            finally
            {
                Console.WriteLine("Program complete.");
            }
        }
    }
}
