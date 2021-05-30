using System.IO;

namespace Certification70_483._04_ImplementDataAccess._01_PerformIOOperations
{
    /// <summary>
    /// Using File.CreateText with a StreamWrite
    /// </summary>
    public class Example15
    {
        public static void Start()
        {
            string path = @"c:\temp\test.dat";
            using (StreamWriter streamWriter = File.CreateText(path))
            {
                string myValue = "MyValue";
                streamWriter.Write(myValue);
            }
        }
    }
}
