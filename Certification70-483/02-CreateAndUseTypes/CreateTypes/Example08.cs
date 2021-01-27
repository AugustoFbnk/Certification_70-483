namespace Certification70_483._02_CreateAndUseTypes.CreateTypes
{
    /// <summary>
    /// Returning data from a method
    /// </summary>
    public static class Example08
    {
        public static void Start()
        {
            MethodWithoutAnyReturnValue();
            MethodWithReturnValue();
        }

        private static void MethodWithoutAnyReturnValue()
        {

        }
        private static int MethodWithReturnValue()
        {
            return 42;
        }
    }
}
