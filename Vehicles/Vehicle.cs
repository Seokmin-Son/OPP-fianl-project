using System;
using Exceptions;

namespace Vehicles
{
    public abstract class Vehicle{
        public string Name {get; set;}
        private double price;
        private double speed;
        public double Price 
        {
            get{return price;}
            set
            {
                if(value < 0)
                {
                    throw new InvalidPriceException("Price cannot be negative.");
                }
                else
                {
                    price = value;
                }
            }
        }
        public double Speed 
        {
            get {return speed;} 
            set
            {
                if(value <= 0)
                {
                    throw new InvalidSpeedException("Speed must be greater than zero.");
                }
                else
                {
                    speed = value;
                }
            }
        }
        public string VehicleType {get; set;}

        public Vehicle(string name, double price, double speed, string vehicleType)
        {
        Name = name;
        Price = price;
        Speed = speed;
        VehicleType = vehicleType;
        }

        public virtual void DisplayInfo(){
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Speed: {Speed}");
            Console.WriteLine($"VehicleType: {VehicleType}");
        }

        public abstract double CalculateTax();
    }
}