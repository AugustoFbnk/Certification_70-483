using System;

namespace Certification70_483._01_ManageProgramFlow._04_CreateAndImplementEventsAndDelegates
{
    /// <summary>
    /// Lambda expression to create a delegate
    /// </summary>
    public static class Example79
    {
        private delegate int Calculate(int x, int y);
        public static void Start()
        {
            Calculate calc = (x, y) => x + y;
            Console.WriteLine(calc(3, 4));
            calc = (x, y) => x * y;
            Console.WriteLine(calc(3, 4));
        }
    }
}
