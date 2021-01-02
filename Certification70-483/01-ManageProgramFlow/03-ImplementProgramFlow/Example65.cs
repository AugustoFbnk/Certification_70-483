using System;

namespace Certification70_483._01_ManageProgramFlow._03_ImplementProgramFlow
{
    /// <summary>
    /// A for loop with multiple loop variables
    /// </summary>
    public static class Example65
    {
        public static void Start()
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };
            for (int x = 0, y = values.Length - 1;
                ((x < values.Length) && (y >= 0));
                x++, y--)
            {
                Console.Write(values[x]);
                Console.Write(values[y]);
            }
            // Displays
            // 162534435261
        }
    }
}
