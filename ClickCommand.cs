namespace M3_KlikkerSpillTask;

internal sealed class ClickCommand : Command
{
    public ClickCommand(ClickerGame? game)
    {
        Game = game;
        Character = ' ';
    }

    public override void Run()
    {
        Game?.Click();
    }
    public override string GetDescription()
    {
        return "- SPACE = klikk (og få poeng)\n";
    }
}