using System;
using Vehicles;

namespace Services
{
    //Class for managing a collection of vehicles
    public class VehicleManager
    {
        //Array to store vehicles
        private Vehicle[] vehicles = new Vehicle[100];
        private int count = 0;
        
        //Add a new vehicle to the collection
        public void Add(Vehicle v)
        {
            if (count < vehicles.Length)
            {
                vehicles[count] = v;
                count++;
            }
            else
            {
                Console.WriteLine("Vehicle array is full.");
            }
        }
        
        //Get all vehicles in the collection
        public Vehicle[] GetAll()
        {
            return vehicles;
        }

        //Get the number of vehicles in the collection
        public int Count()
        {
            return count;
        }
        
        //Display information for all vehicles
        public void Display()
        {
            for (int i = 0; i < count; i++)
            {
                vehicles[i].DisplayInfo();
                Console.WriteLine();
            }
        }
    }
}
