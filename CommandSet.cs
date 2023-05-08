using System.Text;

namespace M3_KlikkerSpillTask;

internal class CommandSet
{
    private readonly Command[] _commands;
    public CommandSet(ClickerGame? game)
    {
        _commands = new Command[]
        {
            new ClickCommand(game),
            new UpgradeCommand(game),
            new SuperUpgradeCommand(game),
            new MegaUpgradeCommand(game),
            new ExitCommand(),
        };
    }

    public void Run(char commandChar)
    {
        var command = FindCommand(commandChar);
        command?.Run();
    }

    private Command? FindCommand(char commandChar)
    {
        return _commands.FirstOrDefault(command 
            => command.Character == commandChar);
    }

    public void PrintCommands()
    {
        var commandListMenu = _commands.Aggregate(
            new StringBuilder(), 
            (current, command) => current.Append(command.GetDescription()),
            current => current.ToString());
        Console.WriteLine("Kommandoer:");
        Console.WriteLine(commandListMenu);
    }
}

