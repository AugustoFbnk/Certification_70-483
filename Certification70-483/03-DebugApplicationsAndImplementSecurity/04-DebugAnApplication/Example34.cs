using System;

namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._04_DebugAnApplication
{
    /// <summary>
    /// Checking for the debug symbol
    /// </summary>
    public class Example34
    {
        public static void Start()
        {
#if DEBUG
            Console.WriteLine("Debug mode");
#else
            Console.WriteLine("Not debug");
#endif
        }
    }
}
