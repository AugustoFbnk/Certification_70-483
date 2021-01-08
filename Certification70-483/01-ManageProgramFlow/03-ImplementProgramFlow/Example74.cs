using System;

namespace Certification70_483._01_ManageProgramFlow._03_ImplementProgramFlow
{
    /// <summary>
    /// goto statement with a labe
    /// </summary>
    public static class Example74
    {
        public static void Start()
        {
            int x = 3;
            if (x == 3) goto customLabel;
            x++;
        
        customLabel: Console.WriteLine(x);
        }
    }
}
