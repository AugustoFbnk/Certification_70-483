namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._04_DebugAnApplication
{
    //The warning and error directives
    public class Example37
    {

        public static void Start()
        {
#warning This code is obsolete
#if DEBUG
//#error Debug build is not allowed
#endif
        }
    }
}
