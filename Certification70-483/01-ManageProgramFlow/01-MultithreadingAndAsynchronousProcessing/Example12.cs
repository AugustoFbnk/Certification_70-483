using System;
using System.Threading.Tasks;

namespace Certification70_483._01_ManageProgramFlow._01_MultithreadingAndAsynchronousProcessing
{
    /// <summary>
    /// Task - Attaching child tasks to a parent task
    /// A task can have many child tasks attached. A parent task finishes when all of the child tasks are ready;
    /// </summary>
    public static class Example12
    {
        public static void Start()
        {
            Task<Int32[]> parent = Task.Run(() =>
            {
                var results = new Int32[3];
                new Task(() => results[0] = 0,
                    TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[1] = 1,
                    TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[2] = 2,
                    TaskCreationOptions.AttachedToParent).Start();
                return results;
            });
            var finalTask = parent.ContinueWith(
               parentTask =>
               {
                   foreach (int i in parentTask.Result)
                       Console.WriteLine(i);
               });
            //The finalTask runs only after the parent Task is finished, and the parent Task finishes when all three children are finished.
            finalTask.Wait();
        }
    }
}
