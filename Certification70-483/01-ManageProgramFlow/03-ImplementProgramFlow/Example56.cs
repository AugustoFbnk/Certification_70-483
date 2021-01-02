using System;

namespace Certification70_483._01_ManageProgramFlow._03_ImplementProgramFlow
{
    /// <summary>
    /// Using multiple if/else statements
    /// </summary>
    public static  class Example56
    {
        public static void Start()
        {
            bool b = false;
            bool c = true;
            if (b)
            {
                Console.WriteLine("b is true");
            }
            else if (c)
            {
                Console.WriteLine("c is true");
            }
            else
            {
                Console.WriteLine("b and c are false");
            }
        }
    }
}
