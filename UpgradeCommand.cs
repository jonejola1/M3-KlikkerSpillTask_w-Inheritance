namespace M3_KlikkerSpillTask;

internal class UpgradeCommand : Command
{
    public UpgradeCommand(ClickerGame? game)
    {
        Game = game;
        Character = 'K';
        Description = " - K = kjøp oppgradering \n       øker poeng per klikk \n       koster 10 poeng\n";
    }
    public override void Run()
    {
        Game?.Upgrade();
    } 
}