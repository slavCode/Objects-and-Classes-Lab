using System;
using System.Linq;

namespace DistanceBetweenPoint
{
    internal class Program
    {
        static void Main()
        {
            var firstLine = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var secondLine = Console.ReadLine().Split().Select(double.Parse).ToArray();

            double x1 = firstLine[0];
            double y1 = firstLine[1];
            double x2 = secondLine[0];
            double y2 = secondLine[1];

            Point pnt1 = ReadPoint(x1, y1);
            Point pnt2 = ReadPoint(x2, y2);

            var result = Math.Round(CalcDistance(pnt1, pnt2), 3);
            Console.WriteLine("{0:f3}", result);
        }

        static Point ReadPoint(double x1, double y1)
        {
            return new Point() { X = x1, Y = y1 };
        }
        static double CalcDistance(Point p1, Point p2)
        {
            var sideA = p1.X - p2.X;
            var sideB = p1.Y - p2.Y;

            return Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
        }
        class Point
        {
            public double X { get; set; }
            public double Y { get; set; }
        }
    }
}
