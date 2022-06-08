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
    public interface IDrawer
    {
        public void DrawRectangle(Rectangle r);
        public void DrawLine(Line l);
        public void DrawCircle(Circle c);
        public void DrawTriangle(Triangle t);
    }
}
