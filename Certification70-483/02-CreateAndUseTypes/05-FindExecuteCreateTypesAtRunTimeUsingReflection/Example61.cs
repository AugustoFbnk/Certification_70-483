using System;

namespace Certification70_483._02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection
{
    /// <summary>
    /// Seeing whether an attribute is defined
    /// </summary>
    public static class Example61
    {
        public static void Start()
        {
            if (Attribute.IsDefined(typeof(Person2), typeof(SerializableAttribute)))
            {
                Console.WriteLine("SerializableAttribute is defined");
            }
        }
    }

    [Serializable]
    class Person2 { }


}
