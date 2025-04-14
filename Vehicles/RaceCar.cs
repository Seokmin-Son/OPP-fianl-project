using System;
using Exceptions;
using IndependentClasses;

namespace Vehicles{
    //RaceCar class inherits from Car class 
    public class RaceCar : Car
    {
        private bool turboBoost;
        // Property for turbo boost feature
        public bool TurboBoost
        {
            get { return turboBoost; }
            set {turboBoost = value;}
        }

        // Constructor initialized RaceCar properties
        public RaceCar(string name, double price, double speed, string vehicleType,string model, int horesePower, bool turboBoost) : 
        base(name, price, speed, vehicleType, model, horesePower)
        {
            TurboBoost = turboBoost;
        }
        // Override DisplayInfo to show race car-specific information
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Turbo Boost: {(TurboBoost ? "Yes" : "No")}");
        }
        
        // Override to calculate tax for RaceCar
        public override double CalculateTax(){
            return TaxCalculator.Calculate(this);     
        }

    }
}
