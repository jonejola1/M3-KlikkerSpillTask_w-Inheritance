namespace M3_KlikkerSpillTask;

internal class ExitCommand : Command
{
    public ExitCommand()
    {
        Character = 'X';
    }
    public override void Run()
    {
        Environment.Exit(0);
    }

    public override string GetDescription()
    {
        return " - X = avslutt applikasjonen";
    }
}