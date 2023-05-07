using M3_KlikkerSpillTask;
using System.Windows.Input;

var game = new ClickerGame();
var commands = new CommandSet(game);

while (true)
{
    Console.Clear();
    Console.WriteLine($"Kommandoer:\n - K = kjøp oppgradering \n       øker poeng per klikk \n       koster 10 poeng\n - S = kjøp superoppgradering \n       øker \"poeng per klikk\" for den vanlige oppgraderingen.\n       koster 100 poeng\n - H = Kjøp Megaoppgradering \n       øker \"poeng per klikk ganger 10\"\n       koster 10Mil\n - X = avslutt applikasjonen\nDu har {game.Points} poeng.\nTrykk tast for ønsket kommando.\n");
    var command = Console.ReadKey().KeyChar;
    commands.Run(command);
}