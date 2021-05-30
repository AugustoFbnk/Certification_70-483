using System;
using System.IO;

namespace Certification70_483._04_ImplementDataAccess._01_PerformIOOperations
{

    /// <summary>
    /// Depending on File.Exists when reading file content
    /// </summary>
    public class Example20
    {

        public static void Start()
        {
            Console.WriteLine(ReadAllText());
        }

        private static string ReadAllText()
        {
            string path = @"C:\temp\test.txt";
            if (File.Exists(path))
            {
                return File.ReadAllText(path);
            }
            return string.Empty;
        }
    }
}
