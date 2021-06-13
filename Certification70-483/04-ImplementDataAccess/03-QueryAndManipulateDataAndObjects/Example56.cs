using System;
using System.Linq;

namespace Certification70_483._04_ImplementDataAccess._03_QueryAndManipulateDataAndObjects
{
    /// <summary>
    /// LINQ where operator
    /// </summary>
    public class Example56
    {

        public static void Start()
        {
            int[] data = { 1, 2, 5, 8, 11 };
            var result = from d in data
                         where d > 5
                         select d;
            Console.WriteLine(string.Join(", ", result)); // Displays 8, 11
        }
    }
}
