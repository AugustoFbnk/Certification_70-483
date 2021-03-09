using System;

namespace Certification70_483._02_CreateAndUseTypes._06_ManageTheObjectLifeCycle
{

    /// <summary>
    /// The IDisposable interface
    /// </summary>
    public class Example82
    {

        public static void Start()
        {
            var classDisposable = new ClassImplementindIDisposable();
        }
    }

    public class ClassImplementindIDisposable : IDisposable
    {
        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
