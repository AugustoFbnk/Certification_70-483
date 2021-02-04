#define CONDITION1
using System.Diagnostics;

namespace Certification70_483._02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection
{
    /// <summary>
    /// Using multiple attributes
    /// Because #define CONDITION1 is specified, the MyMethod is executed
    /// </summary>
    public static class Example59
    {
        public static void Start()
        {
            MyMethod();
        }

        [Conditional("CONDITION1"), Conditional("CONDITION2")]
        static void MyMethod() { }
    }
}
