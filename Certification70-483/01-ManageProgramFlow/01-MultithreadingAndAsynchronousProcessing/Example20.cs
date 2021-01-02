using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Certification70_483._01_ManageProgramFlow._01_MultithreadingAndAsynchronousProcessing
{
    /// <summary>
    /// Using ConfigureAwait example wrong output
    /// You can configure Await to disable the synchronization contex (used to synchronize the 
    /// background threads with the UI thread). If you don't need to update the UI when 
    /// background threads finished it cant make your code perform better.
    /// 
    /// "Avoid the void return type. A void returning async method is effectively a fire-and-forget
    /// method.You can never inspect the return type, and you can’t see whether any exceptions were
    /// thrown.You should use async void methods only when dealing with asynchronous events."
    /// </summary>
    public static class Example20
    {
        public static void Start()
        {
            var result = AsyncMethod().Result;
            Console.WriteLine(result);
            Console.ReadKey();
        }

        private static async Task<string> AsyncMethod()
        {
            HttpClient httpClient = new HttpClient();
            string content = await httpClient
                .GetStringAsync("http://www.microsoft.com")
                .ConfigureAwait(false);
            return content;
        }
    }
}
