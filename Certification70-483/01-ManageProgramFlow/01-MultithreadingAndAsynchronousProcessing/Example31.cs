using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace Certification70_483._01_ManageProgramFlow._01_MultithreadingAndAsynchronousProcessing
{
    /// <summary>
    /// Enumerating a ConcurrentBag
    /// "ConcurrentBag also implements IEnumerable<T>, so you can iterate over it. This operation
    ///  is made thread-safe by making a snapshot of the collection when you start iterating it, so
    ///  items added to the collection after you started iterating it won’t be visible."
    /// </summary>
    public static class Example31
    {
        public static void Start()
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();
            Task.Run(() =>
            {
                bag.Add(42);
                Thread.Sleep(1000);
                bag.Add(21);
            });
            Task.Run(() =>
            {
                foreach (int i in bag)
                    Console.WriteLine(i);
            }).Wait();
        }
    }
}
