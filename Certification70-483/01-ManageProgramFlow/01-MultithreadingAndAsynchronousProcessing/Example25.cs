using System;
using System.Linq;

namespace Certification70_483._01_ManageProgramFlow._01_MultithreadingAndAsynchronousProcessing
{
    /// <summary>
    /// Making a parallel query sequential
    /// AsSequential stop the query from being processed in parallel
    /// </summary>
    public static class Example25
    {
        public static void Start()
        {
            var numbers = Enumerable.Range(0, 20);
            var parallelResult = numbers.AsParallel().AsOrdered()
                .Where(i => i % 2 == 0).AsSequential();

            // AsSequential operator to make sure that the Take method doesn’t mess up your order
            foreach (int i in parallelResult.Take(5))
                Console.WriteLine(i);
        }
    }
}
