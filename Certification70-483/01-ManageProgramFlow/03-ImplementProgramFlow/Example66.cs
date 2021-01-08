using System;

namespace Certification70_483._01_ManageProgramFlow._03_ImplementProgramFlow
{
    /// <summary>
    /// A for loop with a custom increment
    /// </summary>
    public static class Example66
    {
        public static void Start()
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };
            for (int index = 0; index < values.Length; index += 2)
            {
                Console.Write(values[index]);
            }
        }
    }
}
