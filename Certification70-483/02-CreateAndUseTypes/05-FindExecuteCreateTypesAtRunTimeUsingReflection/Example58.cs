using System;

namespace Certification70_483._02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection
{
    /// <summary>
    /// Applying an attribute
    /// </summary>
    public static class Example58
    {
        public static void Start()
        {
            var serializablePerson = new Person();
        }
    }

    [Serializable]
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
