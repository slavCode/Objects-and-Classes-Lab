using System;
using System.Linq;

namespace ClosestTwoPoints
{
    internal class Program
    {
        static void Main()
        {
            Point[] points = ReadPoints();

            var closestPoints = FindClosestPoints(points);

            PrintPoints(closestPoints);
        }

        private static void PrintPoints(Point[] closestPoints)
        {
            Console.WriteLine("{0:F3}", CalcDistance(closestPoints[0], closestPoints[1]));
            Console.WriteLine($"({closestPoints[0].X}, {closestPoints[0].Y})\n\r" +
                $"({closestPoints[1].X}, {closestPoints[1].Y})");
        }

        private static Point[] ReadPoints()
        {
            int n = int.Parse(Console.ReadLine());

            var points = new Point[n];
            for (int i = 0; i < n; i++)
            {
                var parts = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
                Point point = ReadPoint(parts[0], parts[1]);
                points[i] = point;
            }
            return points;
        }

        static Point[] FindClosestPoints(Point[] points)
        {
            double smallestDistance = double.MaxValue;
            var closestPoints = new Point[2];
            for (int i = 0; i < points.Length; i++)
            {
                for (int k = i + 1; k < points.Length; k++)
                {
                    var firstPoint = points[i];
                    var secondPoint = points[k];
                    var currDistance = CalcDistance(firstPoint, secondPoint);
                    if (smallestDistance > currDistance)
                    {
                        smallestDistance = currDistance;
                        closestPoints[0] = points[i];
                        closestPoints[1] = points[k];
                    }
                }
            }
            return closestPoints;
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
