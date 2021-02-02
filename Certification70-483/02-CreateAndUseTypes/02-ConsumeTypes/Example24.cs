using Certification70_483._02_CreateAndUseTypes._02_ConsumeTypes.common;
using System;

namespace Certification70_483._02_CreateAndUseTypes._02_ConsumeTypes
{
    /// <summary>
    /// Implementing an implicit and explicit conversion operator
    /// See Money class
    /// </summary>
    public static class Example24
    {
        public static void Start()
        {
            var money = new Money(15.4m);

            Console.WriteLine(money.Amount);
        }
    }
}
