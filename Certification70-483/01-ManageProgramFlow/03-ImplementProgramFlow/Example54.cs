namespace Certification70_483._01_ManageProgramFlow._03_ImplementProgramFlow
{
    /// <summary>
    /// Code blocks and scoping
    /// </summary>
    public static class Example54
    {
        public static void Start()
        {
            bool b = true;
            if (b)
            {
                int r = 42;
                b = false;
            }
            // r is not accessible
            // b is now false
        }
    }
}
