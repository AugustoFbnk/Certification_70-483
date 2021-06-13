using System;
using System.Collections.Generic;

namespace Certification70_483._04_ImplementDataAccess._05_StoreDataInAndRetrieveDataFromCollections
{
    /// <summary>
    /// Using HashSet<T>
    /// </summary>
    public class Example87
    {

        public static void Start()
        {
            UseHashSet();
        }

        public static void UseHashSet()
        {
            HashSet<int> oddSet = new HashSet<int>();
            HashSet<int> evenSet = new HashSet<int>();
            for (int x = 1; x <= 10; x++)
            {
                if (x % 2 == 0)
                    evenSet.Add(x);
                else
                    oddSet.Add(x);
            }
            DisplaySet(oddSet);
            DisplaySet(evenSet);
            oddSet.UnionWith(evenSet);
            DisplaySet(oddSet);
        }
        private static void DisplaySet(HashSet<int> set)
        {
            Console.Write("{");
            foreach (int i in set)
            {
                Console.Write(" {0}", i);
            }
            Console.WriteLine("}");
        }
    }
}
