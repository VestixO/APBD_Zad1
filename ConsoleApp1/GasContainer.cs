namespace ConsoleApp1;
using System;


class GasContainer : Container
{
    public double Pressure { get; }

    public GasContainer(double maxLoad, double pressure) : base(maxLoad, "G")
    {
        Pressure = pressure;
    }

    public override void Unload()
    {
        CurrentLoad *= 0.05;
    }
}
