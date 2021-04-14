using System;
using System.Threading;

namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._04_DebugAnApplication
{
    /// <summary>
    /// A simple console application
    /// </summary>
    public class Example33
    {

        public static void Start()
        {
            Timer t = new Timer(TimerCallback, null, 0, 2000);
            Console.ReadLine();
        }

        private static void TimerCallback(Object o)
        {
            Console.WriteLine("In TimerCallback: " + DateTime.Now);
            GC.Collect();
        }
    }
}
