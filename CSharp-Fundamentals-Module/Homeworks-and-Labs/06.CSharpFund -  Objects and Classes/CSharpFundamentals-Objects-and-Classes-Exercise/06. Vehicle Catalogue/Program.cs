/*
train Volvo blue 220
train Man red 350
bus Tesla silver 450
train Nio red 650
bus Mack white 430
bus Koenigsegg orange 750
End
Tesla
Nio
Man
Mack
Close the Catalogue
 */

namespace _06._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            AddingVehiclesToOurCatalogue(vehicles);

            string command;
            while ((command = Console.ReadLine()) != "Close the Catalogue")
            {
                foreach (Vehicle vehicle in vehicles)
                {
                    if (vehicle.Model == command)
                    {
                        Console.WriteLine(vehicle.ToString());
                        break;
                    }
                }
            }

            PrintAverageHorsepower(vehicles);
        }

        static void AddingVehiclesToOurCatalogue(List<Vehicle> vehicles)
        {
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] argumnents = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string typeVehicle = argumnents[0];

                if (typeVehicle != "truck" && typeVehicle != "car")
                {
                    continue;
                }

                string model = argumnents[1];
                string color = argumnents[2];
                int horsepower = int.Parse(argumnents[3]);

                if (horsepower > 1000)
                {
                    continue;
                }

                Vehicle v = vehicles.FirstOrDefault(m => m.Model == model);
                if (v != null)
                {
                    continue;
                }
                else
                {
                    Vehicle vehicle = new Vehicle(typeVehicle, model, color, horsepower);
                    vehicles.Add(vehicle);

                    if (vehicles.Count == 50)
                    {
                        break;
                    }
                }
            }
        }

        static void PrintAverageHorsepower(List<Vehicle> vehicles)
        {
            double averageCars = vehicles.Where(v => v.Type == "car")
                .Select(x => x.Horsepower)
                .DefaultIfEmpty(0)
                .Average();

            double averageTrucks = vehicles.Where(v => v.Type == "truck")
                .Select(x => x.Horsepower)
                .DefaultIfEmpty(0)
                .Average();

            Console.WriteLine($"Cars have average horsepower of: {averageCars:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTrucks:f2}.");
        }
    }

    public class Vehicle
    {

        public Vehicle(string typeVehicle, string model, string color, int horsepower)
        {
            Type = typeVehicle;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }

        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int Horsepower { get; set; }

        public override string ToString()
        {
            string result = string.Empty;

            result += $"Type: {this.Type.Substring(0, 1).ToUpper() + this.Type.Substring(1)}\n";
            result += $"Model: {this.Model}\n";
            result += $"Color: {this.Color}\n";
            result += $"Horsepower: {this.Horsepower}";

            return result;
        }
    }
}