
using System.IO;

namespace Certification70_483._02_CreateAndUseTypes._06_ManageTheObjectLifeCycle
{

    /// <summary>
    /// Not closing a file will throw an error
    /// </summary>
    public static class Example80
    {

        public static void Start()
        {
            StreamWriter stream = File.CreateText("temp.dat");
            stream.Write("some data");
            File.Delete("temp.dat"); // Throws an IOException because the file is already open.
        }
    }
}
