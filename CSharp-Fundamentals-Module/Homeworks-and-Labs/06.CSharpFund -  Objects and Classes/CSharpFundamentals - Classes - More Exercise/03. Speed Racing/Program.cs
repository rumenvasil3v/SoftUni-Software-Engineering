using System.ComponentModel.Design;

namespace _03._Speed_Racing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int n = 0; n < numberOfCars; n++)
            {
                string[] carData = Console
                    .ReadLine()
                    .Split();

                string carModel = carData[0];
                double fuelAmount = double.Parse(carData[1]);
                double fuelConsumptionForOneKilometer = double.Parse(carData[2]);
                double travelledDistance = 0;

                Car car = new Car(carModel, fuelAmount, fuelConsumptionForOneKilometer, travelledDistance);

                var containsCar = cars.FirstOrDefault(x => x.Model == carModel);

                if (containsCar == null)
                {
                    cars.Add(car);
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] distanceData = command.Split();

                string currentModel = distanceData[1];
                double travelledDistance = double.Parse(distanceData[2]);

                for (int n = 0; n < cars.Count; n++)
                {
                    if (cars[n].Model == currentModel)
                    {
                        cars[n].CalculateDistance(cars[n], travelledDistance);
                        break;
                    }
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }

    public class Car
    {

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer, double travelledDistance)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            TravelledDistance = travelledDistance;
        }

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double TravelledDistance { get; set; }

        public void CalculateDistance(Car car, double travelledDistance)
        {
            double needingFuel = car.FuelConsumptionPerKilometer * travelledDistance;

            if (needingFuel > car.FuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                car.FuelAmount -= needingFuel;
                car.TravelledDistance += travelledDistance;
            }
        }
    }
}