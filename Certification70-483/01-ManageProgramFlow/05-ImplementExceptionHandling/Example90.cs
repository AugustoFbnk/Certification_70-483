using System;

namespace Certification70_483._01_ManageProgramFlow._05_ImplementExceptionHandling
{
    /// <summary>
    /// Catching different exception types
    /// </summary>
    public static class Example90
    {
        public static void Start()
        {
            while (true)
            {
                string s = Console.ReadLine();
                try
                {
                    int i = int.Parse(s);
                    break;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("You need to enter a value");
                }
                catch (FormatException)
                {
                    Console.WriteLine("{0} is not a valid number.Please try again", s);
                }
            }
        }
    }
}
