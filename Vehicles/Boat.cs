using System;

namespace Vehicles
{
    public class Boat : Vehicle
    {
        private int seatingCapacity;

        public int SeatingCapacity
        {
            get { return seatingCapacity; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Seating capacity must be greater than zero.");
                }
                seatingCapacity = value;
            }
        }

        public Boat(string name, double price, double speed, string vehicleType, int seatingCapacity)
            : base(name, price, speed, vehicleType)
        {
            SeatingCapacity = seatingCapacity;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Seating Capacity: " + SeatingCapacity);
        }

        public override double CalculateTax()
        {
            return Price * 0.05;
        }
    }
}
