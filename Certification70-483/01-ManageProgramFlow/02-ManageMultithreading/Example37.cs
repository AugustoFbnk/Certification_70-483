using System;
using System.Threading;
using System.Threading.Tasks;

namespace Certification70_483._01_ManageProgramFlow._02_ManageMultithreading
{
    /// <summary>
    /// Creating a deadlock
    /// Locinkg is dangerous to use. ou can easily deadlock your program.
    /// "Where both threads wait on each other, causing neither to ever complete"
    /// </summary>
    public static class Example37
    {
        public static void Start()
        {
            object lockA = new object();
            object lockB = new object();
            var up = Task.Run(() =>
            {
                lock (lockA)
                {
                    Thread.Sleep(1000);
                    lock (lockB)
                    {
                        //A is waiting for B to became free
                        Console.WriteLine("Locked A and B");
                    }
                }
            });
            lock (lockB)
            {
                lock (lockA)
                {
                    //B is waiting for A to became free
                    Console.WriteLine("Locked A and B");
                }
            }
            up.Wait();
        }
    }
}
