using System;
using System.Linq;

namespace Certification70_483._04_ImplementDataAccess._03_QueryAndManipulateDataAndObjects
{

    /// <summary>
    /// LINQ Select operator
    /// </summary>
    public class Example55
    {

        public static void Start()
        {
            int[] data = { 1, 2, 5, 8, 11 };
            var result = from d in data
                         select d;
            Console.WriteLine(string.Join(", ", result)); // Displays 1, 2, 5, 8, 11
        }
    }
}
