using System;

namespace Certification70_483._01_ManageProgramFlow._04_CreateAndImplementEventsAndDelegates
{
    /// <summary>
    /// Using a delegate
    /// </summary>
    public static class Example75
    {
        private delegate int Calculate(int x, int y);
        public static int Add(int x, int y) { return x + y; }
        public static int Multiply(int x, int y) { return x * y; }
        public static void UseDelegate()
        {
            Calculate calc = Add;
            Console.WriteLine(calc(3, 4));
            calc = Multiply;
            Console.WriteLine(calc(3, 4));
        }
        public static void Start()
        {
            UseDelegate();
        }
    }
}
