using System;
using System.Linq;

namespace Certification70_483._01_ManageProgramFlow._01_MultithreadingAndAsynchronousProcessing
{
    /// <summary>
    /// Catching AggregateException
    /// If an exception happens, the .net framework handles this by aggregating all exceptions into one AggregationException
    /// </summary>
    public static class Example27
    {
        public static void Start()
        {
            var numbers = Enumerable.Range(0, 20);
            try
            {
                var parallelResult = numbers.AsParallel()
                    .Where(i => IsEven(i));
                parallelResult.ForAll(e => Console.WriteLine(e));
            }
            catch (AggregateException e)
            {
                Console.WriteLine("There where {0} exceptions", e.InnerExceptions.Count);
            }
        }

        public static bool IsEven(int i)
        {
            if (i % 10 == 0) throw new ArgumentException("i");
            return i % 2 == 0;
        }
    }
}
