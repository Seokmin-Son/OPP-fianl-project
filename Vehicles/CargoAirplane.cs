using System;
using Vehicles;

namespace Vehicles{
    public class CargoAirplane : Airplane
    {
        public int CargoCapacity;
        public CargoAirplane(string Name, string Price, double Speed, string VehicleType, int Altitude, int CargoCapacity) : 
        base(Name, Price, Speed, VehicleType, Altitude)
        {
            this.CargoCapacity = CargoCapacity;
        }
        public int CargoCapacity
        {
            get { return CargoCapacity;}
            set
            {
                if (value < 0 || value > 10000)
                {
                    throw new InvalidCargoCapacityException("Cargo capacity must be between 0 and 10000.");
                }
                else
                {
                    CargoCapacity = value;
                }
            }
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
