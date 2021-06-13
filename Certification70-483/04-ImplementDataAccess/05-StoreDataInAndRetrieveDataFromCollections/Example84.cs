using System;
using System.Collections.Generic;

namespace Certification70_483._04_ImplementDataAccess._05_StoreDataInAndRetrieveDataFromCollections
{
    /// <summary>
    /// Using List<T>
    /// </summary>
    public class Example84
    {
        public static void Start()
        {
            List<string> listOfStrings = new List<string> { "A", "B", "C", "D", "E" };
            for (int x = 0; x < listOfStrings.Count; x++)
                Console.Write(listOfStrings[x]); // Displays: ABCDE
            listOfStrings.Remove("A");
            Console.WriteLine(listOfStrings[0]); // Displays: B
            listOfStrings.Add("F");
            Console.WriteLine(listOfStrings.Count); // Displays: 5
            bool hasC = listOfStrings.Contains("C");
            Console.WriteLine(hasC); // Displays: true
        }
    }
}
