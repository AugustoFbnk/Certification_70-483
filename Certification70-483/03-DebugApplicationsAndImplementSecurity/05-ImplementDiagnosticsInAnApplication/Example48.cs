namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._05_ImplementDiagnosticsInAnApplication
{
    /// <summary>
    /// Using a configuration file for tracing
    /// </summary>
    public class Example48
    {
        public static void Start()
        {
            /*
             <?xml version="1.0" encoding="utf-8" ?>
             <configuration>
               <system.diagnostics>
                 <sources>
                   <source name="myTraceSource" switchName="defaultSwitch">
                     <listeners>
                       <add initializeData="output.txt" 
                           type="System.Diagnostics.TextWriterTraceListeer"            
                           name="myLocalListener">
                           <filter type="System.Diagnostics.EventTypeFilter" 
                           initializeData="Warning"/>
                        </add>
                       <add name="consoleListener" />
                       <remove name="Default"/>
                     </listeners>
                   </source>
                 </sources>
                 <sharedListeners>
                   <add initializeData="output.xml" type="System.Diagnostics.XmlWriterTraceListener"
                      name="xmlListener" traceOutputOptions="None" />
                   <add type="System.Diagnostics.ConsoleTraceListener" name="consoleListener"
                       traceOutputOptions="None" />
                 </sharedListeners>
               <switches>
                   <add name="defaultSwitch" value="All" />
                 </switches>
               </system.diagnostics>
             </configuration>
             */
        }
    }
}
