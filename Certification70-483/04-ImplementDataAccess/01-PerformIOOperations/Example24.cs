using System.Net.Http;
using System.Threading.Tasks;

namespace Certification70_483._04_ImplementDataAccess._01_PerformIOOperations
{

    /// <summary>
    /// Executing an asynchronous HTTP request
    /// </summary>
    public class Example24
    {

        public async static void Start()
        {
            await ReadAsyncHttpRequest();
        }

        public static async Task ReadAsyncHttpRequest()
        {
            HttpClient client = new HttpClient();
            string result = await client.GetStringAsync("http://www.microsoft.com");
        }
    }
}
