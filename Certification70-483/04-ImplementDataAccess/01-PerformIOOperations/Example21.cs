using System;
using System.IO;

namespace Certification70_483._04_ImplementDataAccess._01_PerformIOOperations
{
    /// <summary>
    /// Using exception handling when opening a file
    /// </summary>
    public class Example21
    {
        public static void Start()
        {
            Console.WriteLine(ReadAllText());
        }

        private static string ReadAllText()
        {
            string path = @"C:\temp\test.txt";
            try
            {
                return File.ReadAllText(path);
            }
            catch (DirectoryNotFoundException) { }
            catch (FileNotFoundException) { }
            return string.Empty;
        }
    }
}
