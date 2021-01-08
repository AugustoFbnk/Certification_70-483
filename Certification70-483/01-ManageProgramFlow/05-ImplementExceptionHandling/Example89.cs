using System;

namespace Certification70_483._01_ManageProgramFlow._05_ImplementExceptionHandling
{
    /// <summary>
    /// Catching a FormatException
    /// </summary>
    public static class Example89
    {
        public static void Start()
        {
            while (true)
            {
                string s = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(s)) break;
                try
                {
                    int i = int.Parse(s);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("{0} is not a valid number. Please try again", s);
                }
            }
        }
    }
}
