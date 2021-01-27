using Certification70_483._01_ManageProgramFlow._05_ImplementExceptionHandling.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification70_483._01_ManageProgramFlow._05_ImplementExceptionHandling
{
    /// <summary>
    /// Creating a custom exception
    /// look at OrderProcessingException to see the implementation
    /// </summary>
    public static class Example98
    {
        public static void Start()
        {
            try
            {
                ThrowException();
            }
            catch (OrderProcessingException)
            {
                throw;
            }
        }

        private static void ThrowException()
        {
            throw new OrderProcessingException(orderId: 123, message: "Test");
        }
    }
}
