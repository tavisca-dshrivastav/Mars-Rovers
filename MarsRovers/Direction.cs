using System;

namespace MarsRovers
{
    public class Direction
    {
        public char[] ValidDirection { get; set; }
        public char RoverDirection { get; set; }
        public char CurrentDirection { get; private set; }
        public Direction()
        {
            ValidDirection = new char[]
            {
                'N', 'S', 'E', 'W'
            };
        }
        public void SetCurrentDirection(char currentDirection)
        {
            CurrentDirection = currentDirection;
        }

        public void MoveLeft()
        {
            if (CurrentDirection == 'N')
                CurrentDirection = 'W';
            else if (CurrentDirection == 'S')
                CurrentDirection = 'E';
            else if (CurrentDirection == 'E')
                CurrentDirection = 'N';
            else if (CurrentDirection == 'W')
                CurrentDirection = 'S';
        }
        public void MoveRight()
        {
            if (CurrentDirection == 'N')
                CurrentDirection = 'E';
            else if (CurrentDirection == 'S')
                CurrentDirection = 'W';
            else if (CurrentDirection == 'E')
                CurrentDirection = 'S';
            else if (CurrentDirection == 'W')
                CurrentDirection = 'N';
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

        private  SurfaceCordinate GetCurrentPosition(Map map)
        {
            return map.CurrentPosition;
        }
    }
}
