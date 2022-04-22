using System;
using System.Linq;

namespace ReactanglePosition
{
    internal class Program
    {
        static void Main()
        {
            var r1 = ReadReactangle();
            var r2 = ReadReactangle();

            if (IsInside(r1, r2)) Console.WriteLine("Inside");
            else Console.WriteLine("Not Inside");
        }
        static bool IsInside(Rectangle r1, Rectangle r2)
        {
            bool isInside = false;
            if (r1.Left >= r2.Left
                && r1.Right <= r2.Right
                && r1.Top <= r2.Top
                && r1.Bottom <= r2.Bottom)
            {
                isInside = true;
            }
            return isInside;
        }
        static Rectangle ReadReactangle()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Rectangle result = new Rectangle();
            result.Left = input[0];
            result.Top = input[1];
            result.Width = input[2];
            result.Height = input[3];

            return result;
        }
    }
    class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Right
        {
            get
            {
                return Left + Width;
            }
        }
        public double Bottom
        {
            get
            {
                return Height - Top;
            }
        }
    }
}
