using System;

namespace Vehicles
{
    public class LuxuryYacht : Boat
    {
        private bool helipad;

        public bool Helipad
        {
            get { return helipad; }
            set { helipad = value; }
        }

        public LuxuryYacht(string name, double price, double speed, string vehicleType, int seatingCapacity, bool helipad)
            : base(name, price, speed, vehicleType, seatingCapacity)
        {
            Helipad = helipad;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Helipad: " + (Helipad ? "Yes" : "No"));
        }
    }
}
