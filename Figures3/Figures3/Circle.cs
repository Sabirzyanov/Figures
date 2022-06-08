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
    public class Circle : Figure
    {
        public int Radius;
        public Circle(Point point, int radius) : base(point)
        {
            Radius = radius;
        }

        public override void Draw(IDrawer drawer)
        {
            drawer.DrawCircle(this);
        }
    }
}
