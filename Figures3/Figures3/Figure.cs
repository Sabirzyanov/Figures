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
    public class Figure
    {
        public Point basePoint;
        public Point endPoint;
        public Color color;
        public int strokeWidth;

        public Figure(Point point)
        {
            basePoint = point;
        }

        public Figure(int x = 0, int y = 0)
        {
            basePoint = new Point(x, y);
        }


        public virtual void Draw(IDrawer drawer)
        {
            
        }

    }
}
