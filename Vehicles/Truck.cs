using System;
using Exceptions;

namespace Vehicles{
    public class Truck : Vehicle
    {
        private int loadCapacity;
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
        public Truck(string name, double price, double speed, string vehicleType, int loadCapacity) : 
        base(name, price, speed, vehicleType)
        {
            LoadCapacity = loadCapacity;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Load Capacity: {LoadCapacity}");
        }
        public override double CalculateTax(){
            return Price * 0.20;
        }
    }
}

