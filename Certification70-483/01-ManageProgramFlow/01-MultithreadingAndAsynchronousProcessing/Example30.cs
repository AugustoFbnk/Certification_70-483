using System;
using System.Collections.Concurrent;

namespace Certification70_483._01_ManageProgramFlow._01_MultithreadingAndAsynchronousProcessing
{
    /// <summary>
    /// Using a ConcurrentBag
    /// "A ConcurrentBag is just a bag of items. It enables duplicates and it has no particular order."
    /// Important methods are Add (add a new object), TryTake (try to remove an object), and TryPeek (try to return an object).
    /// "TryPeek method is not very useful in a multithreaded environment.It could be that another thread removes the item before you can access it."
    /// </summary>
    public static class Example30
    {
        public static void Start()
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();
            bag.Add(42);
            bag.Add(21);
            int result;
            if (bag.TryTake(out result))
                Console.WriteLine(result);
            if (bag.TryPeek(out result))
                Console.WriteLine("There is a next item: {0}", result);
        }
    }
}
