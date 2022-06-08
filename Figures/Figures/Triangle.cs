using System;

namespace Figures
{
    public class Triangle : Figure
    {
        public Triangle(Point[] points)
        {
            foreach (Point p in points)
            {
                this.points.Add(p);
            }
        }
        public override void Draw()
        {
            Console.WriteLine("Triangle");
        }
    }
}