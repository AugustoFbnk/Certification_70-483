using System;

namespace Certification70_483._02_CreateAndUseTypes._07_ManipulateStrings
{
    /// <summary>
    /// Displaying a number with a currency format string
    /// </summary>
    public class Example97
    {
        public static void Start()
        {
            double cost = 1234.56;
            Console.WriteLine(cost.ToString("C", new System.Globalization.CultureInfo("en-US")));
            // Displays $1,234.56
        }
    }
}
