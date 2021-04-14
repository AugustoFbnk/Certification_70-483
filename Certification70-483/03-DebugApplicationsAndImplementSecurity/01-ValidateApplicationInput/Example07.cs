using System;

namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._01_ValidateApplicationInput
{

    public class Example07
    {

        public static void Start()
        {
            int i = Convert.ToInt32(null);
            Console.WriteLine(i); // Displays 0
        }
    }
}
