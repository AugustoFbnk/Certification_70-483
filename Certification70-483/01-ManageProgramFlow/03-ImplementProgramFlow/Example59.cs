namespace Certification70_483._01_ManageProgramFlow._03_ImplementProgramFlow
{
    /// <summary>
    /// Nesting the null-coalescing operator
    /// </summary>
    public static class Example59
    {
        public static void Start()
        {
            int? x = null;
            int? z = null;
            int y = x ??
                    z ??
                    -1;
        }
    }
}
