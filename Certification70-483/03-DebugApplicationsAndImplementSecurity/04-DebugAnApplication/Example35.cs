#define MySymbol

using System;

namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._04_DebugAnApplication
{
    /// <summary>
    /// Defining a custom symbol
    /// </summary>
    public class Example35
    {
        public static void Start()
        {
#if MySymbol
            Console.WriteLine("Custom symbol is defined");
#endif
        }
    }
}
