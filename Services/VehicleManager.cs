using System;
using Vehicles;

namespace Services
{
    public class VehicleManager
    {
        private Vehicle[] vehicles = new Vehicle[100];
        private int count = 0;

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

        public Vehicle[] GetAll()
        {
            return vehicles;
        }

        public int Count()
        {
            return count;
        }

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
