using System;

namespace MarsRovers
{
    public class Map
    {

        public SurfaceCordinate CurrentPosition { get; set; } //wait
        public SurfaceCordinate LastValidPosition { get; private set; }
        public Direction Direction { get; private set; }

        public Map()
        {
            CurrentPosition = new SurfaceCordinate(0, 0);
            LastValidPosition = new SurfaceCordinate(0, 0);
            Direction = new Direction();
        }
        public void SetCurrentPosition(int x, int y)
        {
            CurrentPosition = new SurfaceCordinate(x, y);
        }
        public void SetLastValidPosition(int x, int y)
        {
            LastValidPosition = new SurfaceCordinate(x, y);
        }
    }
}
