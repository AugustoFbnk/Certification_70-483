namespace Certification70_483._02_CreateAndUseTypes._01_CreateTypes
{
    /// <summary>
    /// Using named and optional arguments
    /// </summary>
    public static class Example07
    {
        public static void Start()
        {
            MyMethod(1, thirdArgument: true);
        }

        private static void MyMethod(int firstArgument, string secondArgument = "default value", bool thirdArgument = false)
        {

        }
    }
}
