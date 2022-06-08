using System;

namespace Figures
{
    public class Circle : Figure
    {
        public int radius;

        public Circle(int radius, Point p)
        {
            points.Add(p);
            this.radius = radius;
        }
        public override void Draw()
        {
            Console.WriteLine($"Circle with radius = {radius}. Start on ({points[0].X},{points[0].Y})");
        }
    }
}