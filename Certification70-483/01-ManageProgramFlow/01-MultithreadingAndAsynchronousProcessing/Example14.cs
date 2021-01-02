using System;
using System.Threading;
using System.Threading.Tasks;

namespace Certification70_483._01_ManageProgramFlow._01_MultithreadingAndAsynchronousProcessing
{
    /// <summary>
    /// Using Task.WaitAll/WhenAll
    /// Wait for multiple Tasks to finish before continuing execution.
    /// </summary>
    public class Example14
    {
        public static void Start()
        {
            //all three Tasks are executed simultaneously, and the whole run takes approximately 1000ms instead of 3000
            Task[] tasks = new Task[3];
            tasks[0] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("1");
                return 1;
            });
            tasks[1] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("2");
                return 2;
            });
            tasks[2] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("3");
                return 3;
            });
            //WhenAll tun s continuation task that is called when all tasks finishes
            Task.WhenAll(Task.Run(() =>
            {
                Console.WriteLine("All tasks are finished");
            }));

            Task.WaitAll(tasks);
        }
    }
}
