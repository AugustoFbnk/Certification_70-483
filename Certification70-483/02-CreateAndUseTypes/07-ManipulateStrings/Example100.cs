using System;

namespace Certification70_483._02_CreateAndUseTypes._07_ManipulateStrings
{
    /// <summary>
    /// Creating a composite string formatting
    /// </summary>
    public class Example100
    {
        public static void Start()
        {
            int a = 1;
            int b = 2;
            string result = string.Format("a: {0}, b: {1}", a, b);
            Console.WriteLine(result); // Displays ‘a: 1, b: 2’
        }
    }
}
