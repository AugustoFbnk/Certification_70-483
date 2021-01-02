using System;
using System.Threading.Tasks.Dataflow;

namespace Certification70_483.AsyncAndThread.SystemThreadingTasksDataflow
{
    public class ProccessActionBlockCompletionContinueWith
    {
        public void Run()
        {
            var throwIfNegative = new ActionBlock<int>(n =>
            {
                Console.WriteLine("n = {0}", n);
                if (n < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
            });

            throwIfNegative.Completion.ContinueWith(task =>
            {
                Console.WriteLine("The status of the completion task is '{0}'.",
                   task.Status);
            });

            throwIfNegative.Post(0);
            throwIfNegative.Post(-1);
            throwIfNegative.Post(1);
            throwIfNegative.Post(-2);
            throwIfNegative.Complete();

            try
            {
                throwIfNegative.Completion.Wait();
            }
            catch (AggregateException ae)
            {
                ae.Handle(e =>
                {
                    Console.WriteLine("Encountered {0}: {1}",
                       e.GetType().Name, e.Message);
                    return true;
                });
            }
        }

    }
}
