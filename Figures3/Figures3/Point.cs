/* 
    Insaf Sabirzyanov 220P,
    Task "Figures 3"
    29.05.22
*/


using System;
namespace Figures3
{
    [Serializable]
    public struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"[{X}, {Y}]";
        }
    }
}
