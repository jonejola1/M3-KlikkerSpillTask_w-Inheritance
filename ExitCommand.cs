namespace M3_KlikkerSpillTask;

internal class ExitCommand : Command
{
    public ExitCommand()
    {
        Character = 'X';
        Description = " - X = avslutt applikasjonen";
    }
    public override void Run()
    {
        Environment.Exit(0);
    }
}