using System.Threading;

namespace Certification70_483._01_ManageProgramFlow._02_ManageMultithreading
{
    /// <summary>
    /// Generated code from a lock statement
    /// The lock code is translated by the compiler into something that looks like this
    /// </summary>
    public static class Example38
    {
        public static void Start()
        {
            object gate = new object();
            bool __lockTaken = false;
            try
            {
                Monitor.Enter(gate, ref __lockTaken);
            }
            finally
            {
                if (__lockTaken)
                    Monitor.Exit(gate);
            }
        }
    }
}
