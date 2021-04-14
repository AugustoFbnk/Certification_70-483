using System;
using System.Diagnostics;

namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._04_DebugAnApplication
{
    /// <summary>
    /// Applying the DebuggerDisplayAttribute
    /// </summary>
    public class Example43
    {
        public static void Start()
        {
            var person = new Person
            {
                FirstName = "John",
                LastName = "Doe"
            };

        }

        [DebuggerDisplay("Name = {FirstName} {LastName}")]
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}
