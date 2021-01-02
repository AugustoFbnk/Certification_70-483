using System;
using System.Linq;

namespace Certification70_483._01_ManageProgramFlow._01_MultithreadingAndAsynchronousProcessing
{
    /// <summary>
    /// Using ForAll
    /// ForAll operator iterate over a collection when the iteration can also be done in a parallel way
    /// "In contrast to foreach, ForAll does not need all results before it starts executing. 
    ///  In this example, ForAll does, however, remove any sort order that is specified."
    /// </summary>
    public static class Example26
    {
        public static void Start()
        {
            var numbers = Enumerable.Range(0, 20);
            var parallelResult = numbers.AsParallel()
                .Where(i => i % 2 == 0);
            
            //Iterating in a parallel way
            parallelResult.ForAll(e => Console.WriteLine(e));
            Console.ReadLine();
        }
    }
}
