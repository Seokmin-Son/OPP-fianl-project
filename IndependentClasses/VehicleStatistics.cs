using System;
using Vehicles;

namespace IndependentClasses
{
    public class VehicleStatistics
    {
        public void AveragePrice(Vehicle[] vehicles)
        {
            if (vehicles == null || vehicles.Length == 0)
            {
                Console.WriteLine("No vehicles found.");
                return;
            }

            double total = 0;
            int valueCount = 0;

            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] != null) 
                {
                    total += vehicles[i].Price;
                    valueCount++;
                }
            }
            if (valueCount == 0)
            {
                Console.WriteLine("No vehicles found.");
                return;
            }

            double average = total / valueCount;
            Console.WriteLine("Average Price of Vehicles: " + average);
        }

        public void FastestByType(Vehicle[] vehicles, string type)
        {
            if (vehicles == null || vehicles.Length == 0)
            {
                Console.WriteLine("No vehicles found.");
                return;
            }

            Vehicle fastest = null;

            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] != null && vehicles[i].VehicleType == type)
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
                fastest.DisplayInfo();
            }
            else
            {
                Console.WriteLine("No vehicle of type " + type + " found.");
            }
        }

        public void TypeCounts(Vehicle[] vehicles)
        {
            if (vehicles == null || vehicles.Length == 0)
            {
                Console.WriteLine("No vehicles found.");
                return;
            }
            int carCount = 0;
            int truckCount = 0;
            int boatCount = 0;
            int airplaneCount = 0;

            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] != null)
                {
                    if (vehicles[i].VehicleType == "Car") carCount++;
                    else if (vehicles[i].VehicleType == "Truck") truckCount++;
                    else if (vehicles[i].VehicleType == "Boat") boatCount++;
                    else if (vehicles[i].VehicleType == "Airplane") airplaneCount++;
                }
                
            }

            Console.WriteLine("Car Count: " + carCount);
            Console.WriteLine("Truck Count: " + truckCount);
            Console.WriteLine("Boat Count: " + boatCount);
            Console.WriteLine("Airplane Count: " + airplaneCount);
        }

        public void FastVehicles(Vehicle[] vehicles)
        {
            if (vehicles == null || vehicles.Length == 0)
            {
                Console.WriteLine("No vehicles found.");
                return;
            }
            
            Console.WriteLine("Vehicles faster than 200 km/h:");
            bool found = false;

            foreach (var v in vehicles)
            {
                if (v != null && v.Speed > 200)
                {
                    Console.WriteLine($"- {v.Name} ({v.Speed} km/h)");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No fast vehicles found.");
            }
        }

        public void MostExpensive(Vehicle[] vehicles)
        {
            if (vehicles == null || vehicles.Length == 0)
            {
                Console.WriteLine("No vehicles available.");
                return;
            }

            Vehicle mostExpensive = null;

            foreach (var v in vehicles)
            {
                if (v != null)
                {
                    if (mostExpensive == null || v.Price > mostExpensive.Price)
                    {
                        mostExpensive = v;
                    }
                }
                
            }

            if (mostExpensive != null)
            {
                Console.WriteLine("Most Expensive Vehicle:");
                mostExpensive.DisplayInfo();
            }
            else
            {
                Console.WriteLine("No vehicles found.");
            }
            
        }

        public void HeavyTrucks(Vehicle[] vehicles)
        {
            if (vehicles == null || vehicles.Length == 0)
            {
                Console.WriteLine("No vehicles available.");
                return;
            }

            Console.WriteLine("Trucks with Load Capacity > 5000kg:");
            bool found = false;

            foreach (var v in vehicles)
            {
                if (v != null && v is Truck t && t.LoadCapacity > 5000)
                {
                    Console.WriteLine($"- {t.Name} ({t.LoadCapacity} kg)");
                    found = true;
                }
            }
        
            if (!found)
            {
                Console.WriteLine("No heavy trucks found.");
            }
        }
    }
}