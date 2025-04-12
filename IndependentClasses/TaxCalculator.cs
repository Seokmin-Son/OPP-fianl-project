using Vehicles;

namespace IndependentClasses
{
    public class TaxCalculator
    {
        public static double Calculate(Vehicle vehicle)
        {
            return vehicle.CalculateTax();
        }
    }
}