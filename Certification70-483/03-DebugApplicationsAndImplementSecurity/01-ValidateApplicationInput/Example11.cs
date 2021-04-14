using System;
using System.Text.RegularExpressions;

namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._01_ValidateApplicationInput
{


    public class Example11
    {

        public static void Start()
        {
            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex(@"[ ]{ 2,}", options);
            string input = "1 2 3 4 5";
            string result = regex.Replace(input, " ");
            Console.WriteLine(result); // Displays 1 2 3 4 5
        }
    }
}
