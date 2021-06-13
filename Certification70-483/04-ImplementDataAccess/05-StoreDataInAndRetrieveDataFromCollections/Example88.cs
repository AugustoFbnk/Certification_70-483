using System;
using System.Collections.Generic;

namespace Certification70_483._04_ImplementDataAccess._05_StoreDataInAndRetrieveDataFromCollections
{
    /// <summary>
    /// Using Queue<T>
    /// </summary>
    public class Example88
    {
        public static void Start()
        {
            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("Hello");
            myQueue.Enqueue("World");
            myQueue.Enqueue("From");
            myQueue.Enqueue("A");
            myQueue.Enqueue("Queue");

            foreach (string s in myQueue)
                Console.Write(s + " ");
            // Displays: Hello World From A Queue
        }
    }
}
