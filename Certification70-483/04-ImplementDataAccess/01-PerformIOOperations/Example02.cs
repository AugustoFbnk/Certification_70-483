using System.IO;

namespace Certification70_483._04_ImplementDataAccess._01_PerformIOOperations
{

    /// <summary>
    /// Creating a new directory
    /// </summary>
    public class Example02
    {
        public static void Start()
        {
            var directory = Directory.CreateDirectory(@"C:\Temp\ProgrammingInCSharp\Directory");
            var directoryInfo = new DirectoryInfo(@"C:\Temp\ProgrammingInCSharp\DirectoryInfo");
            directoryInfo.Create();
        }
    }
}
