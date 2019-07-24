using Xunit;
using FluentAssertions;
using System.Linq;
namespace MarsRovers.Test
{
    public class CommandListFeature
    {
        private CommandList _commandList = new CommandList();
        [Fact]
        public void Command_List_Should_have_L_R_F_Commands()
        {
            var commandList = new char[] { 'L', 'R', 'F' };
            _commandList.commandList.Should().BeEquivalentTo(commandList);
        }
        [Fact]
        public void All_Command_Except_L_R_F_Commands_should_be_unvalid()
        {
            var commandList = new char[] { 'L', 'R', 'F' };
            _commandList.commandList.Contains('E').Should().Be(false);
        }
    }

}
