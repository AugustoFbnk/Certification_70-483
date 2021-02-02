using System;

namespace Certification70_483._02_CreateAndUseTypes._04_CreateAndImplementClassHierarchy
{
    /// <summary>
    /// Hiding a method with the new keyword
    /// Running this code will output Base.Execute twice;
    /// The new keywork is just for explictly hide the member
    /// </summary>
    public static class Example48
    {
        public static void Start()
        {
            Base2 b = new Base2();
            b.Execute();
            b = new Derived2();
            b.Execute();
        }
    }

    class Base2
    {
        public void Execute() { Console.WriteLine("Base2.Execute"); }
    }
    class Derived2 : Base2
    {
        public new void Execute() { Console.WriteLine("Derived2.Execute"); }
    }
}
