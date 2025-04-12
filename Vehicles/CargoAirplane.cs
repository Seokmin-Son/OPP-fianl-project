using System;

namespace Vehicles{
    public class CargoAirplane : Airplane
    {
        private int cargoCapacity;
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
        public CargoAirplane(string name, double price, double speed, string vehicleType, int altitude, int cargoCapacity) : 
        base(name, price, speed, vehicleType, altitude)
        {
            CargoCapacity = cargoCapacity;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Cargo Capacity: {CargoCapacity}");
        }
        public override double CalculateTax(){
            return Price * 0.15;            
        }

    }
}
