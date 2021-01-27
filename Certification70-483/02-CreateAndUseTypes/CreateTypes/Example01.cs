using System;

namespace Certification70_483._02_CreateAndUseTypes.CreateTypes
{
    /// <summary>
    /// Using the FlagAttribute for an enum
    /// </summary>
    public static class Example01
    {
        public static void Start()
        {
            Days readingDays = Days.Monday | Days.Saturday;
            Console.WriteLine(readingDays);
            Console.ReadKey();
        }
    }

    [Flags]
    enum Days
    {
        None = 0x0,
        Sunday = 0x1,
        Monday = 0x2,
        Tuesday = 0x4,
        Wednesday = 0x8,
        Thursday = 0x10,
        Friday = 0x20,
        Saturday = 0x40
    }

}
