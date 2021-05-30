using System;
using System.IO;

namespace Certification70_483._04_ImplementDataAccess._01_PerformIOOperations
{
    /// <summary>
    /// Using other Path methods to parse a path
    /// </summary>
    public class Example13
    {
        public static void Start()
        {
            string path = @"C:\temp\subdir\file.txt";
            Console.WriteLine(Path.GetDirectoryName(path)); // Displays C:\temp\subdir
            Console.WriteLine(Path.GetExtension(path)); // Displays .txt
            Console.WriteLine(Path.GetFileName(path)); // Displays file.txt
            Console.WriteLine(Path.GetPathRoot(path)); // Displays C:\
        }
    }
}
