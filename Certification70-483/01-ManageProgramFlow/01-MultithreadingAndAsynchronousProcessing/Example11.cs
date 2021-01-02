using System;
using System.Threading.Tasks;

namespace Certification70_483._01_ManageProgramFlow._01_MultithreadingAndAsynchronousProcessing
{
    /// <summary>
    /// Using tasks - Scheduling different continuation tasks
    /// ContinuationWith has a couple of overloads tht can be used to configure when the continuation task will run
    /// Some of these methods are: OnlyOnCanceled, run when the task is canceled; OnlyOnFaulted, run when the task is faulted (error) and OnlyOnRanToCompletion tha runs when the task is completed
    /// </summary>
    public static class Example11
    {
        public static void Start()
        {
            Task<int> t = Task.Run(() =>
            {

                //uncomment the line bellow to test the fauted overload
                //throw new Exception("Testing fauted overload");
                return 42;
            });
            t.ContinueWith((i) =>
            {
                //Example of how to cancel a task in the next examples
                Console.WriteLine("Canceled");
            }, TaskContinuationOptions.OnlyOnCanceled);
            t.ContinueWith((i) =>
            {
                Console.WriteLine($"Faulted: {i.Exception.Message} {i.Exception.InnerExceptions}");
            }, TaskContinuationOptions.OnlyOnFaulted);
            var completedTask = t.ContinueWith((i) =>
            {
                Console.WriteLine("Completed");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);
            completedTask.Wait();
        }
    }
}
