using System;
using System.Threading;
using System.Threading.Tasks;

namespace Certification70_483._01_ManageProgramFlow._02_ManageMultithreading
{
    /// <summary>
    /// Throwing OperationCanceledException
    /// To signal the outside users of the task, you can use the ThrowIfCancellationRequested, tha will
    /// throw a exception when the task is being canceled
    /// 
    /// </summary>
    public static class Example43
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
            }, token);
            try
            {
                Console.WriteLine("Press enter to stop the task");
                Console.ReadLine();
                cancellationTokenSource.Cancel();
                task.Wait();
            }
            catch (AggregateException e)
            {
                Console.WriteLine(e.InnerExceptions[0].Message);
            }
            Console.WriteLine("Press enter to end the application");
            Console.ReadLine();
        }
    }
}
