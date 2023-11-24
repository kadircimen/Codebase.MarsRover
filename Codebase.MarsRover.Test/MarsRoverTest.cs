using Codebase.MarsRover.Console.Models;
using Codebase.MarsRover.Console.Services;
namespace Codebase.MarsRover.Test
{
    public class MarsRoverTest
    {
        [Fact]
        public void GetRoverResult()
        {
            Plateau plateau = new Plateau(5, 5);
            var rover = new RoverService(1, 2, 'N', plateau);
            var navigationService = new NavigationService();

            navigationService.Command("LMLMLMLMM", rover);
            var expectedPosition = "1 3 N";
            Assert.Equal(expectedPosition, rover.ToString());
        }
        [Fact]
        public void RoverShouldNotExceedPlateuBoundaries()
        {
            Plateau plateau = new Plateau(5, 5);
            RoverService rover = new RoverService(3, 3, 'E', plateau);
            NavigationService navigationService = new NavigationService();

            navigationService.Command("MMRMMRMRRM", rover);

            string expectedPosition = "5 1 E";
            Assert.Equal(expectedPosition, rover.ToString());
        }
    }
}