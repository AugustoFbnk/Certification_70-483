/// <summary>
/// Using the protected access modifier with inheritance
/// </summary>
namespace Certification70_483._02_CreateAndUseTypes._03_EnforceEncapsulation
{
    public static class Example34
    {
        public static void Start()
        {
            var derived = new Derived1();
            derived.MyDerivedMethod();
        }
    }

    public class Base1
    {
        private int _privateField = 42;
        protected int _protectedField = 42;
        private void MyPrivateMethod() { }
        protected void MyProtectedMethod() { }
    }
    public class Derived1 : Base1
    {
        public void MyDerivedMethod()
        {
            // _privateField = 41; // Not OK, this will generate a compile error
            _protectedField = 43; // OK, protected fields can be accessed
                                  // MyPrivateMethod(); // Not OK, this will generate a compile error
            MyProtectedMethod(); // OK, protected methods can be accessed
        }
    }
}
