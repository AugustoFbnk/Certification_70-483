using System;
using System.Threading;

namespace Certification70_483._01_ManageProgramFlow._01_MultithreadingAndAsynchronousProcessing
{
    /// <summary>
    /// Using the ThreadStaticAttribute
    /// </summary>
    public static class Example05
    {
        //Possibility each thread gets its own copy of a field
        //In this example, maximum value of _field becames 10. If get removed, all threads will access the same attribute, not a copy, and the value becomes 20
        [ThreadStatic]
        public static int _field;
        public static void Start()
        {
            new Thread(() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    _field++;
                    Console.WriteLine("Thread A: {0}", _field);
                }
            }).Start();

            new Thread(() =>
                    {
                        for (int x = 0; x < 10; x++)
                        {
                            _field++;
                            Console.WriteLine("Thread B: {0}", _field);
                        }
                    }).Start();

            Console.ReadKey();
        }
    }
}