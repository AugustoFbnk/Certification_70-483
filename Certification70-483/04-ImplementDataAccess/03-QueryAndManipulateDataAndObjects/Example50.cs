using Certification70_483._04_ImplementDataAccess._03_QueryAndManipulateDataAndObjects.common;
using System.Collections.Generic;

namespace Certification70_483._04_ImplementDataAccess._03_QueryAndManipulateDataAndObjects
{
    /// <summary>
    /// Using a collection initializer
    /// </summary>
    public class Example50
    {

        public static void Start()
        {
            var people = new List<Person>
            {
                new Person
                {
                    FirstName = "John",
                    LastName = "Doe"
                },
                new Person
                {
                    FirstName = "Jane",
                    LastName = "Doe"
                }
            };
        }
    }
}
