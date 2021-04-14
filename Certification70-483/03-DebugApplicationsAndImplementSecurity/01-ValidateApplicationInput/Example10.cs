using System;
using System.Text.RegularExpressions;

namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._01_ValidateApplicationInput
{
    /// <summary>
    /// Validate a ZIP Code with a regular expression
    /// </summary>
    public class Example10
    {
        public static void Start()
        {
            var valid = ValidateZipCodeRegEx("1234AB");
            Console.WriteLine(valid);//true

            var invalid = ValidateZipCodeRegEx("1234|AB");
            Console.WriteLine(invalid);//false
        }

        static bool ValidateZipCodeRegEx(string zipCode)
        {
            Match match = Regex.Match(zipCode, @"^[1-9][0-9]{3}\s?[a-zA-Z]{2}$", RegexOptions.IgnoreCase);
            return match.Success;
        }
    }
}
