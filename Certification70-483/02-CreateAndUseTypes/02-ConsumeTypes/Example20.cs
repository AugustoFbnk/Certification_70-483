using System;

namespace Certification70_483._02_CreateAndUseTypes._02_ConsumeTypes
{
    /// <summary>
    /// Implicitly converting an integer to a double
    /// </summary>
    public static class Example20
    {
        public static void Start()
        {
            int i = 42;
            double d = i;
            Console.WriteLine(d); ;
        }
    }
}
