namespace Certification70_483._02_CreateAndUseTypes._04_CreateAndImplementClassHierarchy
{
    /// <summary>
    /// Creating an abstract class
    /// </summary>
    public static class Example49
    {
        public static void Start()
        {
            var derived = new Derived3();
            derived.AbstractMethod();
            derived.MethodWithImplementation();

            //The code bellow Won't compile. Abstracts classes can't be instantiated
            //var baseClass = new Base3()
        }
    }

    abstract class Base3
    {
        public virtual void MethodWithImplementation() {/*Method with implementation*/}
        public abstract void AbstractMethod();
    }
    class Derived3 : Base3
    {
        public override void AbstractMethod() { }
    }
}
