namespace Certification70_483._02_CreateAndUseTypes._03_EnforceEncapsulation
{
    /// <summary>
    /// Implementing an interface explicitly
    /// </summary>
    public static class Example39
    {
        public static void Start()
        {
            var implementation = new Implementation();
            //implementation.MyMethod() would'nt compiles because MyMethod is implementing an Explicitly interface
            ((IInterfaceA)implementation).MyMethod();
        }
    }

    interface IInterfaceA
    {
        void MyMethod();
    }
    class Implementation : IInterfaceA
    {
        void IInterfaceA.MyMethod() { }
    }
}
