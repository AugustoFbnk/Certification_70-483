using System;

namespace Certification70_483._01_ManageProgramFlow._03_ImplementProgramFlow
{
    /// <summary>
    /// A complex if statement
    /// </summary>
    public static class Example61
    {
        public static void Start(char input)
        {
            if (input == 'a'
                || input == 'e'
                || input == 'i'
                || input == 'o'
                || input == 'u')
            {
                Console.WriteLine("Input is a vowel");
            }
            else
            {
                Console.WriteLine("Input is a consonant");
            }
        }
    }
}
