using System;

namespace MarsRovers
{
    public class Rover
    {
        public Map map{ get; set; }
        public CommandList commands;
        public Direction direction;
        public Rover()
        {
            map = new Map();
            commands = new CommandList();
            direction = new Direction();
        }
        public static void Main()
        {

        }
    }
    public class Map
    {

        public SurfaceCordinate CurrentPosition { get; private set; } //wait
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
    public class CommandList
    {
        public char[] commandList { get; set; }
        public CommandList()
        {
            commandList = new char[]{ 'L', 'R', 'F'};
        }
    }
    public class Direction
    {
        public char RoverDirection { get; set; }
    }
}
