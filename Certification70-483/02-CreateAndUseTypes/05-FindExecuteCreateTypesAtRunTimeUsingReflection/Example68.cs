using System;

namespace Certification70_483._02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection
{
    /// <summary>
    /// Adding properties to a custom attribute
    /// </summary>
    [CompleteCustomAttribute("Test")]
    public static class Example68
    {
        public static void Start()
        {
        }

        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
        class CompleteCustomAttribute : Attribute
        {
            public CompleteCustomAttribute(string description)
            {
                Description = description;
            }
            public string Description { get; set; }
        }
    }
}
