using System;

namespace Certification70_483._02_CreateAndUseTypes._07_ManipulateStrings
{
    /// <summary>
    /// Implementing custom formatting on a type
    /// </summary>
    public class Example99
    {
        public static void Start()
        {
            var person = new Person();
            person.FirstName = "Augusto";
            person.LastName = "Ferbonink";

            Console.WriteLine(person.ToString("FL"));
            Console.WriteLine(person.ToString("LF"));
            Console.WriteLine(person.ToString("FSL"));
            Console.WriteLine(person.ToString("LSF"));
        }

        class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string ToString(string format)
            {
                if (string.IsNullOrWhiteSpace(format) || format == "G") format = "FL";
                format = format.Trim().ToUpperInvariant();
                switch (format)
                {
                    case "FL":
                        return FirstName + " " + LastName;
                    case "LF":
                        return LastName + " " + FirstName;
                    case "FSL":
                        return FirstName + ", " + LastName;
                    case "LSF":
                        return LastName + ", " + FirstName;
                    default:
                        throw new FormatException(String.Format("The '{0}' format string is not supported.", format));
                }
            }
        }
    }

}
