using System;
using System.Net.Http;

namespace Certification70_483._02_CreateAndUseTypes.CreateTypes
{
    /// <summary>
    /// Implicitly converting an object to a base type
    /// </summary>
    public static class Example21
    {
        public static void Start()
        {
            HttpClient client = new HttpClient();
            object o = client;
            IDisposable d = client;
        }
    }
}
