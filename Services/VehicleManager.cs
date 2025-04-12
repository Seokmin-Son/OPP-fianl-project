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

        public void SortPrice()
        {
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (vehicles[i].Price > vehicles[j].Price)
                    {
                        Vehicle temp = vehicles[i];
                        vehicles[i] = vehicles[j];
                        vehicles[j] = temp;
                    }
                }
            }
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
