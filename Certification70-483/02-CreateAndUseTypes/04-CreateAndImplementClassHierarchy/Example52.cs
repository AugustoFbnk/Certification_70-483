using Certification70_483._02_CreateAndUseTypes._04_CreateAndImplementClassHierarchy.common;
using System;

namespace Certification70_483._02_CreateAndUseTypes._04_CreateAndImplementClassHierarchy
{
    /// <summary>
    /// Using the Square class
    /// Exemplifying the violation of Lyscov principle 03
    /// </summary>
    public static class Example52
    {
        public static void Start()
        {
            Rectangle rectangle = new Square();
            rectangle.Height = 10;
            rectangle.Width = 5;
            Console.WriteLine(rectangle.Area);
        }
    }
}
