using System;

namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._01_ValidateApplicationInput
{
    /// <summary>
    /// Manually validating a ZIP Code
    /// </summary>
    public class Example09
    {
        public static void Start()
        {
            var valid = ValidateZipCode("1234AB");
            Console.WriteLine(valid);//true

            var invalid = ValidateZipCode("1234|AB");
            Console.WriteLine(invalid);//false
        }

        static bool ValidateZipCode(string zipCode)
        {
            // Valid zipcodes: 1234AB | 1234 AB | 1001 AB
            if (zipCode.Length < 6) return false;
            string numberPart = zipCode.Substring(0, 4);
            int number;
            if (!int.TryParse(numberPart, out number)) return false;

            string characterPart = zipCode.Substring(4);
            if (numberPart.StartsWith("0")) return false;
            if (characterPart.Trim().Length < 2) return false;
            if (characterPart.Length == 3 && characterPart.Trim().Length != 2)
                return false;
            return true;
        }
    }
}
