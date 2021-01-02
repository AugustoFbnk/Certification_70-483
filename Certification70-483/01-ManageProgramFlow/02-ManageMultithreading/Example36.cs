using System;
using System.Threading.Tasks;

namespace Certification70_483._01_ManageProgramFlow._02_ManageMultithreading
{
    /// <summary>
    /// Using the lock keyword
    /// The lock keyword can block an object to no one else can change its value at the same time
    /// </summary>
    public static class Example36
    {
        public static void Start()
        {
            int n = 0;
            object _lock = new object();
            var up = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                    lock (_lock)
                        n++;
            });
            for (int i = 0; i < 1000000; i++)
                lock (_lock)
                    n--;
            up.Wait();
            Console.WriteLine(n);
        }
    }
}
