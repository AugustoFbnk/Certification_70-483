using System.Diagnostics;
using System.IO;

namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._05_ImplementDiagnosticsInAnApplication
{
    /// <summary>
    /// Configuring TraceListener.
    /// </summary>
    public class Example47
    {
        public static void Start()
        {
            Stream outputFile = File.Create("tracefile.txt");
            TextWriterTraceListener textListener = new TextWriterTraceListener(outputFile);
            TraceSource traceSource = new TraceSource("myTraceSource", SourceLevels.All);
            traceSource.Listeners.Clear();
            traceSource.Listeners.Add(textListener);
            traceSource.TraceInformation("Trace output");
            traceSource.Flush();
            traceSource.Close();
        }
    }
}
