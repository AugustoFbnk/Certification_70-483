using System;
using System.Reflection;

namespace Certification70_483._02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection
{
    /// <summary>
    /// Getting the value of a field through reflection
    /// </summary>
    public static class Example72
    {
        public static void Start()
        {
            var obj = new ObjectWithIntegerPrivateFields();
            DumpObject(obj);
        }

        static void DumpObject(object obj)
        {
            FieldInfo[] fields = obj.GetType().GetFields(
                BindingFlags.Instance | 
                BindingFlags.NonPublic);

            foreach (FieldInfo field in fields)
            {
                if (field.FieldType == typeof(int))
                {
                    Console.WriteLine(field.GetValue(obj));
                }
            }
        }
    }

    class ObjectWithIntegerPrivateFields
    {
        public ObjectWithIntegerPrivateFields()
        {
            myProperty1 = 1;
            myProperty2 = 2;
            myProperty3 = 3;
            myProperty4 = 4;
        }
        private int myProperty1;
        private int myProperty2;
        private int myProperty3;
        private int myProperty4;
    }


}
