using Certification70_483._02_CreateAndUseTypes._04_CreateAndImplementClassHierarchy.common;
using System;

namespace Certification70_483._02_CreateAndUseTypes._04_CreateAndImplementClassHierarchy
{
    /// <summary>
    /// A Rectangle class with an Area calculation
    /// Exemplifying the violation of Lyscov principle 01
    /// </summary>
    public static class Example50
    {
        public static void Start()
        {
            var rectangle = new Rectangle();
            rectangle.Height = 10;
            rectangle.Width = 5;
            Console.WriteLine(rectangle.Area);
        }
    }
}
