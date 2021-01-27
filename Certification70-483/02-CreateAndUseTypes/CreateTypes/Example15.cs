using System;

namespace Certification70_483._02_CreateAndUseTypes.CreateTypes
{
    /// <summary>
    /// Using default(T) with a generic type parameter
    /// </summary>
    public static class Example15
    {
        public static void Start()
        {
            var myClass2 = new MyClass2();
            myClass2.MyGenericMethod<int>();
        }

        class MyClass2
        {
            public void MyGenericMethod<T>()
            {
                T defaultValue = default(T);
                Console.WriteLine(defaultValue);
            }
        }
    }
}
