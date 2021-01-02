using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace Certification70_483._01_ManageProgramFlow._01_MultithreadingAndAsynchronousProcessing
{
    /// <summary>
    /// Using BlockingCollection<T>
    /// "Thread-safe collection for adding and removing data. 
    ///  Removing an item from the collection can be blocked until data becomes available. Adding data is fast, but you can set a maximum upper limit.
    ///  If that limit is reached, adding an item blocks the calling thread until there is room."
    /// </summary>
    public static class Example28
    {
        public static void Start()
        {
            BlockingCollection<string> col = new BlockingCollection<string>();
            Task read = Task.Run(() =>
            {
                while (true)
                {
                    Console.WriteLine(col.Take());
                }
            });
            Task write = Task.Run(() =>
            {
                while (true)
                {
                    string s = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(s)) break;
                    col.Add(s);
                }
            });
            write.Wait();
        }
    }
}
