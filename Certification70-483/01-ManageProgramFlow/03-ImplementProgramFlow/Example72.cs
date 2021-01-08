using Certification70_483._01_ManageProgramFlow._03_ImplementProgramFlow.Common;
using System.Collections.Generic;

namespace Certification70_483._01_ManageProgramFlow._03_ImplementProgramFlow
{
    /// <summary>
    /// Changing items in a foreach
    /// </summary>
    public static class Example72
    {
        public static void Start()
        {
            CannotChangeForeachIterationVariable();
        }
        private static void CannotChangeForeachIterationVariable()
        {
            var people = new List<Person>
            {
                new Person() { FirstName = "John", LastName = "Doe"},
                new Person() { FirstName = "Jane", LastName = "Doe"},
            };
            foreach (Person p in people)
            {
                p.LastName = "Changed"; // This is allowed
                //p = new Person(); // This gives a compile error
            }
        }
    }
}
