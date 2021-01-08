using System;
using System.Runtime.ExceptionServices;

namespace Certification70_483._01_ManageProgramFlow._05_ImplementExceptionHandling
{
    /// <summary>
    /// Using ExceptionDispatchInfo.Throw
    /// ExceptionDispatchInfo.Throw method can be used to throw an exception and preserve the original stacktrace
    /// "This feature can be used when you want to catch an exception in one thread and throw it
    ///  on another thread.By using the ExceptionDispatchInfo class, you can move the exception data
    ///  between threads and throw it"
    /// </summary>
    public static class Example97
    {
        public static void Start()
        {
            ExceptionDispatchInfo possibleException = null;

            try
            {
                string s = Console.ReadLine();
                int.Parse(s);
            }
            catch (FormatException ex)
            {
                possibleException = ExceptionDispatchInfo.Capture(ex);
            }
            //Its possible to access even outsite catch block
            if (possibleException != null)
            {
                possibleException.Throw();
            }
        }
    }
}
