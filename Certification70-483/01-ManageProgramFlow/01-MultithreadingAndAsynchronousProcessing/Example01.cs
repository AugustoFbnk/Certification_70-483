using System;
using System.Threading;

namespace Certification70_483._01_ManageProgramFlow._01_MultithreadingAndAsynchronousProcessing
{
    /// <summary>
    /// Example of thread and Synchronization
    /// </summary>
    public static class Example01
    {
        private static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                //Call Thread.Sleep to enable the first thread can be executed
                Thread.Sleep(0);
            }
        }
        //This proccess is runing in a thread that the application manages by itself
        public static void Start()
        {
            //Create a new thread and pass the proccess (ThreadMethod) as a delegate
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            //Set Start to the thread so that can be triggered when the running thread is paused
            t.Start();

            for (int i = 0; i < 4; i++)
            {

                Console.WriteLine("Main thread: Do some work.");
                //Call Thread.Sleep to enable an second thread can be executed
                Thread.Sleep(0);
            }
            //t.Join is a Synchronization method, he blocks the calling thread until the thread represented by this instance (instance t) is terminated.
            t.Join();
        }
    }
}
