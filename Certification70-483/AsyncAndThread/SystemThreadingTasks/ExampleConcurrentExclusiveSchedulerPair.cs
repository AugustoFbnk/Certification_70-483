using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification70_483.AsyncAndThread.SystemThreadingTasks
{
    /// <summary>
    /// 
    /// </summary>
    public class ExampleConcurrentExclusiveSchedulerPair
    {
        public void Run()
        {
            Console.WriteLine("Hello world");
            var sw = new Stopwatch();
            sw.Start();
            sw.Stop();
            Console.WriteLine($"Done = {sw.ElapsedMilliseconds}");
            Console.ReadKey();
        }
    }
}
