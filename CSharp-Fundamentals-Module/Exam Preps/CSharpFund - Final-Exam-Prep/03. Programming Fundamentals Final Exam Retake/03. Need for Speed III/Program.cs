using System;
using System.Collections.Generic;
using System.Threading;

namespace Problem_3___Need_for_Speed_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> cars = new Dictionary<string, Car>();
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int n = 0; n < numberOfLines; n++)
            {
                string[] arguments = Console
                    .ReadLine()
                    .Split('|');

                string carName = arguments[0];
                int mileage = int.Parse(arguments[1]);
                int fuel = int.Parse(arguments[2]);

                Car car = new Car(carName, mileage, fuel);

                if (!cars.ContainsKey(carName))
                {
                    cars.Add(carName, car);
                }
            }

            string input;
            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] commands = input
                    .Split(" : ");

                int fuel = 0;
                string car = string.Empty;
                switch (commands[0])
                {
                    case "Drive":
                        car = commands[1];
                        int distance = int.Parse(commands[2]);
                        fuel = int.Parse(commands[3]);

                        if (cars[car].Fuel < fuel)
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }
                        else
                        {
                            cars[car].Fuel -= fuel;
                            Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

                            cars[car].Mileage += distance;
                            if (cars[car].Mileage >= 100000)
                            {
                                cars.Remove(car);
                                Console.WriteLine($"Time to sell the {car}!");
                            }
                        }
                        break;
                    case "Refuel":
                        car = commands[1];
                        fuel = int.Parse(commands[2]);

                        cars[car].Fuel += fuel;
                        if (cars[car].Fuel > 75)
                        {
                            Console.WriteLine($"{car} refueled with {75 - (cars[car].Fuel - fuel)} liters");
                            cars[car].Fuel = 75;
                            break;
                        }

                        Console.WriteLine($"{car} refueled with {fuel} liters");
                        break;
                    case "Revert":
                        car = commands[1];
                        int kilometers = int.Parse(commands[2]);

                        cars[car].Mileage -= kilometers;
                        if (cars[car].Mileage < 10000)
                        {
                            cars[car].Mileage = 10000;
                            break;
                        }

                        Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                        break;
                }
            }

            foreach (var kvp in cars)
            {
                Console.WriteLine($"{kvp.Key} -> Mileage: {kvp.Value.Mileage} kms, Fuel in the tank: {kvp.Value.Fuel} lt.");
            }
        }
    }

    public class Car
    {

        public Car(string name, int mileage, int fuel)
        {
            Name = name;
            Mileage = mileage;
            Fuel = fuel;
        }

        public string Name { get; set; }

        public int Mileage { get; set; }

        public int Fuel { get; set; }
    }
}