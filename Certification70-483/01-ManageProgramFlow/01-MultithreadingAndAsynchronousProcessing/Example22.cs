using System;
using System.Linq;

namespace Certification70_483._01_ManageProgramFlow._01_MultithreadingAndAsynchronousProcessing
{
    /// <summary>
    /// Using AsParallel
    /// AsParallel() Convert a query to a parallel query.
    /// Runtime determines whether it makes sense to turn the query into a parallel one.
    /// Prallel prcessing does not garantee any particular order
    /// </summary>
    public static class Example22
    {
        public static void Start()
        {
            var numbers = Enumerable.Range(0, 10000);
            var parallelResult = numbers.AsParallel()
                .Where(i => i % 2 == 0)
                .ToArray();
            
            parallelResult.ToList().ForEach(x => Console.WriteLine(x));
            Console.ReadKey();
        }
    }
}
