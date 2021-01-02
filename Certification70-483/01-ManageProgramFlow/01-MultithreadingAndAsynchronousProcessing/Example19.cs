using System.Threading;
using System.Threading.Tasks;

namespace Certification70_483._01_ManageProgramFlow._01_MultithreadingAndAsynchronousProcessing
{
    /// <summary>
    /// Scalability versus responsiveness
    /// </summary>
    public static class Example19
    {
        public static void Start()
        {
            //Uses a thread from the thread pool while sleeping.
            SleepAsyncA(2000);

            //Do the same thing taht SleepAsyncA, but dont use any thread while wait for the response
            //It gives you scalability
            SleepAsyncB(2000);
        }
        private static Task SleepAsyncA(int millisecondsTimeout)
        {
            return Task.Run(() => Thread.Sleep(millisecondsTimeout));
        }
        private static Task SleepAsyncB(int millisecondsTimeout)
        {
            TaskCompletionSource<bool> tcs = null;
            var t = new Timer(delegate { tcs.TrySetResult(true); }, null, -1, -1);
            tcs = new TaskCompletionSource<bool>(t);
            t.Change(millisecondsTimeout, -1);
            return tcs.Task;
        }
    }
}
