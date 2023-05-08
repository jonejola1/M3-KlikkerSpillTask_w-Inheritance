namespace M3_KlikkerSpillTask;

internal class MegaUpgradeCommand : Command
{
    public MegaUpgradeCommand(ClickerGame? game)
    {
        Game = game;
        Character = 'H';
    }
    public override void Run()
    {
        Game?.MegaUpgrade();
    }

    public override string GetDescription()
    {
        return " - H = Kjøp Megaoppgradering \n       øker \"poeng per klikk ganger 10\"\n       koster 10Mil poeng\n";
    }
}