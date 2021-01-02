using System;
using System.Threading;
using System.Threading.Tasks;

namespace Certification70_483._01_ManageProgramFlow._02_ManageMultithreading
{
    /// <summary>
    /// Setting a timeout on a task
    /// WaitAny method has an overload that takes a timeout
    /// "If the returned index is -1, the task timed out. It’s important to check for any possible errors
    ///  on the other tasks.If you don’t catch them, they will go unhandled."
    /// </summary>
    public static class Example45
    {
        public static void Start()
        {
            Task longRunning = Task.Run(() =>
            {
                Thread.Sleep(10000);
            });
            int index = Task.WaitAny(new[] { longRunning }, 3000);
            if (index == -1)
            {
                Console.WriteLine("Task timed out");
                Console.ReadKey();
            }
        }
    }
}
