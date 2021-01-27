namespace Certification70_483._02_CreateAndUseTypes.CreateTypes
{
    /// <summary>
    /// Using the sealed keyword on a method
    /// </summary>
    public static class Example18
    {
        public static void Start()
        {
            var derived3 = new Derived3();
            derived3.MyMethod();
        }
    }

    class Base2
    {
        public virtual int MyMethod()
        {
            return 42;
        }
    }
    class Derived2 : Base
    {
        public sealed override int MyMethod()
        {
            return base.MyMethod() * 2;
        }
    }
    class Derived3 : Derived2
    {
        // This line would give a compile error
        //public override int MyMethod() { return 1;}
    }
}
