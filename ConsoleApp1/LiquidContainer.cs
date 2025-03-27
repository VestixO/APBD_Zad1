namespace ConsoleApp1;

class LiquidContainer : Container
{
    public bool IsHazardous { get; }

    public LiquidContainer(double maxLoad, bool isHazardous) : base(maxLoad, "L")
    {
        IsHazardous = isHazardous;
    }

    public override void Load(double load)
    {
        double maxCapacity = IsHazardous ? MaxLoad * 0.5 : MaxLoad * 0.9;
        if (CurrentLoad + load > maxCapacity)
            throw new OverfillException($"Niebezpieczna operacja! {SerialNumber} może mieć max {maxCapacity} kg.");

        base.Load(load);
    }
}