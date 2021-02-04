namespace Certification70_483._02_CreateAndUseTypes._04_CreateAndImplementClassHierarchy
{
    /// <summary>
    /// The IDisposable interface
    /// </summary>
    public static class Example57
    {
        public static void Start()
        {
            var disposableClass = new DisposableClass();
            disposableClass.Dispose();
        }
    }

    public class DisposableClass : IDisposable
    {
        public void Dispose()
        {
            //Dispose
        }
    }

    public interface IDisposable
    {
        void Dispose();
    }
}
