using System.Net.Http;
using System.Threading.Tasks;

namespace Certification70_483._04_ImplementDataAccess._01_PerformIOOperations
{

    /// <summary>
    /// Executing multiple requests in parallel
    /// </summary>
    public class Example26
    {

        public static async void Start()
        {
            await ExecuteMultipleRequestsInParallel();
        }

        public static async Task ExecuteMultipleRequestsInParallel()
        {
            HttpClient client = new HttpClient();
            Task microsoft = client.GetStringAsync("http://www.microsoft.com");
            Task msdn = client.GetStringAsync("http://msdn.microsoft.com");
            Task blogs = client.GetStringAsync("http://blogs.msdn.com/");
            await Task.WhenAll(microsoft, msdn, blogs);
        }
    }
}
