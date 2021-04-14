using System;
using System.Diagnostics;

namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._04_DebugAnApplication
{

    /// <summary>
    /// Applying the ConditionalAttribute
    /// </summary>
    public class Example42
    {
        public static void Start()
        {
            Log("Debug mode");
        }

        [Conditional("DEBUG")]
        private static void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
