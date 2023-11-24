namespace Codebase.MarsRover.Console.Services;
public class NavigationService
{
    public void Command(string command, RoverService rover)
    {
        foreach (var c in command)
        {
            switch (c)
            {
                case 'L':
                    rover.SetMovement(new RotateLeftService());
                    break;
                case 'R':
                    rover.SetMovement(new RotateRightService());
                    break;
                case 'M':
                    rover.SetMovement(new MoveFroward());
                    break;
            }
            rover.Move();
        }
    }
}
