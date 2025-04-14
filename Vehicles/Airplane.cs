using System;
using Exceptions;
using IndependentClasses;

namespace Vehicles
{
    //Airplane class inherits from the base Vehicle class
    public class Airplane : Vehicle
    {
        private int altitude;

        //Property for altitude with validation
        public int Altitude
        {
            get { return altitude; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Altitude cannot be negative.");
                }
                altitude = value;
            }
        }
        
        //Constructor initializing all airplane properties
        public Airplane(string name, double price, double speed, string vehicleType, int altitude)
            : base(name, price, speed, vehicleType)
        {
            Altitude = altitude;
        }
        
        //Override DisplayInfo to show airplane-specific information
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Altitude: {Altitude}");
        }
        
        //Override to calculate tax for airplane
        public override double CalculateTax()
        {
            return TaxCalculator.Calculate(this);
        }
    }
}
