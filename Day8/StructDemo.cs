using System;

namespace N_StructDemo
{
    struct Point
    {
        public double X;
        public double Y;
    }

    public class StructDemo
    {
        public static void StructDemoEx()
        {
            Point point;
            point.X = 3.5;
            point.Y = 2.5;
            Console.WriteLine($"X : {point.X}, Y : {point.Y}");
        }
    }
}
