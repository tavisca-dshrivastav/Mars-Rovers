using System;

namespace MarsRovers
{
    public class SurfaceCordinate
    {
        public int XAxis { get; set; }
        public int YAxis { get; set; }
        public SurfaceCordinate(int x, int y)
        {
            XAxis = x;
            YAxis = y;
        }
    }
}
