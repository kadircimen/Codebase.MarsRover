namespace Codebase.MarsRover.Console.Services;
public class RotateRightService : IMovement
{
    public void Execute(RoverService rover)
    {
        rover.Directions = rover.Directions switch
        {
            'N' => 'E',
            'E' => 'S',
            'S' => 'W',
            'W' => 'N',
            _ => rover.Directions
        };
    }
}
