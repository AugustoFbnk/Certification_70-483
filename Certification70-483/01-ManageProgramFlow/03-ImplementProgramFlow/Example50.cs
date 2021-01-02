namespace Certification70_483._01_ManageProgramFlow._03_ImplementProgramFlow
{
    /// <summary>
    /// Using the AND operator
    /// As a OR operator, the compiler applies the short-circuit to operator 'and' (&&)
    /// In this case c# applies the short circuit and if the input is null c# won't throw 
    /// an exception
    /// </summary>
    public static class Example50
    {
        public static void Start(string input)
        {
            bool result = (input != null) && (input.StartsWith("v"));
        }
    }
}
