using Vehicles;

namespace IndependentClasses
{
    public class TaxCalculator
    {
        public static double Calculate(Vehicle vehicle)
        {
            if (vehicle.VehicleType == "Car")
            {
                return vehicle.Price * 0.10; // 10% tax for cars
            }
            else if (vehicle.VehicleType == "Truck")
            {
                return vehicle.Price * 0.20; // 20% tax for trucks
            }
            else if (vehicle.VehicleType == "Airplane")
            {
                return vehicle.Price * 0.15; // 15% tax for airplanes
            }
            else if (vehicle.VehicleType == "Boat")
            {
                return vehicle.Price * 0.05; // 5% tax for motorcycles
            }
            else
            {
                throw new Exception("Unknown vehicle type for tax calculation.");
            }
        }
    }
}