namespace Certification70_483._02_CreateAndUseTypes.CreateTypes
{
    /// <summary>
    /// Declaring and using a field
    /// </summary>
    public static class Example09
    {
        public static string MyInstanceField;

        public static void Start()
        {
            Concatenate("value");
        }
        
        public static string Concatenate(string valueToAppend)
        {
            return MyInstanceField + valueToAppend;
        }
    }
}
