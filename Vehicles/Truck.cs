using System;
using Exceptions;
using IndependentClasses;

namespace Vehicles{
    // Truck class inherits from Vehicle class
    public class Truck : Vehicle
    {
        private int loadCapacity;
        // Property for load capacity with validation
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
        // Constructor initializing all truck properties
        public Truck(string name, double price, double speed, string vehicleType, int loadCapacity) : 
        base(name, price, speed, vehicleType)
        {
            LoadCapacity = loadCapacity;
        }
        // Override DisplayInfo to show truck-specific information
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Load Capacity: {LoadCapacity}");
        }
        // Override to calculate tax for truck
        public override double CalculateTax(){
            return TaxCalculator.Calculate(this);   
        }
    }
}

