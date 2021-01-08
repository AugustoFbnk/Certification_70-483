using System;

namespace Certification70_483._01_ManageProgramFlow._05_ImplementExceptionHandling
{
    /// <summary>
    /// Rethrowing an exception
    /// </summary>
    public static class Example95
    {
        public static void Start()
        {
            try
            {
                SomeOperation();
            }
            catch (Exception logEx)
            {
                Log(logEx);
                throw; // rethrow the original exception
            }
        }

        private static void Log(Exception logEx)
        {
            Console.WriteLine($"{logEx.Message} - {logEx.InnerException}");
        }

        private static void SomeOperation()
        {
            throw new NotImplementedException();
        }
    }
}
