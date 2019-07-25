using System;
using System.Collections.Generic;

namespace MarsRovers
{
    public class Direction
    {
        private char[] ValidDirection { get; set; }
        public char RoverDirection { get; set; }
        public char CurrentDirection { get; private set; }
        private Dictionary<char, char> moveLeft = new Dictionary<char, char>();
        private Dictionary<char, char> moveRight = new Dictionary<char, char>();
        public Direction()
        {
            ValidDirection = new char[]
            {
                'N', 'S', 'E', 'W'
            };
            moveLeft['N'] = 'W';
            moveLeft['S'] = 'E';
            moveLeft['E'] = 'N';
            moveLeft['W'] = 'S';
            moveRight['N'] = 'E';
            moveRight['S'] = 'W';
            moveRight['E'] = 'S';
            moveRight['W'] = 'N';
        }
        
        
        public void SetCurrentDirection(char currentDirection)
        {
            CurrentDirection = currentDirection;
        }

        public void MoveLeft()
        {
            CurrentDirection = moveLeft[CurrentDirection];
        }
        public void MoveRight()
        {
            CurrentDirection = moveRight[CurrentDirection];
        }

        public bool isValidMove(Map map)
        {
            if (map.CurrentPosition.XAxis < map.LastValidPosition.XAxis && CurrentDirection == 'E')
                return true;
            if (map.CurrentPosition.YAxis < map.LastValidPosition.YAxis && CurrentDirection == 'N')
                return true;
            if (map.CurrentPosition.XAxis > 0 && CurrentDirection == 'E')
                return true;
            if (map.CurrentPosition.YAxis > 0 && CurrentDirection == 'W')
                return true;
            return false;
        }

        public void MoveForward(Map map)
        {
            if (CurrentDirection == 'N')
                map.CurrentPosition.YAxis += 1;
            if (CurrentDirection == 'S')
                map.CurrentPosition.YAxis -= 1;
            if (CurrentDirection == 'E')
                map.CurrentPosition.XAxis += 1;
            if (CurrentDirection == 'W')
                map.CurrentPosition.XAxis -= 1;
        }
        
    }
}
