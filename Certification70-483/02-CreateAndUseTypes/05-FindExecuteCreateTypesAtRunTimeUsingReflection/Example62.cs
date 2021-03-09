#define CONDITION1
using System;
using System.Diagnostics;

namespace Certification70_483._02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection
{
    /// <summary>
    /// Getting a specific attribute instance
    /// </summary>
    public static class Example62
    {
        public static void Start()
        {
            ConditionalAttribute conditionalAttribute =
                (ConditionalAttribute)Attribute.GetCustomAttribute(
                    typeof(Person3),
                    typeof(ConditionalAttribute));
            string condition = conditionalAttribute.ConditionString; // returns CONDITION1
        }

    }

    [Conditional("CONDITION1")]
    public class Person3 : Attribute
    {

    }
}
