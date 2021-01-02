namespace Certification70_483._01_ManageProgramFlow._03_ImplementProgramFlow
{
    /// <summary>
    /// A more readable nested if statement
    /// Instead to do "if (x) if (y) F(); else G();" outline your code to better readability
    /// </summary>
    public static class Example57
    {
        public static void Start()
        {
            var x = true;
            var y = true;

            if (x)
            {
                if (y)
                {
                    F();
                }
                else
                {
                    G();
                }
            }
        }

        public static void F() 
        {
        }

        public static void G()
        {
        }
    }
}
