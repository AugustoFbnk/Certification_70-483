using System;

namespace Certification70_483._01_ManageProgramFlow._03_ImplementProgramFlow
{
    /// <summary>
    /// A better readable nested if statement
    /// </summary>
    public static class Example46
    {
        public static void Start()
        {
            int x = 42;
            int y = 1;
            int z = 42;
            Console.WriteLine(x == y); // Displays false
            Console.WriteLine(x == z); // Displays true
        }
    }
}
