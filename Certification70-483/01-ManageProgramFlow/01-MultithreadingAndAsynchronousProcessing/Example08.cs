using System;
using System.Threading.Tasks;

namespace Certification70_483._01_ManageProgramFlow._01_MultithreadingAndAsynchronousProcessing
{
    /// <summary>
    /// Using tasks
    /// Unlike Threadpools, tasks can know when the proccess is finished and what the return value is.
    /// "If a thread receives a web request and it would start a new Task, it would just consume
    ///  another thread from the thread pool while the original thread waits for results.
    ///  Executing a Task on another thread makes sense only if you want to keep the user interface thread free for other work or if you want to parallelize your work on to multiple
    ///  processors."
    /// </summary>
    public static class Example08
    {
        public static void Start()
        {
            Task t = Task.Run(() =>
            {
                for (int x = 0; x < 100; x++)
                {
                    Console.Write("*");
                }
            });
            // Wait is equivalent to calling Join on a thread.
            t.Wait();
            Console.ReadKey();
        }
    }
}
