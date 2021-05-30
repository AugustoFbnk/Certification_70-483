using System;
using System.Diagnostics;

namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._05_ImplementDiagnosticsInAnApplication
{
    /// <summary>
    /// Writing data to the event log
    /// </summary>
    public class Example51
    {
        public static void Start()
        {
            EventLog applicationLog = new EventLog("Application", ".", "testEventLogEvent");
            applicationLog.EntryWritten += (sender, e) =>
            {
                Console.WriteLine(e.Entry.Message);
            };
            applicationLog.EnableRaisingEvents = true;
            applicationLog.WriteEntry("Test message", EventLogEntryType.Information);

            Console.ReadKey();
        }
    }
}
