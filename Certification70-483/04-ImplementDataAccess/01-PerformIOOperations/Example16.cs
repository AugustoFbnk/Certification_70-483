using System;
using System.IO;
using System.Text;

namespace Certification70_483._04_ImplementDataAccess._01_PerformIOOperations
{
    /// <summary>
    /// Opening a FileStream and decode the bytes to a string
    /// </summary>
    public class Example16
    {

        public static void Start()
        {
            string path = @"c:\temp\test.dat";

            using (FileStream fileStream = File.OpenRead(path))
            {
                byte[] data = new byte[fileStream.Length];
                for (int index = 0; index < fileStream.Length; index++)
                {
                    data[index] = (byte)fileStream.ReadByte();
                }
                Console.WriteLine(Encoding.UTF8.GetString(data));
            }
        }
    }
}
