﻿using System;
using Vehicles;
using Services;
using IndependentClasses;
using Exceptions;

class Program
{
    static void Main(string[] args)
    {
        VehicleManager manager = new VehicleManager();
        FileHandler handler = new FileHandler();
        VehicleStatistics stats = new VehicleStatistics();
        VehicleComparer comparer = new VehicleComparer();

        try
        {
            //Create various vehicle objects
            Console.WriteLine("Adding Vehicle to the Management System");
            manager.Add(new Car("Avante", 20000, 180, "Car", "Modern", 120));
            manager.Add(new Truck("Volvo Truck", 80000, 120, "Truck", 15000));
            manager.Add(new Boat("Sailor", 30000, 60, "Boat", 8));
            manager.Add(new RaceCar("F1 Racer", 150000, 320, "RaceCar", "VMax", 500, true));
            manager.Add(new Train("Bullet", 500000, 280, "Train", 12));
            
            //Test for exceptions
            Console.WriteLine("\nTest cases for exceptionos");
            try {
                //price exception
                Console.WriteLine("Testing negative price exception");
                Car invalidCar = new Car("Invalid Car", -10000, 180, "Car", "Test", 80);
            } catch (InvalidPriceException ex) {
                Console.WriteLine("[Price Error] " + ex.Message);
            }
            try {
                //speed exception
                Console.WriteLine("Testing negative speed exception");
                Truck invalidTruck = new Truck("Invalid Truck", 50000, -100, "Truck", 2000);
            } catch (InvalidSpeedException ex) {
                Console.WriteLine("[Speed Error] " + ex.Message);
            }
            try {
                //cargo capacity exception
                Console.WriteLine("Testing negative cargo capacity exception");
                Truck invalidTruck = new Truck("Invalid Truck", 50000, 100, "Truck", -2000);
            } catch (InvalidCargoCapacityException ex) {
                Console.WriteLine("[Cargo Capacity Error] " + ex.Message);
            }
            Console.WriteLine("==============================");

            //sort and display by price
            Console.WriteLine("\nSorted by Price:");
            comparer.SortByPrice(manager.GetAll());
            manager.Display();
            Console.WriteLine("==============================");

            //sort and display by speed
            Console.WriteLine("\nSorted by Speed:");   
            comparer.SortBySpeed(manager.GetAll());
            manager.Display();  
            Console.WriteLine("==============================");

            //sort and display by cargo capacity
            Console.WriteLine("\nSorted by Type:");
            comparer.SortByType(manager.GetAll());
            manager.Display();
            Console.WriteLine("==============================");

            //save to file
            handler.Save(manager.GetAll(), manager.Count());
            Console.WriteLine("\nSaved to vehicles.txt");

            //load from file
            int loadedCount;
            Vehicle[] loaded = handler.Load(out loadedCount);

            //Display loaded vehicles
            Console.WriteLine("\nLoaded from file:");
            for (int i = 0; i < loadedCount; i++)
            {
                loaded[i].DisplayInfo();
                Console.WriteLine();
            }
            Console.WriteLine("==============================");

            //Display statistics
            Console.WriteLine("\nStatistics:");
            stats.AveragePrice(manager.GetAll());
            Console.WriteLine("==============================");
            stats.TypeCounts(manager.GetAll());
            Console.WriteLine("==============================");
            stats.FastestByType(manager.GetAll(), "Car");
            Console.WriteLine("==============================");
            stats.FastVehicles(manager.GetAll());
            Console.WriteLine("==============================");
            stats.MostExpensive(manager.GetAll());
            Console.WriteLine("==============================");
            stats.HeavyTrucks(manager.GetAll());
            Console.WriteLine("==============================");
        }
        //Handle various exceptions
        catch (InvalidPriceException ex)
        {
            Console.WriteLine("[Price Error] " + ex.Message);
        }
        catch (InvalidSpeedException ex)
        {
            Console.WriteLine("[Speed Error] " + ex.Message);
        }
        catch (InvalidCargoCapacityException ex)
        {
            Console.WriteLine("[Cargo Capacity Error] " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("[General Error] " + ex.Message);
        }
    }
}
