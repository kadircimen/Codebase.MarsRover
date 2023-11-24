using Codebase.MarsRover.Console.Models;
namespace Codebase.MarsRover.Console.Services;
public class RoverService
{
    public int X { get; set; }
    public int Y { get; set; }
    private IMovement _movement;
    public char Directions { get; set; }
    private readonly Plateau _plateau;
    public RoverService(int x, int y, char directions, Plateau plateau)
    {
        X = x;
        Y = y;
        Directions = directions;
        _plateau = plateau;
    }
    public void SetMovement(IMovement movement)
    {
        _movement = movement;
    }
    public void Move()
    {
        _movement.Execute(this);
    }
    public override string ToString()
    {
        return $"{X} {Y} {Directions}";
    }
}
