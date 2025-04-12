using System;

namespace Vehicles{
    public class Car : Vehicle
    {
        public string Model{get; set;}
        private int horesePower;
        public int HoresePower
        {
            get { return horesePower; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Horse power cannot be negative.");
                }
                else
                {
                    horesePower = value;
                }
            }
        }

        public Car(string name, double price, double speed, string vehicleType, string model, int horesePower) : 
        base(name, price, speed, vehicleType)
        {
            Model = model;
            HoresePower = horesePower;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Horse Power: {HoresePower}");
        }
        public override double CalculateTax(){
            return Price * 0.10;            
        }
    }
}