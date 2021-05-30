using System;

namespace Certification70_483._04_ImplementDataAccess._03_QueryAndManipulateDataAndObjects
{
    /// <summary>
    /// Creating an anonymous type
    /// </summary>
    public class Example53
    {

        public static void Start()
        {
            var person = new
            {
                FirstName = "John",
                LastName = "Doe"
            };
            Console.WriteLine(person.GetType().Name); // Displays “<>f__AnonymousType0`2
        }
    }
}
