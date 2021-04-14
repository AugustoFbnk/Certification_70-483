using System;

namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._04_DebugAnApplication
{
    /// <summary>
    /// Disabling and enabling specific warnings
    /// </summary>
    public class Example40
    {

        public static void Start()
        {
#pragma warning disable 0162, 0168
            int i;
#pragma warning restore 0162
            while (false)
            {
                Console.WriteLine("Unreachable code");
            }
#pragma warning restore 
        }
    }
}
