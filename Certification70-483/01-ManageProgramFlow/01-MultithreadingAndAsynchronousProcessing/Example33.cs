using System;
using System.Collections.Concurrent;

namespace Certification70_483._01_ManageProgramFlow._01_MultithreadingAndAsynchronousProcessing
{
    /// <summary>
    /// ConcurrentQueue
    /// A queue is a first in, first out (FIFO) collection
    /// </summary>
    public static class Example33
    {
        public static void Start()
        {
            ConcurrentQueue<int> queue = new ConcurrentQueue<int>();
            //Enqueue add
            queue.Enqueue(42);
            int result;
            //TryDequeue remove
            if (queue.TryDequeue(out result))
                Console.WriteLine("Dequeued: {0}", result);
            
            // output: Dequeued: 42
        }
    }
}
