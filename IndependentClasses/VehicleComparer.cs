using System;
using Vehicles;

namespace IndependentClasses
{
    public class VehicleComparer
    {
        public void SortByPrice(Vehicle[] vehicles)
        {
            if (vehicles == null) return;

            for (int i = 0; i < vehicles.Length - 1; i++)
            {
                for (int j = i + 1; j < vehicles.Length; j++)
                {
                    if (vehicles[i] != null && vehicles[j] != null && vehicles[i].Price > vehicles[j].Price)
                    {
                        Vehicle temp = vehicles[i];
                        vehicles[i] = vehicles[j];
                        vehicles[j] = temp;
                    }
                }
            }
        }

        public void SortBySpeed(Vehicle[] vehicles)
        {
            if (vehicles == null) return;

            for (int i = 0; i < vehicles.Length - 1; i++)
            {
                for (int j = i + 1; j < vehicles.Length; j++)
                {
                    if (vehicles[i] != null && vehicles[j] != null && vehicles[i].Speed > vehicles[j].Speed)
                    {
                        Vehicle temp = vehicles[i];
                        vehicles[i] = vehicles[j];
                        vehicles[j] = temp;
                    }
                }
            }
        }

        public void SortByType(Vehicle[] vehicles)
        {
            if (vehicles == null) return;

            for (int i = 0; i < vehicles.Length - 1; i++)
            {
                for (int j = i + 1; j < vehicles.Length; j++)
                {
                    if (vehicles[i] != null && vehicles[j] != null && 
                        string.Compare(vehicles[i].VehicleType, vehicles[j].VehicleType) > 0)
                    {
                        Vehicle temp = vehicles[i];
                        vehicles[i] = vehicles[j];
                        vehicles[j] = temp;
                    }
                }
            }
        }
    }
}
