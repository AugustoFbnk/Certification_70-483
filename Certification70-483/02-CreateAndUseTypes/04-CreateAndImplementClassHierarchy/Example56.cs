using System.Collections;
using System.Collections.Generic;

namespace Certification70_483._02_CreateAndUseTypes._04_CreateAndImplementClassHierarchy
{
    /// <summary>
    /// Implementing IEnumerable<T> on a custom type
    /// </summary>
    public static class Example56
    {
        public static void Start()
        {
            Person[] personArray = new Person[]
            {
                new Person("NameA", "LastNameA"),
                new Person("NameB", "LastNameB"),
                new Person("NameC", "LastNameC"),
                new Person("NameD", "LastNameD")
            };

            var people = new People(personArray);

            var enumerator = people.GetEnumerator();
            foreach (var person in people)
            {
                System.Console.WriteLine(person.ToString());
            }
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
            return FirstName + " " + LastName;
        }
    }
    class People : IEnumerable<Person>
    {
        public People(Person[] people)
        {
            this.people = people;
        }
        Person[] people;
        public IEnumerator<Person> GetEnumerator()
        {
            for (int index = 0; index < people.Length; index++)
            {
                yield return people[index];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
