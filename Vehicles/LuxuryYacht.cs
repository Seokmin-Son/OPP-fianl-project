using System;
using Exceptions;
using IndependentClasses;

namespace Vehicles
{
    // Luxury yacht inheriting from the Boat class
    public class LuxuryYacht : Boat
    {
        private bool helipad;
        // Property for helipad feature
        public bool Helipad
        {
            get { return helipad; }
            set { helipad = value; }
        }
        // Constructor initializing all yacht properties
        public LuxuryYacht(string name, double price, double speed, string vehicleType, int seatingCapacity, bool helipad)
            : base(name, price, speed, vehicleType, seatingCapacity)
        {
            Helipad = helipad;
        }
        // Override DisplayInfo to show yacht-specific information
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Helipad: " + (Helipad ? "Yes" : "No"));
        }
        // Override to calculate tax for luxury yacht
        public override double CalculateTax(){
            return TaxCalculator.Calculate(this);          
        }
    }
}
