using System;

namespace Figures
{
    public class Rectangle : Figure
    {
        public int height;
        public int width;
        public Rectangle(int height, int width, Point[] points)
        {
            this.width = width;
            this.height = height;
            
            foreach (Point p in points)
            {
                this.points.Add(p);
            }
        }

        public override void Draw()
        {
            Console.WriteLine($"Rectangle with Height = {height}, Width = {width}");
        }
    }
}