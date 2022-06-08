/* 
    Insaf Sabirzyanov 220P,
    Task "Figures 4"
    30.05.22
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures3
{
    public class WinFormsDrawer : IDrawer
    {
        Graphics graphics;

        public WinFormsDrawer(Graphics e)
        {
            graphics = e;
        }

        public void DrawRectangle(Rectangle r)
        {
            Pen p = new Pen(r.color, r.strokeWidth);
            graphics.DrawRectangle(p, System.Drawing.Rectangle.FromLTRB(
                Math.Min(r.basePoint.X, r.endPoint.X),
                Math.Min(r.basePoint.Y, r.endPoint.Y),
                Math.Max(r.basePoint.X, r.endPoint.X),
                Math.Max(r.basePoint.Y, r.endPoint.Y)
            ));
        }

        public void DrawLine(Line l)
        {
            Pen p = new Pen(l.color, l.strokeWidth);
            graphics.DrawLine(p, l.basePoint.X, l.basePoint.Y, l.endPoint.X, l.endPoint.Y);
        }

        public void DrawCircle(Circle c)
        {
            Pen p = new Pen(c.color, c.strokeWidth);
            float radius = (float)Math.Sqrt(Math.Pow((c.endPoint.X - c.basePoint.X), 2) + Math.Pow((c.endPoint.Y - c.basePoint.Y), 2));
            graphics.DrawEllipse(p, c.basePoint.X - radius, c.basePoint.Y - radius, radius * 2, radius * 2);
        }

        public void DrawTriangle(Triangle t)
        {
            Pen p = new Pen(t.color, t.strokeWidth);
            graphics.DrawPolygon(p, new System.Drawing.Point[] {
                new System.Drawing.Point(t.basePoint.X, t.basePoint.Y),
                new System.Drawing.Point((t.endPoint.X + t.basePoint.X) / 2, t.endPoint.Y),
                new System.Drawing.Point(t.endPoint.X, t.basePoint.Y),
            });
        }
    }
}
