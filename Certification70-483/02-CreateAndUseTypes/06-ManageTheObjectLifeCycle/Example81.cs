using System;
using System.IO;

namespace Certification70_483._02_CreateAndUseTypes._06_ManageTheObjectLifeCycle
{

    /// <summary>
    /// Forcing a garbage collection
    /// it's possible, but not recommended
    /// This case will only work in release mode
    /// in debug mode, the compiler will make sure that the reference isn’t garbage collected till the end of the method
    /// </summary>
    public static class Example81
    {

        public static void Start()
        {
            StreamWriter stream = File.CreateText("temp.dat");
            stream.Write("some data");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            File.Delete("temp.dat");
        }
    }
}
