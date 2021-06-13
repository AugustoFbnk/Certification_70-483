using System;

namespace Certification70_483._04_ImplementDataAccess._05_StoreDataInAndRetrieveDataFromCollections
{
    /// <summary>
    ///  Using a two-dimensional array
    /// </summary>
    public class Example81
    {
        public static void Start()
        {
            string[,] array2D = new string[3, 2] { { "one", "two" }, { "three", "four" }, { "five", "six" } };
            Console.WriteLine(array2D[0, 0]); // one
            Console.WriteLine(array2D[0, 1]); // two
            Console.WriteLine(array2D[1, 0]); // three
            Console.WriteLine(array2D[1, 1]); // four
            Console.WriteLine(array2D[2, 0]); // five
            Console.WriteLine(array2D[2, 1]); // six
        }
    }
}
