using System;

namespace Certification70_483._02_CreateAndUseTypes._01_CreateTypes
{
    /// <summary>
    /// Creating a method
    /// </summary>
    public static class Example04
    {
        public static void Start(int x, int y)
        {
            Console.WriteLine(Add(x, y));
        }
        public static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
