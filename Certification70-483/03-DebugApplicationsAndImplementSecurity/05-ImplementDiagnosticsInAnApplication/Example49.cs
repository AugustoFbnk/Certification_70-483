using System;
using System.Diagnostics;

namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._05_ImplementDiagnosticsInAnApplication
{
    /// <summary>
    /// Writing data to the event log
    /// </summary>
    public class Example49
    {

        public static void Start()
        {
            if (!EventLog.SourceExists("MySource"))
            {
                EventLog.CreateEventSource("MySource", "MyNewLog");
                Console.WriteLine("CreatedEventSource");
                Console.WriteLine("Please restart application");
                Console.ReadKey();
                return;
            }
            EventLog myLog = new EventLog();
            myLog.Source = "MySource";
            myLog.WriteEntry("Log event!");
        }
    }
}
