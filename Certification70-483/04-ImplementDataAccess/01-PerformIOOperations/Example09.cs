using System.IO;

namespace Certification70_483._04_ImplementDataAccess._01_PerformIOOperations
{
    /// <summary>
    /// Moving a file
    /// </summary>
    public class Example09
    {

        public static void Start()
        {
            string path = @"c:\temp\test.txt";
            string destPath = @"c:\temp\destTest.txt";
            File.CreateText(path).Close();
            File.Move(path, destPath);
            FileInfo fileInfo = new FileInfo(path);
            fileInfo.MoveTo(destPath);
        }
    }
}
