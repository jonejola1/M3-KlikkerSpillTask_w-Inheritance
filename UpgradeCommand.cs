using System.Security.Cryptography;

namespace M3_KlikkerSpillTask;

internal class UpgradeCommand : Command
{
    public UpgradeCommand(ClickerGame? game)
    {
        Game = game;
        Character = 'K';
    }
    public override void Run()
    {
        Game?.Upgrade();
    }

    public override string GetDescription()
    {
        return " - K = kjøp oppgradering \n       øker poeng per klikk \n       koster 10 poeng\n";
    }
}