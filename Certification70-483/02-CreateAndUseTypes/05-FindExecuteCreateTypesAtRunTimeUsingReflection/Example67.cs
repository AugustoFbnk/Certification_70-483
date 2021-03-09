using System;

namespace Certification70_483._02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection
{
    /// <summary>
    /// Setting the AllowMultiple parameter for a custom attribute
    /// </summary>
    [MyMultipleUsageAttribute]
    public static class Example67
    {
        public static void Start()
        {
            var myMultipleUsageAttribute = new MyMultipleUsageAttribute();
        }

        [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
        class MyMultipleUsageAttribute : Attribute { }
    }
}
