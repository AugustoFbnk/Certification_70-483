using System;
using System.Threading;

namespace Certification70_483._01_ManageProgramFlow._01_MultithreadingAndAsynchronousProcessing
{
    /// <summary>
    /// Thread pools
    /// </summary>
    public static class Example07
    {
        //Thread pool is a maner to reuse threads that already finishes its work
        //Thread pool manages the amount of threads that need to keep around,
        //creating addictional threads when no more threads are avaliable and excluding it after some time if those threads are no more necessary

        /* "One thing to be aware of is that because threads are being reused, they also reuse their
           local state. You may not rely on state that can potentially be shared between multiple
           operations."
        */
        public static void Start()
        {
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Console.WriteLine("Working on a thread from threadpool");
            });
            Console.ReadLine();
        }
    }
}
