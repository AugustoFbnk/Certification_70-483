using System;

namespace Certification70_483._02_CreateAndUseTypes._03_EnforceEncapsulation
{
    /// <summary>
    /// Creating a property
    /// </summary>
    public static class Example37
    {
        public static void Start()
        {
            var person = new Person();
            person.FirstName = "";//Will throw an argument exception.
        }
    }

    class Person
    {
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException();
                _firstName = value;
            }
        }
    }
}
