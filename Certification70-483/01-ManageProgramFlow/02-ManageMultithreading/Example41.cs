using System;
using System.Threading;
using System.Threading.Tasks;

namespace Certification70_483._01_ManageProgramFlow._02_ManageMultithreading
{
    /// <summary>
    /// Compare and exchange as a nonatomic operation
    /// This example show what can go worong when exchange values in an not atomic operation
    /// 
    /// "Task t1 starts running and sees that value is equal to 1. At the same time, t2 changes the
    ///  value to 3 and then t1 changes it back to 2. 
    ///  To avoid this, you can use the following Interlocked statement:
    ///  Interlocked.CompareExchange(ref value, newValue, compareTo)"
    /// 
    /// </summary>
    public static class Example41
    {
        static int value = 1;
        public static void Start()
        {
            Task t1 = Task.Run(() =>
            {
                //wrong 
                //if (value == 1)
                //{
                //    // Removing the following line will change the output
                //    Thread.Sleep(1000);
                //    value = 2;
                //}

                //right
                Thread.Sleep(1000);
                Interlocked.CompareExchange(ref value, 2, 1);

            });
            Task t2 = Task.Run(() =>
            {
                value = 3;
            });
            Task.WaitAll(t1, t2);
            // Displays 2
            Console.WriteLine(value);
            Console.ReadKey();
        }
    }
}