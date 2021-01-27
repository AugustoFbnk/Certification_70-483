using System;

namespace Certification70_483._02_CreateAndUseTypes.CreateTypes
{
    /// <summary>
    /// Creating a custom struct
    /// </summary>
    public static class Example02
    {
        public static void Start()
        {
            var point = new Point(1, 2);

            Console.WriteLine($"{point.x} - {point.y}");
            Console.ReadKey();

        }
    }

    public struct Point
    {
        public int x, y;
        public Point(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }
}
