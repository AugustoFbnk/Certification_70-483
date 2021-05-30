using System;
using System.IO;

namespace Certification70_483._04_ImplementDataAccess._01_PerformIOOperations
{
    /// <summary>
    /// Opening a TextFile and reading the content
    /// </summary>
    public class Example17
    {
        public static void Start()
        {
            string path = @"c:\temp\test.dat";
            using (StreamReader streamWriter = File.OpenText(path))
            {
                Console.WriteLine(streamWriter.ReadLine());
            }
        }
    }
}
