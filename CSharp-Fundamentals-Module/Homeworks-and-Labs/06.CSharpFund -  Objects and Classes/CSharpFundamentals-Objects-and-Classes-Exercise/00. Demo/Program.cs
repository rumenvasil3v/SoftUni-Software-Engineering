namespace _06._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string typeOfVehicle = arguments[0];
                string model = arguments[1];
                string color = arguments[2];
                ushort horsePower = ushort.Parse(arguments[3]);

                Vehicle vehicle = new Vehicle(typeOfVehicle, model, color, horsePower);

                vehicles.Add(vehicle);
            }

            string infoAboutVehicle;
            while ((infoAboutVehicle = Console.ReadLine()) != "Close the Catalogue")
            {
                foreach (Vehicle vehicle in vehicles)
                {
                    if (vehicle.Model == infoAboutVehicle)
                    {
                        Console.WriteLine($"Type: {vehicle.Type.Substring(0, 1).ToUpper() + vehicle.Type.Substring(1)}");
                        Console.WriteLine($"Model: {vehicle.Model}");
                        Console.WriteLine($"Color: {vehicle.Color}");
                        Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
                    }
                }
            }

            int countCars = 0;
            int countTrucks = 0;
            double horsePowerCars = 0;
            double horsePowerTrucks = 0;
            foreach (Vehicle vehicle in vehicles)
            {
                switch (vehicle.Type)
                {
                    case "car":
                        horsePowerCars += vehicle.HorsePower;
                        countCars++;
                        break;
                    case "truck":
                        horsePowerTrucks += vehicle.HorsePower;
                        countTrucks++;
                        break;
                }
            }

            if (countCars > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {horsePowerCars / countCars:F2}.");
            }

            if (countTrucks > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {horsePowerTrucks / countTrucks:F2}.");
            }
        }

        public static string FirstLetterToUpper(string str)
        {
            if (str == null)
                return null;

            if (str.Length > 1)
                return char.ToUpper(str[0]) + str.Substring(1);

            return str.ToUpper();
        }

        public class Vehicle
        {

            public Vehicle(string typeOfVehicle, string model, string color, ushort horsePower)
            {
                Type = typeOfVehicle;
                Model = model;
                Color = color;
                HorsePower = horsePower;
            }

            public string Type { get; set; }

            public string Model { get; set; }

            public string Color { get; set; }

            public ushort HorsePower { get; set; }

        }
    }
}