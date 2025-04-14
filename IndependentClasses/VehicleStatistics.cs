using System;
using Vehicles;

namespace IndependentClasses
{
    public class VehicleStatistics
    {
        //Calculate and display average price
        public void AveragePrice(Vehicle[] vehicles)
        {
            // Check if array is null or empty
            if (vehicles == null || vehicles.Length == 0)
            {
                Console.WriteLine("No vehicles found.");
                return;
            }

            double total = 0;
            int valueCount = 0;
            
            // Sum up all vehicle prices
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] != null) 
                {
                    total += vehicles[i].Price;
                    valueCount++;
                }
            }
            //Handle case with no valid vehicles
            if (valueCount == 0)
            {
                Console.WriteLine("No vehicles found.");
                return;
            }
            
            // Calculate and display average price
            double average = total / valueCount;
            Console.WriteLine("Average Price of Vehicles: " + average);
        }
        
        //Find fastest vehicle of a specific type
        public void FastestByType(Vehicle[] vehicles, string type)
        {
            //Check array for null or empty
            if (vehicles == null || vehicles.Length == 0)
            {
                Console.WriteLine("No vehicles found.");
                return;
            }

            Vehicle fastest = null;
            
            //Find the fastest vehicle of the given type
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
            
            //Display result
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

        // Count vehicles by type
        public void TypeCounts(Vehicle[] vehicles)
        {
            //Check array for null or empty
            if (vehicles == null || vehicles.Length == 0)
            {
                Console.WriteLine("No vehicles found.");
                return;
            }
            //Initialize counters for each vehicle type
            int carCount = 0;
            int truckCount = 0;
            int boatCount = 0;
            int airplaneCount = 0;
            
            //Count vehicles of each type
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

            //Display results
            Console.WriteLine("Car Count: " + carCount);
            Console.WriteLine("Truck Count: " + truckCount);
            Console.WriteLine("Boat Count: " + boatCount);
            Console.WriteLine("Airplane Count: " + airplaneCount);
        }
        
        //Find vechicles with speed > 200 km/h
        public void FastVehicles(Vehicle[] vehicles)
        {
            //Check array for null or empty
            if (vehicles == null || vehicles.Length == 0)
            {
                Console.WriteLine("No vehicles found.");
                return;
            }
            
            Console.WriteLine("Vehicles faster than 200 km/h:");
            bool found = false;

            //Find fast vehicles
            foreach (var v in vehicles)
            {
                if (v != null && v.Speed > 200)
                {
                    Console.WriteLine($"- {v.Name} ({v.Speed} km/h)");
                    found = true;
                }
            }
            
            //Display result
            if (!found)
            {
                Console.WriteLine("No fast vehicles found.");
            }
        }
        
        //Find the most expensive vehicle
        public void MostExpensive(Vehicle[] vehicles)
        {
            //Check array for null or empty
            if (vehicles == null || vehicles.Length == 0)
            {
                Console.WriteLine("No vehicles available.");
                return;
            }

            Vehicle mostExpensive = null;
            
            //Find the most expensive vehicle
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
            
            //Display result
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
        
        //Find trucks with load capacity > 5000 kg
        public void HeavyTrucks(Vehicle[] vehicles)
        {
            //Check array for null or empty
            if (vehicles == null || vehicles.Length == 0)
            {
                Console.WriteLine("No vehicles available.");
                return;
            }

            Console.WriteLine("Trucks with Load Capacity > 5000kg:");
            bool found = false;
            
            //Find heavy trucks
            foreach (var v in vehicles)
            {
                if (v != null && v is Truck t && t.LoadCapacity > 5000)
                {
                    Console.WriteLine($"- {t.Name} ({t.LoadCapacity} kg)");
                    found = true;
                }
            }

            //Display result        
            if (!found)
            {
                Console.WriteLine("No heavy trucks found.");
            }
        }
    }
}