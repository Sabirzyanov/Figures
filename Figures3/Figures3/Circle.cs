/* 
    Insaf Sabirzyanov 220P,
    Task "Figures 3"
    29.05.22
*/


using System;
using System.Drawing;
namespace Figures3
{
    [Serializable]
    public class Circle : Figure
    {
        public int Radius;
        public Circle(Point point, int radius) : base(point)
        {
            Radius = radius;
        }

        public override void Draw(PaintEventArgs e, Pen p)
        {
            p.Color = color;
            p.Width = penWidth;
            float radius = (float) Math.Sqrt(Math.Pow((endPoint.X - basePoint.X), 2) + Math.Pow((endPoint.Y - basePoint.Y), 2));
            e.Graphics.DrawEllipse(p, basePoint.X - radius, basePoint.Y - radius, radius * 2, radius * 2);
        }
    }
}
