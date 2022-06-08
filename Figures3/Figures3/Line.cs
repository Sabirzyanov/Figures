/* 
    Insaf Sabirzyanov 220P,
    Task "Figures 4"
    30.05.22
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

        public override void Draw(IDrawer drawer)
        {
            drawer.DrawLine(this);
        }

    }
}
