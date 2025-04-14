using System;
using Exceptions;
using IndependentClasses;

namespace Vehicles{
    // Train class inheriting from Vehicle
    public class Train : Vehicle
    {
        private int units;
        //Property for units with validation        
        public int Units
        {
            get { return units;}
            set
            {
                if (value <= 0)
                {
                    throw new InvalidCargoCapacityException("Train must have at least 1 unit.");
                }
                else
                {
                    units = value;
                }
            }
        }
        //Constructor initializing all train properties
        public Train(string name, double price, double speed, string vehicleType, int units) : 
        base(name, price, speed, vehicleType)
        {
            Units = units;
        }
        //Override DisplayInfo to show train-specific information
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Units: {Units}");
        }
        //Override to calculate tax for train
        public override double CalculateTax(){
            return TaxCalculator.Calculate(this);
        }

    }
}
