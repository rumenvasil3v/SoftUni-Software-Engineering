using System;
using System.Collections.Generic;

namespace Problem_3___P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, City> cities = new Dictionary<string, City>();

            string input;
            while ((input = Console.ReadLine()) != "Sail")
            {
                string[] arguments = input.Split("||");

                string nameOfCity = arguments[0];
                int populationOfCity = int.Parse(arguments[1]);
                int gold = int.Parse(arguments[2]);

                City city = new City(nameOfCity, populationOfCity, gold);

                if (!cities.ContainsKey(nameOfCity))
                {
                    cities.Add(nameOfCity, city);
                    continue;
                }

                cities[nameOfCity].Gold += city.Gold;
                cities[nameOfCity].Population += city.Population;
            }

            string currentEvent;
            while ((currentEvent = Console.ReadLine()) != "End")
            {
                string[] eventArguments = currentEvent.Split("=>");

                switch (eventArguments[0])
                {
                    case "Plunder":
                        string townToPlunder = eventArguments[1];
                        int peopleKilled = int.Parse(eventArguments[2]);
                        int stolenGold = int.Parse(eventArguments[3]);

                        Console.WriteLine($"{townToPlunder} plundered! {stolenGold} gold stolen, {peopleKilled} citizens killed.");

                        cities[townToPlunder].Gold -= stolenGold;
                        cities[townToPlunder].Population -= peopleKilled;

                        if (cities[townToPlunder].Gold == 0 || cities[townToPlunder].Population == 0)
                        {
                            cities.Remove(townToPlunder);
                            Console.WriteLine($"{townToPlunder} has been wiped off the map!");
                        }
                        break;
                    case "Prosper":
                        string prosperTown = eventArguments[1];
                        int gold = int.Parse(eventArguments[2]);

                        if (gold > 0)
                        {
                            cities[prosperTown].Gold += gold;
                            Console.WriteLine($"{gold} gold added to the city treasury. {prosperTown} now has {cities[prosperTown].Gold} gold.");
                        }
                        else
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");
                        }
                        break;
                }
            }

            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach (var kvp in cities)
                {
                    Console.WriteLine($"{kvp.Key} -> Population: {kvp.Value.Population} citizens, Gold: {kvp.Value.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }

        }
    }

    public class City
    {

        public City(string name, int population, int gold)
        {
            Name = name;
            Population = population;
            Gold = gold;
        }

        public string Name { get; set; }

        public int Population { get; set; }

        public int Gold { get; set; }
    }
}