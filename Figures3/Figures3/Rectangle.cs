/* 
    Insaf Sabirzyanov 220P,
    Task "Figures 4"
    30.05.22
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

        public override void Draw(IDrawer drawer)
        {
            drawer.DrawRectangle(this);
        }
    }
}
