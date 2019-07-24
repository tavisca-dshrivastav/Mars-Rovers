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
}
