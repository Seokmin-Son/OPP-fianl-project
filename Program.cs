using System;
using Vehicles;
using Services;
using IndependentClasses;
using Exceptions;

class Program
{
    static void Main(string[] args)
    {
        VehicleManager manager = new VehicleManager();
        FileHandler handler = new FileHandler();
        VehicleStatistics stats = new VehicleStatistics();

        try
        {
            manager.Add(new Car("Avante", 20000, 180, "Car", "Modern", 120));
            manager.Add(new Truck("Volvo Truck", 80000, 120, "Truck", 15000));
            manager.Add(new Boat("Sailor", 30000, 60, "Boat", 8));
            manager.Add(new RaceCar("F1 Racer", 150000, 320, "Car", "VMax", 500, true));
            manager.Add(new Train("Bullet", 500000, 280, "Train", 12));

            Console.WriteLine("\nSorted by Price:");
            manager.SortPrice();
            manager.Display();

            handler.Save(manager.GetAll(), manager.Count());
            Console.WriteLine("\nSaved to vehicles.txt");

            int loadedCount;
            Vehicle[] loaded = handler.Load(out loadedCount);

            Console.WriteLine("\nLoaded from file:");
            for (int i = 0; i < loadedCount; i++)
            {
                loaded[i].DisplayInfo();
                Console.WriteLine();
            }

            Console.WriteLine("\nStatistics:");
            stats.AveragePrice(manager.GetAll());
            stats.TypeCounts(manager.GetAll());
            stats.FastestByType(manager.GetAll(), "Car");
            stats.FastVehicles(manager.GetAll());
            stats.MostExpensive(manager.GetAll());
            stats.HeavyTrucks(manager.GetAll());
        }
        catch (InvalidPriceException ex)
        {
            Console.WriteLine("[Price Error] " + ex.Message);
        }
        catch (InvalidSpeedException ex)
        {
            Console.WriteLine("[Speed Error] " + ex.Message);
        }
        catch (InvalidCargoCapacityException ex)
        {
            Console.WriteLine("[Cargo Capacity Error] " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("[General Error] " + ex.Message);
        }
    }
}
