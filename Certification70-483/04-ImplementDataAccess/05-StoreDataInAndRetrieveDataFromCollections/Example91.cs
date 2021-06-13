using Certification70_483._04_ImplementDataAccess._05_StoreDataInAndRetrieveDataFromCollections.common;
using System;

namespace Certification70_483._04_ImplementDataAccess._05_StoreDataInAndRetrieveDataFromCollections
{
    /// <summary>
    /// Using a custom collection
    /// </summary>
    public class Example91
    {

        public static void Start()
        {
            Person p1 = new Person
            {
                FirstName = "John",
                LastName = "Doe",
                Age = 42
            };
            Person p2 = new Person
            {
                FirstName = "Jane",
                LastName = "Doe",
                Age = 21
            };
            PeopleCollection people = new PeopleCollection { p1, p2 };
            Console.WriteLine(people.ToString());
            people.RemoveByAge(42);
            Console.WriteLine(people.Count);
            Console.WriteLine(people.ToString());
        }
    }
}
