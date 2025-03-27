namespace ConsoleApp1;
using System;
using System.Collections.Generic;


class ContainerShip
{
    private List<Container> Containers = new List<Container>();
    public double MaxWeight { get; }
    public int MaxContainers { get; }

    public ContainerShip(double maxWeight, int maxContainers)
    {
        MaxWeight = maxWeight;
        MaxContainers = maxContainers;
    }

    public void LoadContainer(Container container)
    {
        if (Containers.Count >= MaxContainers)
            throw new Exception("Statek nie może przyjąć więcej kontenerów!");

        Containers.Add(container);
    }

    public void PrintContainers()
    {
        Console.WriteLine("Statek przewozi kontenery:");
        foreach (var container in Containers)
        {
            Console.WriteLine($"Serial: {container.SerialNumber}, Obecny ładunek: {container.GetCurrentLoad()}/{container.MaxLoad} kg");
        }
    }
}