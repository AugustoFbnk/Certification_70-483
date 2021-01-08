using System;

namespace Certification70_483._01_ManageProgramFlow._05_ImplementExceptionHandling.CustomExceptions
{
    public class OrderProcessingException : Exception
    {
        public OrderProcessingException(string customizedError, Exception ex) 
            : base($"An error happened when trying to proccess your order: {customizedError} - {ex.Message}")
        {

        }
    }
}
