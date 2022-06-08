/* 
    Insaf Sabirzyanov 220P,
    Task "Figures 3"
    29.05.22
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

        public override void Draw(PaintEventArgs e, Pen p)
        {
            p.Color = color;
            p.Width = penWidth;
            e.Graphics.DrawPolygon(p, new System.Drawing.Point[] {
                new System.Drawing.Point(basePoint.X, basePoint.Y),
                new System.Drawing.Point((endPoint.X + basePoint.X) / 2, endPoint.Y),
                new System.Drawing.Point(endPoint.X, basePoint.Y),
            });
        }
    }
}
