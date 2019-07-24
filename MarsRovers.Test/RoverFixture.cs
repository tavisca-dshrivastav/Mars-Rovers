using System;
using Xunit;
using MarsRovers;
using FluentAssertions;
namespace MarsRovers.Test
{
    public class RoverFixtures
    {

        private Rover _rover = new Rover();
        [Fact]
        public void Every_rover_should_have_map()
        {
            _rover.map.GetType().Should().Be(typeof(Map));
        }
        [Fact]
        public void Every_rover_should_have_commandList()
        {
            _rover.commands.GetType().Should().Be(typeof(CommandList));
        }
        [Fact]
        public void Every_rover_should_have_direction()
        {
            _rover.direction.GetType().Should().Be(typeof(Direction));
        }
        
    }
    public class SurfaceCordinateFixture
    {
        private SurfaceCordinate _surfaceCordinate = new SurfaceCordinate(2, 10);
        [Fact]
        public void SurfaceCordinate_should_add_x_axis_and_y_axis()
        {
            _surfaceCordinate.getXAxis().Should().Be(2);
            _surfaceCordinate.getYAxis().Should().Be(10);
        }
    }

}
