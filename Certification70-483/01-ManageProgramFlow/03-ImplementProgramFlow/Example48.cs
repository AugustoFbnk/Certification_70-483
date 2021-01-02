using System;

namespace Certification70_483._01_ManageProgramFlow._03_ImplementProgramFlow
{
    /// <summary>
    /// Short-circuiting the OR operator
    /// "If the runtime notices that the left part of your OR operation is true, it doesn’t have to
    /// evaluate the right part of your expression.This is called short-circuiting"
    /// </summary>
    public static class Example48
    {
        public static void Start()
        {
            OrShortCircuit();
        }
        private static void OrShortCircuit()
        {
            bool x = true;
            bool result = x || GetY();
        }
        private static bool GetY()
        {
            Console.WriteLine("This method doesn’t get called");
            return true;
        }
    }
}
