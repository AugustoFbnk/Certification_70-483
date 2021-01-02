using System;
using System.Threading.Tasks;

namespace Certification70_483._01_ManageProgramFlow._02_ManageMultithreading
{
    /// <summary>
    /// Accessing shared data in a multithreaded application
    /// This is a example of wrong unsynchronized tasks.
    /// " The seemingly simple operation of incrementing and decrementing the variable n results in both a lookup (check the value of n) and
    ///   add or subtract 1 from n.But what if the first task reads the value and adds 1, and at the exact
    ///   same time task 2 reads the value and subtracts 1? This is what happens in this example and
    ///   that’s why you never get the expected output of 0."
    /// </summary>
    public static class Example35
    {
        public static void Start()
        {
            int n = 0;
            var up = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                    n++;
            });
            for (int i = 0; i < 1000000; i++)
                n--;

            up.Wait();
            Console.WriteLine(n);
        }
    }
}
