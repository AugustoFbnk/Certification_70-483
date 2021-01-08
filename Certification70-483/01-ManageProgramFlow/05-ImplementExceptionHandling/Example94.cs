using System;
using System.IO;

namespace Certification70_483._01_ManageProgramFlow._05_ImplementExceptionHandling
{
    /// <summary>
    /// Throwing an ArgumentNullException
    /// </summary>
    public static class Example94
    {
        public static void Start()
        {
            var fileName = Console.ReadLine();
            OpenAndParse(fileName);
        }
        public static string OpenAndParse(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
                throw new ArgumentNullException("fileName", "Filename is required");
            return File.ReadAllText(fileName);
        }
    }
}
