using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification70_483._01_ManageProgramFlow._01_MultithreadingAndAsynchronousProcessing
{
    /// <summary>
    /// Using Tasks - ContinueWith
    /// 
    /// "Attempting to read the Result property on a Task will force the thread that’s trying to
    ///    read the result to wait until the Task is finished before continuing.As long as the Task has not
    ///    finished, it is impossible to give the result.If the Task is not finished, this call will block the
    ///    current thread."
    /// 
    /// </summary>
    public static class Example10
    {
        //ContinueWith Will trigger a new task as soon as possible as the task finishes
        public static void Start()
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            }).ContinueWith((i) =>
            {
                return i.Result * 2;
            });
            Console.WriteLine(t.Result); // Displays 84
        }
    }
}
