using System;
using System.Threading;

namespace Certification70_483._01_ManageProgramFlow._01_MultithreadingAndAsynchronousProcessing
{
    /// <summary>
    /// Using backgroud and foregroud thread
    /// </summary>
    public static class Example02
    {
        private static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
            }
        }
        /// <summary>
        /// If the application with the IsBackground property set to true, the application exits immediately. (Console prompt is closed). 
        /// If it set to false, the console will print ThreadProc messages (from ThreadMethod) ten times
        /// </summary>
        /// <param name="isBackGroud"></param>
        public static void Start(bool isBackGroud)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.IsBackground = isBackGroud;
            t.Start();
        }
    }
}
