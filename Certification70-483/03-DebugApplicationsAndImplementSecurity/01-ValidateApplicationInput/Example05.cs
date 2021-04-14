using System;

namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._01_ValidateApplicationInput
{
    /// <summary>
    /// Using TryParse
    /// </summary>
    public class Example05
    {
        public static void Start()
        {
            string value = "1";
            bool success = int.TryParse(value, out int result);
            if (success)
                Console.WriteLine(result);
            else
                Console.WriteLine(false);
        }
    }
}
