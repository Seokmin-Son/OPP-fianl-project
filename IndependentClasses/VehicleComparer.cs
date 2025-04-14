using System;
using Vehicles;

namespace IndependentClasses
{
    //Class for sorting vehicles by different criteria
    public class VehicleComparer
    {
        //Sort vehicles by price in ascending order
        public void SortByPrice(Vehicle[] vehicles)
        {
            if (vehicles == null) return;
            
            //Simple bubble sort alogorithm
            for (int i = 0; i < vehicles.Length - 1; i++)
            {
                for (int j = i + 1; j < vehicles.Length; j++)
                {
                    // only compare non-null vehicles
                    if (vehicles[i] != null && vehicles[j] != null && vehicles[i].Price > vehicles[j].Price)
                    {
                        //Swap vehicles if needed
                        Vehicle temp = vehicles[i];
                        vehicles[i] = vehicles[j];
                        vehicles[j] = temp;
                    }
                }
            }
        }
        
        //Sort vehicles by spped in ascending order
        public void SortBySpeed(Vehicle[] vehicles)
        {
            if (vehicles == null) return;
            
            //Simple bubble sort alogorithm
            for (int i = 0; i < vehicles.Length - 1; i++)
            {
                for (int j = i + 1; j < vehicles.Length; j++)
                {
                    // only compare non-null vehicles
                    if (vehicles[i] != null && vehicles[j] != null && vehicles[i].Speed > vehicles[j].Speed)
                    {
                        //Swap vehicles if needed
                        Vehicle temp = vehicles[i];
                        vehicles[i] = vehicles[j];
                        vehicles[j] = temp;
                    }
                }
            }
        }
        
        //Sort vehicles alphaabetically by type 
        public void SortByType(Vehicle[] vehicles)
        {
            if (vehicles == null) return;
            
            //Simple bubble sort alogorithm
            for (int i = 0; i < vehicles.Length - 1; i++)
            {
                for (int j = i + 1; j < vehicles.Length; j++)
                {
                    // only compare non-null vehicles
                    if (vehicles[i] != null && vehicles[j] != null && 
                        string.Compare(vehicles[i].VehicleType, vehicles[j].VehicleType) > 0)
                    {
                        //Swap vehicles if needed
                        Vehicle temp = vehicles[i];
                        vehicles[i] = vehicles[j];
                        vehicles[j] = temp;
                    }
                }
            }
        }
    }
}
