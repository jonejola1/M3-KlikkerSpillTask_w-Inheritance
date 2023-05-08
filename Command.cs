namespace M3_KlikkerSpillTask;

internal abstract class Command
{
    protected ClickerGame? Game { get; set; }
    public char Character { get; protected set; }
    public abstract void Run();
    public abstract string GetDescription();
}