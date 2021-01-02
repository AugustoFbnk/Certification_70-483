namespace Certification70_483._01_ManageProgramFlow._03_ImplementProgramFlow
{
    /// <summary>
    /// The null-coalescing operator
    /// </summary>
    public static class Example58
    {
        public static void Start()
        {
            int? x = null;
            int y = x ?? -1;
        }
    }
}
