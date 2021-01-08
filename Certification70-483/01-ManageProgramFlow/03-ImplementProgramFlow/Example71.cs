using System;

namespace Certification70_483._01_ManageProgramFlow._03_ImplementProgramFlow
{
    /// <summary>
    /// foreach loop
    /// </summary>
    public static class Example71
    {
        public static void Start()
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };
            foreach (int i in values)
            {
                Console.Write(i);
            }
        }
    }
}
