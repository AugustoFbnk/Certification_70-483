using Certification70_483._02_CreateAndUseTypes._04_CreateAndImplementClassHierarchy.common;
using System;

namespace Certification70_483._02_CreateAndUseTypes._04_CreateAndImplementClassHierarchy
{
    /// <summary>
    /// A Square class that inherits from Rectangle    /// Exemplifying the violation of Lyscov principle 02    /// </summary>
    public static class Example51
    {
        public static void Start()
        {
            var square = new Square();
            square.Height = 10;
            square.Width = 10;
            Console.WriteLine(square.Area);
        }
    }
}
