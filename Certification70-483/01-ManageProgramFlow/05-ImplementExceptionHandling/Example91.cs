using System;

namespace Certification70_483._01_ManageProgramFlow._05_ImplementExceptionHandling
{
    /// <summary>
    /// Using a finally block
    /// </summary>
    public static class Example91
    {
        public static void Start()
        {
            string s = Console.ReadLine();
            try
            {
                int i = int.Parse(s);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("You need to enter a value");
            }
            catch (FormatException)
            {
                Console.WriteLine("{0} is not a valid number. Please try again", s);
            }
            finally
            {
                Console.WriteLine("Program complete.");
                Console.ReadKey();
            }
        }
    }
}