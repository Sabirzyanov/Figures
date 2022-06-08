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
    public class Line : Figure
    {
        public Point A
        {
            get { return basePoint; }
            set { basePoint = value; }
        }
        public Point B
        {
            get { return endPoint; }
            set { endPoint = value; }
        }

        public Line(Point a, Point b) : base(a)
        {
        }

        public override string ToString()
        {
            return $"Line A {A} - B {B}";
        }

        public override void Draw(PaintEventArgs e, Pen p)
        {
            p.Color = color;
            p.Width = penWidth;
            e.Graphics.DrawLine(p, A.X, A.Y, B.X, B.Y);
        }

    }
}
