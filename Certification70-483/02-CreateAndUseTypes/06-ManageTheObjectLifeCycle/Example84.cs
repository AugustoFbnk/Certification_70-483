using Certification70_483._02_CreateAndUseTypes._06_ManageTheObjectLifeCycle.common;

namespace Certification70_483._02_CreateAndUseTypes._06_ManageTheObjectLifeCycle
{

    /// <summary>
    /// Implementing IDisposable and a finalizer
    /// </summary>
    public class Example84
    {

        public static void Start()
        {
            var disposableClass = new UnmangedWrapper();
            disposableClass.Dispose();
        }
    }
}
