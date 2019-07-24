using Xunit;
using FluentAssertions;
namespace MarsRovers.Test
{
    public class SurfaceCordinateFixture
    {
        private SurfaceCordinate _surfaceCordinate = new SurfaceCordinate(2, 10);
        [Fact]
        public void SurfaceCordinate_should_add_x_axis_and_y_axis()
        {
            _surfaceCordinate.XAxis.Should().Be(2);
            _surfaceCordinate.YAxis.Should().Be(10);
        }
    }

}
