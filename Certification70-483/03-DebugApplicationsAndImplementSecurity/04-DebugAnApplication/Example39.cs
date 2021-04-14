using System;

namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._04_DebugAnApplication
{
    /// <summary>
    /// The pragma warning directive
    /// </summary>
    public class Example39
    {

        public static void Start()
        {
#pragma warning disable
            while (false)
            {
                Console.WriteLine("Unreachable code");
            }
#pragma warning restore
        }
    }
}
