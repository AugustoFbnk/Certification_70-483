using System;
using System.Collections.Generic;

namespace Certification70_483._04_ImplementDataAccess._05_StoreDataInAndRetrieveDataFromCollections
{
    /// <summary>
    /// Using Stack<T>
    /// </summary>
    public class Example89
    {
        public static void Start()
        {
            Stack<string> myStack = new Stack<string>();
            myStack.Push("Hello");
            myStack.Push("World");
            myStack.Push("From");
            myStack.Push("A");
            myStack.Push("Queue");
            foreach (string s in myStack)
                Console.Write(s + " ");
            // Displays: Queue A From World Hello
        }
    }
}
