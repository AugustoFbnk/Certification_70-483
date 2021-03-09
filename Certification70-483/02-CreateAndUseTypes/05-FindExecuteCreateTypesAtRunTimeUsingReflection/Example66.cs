using System;

namespace Certification70_483._02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection
{
    /// <summary>
    /// Defining the targets for a custom attribute
    /// </summary>
    public static class Example66
    {
        [MyMethodAndParameterAttribute]
        public static void Start()
        {
        }

        [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
        public class MyMethodAndParameterAttribute : Attribute { }
    }
}
