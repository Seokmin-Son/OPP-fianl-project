using System;
using Vehicles;

namespace Vehicles{
    public class Truck : Vehicle
    {
        public int loadCapacity;
        public Truck(string Name, string Price, double Speed, string VehicleType, int loadCapacity) : 
        base(Name, Price, Speed, VehicleType)
        {
            this.loadCapacity = loadCapacity;
        }
        public int LoadCapacity
        {
            get { return loadCapacity;}
            set
            {
                if (value < 0 || value > 1000000)
                {
                    throw new InvalidCargoCapacityException("Load capacity must be between 0 and 1000000.");
                }
                else
                {
                    loadCapacity = value;
                }
            }
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Load Capacity: {loadCapacity}");
        }
        public override double CalculateTax(){
            return Price * 0.20;
        }
    }
}

