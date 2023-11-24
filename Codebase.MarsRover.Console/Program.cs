using Codebase.MarsRover.Console.Models;
using Codebase.MarsRover.Console.Services;
Console.WriteLine("Set ğlateau Boundaries : ");
var plateauBoundaries = Console.ReadLine().Split(' ');
Plateau plateau = new Plateau(int.Parse(plateauBoundaries[0]), int.Parse(plateauBoundaries[1]));

Console.WriteLine("Set Rover's Initial Position: ");
var initial = Console.ReadLine().Split(' ');
int x = int.Parse(initial[0]);
int y = int.Parse(initial[1]);
char direction = char.Parse(initial[2]);
RoverService rover = new RoverService(x, y, direction, plateau);

Console.WriteLine("Set Movements: ");
var movements = Console.ReadLine();

NavigationService navigationService = new NavigationService();
navigationService.Command(movements, rover);
Console.WriteLine($"Rover's Position: {rover}");