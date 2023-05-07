namespace M3_KlikkerSpillTask;

internal sealed class ClickCommand : Command
{
    public ClickCommand(ClickerGame? game)
    {
        Game = game;
        Character = ' ';
        Description = "- SPACE = klikk (og få poeng)\n";
    }

    public override void Run()
    {
        Game?.Click();
    }
}