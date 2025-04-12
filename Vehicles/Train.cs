using System;
using Vehicles;

namespace Vehicles{
    public class Train : Vehicle
    {
        public int Units;
        public Train(string Name, string Price, double Speed, string VehicleType, int Units) : 
        base(Name, Price, Speed, VehicleType)
        {
            this.Units = Units;
        }
        public int Units
        {
            get { return Units;}
            set
            {
                if (value <= 0)
                {
                    throw new InvalidCargoCapacityException("Train must have at least 1 unit.");
                }
                else
                {
                    Units = value;
                }
            }
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
