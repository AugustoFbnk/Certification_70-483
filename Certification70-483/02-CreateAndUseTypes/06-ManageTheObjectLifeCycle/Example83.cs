using System.IO;

namespace Certification70_483._02_CreateAndUseTypes._06_ManageTheObjectLifeCycle
{

    /// <summary>
    /// Calling Dispose to free unmanaged resources
    /// </summary>
    public class Example83
    {

        public static void Start()
        {
            StreamWriter stream = File.CreateText("temp.dat");
            stream.Write("some data");
            stream.Dispose();
            File.Delete("temp.dat");
        }
    }
}
