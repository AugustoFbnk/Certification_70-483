using System.Net.Http;
using System.Threading.Tasks;

namespace Certification70_483._04_ImplementDataAccess._01_PerformIOOperations
{

    /// <summary>
    /// Executing multiple awaits
    /// </summary>
    public class Example25
    {

        public static async void Start()
        {
            await ExecuteMultipleRequests();
        }

        public static async Task ExecuteMultipleRequests()
        {
            HttpClient client = new HttpClient();
            string microsoft = await client.GetStringAsync("http://www.microsoft.com");
            string msdn = await client.GetStringAsync("http://msdn.microsoft.com");
            string blogs = await client.GetStringAsync("http://blogs.msdn.com/");
        }
    }
}
