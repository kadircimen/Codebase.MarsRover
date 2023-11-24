namespace Codebase.MarsRover.Console.Services;
public class RotateLeftService : IMovement
{
    public void Execute(RoverService rover)
    {
        rover.Directions = rover.Directions switch
        {
            'N' => 'W',
            'W' => 'S',
            'S' => 'E',
            'E' => 'N',
            _ => rover.Directions
        };
    }
}