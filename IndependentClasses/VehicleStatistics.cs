using System;
using Vehicles;

namespace IndependentClasses
{
    public class VehicleStatistics
    {
        public void AveragePrice(Vehicle[] vehicles)
        {
            if (vehicles.Length == 0)
            {
                Console.WriteLine("No vehicles found.");
                return;
            }

            double total = 0;
            for (int i = 0; i < vehicles.Length; i++)
            {
                total += vehicles[i].Price;
            }

            double average = total / vehicles.Length;
            Console.WriteLine("Average Price of Vehicles: " + average);
        }

        public void FastestByType(Vehicle[] vehicles, string type)
        {
            Vehicle fastest = null;

            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i].VehicleType == type)
                {
                    if (fastest == null || vehicles[i].Speed > fastest.Speed)
                    {
                        fastest = vehicles[i];
                    }
                }
            }

            if (fastest != null)
            {
                Console.WriteLine("Fastest " + type + ":");
                fastest.PrintDetails();
            }
            else
            {
                Console.WriteLine("No vehicle of type " + type + " found.");
            }
        }

        public void TypeCounts(Vehicle[] vehicles)
        {
            int carCount = 0;
            int truckCount = 0;
            int boatCount = 0;
            int airplaneCount = 0;

            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i].VehicleType == "Car") carCount++;
                else if (vehicles[i].VehicleType == "Truck") truckCount++;
                else if (vehicles[i].VehicleType == "Boat") boatCount++;
                else if (vehicles[i].VehicleType == "Airplane") airplaneCount++;
            }

            Console.WriteLine("Car Count: " + carCount);
            Console.WriteLine("Truck Count: " + truckCount);
            Console.WriteLine("Boat Count: " + boatCount);
            Console.WriteLine("Airplane Count: " + airplaneCount);
        }

        public void FastVehicles(Vehicle[] vehicles)
        {
            Console.WriteLine("Vehicles faster than 200 km/h:");
            foreach (var v in vehicles)
            {
                if (v != null && v.Speed > 200)
                {
                    Console.WriteLine($"- {v.Name} ({v.Speed} km/h)");
                }
            }
        }

        public void MostExpensive(Vehicle[] vehicles)
        {
            if (vehicles == null || vehicles.Length == 0)
            {
                Console.WriteLine("No vehicles available.");
                return;
            }

            Vehicle mostExpensive = vehicles[0];
            foreach (var v in vehicles)
            {
                if (v != null && v.Price > mostExpensive.Price)
                {
                    mostExpensive = v;
                }
            }

            Console.WriteLine("Most Expensive Vehicle:");
            mostExpensive.PrintDetails();
        }

        public void HeavyTrucks(Vehicle[] vehicles)
        {
            Console.WriteLine("Trucks with Load Capacity > 5000kg:");
            foreach (var v in vehicles)
            {
                if (v is Truck t && t.LoadCapacity > 5000)
                {
                    Console.WriteLine($"- {t.Name} ({t.LoadCapacity} kg)");
                }
            }
        }
    }
}