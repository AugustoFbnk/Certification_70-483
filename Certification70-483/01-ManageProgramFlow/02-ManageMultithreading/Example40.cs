using System;
using System.Threading;
using System.Threading.Tasks;

namespace Certification70_483._01_ManageProgramFlow._02_ManageMultithreading
{
    /// <summary>
    /// Using the Interlocked class
    /// Back to Example 35. The problem happened because the operation was was not atomic
    /// n++ and n-- are traslated by compiler to n = n + 1 and n = n -1 respectively
    /// The Interlocked class make this work
    /// </summary>
    public static class Example40
    {
        public static void Start()
        {
            int n = 0;
            var up = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                    Interlocked.Increment(ref n);
            });

            for (int i = 0; i < 1000000; i++)
                Interlocked.Decrement(ref n);
            up.Wait();
            Console.WriteLine(n);
        }
    }
}
