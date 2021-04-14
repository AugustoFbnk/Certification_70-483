using System;
using System.Reflection;

namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._04_DebugAnApplication
{
    /// <summary>
    /// Using preprocessor directives to target multiple platforms
    /// </summary>
    public class Example36
    {
        public static void Start()
        {
            var assembly = LoadAssembly<Example36>();
            Console.WriteLine(assembly.FullName);
        }

        public static Assembly LoadAssembly<T>()
        {
#if !WINRT
            Assembly assembly = typeof(T).Assembly;
#else
        Assembly assembly = typeof(T).GetTypeInfo().Assembly;
#endif
            return assembly;
        }
    }
}
