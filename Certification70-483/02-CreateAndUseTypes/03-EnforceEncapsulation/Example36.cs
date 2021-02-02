namespace Certification70_483._02_CreateAndUseTypes._03_EnforceEncapsulation
{
    /// <summary>
    /// Encapsulating a field with custom methods
    /// </summary>
    public static class Example36
    {
        private static int _field;
        public static void SetValue(int value) { _field = value; }
        public static int GetValue() { return _field; }

        public static void Start(int value)
        {
            GetValue();
            SetValue(value);
        }
    }
}
