using System;

namespace Certification70_483._01_ManageProgramFlow._03_ImplementProgramFlow
{
    /// <summary>
    /// A switch statement
    /// </summary>
    public static class Example62
    {
        public static void Start(char input)
        {
            switch (input)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    {
                        Console.WriteLine("Input is a vowel");
                        break;
                    }
                case 'y':
                    {
                        Console.WriteLine("Input is sometimes a vowel.");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Input is a consonant");
                        break;
                    }
            }
        }
    }
}
