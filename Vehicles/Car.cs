using System;

namespace Vehicles{
    public class Car : Vehicle
    {
        public string Model{get; set;}
        private int horesePower;
        public int HoresePower;
        {
            get { return horesePower; }
            set
            {
                if (value < 0)
                {
                    throo new Exception("Horse power cannot be nagative.");
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
            this.Model = model;
            this.HoresePower = horesePower;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Horse Power: {HoresePower}");
        }
        publlic override double CalculateTax(){
            return Price * 0.10;            
        }
    }
}