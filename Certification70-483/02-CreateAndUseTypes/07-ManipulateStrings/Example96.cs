using System;

namespace Certification70_483._02_CreateAndUseTypes._07_ManipulateStrings
{
    /// <summary>
    /// Overriding ToString
    /// </summary>
    public class Example96
    {
        public static void Start()
        {
            Person p = new Person("John", "Doe");
            Console.WriteLine(p); // Displays ‘John Doe’
        }
    }

    class Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
