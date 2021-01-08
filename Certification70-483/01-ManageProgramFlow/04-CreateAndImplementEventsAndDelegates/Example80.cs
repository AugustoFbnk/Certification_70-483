using System;

namespace Certification70_483._01_ManageProgramFlow._04_CreateAndImplementEventsAndDelegates
{
    /// <summary>
    /// Creating a lambda expression with multiple statements
    /// </summary>
    public static class Example80
    {
        private delegate int Calculate(int x, int y);
        public static void Start()
        {
            Calculate calc = (x, y) =>
            {
                Console.WriteLine("Adding numbers");
                return x + y;
            };
            int result = calc(3, 4);
        }
    }
}
