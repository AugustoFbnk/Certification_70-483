using System.IO;

namespace Certification70_483._04_ImplementDataAccess._01_PerformIOOperations
{
    /// <summary>
    /// Using Path.Combine
    /// </summary>
    public class Example12
    {
        public static void Start()
        {
            string folder = @"C:\temp";
            string fileName = "test.dat";
            string fullPath = Path.Combine(folder, fileName);
        }
    }
}
