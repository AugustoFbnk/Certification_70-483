using System.Diagnostics;

namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._05_ImplementDiagnosticsInAnApplication
{
    /// <summary>
    /// Using the TraceSource class
    /// </summary>
    public class Example46
    {

        public static void Start()
        {
            TraceSource traceSource = new TraceSource("myTraceSource", SourceLevels.All);
            traceSource.TraceInformation("Tracing application..");
            traceSource.TraceEvent(TraceEventType.Critical, 0, "Critical trace");
            traceSource.TraceData(TraceEventType.Information, 1,
                new object[] { "a", "b", "c" });
            traceSource.Flush();
            traceSource.Close();
        }
    }
}
