namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._04_DebugAnApplication
{

    /// <summary>
    /// The line directive
    /// </summary>
    public class Example38
    {

        public static void Start()
        {
#line 200 "OtherFileName"
            int a;    // line 200
#line default
            int b;   // line 4
#line hidden
            int c; // hidden
            int d; // line 7
        }
    }
}
