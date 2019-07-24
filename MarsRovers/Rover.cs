using System;
using System.Collections.Generic;
using System.Linq;
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
        public char ProcessInput(List<string> input)
        {
            //first line of input is in lengthXbreath format 
            var token1 = input[0].Split('X');

            //second line of input is in (X_position Y_position Direction) format
            var token2 = input[1].Split(' ');

            //second line of input is string of command chars
            //e.g. LLLLFFFRR
            var token3 = input[2];
            map.SetLastValidPosition(int.Parse(token1[0]), int.Parse(token1[0]));
            map.SetCurrentPosition(int.Parse(token1[1]), int.Parse(token1[1]));
            map.Direction.SetCurrentDirection(char.Parse(token2[2]));
            ExecuteInstruction(token3);

            return map.Direction.CurrentDirection;
        }

        private void ExecuteInstruction(string instruction)
        {
            foreach(var command in instruction)
            {
                if (commands.commandList.Contains(command) == false)
                {
                    continue;
                }
                if (direction.isValidMove(map) == false)
                    continue;
                if (command == 'L')
                    direction.MoveLeft();
                if (command == 'R')
                    direction.MoveRight();
                if (command == 'F')
                    direction.MoveForward(map);
            }
        }
    }
}
