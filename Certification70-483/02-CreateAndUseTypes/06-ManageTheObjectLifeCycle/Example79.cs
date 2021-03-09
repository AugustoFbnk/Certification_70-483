namespace Certification70_483._02_CreateAndUseTypes._06_ManageTheObjectLifeCycle
{
    /// <summary>
    /// Adding a finalizer
    /// </summary>
    public class Example79
    {
        public static void Start()
        {
            var finalizer = new ExampleFinalizer();
        }
    }

    public class ExampleFinalizer
    {
        ~ExampleFinalizer()
        {

        }
    }
}
