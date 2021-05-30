using System;
using System.IO;
using System.Net;

namespace Certification70_483._04_ImplementDataAccess._01_PerformIOOperations
{
    /// <summary>
    /// Executing a web request
    /// </summary>
    public class Example22
    {

        public static void Start()
        {
            WebRequest request = WebRequest.Create("http://www.microsoft.com");
            WebResponse response = request.GetResponse();
            StreamReader responseStream = new StreamReader(response.GetResponseStream());
            string responseText = responseStream.ReadToEnd();
            Console.WriteLine(responseText);
            response.Close();
        }
    }
}
