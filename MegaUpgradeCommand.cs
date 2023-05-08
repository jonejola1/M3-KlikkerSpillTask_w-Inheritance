namespace M3_KlikkerSpillTask;

internal class MegaUpgradeCommand : Command
{
    public MegaUpgradeCommand(ClickerGame? game)
    {
        Game = game;
        Character = 'H';
        Description = " - H = Kjøp Megaoppgradering \n       øker \"poeng per klikk ganger 10\"\n       koster 10Mil poeng\n";
    }
    public override void Run()
    {
        Game?.MegaUpgrade();
    }
}