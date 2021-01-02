using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Certification70_483._01_ManageProgramFlow._01_MultithreadingAndAsynchronousProcessing
{
    /// <summary>
    /// Continuing on a thread pool instead of the UI thread
    /// </summary>
    public static class Example21
    {
        public static void Start()
        {
            _ = AsyncMethod();
        }

        private static async Task AsyncMethod()
        {
            HttpClient httpClient = new HttpClient();
            string content = await httpClient
                .GetStringAsync("http://www.microsoft.com")
                .ConfigureAwait(false);

            using (FileStream sourceStream = new FileStream("temp.html",
                    FileMode.Create, FileAccess.Write, FileShare.None,
                    4096, useAsync: true))
            {
                byte[] encodedText = Encoding.Unicode.GetBytes(content);
                await sourceStream.WriteAsync(encodedText, 0, encodedText.Length)
                    .ConfigureAwait(false);
            };
        }
    }
}
