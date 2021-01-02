using System;
using System.Threading;
using System.Threading.Tasks;

namespace Certification70_483._01_ManageProgramFlow._02_ManageMultithreading
{
    /// <summary>
    /// Adding a continuation for canceled tasks
    /// "Instead of catching the exception, you can also add a continuation Task that executes only
    ///  when the Task is canceled.In this Task, you have access to the exception that was thrown, and
    ///  you can choose to handle it if that’s appropriate"
    /// </summary>
    public static class Example44
    {
        public static void Start()
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;

            Task task = Task.Run(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    Console.Write("*");
                    Thread.Sleep(1000);
                }
                token.ThrowIfCancellationRequested();

            }, token).ContinueWith((t) =>
            {
                t?.Exception?.Handle((e) => true);
                Console.WriteLine("You have canceled the task");
            }, TaskContinuationOptions.OnlyOnCanceled);

            Console.WriteLine("Press enter to stop the task");
            Console.ReadLine();
            cancellationTokenSource.Cancel();
            task.Wait();
        }
    }
}
