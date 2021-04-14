using System;

namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._04_DebugAnApplication
{
    /// <summary>
    /// Call a method only in a debug build
    /// </summary>
    public class Example41
    {

        public static void Start()
        {
            SomeMethod();
        }

        public static void SomeMethod()
        {
#if DEBUG
    Log("Step1");
#endif
        }
        private static void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
