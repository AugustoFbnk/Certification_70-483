using System;

namespace Certification70_483._01_ManageProgramFlow._04_CreateAndImplementEventsAndDelegates
{
    /// <summary>
    /// Using the Action delegate
    /// </summary>
    public static class Example81
    {
        public static void Start()
        {
            Action<int, int> calc = (x, y) =>
            {
                Console.WriteLine(x + y);
            };
            calc(3, 4);
        }
    }
}
