using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Certification70_483._01_ManageProgramFlow._01_MultithreadingAndAsynchronousProcessing
{
    /// <summary>
    /// Using Parallel.For and Parallel.Foreach
    /// </summary>
    public static class Example16
    {
        public static void Start()
        {
            //Parallel for runs a asynchronous loop For
            Parallel.For(0, 10, i =>
            {
                Thread.Sleep(1000);
            });
            var numbers = Enumerable.Range(0, 10);
            //Parallel ForEach runs a asynchronous loop ForEach
            Parallel.ForEach(numbers, i =>
            {
                Thread.Sleep(1000);
            });
        }
    }
}
