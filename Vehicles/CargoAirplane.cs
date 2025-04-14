using System;
using Exceptions;
using IndependentClasses;

namespace Vehicles{
    // CargoAirplane class inherits from Airplane class
    public class CargoAirplane : Airplane
    {
        private int cargoCapacity;
        // Property for cargo capacity with validation
        public int CargoCapacity
        {
            get { return cargoCapacity;}
            set
            {
                if (value < 0 || value > 10000)
                {
                    throw new InvalidCargoCapacityException("Cargo capacity must be between 0 and 10000.");
                }
                else
                {
                    cargoCapacity = value;
                }
            }
        }
        // Constructor initializing all cargo airplane properties
        public CargoAirplane(string name, double price, double speed, string vehicleType, int altitude, int cargoCapacity) : 
        base(name, price, speed, vehicleType, altitude)
        {
            CargoCapacity = cargoCapacity;
        }
        
        // Override DisplayInfo to show cargo airplane-specific information
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Cargo Capacity: {CargoCapacity}");
        }
        // Override to calculate tax for cargo airplane
        public override double CalculateTax(){
            return TaxCalculator.Calculate(this);          
        }

    }
}
