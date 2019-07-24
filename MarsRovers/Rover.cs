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

        public SurfaceCordinate CurrentPosition { get; set; } //wait
        public SurfaceCordinate LastValidPosition { get; set; }
        public Direction Direction { get; set; }

        public Map()
        {
            CurrentPosition = new SurfaceCordinate();
            LastValidPosition = new SurfaceCordinate();
            Direction = new Direction();
        }
    }
    public class CommandList
    {

    }
    public class Direction
    {
        public char RoverDirection { get; set; }
    }
}
