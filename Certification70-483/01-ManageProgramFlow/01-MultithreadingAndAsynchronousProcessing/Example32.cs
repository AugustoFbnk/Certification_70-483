using System;
using System.Collections.Concurrent;

namespace Certification70_483._01_ManageProgramFlow._01_MultithreadingAndAsynchronousProcessing
{
    /// <summary>
    /// Using a ConcurrentStack
    /// ConcurrentStack is a LIFO collection (Last in, first out)
    /// </summary>
    public static class Example32
    {
        public static void Start()
        {
            ConcurrentStack<int> stack = new ConcurrentStack<int>();
            //Push add an item to the stack
            stack.Push(42);
            int result;
            //TryPop tries to get an item off the stack
            if (stack.TryPop(out result))
                Console.WriteLine("Popped: {0}", result);
            stack.PushRange(new int[] { 1, 2, 3 });
            int[] values = new int[2];
            stack.TryPopRange(values);
            foreach (int i in values)
                Console.WriteLine(i);

            //it will outpu:
            // Popped: 42
            // 3
            // 2
        }
    }
}
