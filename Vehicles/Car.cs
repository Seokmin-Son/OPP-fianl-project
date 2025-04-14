using System;
using Exceptions;
using IndependentClasses;

namespace Vehicles{
    public class Car : Vehicle
    {
        public string Model{get; set;}
        private int horesePower;
        //Property with validation for horsepower
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
        
        //Constructor initializing all car properties
        public Car(string name, double price, double speed, string vehicleType, string model, int horesePower) : 
        base(name, price, speed, vehicleType)
        {
            Model = model;
            HoresePower = horesePower;
        }

        //Override to display additional car info
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Horse Power: {HoresePower}");
        }
        //Override to calculate tax for car
        public override double CalculateTax(){
            return TaxCalculator.Calculate(this);     
        }
    }
}