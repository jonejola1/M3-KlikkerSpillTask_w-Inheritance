using System.Reflection.Metadata;

namespace M3_KlikkerSpillTask;

internal abstract class Command
{
    protected ClickerGame? Game { get; set; }
    public char Character { get; protected set; }
    public string Description { get; protected set; }
    public abstract void Run();

    public static void promt()
    {
        
    }
}