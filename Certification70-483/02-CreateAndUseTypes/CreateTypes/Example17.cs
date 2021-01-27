using System;

namespace Certification70_483._02_CreateAndUseTypes.CreateTypes
{
    /// <summary>
    /// Overriding a virtual method
    /// </summary>
    public static class Example17
    {
        public static void Start()
        {
            var baseClass = new Base();
            Console.WriteLine(baseClass.MyMethod());
            var derivedClass = new Derived();
            Console.WriteLine(derivedClass.MyMethod());

            Console.ReadKey();
        }
    }

    class Base
    {
        public virtual int MyMethod()
        {
            return 42;
        }
    }
    class Derived : Base
    {
        public override int MyMethod()
        {
            return base.MyMethod() * 2;
        }
    }
}
