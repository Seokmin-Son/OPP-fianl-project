using System;
using Vehicles;

namespace Vehicles{
    public class Car : Vehicle
    {
        public string Model;
        public int HoresePower;
        public Car(string Name, string Price, double Speed, string VehicleType, string Model, int HoresePower) : 
        base(Name, Price, Speed, VehicleType)
        {
            this.Model = Model;
            this.HoresePower = HoresePower;
        }
        public string GetModel()
        {
            return Model;
        }
        public void SetModel(string model)
        {
            Model = model;
        }
        public int HoresePower
        {
            get { return HoresePower;}
            set
            {
                if (value < 0)
                {
                    throw new Exception("Horse power cannot be nagative.");
                }
                else
                {
                    HoresePower = value;
                }
            }
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