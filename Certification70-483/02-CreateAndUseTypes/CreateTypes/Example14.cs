namespace Certification70_483._02_CreateAndUseTypes.CreateTypes
{
    /// <summary>
    /// Using a where clause on a class definition
    /// </summary>
    public static class Example14
    {
        public static void Start()
        {
            var myClass = new MyClass<ClassWithDefautlConstructor>();
        }

        class ClassWithDefautlConstructor
        {
            public ClassWithDefautlConstructor()
            {

            }
        }

        class MyClass<T> where T : class, new()
        {
            public MyClass()
            {
                MyProperty = new T();
            }
            T MyProperty { get; set; }
        }
    }
}
