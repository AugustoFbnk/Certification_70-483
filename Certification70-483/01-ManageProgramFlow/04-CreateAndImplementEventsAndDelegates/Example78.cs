using System.IO;

namespace Certification70_483._01_ManageProgramFlow._04_CreateAndImplementEventsAndDelegates
{
    /// <summary>
    /// Contravariance with delegates
    /// </summary>
    public static class Example78
    {
        private static void DoSomething(TextWriter tw) { }
        public delegate void ContravarianceDel(StreamWriter tw);

        public static void Start()
        {
            ContravarianceDel del = DoSomething;
        }
    }
}
