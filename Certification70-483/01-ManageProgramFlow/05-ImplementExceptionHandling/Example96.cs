using Certification70_483._01_ManageProgramFlow._05_ImplementExceptionHandling.CustomExceptions;
using System;

namespace Certification70_483._01_ManageProgramFlow._05_ImplementExceptionHandling
{
    /// <summary>
    /// Throwing a new exception that points to the original one
    /// </summary>
    public static class Example96
    {
        public static void Start()
        {
            try
            {
                ProcessOrder();
            }
            catch (Exception ex)
            {
                throw new OrderProcessingException("Error while processing order", ex);
            }
        }

        private static void ProcessOrder()
        {
            throw new Exception();
        }
    }
}
