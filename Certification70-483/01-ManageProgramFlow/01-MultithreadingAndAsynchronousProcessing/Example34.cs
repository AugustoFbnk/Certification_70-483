using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification70_483._01_ManageProgramFlow._01_MultithreadingAndAsynchronousProcessing
{
    /// <summary>
    /// Using ConcurrentDictionary
    /// A thread-safe manner to store key-value collections
    /// "When working with a ConcurrentDictionary you have methods that can atomically add,
    ///  get, and update items.An atomic operation means that it will be started and finished as a
    ///  single step without other threads interfering"
    /// </summary>
    public static class Example34
    {
        public static void Start()
        {
            var dict = new ConcurrentDictionary<string, int>();
            if (dict.TryAdd("k1", 42))
            {
                Console.WriteLine("Added");
            }
            // checks to see whether the current value is equal to the existing value before updating it
            if (dict.TryUpdate("k1", 21, 42))
            {
                Console.WriteLine("42 updated to 21");
            }
            // Overwrite unconditionally
            dict["k1"] = 42;

            //AddOrUpdate makes sure an item is added if it’s not there, and updated to a new value if it is
            int r1 = dict.AddOrUpdate("k1", 3, (s, i) => i * 2);

            //GetOrAdd gets the current value of an item if it’s available; if not, it adds the new value by using a factory method.
            int r2 = dict.GetOrAdd("k2", 3);
        }
    }
}
