using System;

namespace Figures
{
    public class Segment : Figure
    {
        public int length;

        public Segment(int length, Point[] points)
        {
            foreach (Point p in points)
            {
                this.points.Add(p);
            }

            this.length = length;
        }

        public override void Draw()
        {
            Console.WriteLine($"Segment with length = {length}");
        }
    }
}