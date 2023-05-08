using M3_KlikkerSpillTask;

var game = new ClickerGame();
var commands = new CommandSet(game);

while (true)
{
    Console.Clear();
    commands.PrintCommands();
    Console.WriteLine($"Du har {game.Points} poeng.\nTrykk tast for ønsket kommando.\n");
    var command = Console.ReadKey().KeyChar;
    commands.Run(command);
}
