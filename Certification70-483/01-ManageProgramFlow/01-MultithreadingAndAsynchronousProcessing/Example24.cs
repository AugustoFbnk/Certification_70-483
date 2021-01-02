using System;
using System.Linq;

namespace Certification70_483._01_ManageProgramFlow._01_MultithreadingAndAsynchronousProcessing
{
    /// <summary>
    /// Ordered parallel query
    /// AsOrdered order the results
    /// The query is still processed in parallel, but the results are buffered and sorted
    /// </summary>
    public static class Example24
    {
        public static void Start()
        {
            var numbers = Enumerable.Range(0, 10);
            var parallelResult = numbers.AsParallel().AsOrdered()
                .Where(i => i % 2 == 0)
                .ToArray();
            foreach (int i in parallelResult)
                Console.WriteLine(i);
        }
    }
}
