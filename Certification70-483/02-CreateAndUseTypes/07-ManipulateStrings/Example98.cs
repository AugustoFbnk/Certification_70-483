using System;
using System.Globalization;

namespace Certification70_483._02_CreateAndUseTypes._07_ManipulateStrings
{
    /// <summary>
    /// Displaying a DateTime with different format strings
    /// </summary>
    public class Example98
    {
        public static void Start()
        {
            DateTime d = new DateTime(2021, 3, 08);
            CultureInfo provider = new CultureInfo("en-US");
            Console.WriteLine(d.ToString("d", provider)); // Displays 3/08/2021
            Console.WriteLine(d.ToString("D", provider)); // Displays Monday, March 8, 2021
            Console.WriteLine(d.ToString("M", provider)); // Displays March 08
        }
    }
}
