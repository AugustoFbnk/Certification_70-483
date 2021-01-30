using Certification70_483._02_CreateAndUseTypes.CreateTypes.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification70_483._02_CreateAndUseTypes.CreateTypes
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
