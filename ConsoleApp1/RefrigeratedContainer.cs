namespace ConsoleApp1;

class RefrigeratedContainer : Container
{
    public double Temperature { get; }

    public RefrigeratedContainer(double maxLoad, double temperature) : base(maxLoad, "C")
    {
        Temperature = temperature;
    }
}