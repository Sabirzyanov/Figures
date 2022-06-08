/* 
    Insaf Sabirzyanov 220P,
    Task "Figures 3"
    29.05.22
*/


using System;
namespace Figures3
{
    [Serializable]
    public class Rectangle : Figure
    {
        public int Height;
        public int Width;

        public Rectangle(Point point, int height, int width) : base(point)
        {
            Height = height;
            Width = width;
        }

        public override void Draw(PaintEventArgs e, Pen p)
        {
            p.Color = color;
            p.Width = penWidth;
            e.Graphics.DrawRectangle(p, System.Drawing.Rectangle.FromLTRB(
                Math.Min(basePoint.X, endPoint.X),
                Math.Min(basePoint.Y, endPoint.Y),
                Math.Max(basePoint.X, endPoint.X),
                Math.Max(basePoint.Y, endPoint.Y)
            ));
        }
    }
}
