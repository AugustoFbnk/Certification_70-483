using System;

namespace Certification70_483._02_CreateAndUseTypes._02_ConsumeTypes
{
    /// <summary>
    /// Casting a double to an int
    /// </summary>
    public static class Example22
    {
        public static void Start()
        {
            double x = 1234.7;
            int a;
            a = (int)x;
            Console.WriteLine(a);
        }
    }
}
