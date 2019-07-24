using System;
using Xunit;
using MarsRovers;
using FluentAssertions;
using System.Collections.Generic;

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
    public class MarsRoverProblemFixture
    {
        private Rover _rover = new Rover();
        [Fact]
        public void check_for_actual_input()
        {
            List<string> input = new List<string>() {
                "5X5",
                "1 2 N",
                "LFLFLFLFF"
            };
            _rover.ProcessInput(input).Should().Be('N');
        }
    }
}
