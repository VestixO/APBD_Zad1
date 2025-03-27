namespace ConsoleApp1;

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        ContainerShip ship = new ContainerShip(50000, 10);

        // Tworzenie kontenerów
        LiquidContainer lContainer = new LiquidContainer(10000, false); 
        GasContainer gContainer = new GasContainer(5000, 10); 
        RefrigeratedContainer cContainer = new RefrigeratedContainer(8000, -5); 

        // Załaduj ładunek do kontenerów
        try
        {
            lContainer.Load(4000);
            gContainer.Load(2500);
            cContainer.Load(6000);
        }
        catch (OverfillException e)
        {
            Console.WriteLine($"Błąd: {e.Message}");
        }

        // Załaduj kontenery na statek
        ship.LoadContainer(lContainer);
        ship.LoadContainer(gContainer);
        ship.LoadContainer(cContainer);

        // Wypisz informacje o statku i jego ładunku
        ship.PrintContainers();

        // Opróżnij kontenery
        Console.WriteLine("\nOpróżnianie kontenerów...");
        lContainer.Unload();
        gContainer.Unload();
        cContainer.Unload();

        // Wypisz informacje po opróżnieniu
        ship.PrintContainers();
    }
}