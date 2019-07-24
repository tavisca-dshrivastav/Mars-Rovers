using Xunit;
using FluentAssertions;
namespace MarsRovers.Test
{
    public class MapFixture
    {
        private Map _map = new Map();
        [Fact]
        public void Every_map_should_have_current_position()
        {
            _map.CurrentPosition.GetType().Should().Be(typeof(SurfaceCordinate));
        }
        [Fact]
        public void Every_map_should_have_direction()
        {
            _map.Direction.RoverDirection = 'E';
            _map.Direction.RoverDirection.Should().Be('E');
        }
    }
}
