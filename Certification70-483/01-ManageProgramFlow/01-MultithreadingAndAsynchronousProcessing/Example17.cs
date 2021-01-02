using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification70_483._01_ManageProgramFlow._01_MultithreadingAndAsynchronousProcessing
{
    /// <summary>
    /// Using Parallel.Break/Stop
    /// </summary>
    public static class Example17
    {
        public static void Start()
        {
            ParallelLoopResult resultBreak = Parallel.
                For(0, 1000, (int i, ParallelLoopState loopState) =>
                {
                    if (i == 500)
                    {
                        Console.WriteLine("Breaking loop");
                        //Ensures that all iterations that are currently running will be finished, then, break the loop
                        loopState.Break();

                    }
                    return;
                });
            Console.WriteLine(resultBreak.IsCompleted);//When loop break, it still will be false
            Console.WriteLine(resultBreak.LowestBreakIteration);//When loop break, it will be 500

            ParallelLoopResult resultStop = Parallel.
                For(0, 1000, (int i, ParallelLoopState loopState) =>
                {
                    if (i == 500)
                    {
                        Console.WriteLine("Stopping loop");
                        //Just terminates everything
                        loopState.Stop();
                    }
                    return;
                });
            Console.WriteLine(resultStop.IsCompleted);//When loop stop, it still will be false
            Console.WriteLine(resultStop.LowestBreakIteration);//When loop stop, it will be null
            Console.ReadKey();
        }
    }
}
