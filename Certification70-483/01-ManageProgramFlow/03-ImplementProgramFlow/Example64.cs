using System;

namespace Certification70_483._01_ManageProgramFlow._03_ImplementProgramFlow
{
    /// <summary>
    /// A basic for loop
    /// "You can use for(;;) {} as a perfectly legal for loop that would never end"
    /// </summary>
    public static class Example64
    {
        public static void Start()
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };
            for (int index = 0; index < values.Length; index++)
            {
                Console.Write(values[index]);
            }
            // Displays
            // 123456
        }
    }
}
