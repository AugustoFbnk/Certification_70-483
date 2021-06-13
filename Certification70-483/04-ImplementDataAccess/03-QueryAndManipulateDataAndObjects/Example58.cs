using System;
using System.Linq;

namespace Certification70_483._04_ImplementDataAccess._03_QueryAndManipulateDataAndObjects
{
    /// <summary>
    /// LINQ multiple from statements
    /// </summary>
    public class Example58
    {

        public static void Start()
        {
            int[] data1 = { 1, 2, 5 };
            int[] data2 = { 2, 4, 6 };
            var result = from d1 in data1
                         from d2 in data2
                         select d1 * d2;
            Console.WriteLine(string.Join(", ", result)); // Displays 2, 4, 6, 4, 8, 12, 10, 20, 30
        }
    }
}
