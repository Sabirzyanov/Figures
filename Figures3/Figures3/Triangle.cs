/* 
    Insaf Sabirzyanov 220P,
    Task "Figures 4"
    30.05.22
*/


using System;
namespace Figures3
{
    [Serializable]
    public class Triangle : Figure
    {
        public Point A
        {
            get { return basePoint; }
            set { basePoint = value; }
        }
        public Point B;
        public Point C;

        public Triangle(Point a, Point b, Point c) : base(a)
        {
            B = b;
            C = c;
        }

        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3) : base(x1, y1)
        {
            B = new Point(x2, y2);
            C = new Point(x3, y3);
        }

        public override void Draw(IDrawer drawer)
        {
            drawer.DrawTriangle(this);
        }
    }
}
