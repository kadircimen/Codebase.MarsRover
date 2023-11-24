namespace Codebase.MarsRover.Console.Services;
public class MoveFroward : IMovement
{
    public void Execute(RoverService rover)
    {
        switch (rover.Directions)
        {
            case 'N':
                rover.Y++;
                break;
            case 'S':
                rover.Y--;
                break;
            case 'E':
                rover.X++;
                break;
            case 'W':
                rover.X--;
                break;
        }
    }
}
