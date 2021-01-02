using System;
using System.Threading.Tasks;

namespace Certification70_483._01_ManageProgramFlow._01_MultithreadingAndAsynchronousProcessing
{
    /// <summary>
    /// Using TaskFactory
    /// A facilitator for creating task hierarchies with certain configuration.
    /// </summary>
    public static class Example13
    {
        public static void Start()
        {
            Task<Int32[]> parent = Task.Run(() =>
            {
                var results = new Int32[3];
                TaskFactory tf = new TaskFactory(TaskCreationOptions.AttachedToParent,
                   TaskContinuationOptions.ExecuteSynchronously);
                tf.StartNew(() => results[0] = 0);
                tf.StartNew(() => results[1] = 1);
                tf.StartNew(() => results[2] = 2);
                return results;
            });
            var finalTask = parent.ContinueWith(
               parentTask =>
               {
                   foreach (int i in parentTask.Result)
                       Console.WriteLine(i);
               });
            finalTask.Wait();
        }
    }
}