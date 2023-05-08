namespace M3_KlikkerSpillTask;

internal class SuperUpgradeCommand : Command
{
    public SuperUpgradeCommand(ClickerGame? game)
    {
        Game = game;
        Character = 'S';
    }
    public override void Run()
    {
        Game?.SuperUpgrade();
    }
    public override string GetDescription()
    {
        return " - S = kjøp superoppgradering \n       øker \"poeng per klikk\" for den vanlige oppgraderingen.\n       koster 100 poeng\n";
    }
}