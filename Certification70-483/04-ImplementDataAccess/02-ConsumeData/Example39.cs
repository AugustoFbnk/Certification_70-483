
using System;
using System.ServiceModel;

namespace Certification70_483._04_ImplementDataAccess._02_ConsumeData
{

    /// <summary>
    /// A simple WCF web service
    /// You can create this service by creating a new ASP.NET project and adding a WCF service to 
    /// it. A WCF service consists of both an.svc file and a code-behind file that contains the actual
    /// service code
    /// </summary>
    public class Example39
    {

        public static void Start()
        {
            var service = new MyService();
            Console.WriteLine(service.DoWork("10", "20"));
        }

        [ServiceContract]
        public class MyService
        {
            [OperationContract]
            public string DoWork(string left, string right)
            {
                return left + right;
            }

        }
    }
}