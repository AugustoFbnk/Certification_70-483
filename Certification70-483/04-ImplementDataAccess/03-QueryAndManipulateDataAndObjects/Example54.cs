using System;
using System.Linq;

namespace Certification70_483._04_ImplementDataAccess._03_QueryAndManipulateDataAndObjects
{
    /// <summary>
    /// A LINQ select query
    /// </summary>
    public class Example54
    {

        public static void Start()
        {
            int[] data = { 1, 2, 5, 8, 11 };
            var result = from d in data
                         where d % 2 == 0
                         select d;
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
            // Displays 2 8
        }
    }
}
