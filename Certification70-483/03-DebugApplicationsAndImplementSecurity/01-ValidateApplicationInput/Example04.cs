using System;

namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._01_ValidateApplicationInput
{
    /// <summary>
    ///  Using Parse
    /// </summary>
    public class Example04
    {

        public static void Start()
        {
            string value = "true";
            bool b = bool.Parse(value);
            Console.WriteLine(b); // displays True
        }
    }
}
