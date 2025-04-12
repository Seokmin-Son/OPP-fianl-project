using System;
using System.IO;
using Vehicles;

namespace Services
{
    public class FileHandler
    {
        private string filePath = "vehicles.txt";

        public void Save(Vehicle[] vehicles, int count)
        {
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(filePath);
                for (int i = 0; i < count; i++)
                {
                    if (vehicles[i] != null)
                    {
                        writer.WriteLine(
                            vehicles[i].GetType().Name + "," +
                            vehicles[i].Name + "," +
                            vehicles[i].Price + "," +
                            vehicles[i].Speed + "," +
                            vehicles[i].VehicleType
                        );
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error while saving: " + e.Message);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }

        public Vehicle[] Load(out int count)
        {
            count = 0;

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return new Vehicle[100];
            }

            string[] lines = File.ReadAllLines(filePath);
            Vehicle[] vehicles = new Vehicle[100];

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 5)
                {
                    string type = parts[0];
                    string name = parts[1];
                    double price = Convert.ToDouble(parts[2]);
                    double speed = Convert.ToDouble(parts[3]);
                    string vehicleType = parts[4];

                    if (type == "Car")
                        vehicles[count++] = new Car(name, price, speed, vehicleType, "DefaultModel", 100);
                    else if (type == "Truck")
                        vehicles[count++] = new Truck(name, price, speed, vehicleType, 5000);
                    else if (type == "Boat")
                        vehicles[count++] = new Boat(name, price, speed, vehicleType, 10);
                    else if (type == "Airplane")
                        vehicles[count++] = new Airplane(name, price, speed, vehicleType, 30000);
                }
            } 

            return vehicles;
        }
    }
}
