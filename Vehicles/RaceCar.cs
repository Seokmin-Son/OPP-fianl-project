using System;
using Exceptions;

namespace Vehicles{
    public class RaceCar : Car
    {
        private bool turboBoost;
        public bool TurboBoost
        {
            get { return turboBoost; }
            set {turboBoost = value;}
        }
       
        public RaceCar(string name, double price, double speed, string vehicleType,string model, int horesePower, bool turboBoost) : 
        base(name, price, speed, vehicleType, model, horesePower)
        {
            TurboBoost = turboBoost;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Turbo Boost: {(TurboBoost ? "Yes" : "No")}");
        }
        public override double CalculateTax(){
            return Price * 0.10;          
        }

    }
}
