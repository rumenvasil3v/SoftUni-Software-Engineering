using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Pianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Plant> plants = new Dictionary<string, Plant>();
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int n = 0; n < numberOfLines; n++)
            {
                string[] informationAboutPlant = Console.ReadLine().Split("<->");
                string plantName = informationAboutPlant[0];
                int plantRarity = int.Parse(informationAboutPlant[1]);

                Plant plant = new Plant(plantName, plantRarity);

                if (!plants.ContainsKey(plantName))
                {
                    plants.Add(plantName, plant);
                    continue;
                }

                plants[plant.Name].Rarity = plant.Rarity;
            }

            string input;
            while ((input = Console.ReadLine()) != "Exhibition")
            {
                char[] separators = { ' ', ':', '-' };

                string[] commands = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                switch (commands[0])
                {
                    case "Rate":
                        if (plants.ContainsKey(commands[1]))
                        {
                            plants[commands[1]].Rating.Add(int.Parse(commands[2]));
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                    case "Update":
                        if (plants.ContainsKey(commands[1]))
                        {
                            plants[commands[1]].Rarity = int.Parse(commands[2]);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                    case "Reset":
                        if (plants.ContainsKey(commands[1]))
                        {
                            plants[commands[1]].Rating.Clear();
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                }
            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (var kvp in plants)
            {
                if (!plants[kvp.Key].Rating.Any())
                {
                    plants[kvp.Key].Rating.Add(0);
                }

                Console.WriteLine($"- {kvp.Value.Name}; Rarity: {kvp.Value.Rarity}; Rating: {plants[kvp.Key].Rating.Average():f2}");
            }
        }
    }

    public class Plant
    {

        public Plant(string name, int rarity)
        {
            Name = name;
            Rarity = rarity;
            Rating = new List<double>();
        }

        public string Name { get; set; }

        public int Rarity { get; set; }

        public List<double> Rating { get; set; }
    }
}
