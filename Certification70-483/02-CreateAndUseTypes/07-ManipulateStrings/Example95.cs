using System;

namespace Certification70_483._02_CreateAndUseTypes._07_ManipulateStrings
{
    /// <summary>
    ///  Iterating over a string
    /// </summary>
    public class Example95
    {
        public static void Start()
        {
            string value = "My Custom Value";
            foreach (char c in value)
                Console.WriteLine(c);
        }
    }
}
