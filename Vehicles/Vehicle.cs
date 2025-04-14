using System;
using Exceptions;

namespace Vehicles
{
    //Abstract base class for all vehicles types
    public abstract class Vehicle{
        public string Name {get; set;}
        private double price;
        private double speed;
        //Property with validation to ensure price is not negative
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
        //Property with validation to ensure speed is positive
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
        
        //Constructor initializing all common vehicle properties
        public Vehicle(string name, double price, double speed, string vehicleType)
        {
        Name = name;
        Price = price;
        Speed = speed;
        VehicleType = vehicleType;
        }

        //Can be overridden by child classes to display addtional info
        public virtual void DisplayInfo(){
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Speed: {Speed}");
            Console.WriteLine($"VehicleType: {VehicleType}");
        }
        
        //Abstract method to be implemented by child classes for tax calculation
        public abstract double CalculateTax();
    }
}