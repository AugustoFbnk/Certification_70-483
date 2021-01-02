using System;

namespace Certification70_483._01_ManageProgramFlow._03_ImplementProgramFlow
{
    /// <summary>
    /// Using the XOR operator (^)
    /// c# don't apply short-circuit in this case because it have to check both conditions
    /// </summary>
    public static class Example51
    {
        public static void Start()
        {
            bool a = true;
            bool b = false;
            Console.WriteLine(a ^ a); // False
            Console.WriteLine(a ^ b); // True
            Console.WriteLine(b ^ b); // False
        }
    }
}
