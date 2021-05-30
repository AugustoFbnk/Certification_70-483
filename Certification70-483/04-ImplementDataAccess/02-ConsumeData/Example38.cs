using System;
using System.Data.Entity;
using System.Linq;
using Certification70_483._04_ImplementDataAccess._02_ConsumeData.common;

namespace Certification70_483._04_ImplementDataAccess._02_ConsumeData
{

    /// <summary>
    ///  Using Code First to map a class to the database
    /// </summary>
    public class Example38
    {

        public static void Start()
        {

            using (PeopleContext ctx = new PeopleContext())
            {
                ctx.People.Add(new Person() { Id = 1, Name = "John Doe" });
                ctx.SaveChanges();
            }
            using (PeopleContext ctx = new PeopleContext())
            {
                Person person = ctx.People.SingleOrDefault(p => p.Id == 1);
                Console.WriteLine(person.Name);
            }
        }
    }

    public class PeopleContext : DbContext
    {
        public IDbSet<Person> People { get; set; }
    }
}
