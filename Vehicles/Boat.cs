using System;
using Exceptions;
using IndependentClasses;

namespace Vehicles
{
    //Boat class inheriting from the base Vehicle class
    public class Boat : Vehicle
    {
        private int seatingCapacity;
        
        //Property for seating capacity with validation
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
        
        //Constructor initializing all boat properties
        public Boat(string name, double price, double speed, string vehicleType, int seatingCapacity)
            : base(name, price, speed, vehicleType)
        {
            SeatingCapacity = seatingCapacity;
        }
        
        //Override DisplayInfo to show boat-specific information
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Seating Capacity: " + SeatingCapacity);
        }
        
        //Override to calculate tax for boat
        public override double CalculateTax()
        {
            return TaxCalculator.Calculate(this);
        }
    }
}
