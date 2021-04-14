using System;
using System.Globalization;

namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._01_ValidateApplicationInput
{
    /// <summary>
    /// Using configuration options when parsing a number
    /// </summary>
    public class Example06
    {
        public static void Start()
        {
            CultureInfo english = new CultureInfo("En");
            CultureInfo dutch = new CultureInfo("Nl");
            string value = "€19,95";
            decimal d = decimal.Parse(value, NumberStyles.Currency, dutch);
            Console.WriteLine(d.ToString(english)); // Displays 19.95
        }
    }
}
