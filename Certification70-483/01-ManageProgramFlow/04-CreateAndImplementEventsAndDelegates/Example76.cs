using System;

namespace Certification70_483._01_ManageProgramFlow._04_CreateAndImplementEventsAndDelegates
{
    /// <summary>
    /// A multicast delegate
    /// </summary>
    public static class Example76
    {
        public static void MethodOne()
        {
            Console.WriteLine("MethodOne");
        }
        public static void MethodTwo()
        {
            Console.WriteLine("MethodTwo");
        }
        public delegate void Del();
        public static void Multicast()
        {
            Del d = MethodOne;
            d += MethodTwo;
            d();
        }
        public static void Start()
        {
            Multicast();
        }
    }

}
