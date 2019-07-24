using Xunit;
using FluentAssertions;
namespace MarsRovers.Test
{
    public class DirectionFixture
    {
        private Direction _direction = new Direction();
        [Fact]
        public void If_rover_is_facing_in_North_and_Command_is_Left_then_it_should_face_in_south()
        {
            _direction.SetCurrentDirection('N');
            _direction.MoveLeft();
            _direction.CurrentDirection.Should().Be('W');

        }
        [Fact ]
        public void If_rover_facing_in_North_and_command_is_forward_then_its_y_cordinate_should_increase_by_one()
        {
            var map = new Map();
            map.SetCurrentPosition(2, 4);
            _direction.SetCurrentDirection('N');
            _direction.MoveForward(map);
            map.CurrentPosition.YAxis.Should().Be(5);

        }
        
    }

}
