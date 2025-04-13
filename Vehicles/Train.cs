using System;
using Exceptions;

namespace Vehicles{
    public class Train : Vehicle
    {
        private int units;        
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
        public Train(string name, double price, double speed, string vehicleType, int units) : 
        base(name, price, speed, vehicleType)
        {
            Units = units;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Units: {Units}");
        }
        public override double CalculateTax(){
            return Price * 0.30;
        }

    }
}
