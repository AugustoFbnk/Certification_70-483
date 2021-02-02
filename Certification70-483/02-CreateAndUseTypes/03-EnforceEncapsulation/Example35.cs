namespace Certification70_483._02_CreateAndUseTypes._03_EnforceEncapsulation
{
    /// <summary>
    /// Using the internal access modifier
    /// You can use internal types outside your assembly by adding the InternalsVisibleTo attribue in your AssemblyInfo
    /// Example: [assembly:InternalsVisibleTo("AssemblyNameWhichWillBeAllowed")]
    /// </summary>
    public static class Example35
    {
        public static void Start()
        {
            var internalClass = new MyInternalClass();
            internalClass.MyMethod();
        }
    }

    internal class MyInternalClass
    {
        public void MyMethod() { }
    }
}
