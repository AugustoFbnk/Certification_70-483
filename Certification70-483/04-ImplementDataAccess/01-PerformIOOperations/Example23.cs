using System;
using System.IO;
using System.Threading.Tasks;

namespace Certification70_483._04_ImplementDataAccess._01_PerformIOOperations
{
    /// <summary>
    /// Writing asynchronously to a file
    /// </summary>
    public class Example23
    {

        public static async void Start()
        {
            await CreateAndWriteAsyncToFile();
        }

        public static async Task CreateAndWriteAsyncToFile()
        {
            using (FileStream stream = new FileStream("test.dat", FileMode.Create,
                FileAccess.Write, FileShare.None, 4096, true))
            {
                byte[] data = new byte[100000];
                new Random().NextBytes(data);
                await stream.WriteAsync(data, 0, data.Length);
            }
        }
    }
}
