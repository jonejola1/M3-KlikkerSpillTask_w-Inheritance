namespace M3_KlikkerSpillTask;

internal class CommandSet
{
    private readonly Command[] _commands;
    public CommandSet(ClickerGame? game)
    {
        _commands = new Command[]
        {
            new ExitCommand(),
            new ClickCommand(game),
            new UpgradeCommand(game),
            new SuperUpgradeCommand(game),
            new MegaUpgradeCommand(game),
        };
    }

    public void Run(char commandChar)
    {
        var command = FindCommand(commandChar);
        command?.Run();
    }

    private Command FindCommand(char commandChar)
    {
        foreach (var command in _commands)
        {
            if (commandChar == command.Character) return command;
        }
        return null;
    }
}

