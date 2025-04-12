using System;

namespace Vehicles
{
    public class Vehicle{
        public string Name {get; set;}
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

        public Vehicle(string Name, string Price, double Speed, string VehicleType)
        {
        Name = name;
        Price = price;
        Speed = speed;
        VehicleType = vehicletype;
        }

        public void DisplayInfo(){
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Speed: {Speed}");
            Console.WriteLine($"VehicleType: {VehicleType}");
        }

        public abstract double CalculateTax();
    }
}