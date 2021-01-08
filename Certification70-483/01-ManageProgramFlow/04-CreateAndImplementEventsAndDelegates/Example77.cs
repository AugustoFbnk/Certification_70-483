using System.IO;

namespace Certification70_483._01_ManageProgramFlow._04_CreateAndImplementEventsAndDelegates
{
    /// <summary>
    /// 7 Covariance with delegates
    /// </summary>
    public static class Example77
    {
        public delegate TextWriter CovarianceDel();
        public static StreamWriter MethodStream() { return null; }
        public static StringWriter MethodString() { return null; }
        public static void Start()
        {
            CovarianceDel del;
            del = MethodStream;
            del = MethodString;
        }
    }
}
