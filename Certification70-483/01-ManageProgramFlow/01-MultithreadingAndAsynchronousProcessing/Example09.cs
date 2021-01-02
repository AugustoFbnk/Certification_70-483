using System;
using System.Threading.Tasks;

namespace Certification70_483._01_ManageProgramFlow._01_MultithreadingAndAsynchronousProcessing
{
    /// <summary>
    /// Usgin Task<T>
    /// This class can be used if you have the need to return a value;
    /// </summary>
    public static class Example09
    {
        public static void Start()
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            });
            Console.WriteLine(t.Result);
        }
    }
}
