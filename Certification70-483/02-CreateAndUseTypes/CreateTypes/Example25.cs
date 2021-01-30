using Certification70_483._02_CreateAndUseTypes.CreateTypes.common;
using System;

namespace Certification70_483._02_CreateAndUseTypes.CreateTypes
{
    /// <summary>
    /// Using an implicit and explicit cast operator on a custom type
    /// </summary>
    public static class Example25
    {
        public static void Start()
        {
            Money m = new Money(42.42M);
            decimal amount = m;
            Console.WriteLine(amount);
            int truncatedAmount = (int)m;
            Console.WriteLine(truncatedAmount);
        }
    }
}
