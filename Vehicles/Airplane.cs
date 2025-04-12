using System;

namespace Vehicles
{
    public class Airplane : Vehicle
    {
        private int altitude;

        public int Altitude
        {
            get { return altitude; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Altitude cannot be negative.");
                }
                altitude = value;
            }
        }

        public Airplane(string name, double price, double speed, string vehicleType, int altitude)
            : base(name, price, speed, vehicleType)
        {
            Altitude = altitude;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Altitude: " + Altitude);
        }

        public override double CalculateTax()
        {
            return Price * 0.15;
        }
    }
}
