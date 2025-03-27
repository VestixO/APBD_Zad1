namespace ConsoleApp1;
using System; 
//ff

abstract class Container
{
    private static int counter = 1; 
    public string SerialNumber { get; }
    public double CurrentLoad { get; protected set; } 
    public double MaxLoad { get; }

    protected Container(double maxLoad, string type)
    {
        MaxLoad = maxLoad;
        SerialNumber = $"KON-{type}-{counter++}";
    }

    public virtual void Load(double load)
    {
        if (CurrentLoad + load > MaxLoad)
            throw new OverfillException($"Przekroczono ładowność kontenera {SerialNumber}!");

        CurrentLoad += load;
    }

    public virtual void Unload()
    {
        CurrentLoad = 0;
    }

    public double GetCurrentLoad()
    {
        return CurrentLoad;
    }
}