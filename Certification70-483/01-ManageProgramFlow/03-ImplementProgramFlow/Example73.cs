using Certification70_483._01_ManageProgramFlow._03_ImplementProgramFlow.Common;
using System.Collections.Generic;

namespace Certification70_483._01_ManageProgramFlow._03_ImplementProgramFlow
{
    /// <summary>
    /// The compiler-generated code for a foreach loop
    /// </summary>
    public static class Example73
    {
        public static void Start()
        {
            var people = new List<Person>
            {
                new Person() { FirstName = "John", LastName = "Doe"},
                new Person() { FirstName = "Jane", LastName = "Doe"},
            };

            List<Person>.Enumerator e = people.GetEnumerator();
            try
            {
                Person v;
                while (e.MoveNext())
                {
                    v = e.Current;
                }
            }
            finally
            {
                System.IDisposable d = e as System.IDisposable;
                if (d != null) d.Dispose();
            }
        }
    }
}
