using System;
using System.Collections.Generic;

namespace Certification70_483._04_ImplementDataAccess._05_StoreDataInAndRetrieveDataFromCollections
{
    /// <summary>
    /// Using Dictionary<TKey, TValue>
    /// </summary>
    public class Example85
    {
        class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public static void Start()
        {
            Person p1 = new Person { Id = 1, Name = "Name1" };
            Person p2 = new Person { Id = 2, Name = "Name2" };
            Person p3 = new Person { Id = 3, Name = "Name3" };
            var dict = new Dictionary<int, Person>();
            dict.Add(p1.Id, p1);
            dict.Add(p2.Id, p2);
            dict.Add(p3.Id, p3);
            foreach (KeyValuePair<int, Person> v in dict)
            {
                Console.WriteLine("{0}: {1}", v.Key, v.Value.Name);
            }
            dict[0] = new Person { Id = 4, Name = "Name4" };
            Person result;
            if (!dict.TryGetValue(5, out result))
            {
                Console.WriteLine("No person with a key of 5 can be found");
            }
        }
    }
}
