using System;

namespace Certification70_483._04_ImplementDataAccess._05_StoreDataInAndRetrieveDataFromCollections
{
    /// <summary>
    /// Using an array
    /// </summary>
    public class Example80
    {
        public static void Start()
        {
            int[] arrayOfInt = new int[10];
            for (int x = 0; x < arrayOfInt.Length; x++)
            {
                arrayOfInt[x] = x;
            }
            foreach (int i in arrayOfInt)
            {
                Console.Write(i); // Displays 0123456789
            }
        }
    }
}
