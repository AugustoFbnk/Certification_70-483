using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Certification70_483._01_ManageProgramFlow._01_MultithreadingAndAsynchronousProcessing
{
    /// <summary>
    /// Using Asyc/Await
    /// To work with I/O operations.
    /// </summary>
    public static class Example18
    {
        public static void Start()
        {
            string result = DownloadContent().Result;
            Console.WriteLine(result);
            Console.ReadKey();
        }

        //async keyword signal to the compiler that something asynchronous is going to happen.
        public static async Task<string> DownloadContent()
        {
          
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync("http://www.microsoft.com");
                return result;
            }
        }
        //Other example of asynchronous method than can be waited by await;
        private static Task<string> Test()
        {
            return Task.Run(() =>
            {
                Thread.Sleep(1000);
                return "Completed";
            });
        }
    }
}
