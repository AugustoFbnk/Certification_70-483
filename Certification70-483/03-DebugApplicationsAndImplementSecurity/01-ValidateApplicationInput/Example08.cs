using System;

namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._01_ValidateApplicationInput
{
    /// <summary>
    /// Using Convert to convert from double to int
    /// </summary>
    public class Example08
    {
        public static void Start()
        {
            double d = 23.15;
            int i = Convert.ToInt32(d);
            Console.WriteLine(i); // Displays 23
        }
    }
}
