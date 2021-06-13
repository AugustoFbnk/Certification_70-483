using Certification70_483._04_ImplementDataAccess._03_QueryAndManipulateDataAndObjects.common;
using System;
using System.Collections.Generic;

namespace Certification70_483._04_ImplementDataAccess._03_QueryAndManipulateDataAndObjects
{
    /// <summary>
    /// Implementing Where
    /// </summary>
    public class Example63
    {
        public static void Start()
        {
            var listInt = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 9 };

            var couple = listInt.CustonWhere(x => x % 2 == 0);

            foreach (var pair in couple)
            {
                Console.WriteLine(pair);
            }
        }
    }
}
