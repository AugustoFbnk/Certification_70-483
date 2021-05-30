using System.IO;

namespace Certification70_483._04_ImplementDataAccess._01_PerformIOOperations
{
    /// <summary>
    /// Deleting an existing directory
    /// </summary>
    public class Example03
    {
        public static void Start()
        {
            if (Directory.Exists(@"C:\Temp\ProgrammingInCSharp\Directory"))
            {
                Directory.Delete(@"C:\Temp\ProgrammingInCSharp\Directory");
            }
            var directoryInfo = new DirectoryInfo(@"C:\Temp\ProgrammingInCSharp\DirectoryInfo");
            if (directoryInfo.Exists)
            {
                directoryInfo.Delete();
            }
        }
    }
}
