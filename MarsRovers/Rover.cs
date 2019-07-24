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
}
