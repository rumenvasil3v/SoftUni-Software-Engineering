using System;
using System.Collections.Generic;
using System.Linq;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxCapacityOfWagon = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            while (input != "end")
            {
                List<string> items = input.Split().ToList();
                if (items[0] == "Add")
                {
                    AddingWagonWithPassangers(wagons, items);
                }
                else
                {
                    PassengersFitting(wagons, items, maxCapacityOfWagon);
                }
                
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', wagons));
        }

        static void AddingWagonWithPassangers(List<int> wagons, List<string> items)
        {
            switch (items[0])
            {
                case "Add":
                    int passengers = int.Parse(items[1]);
                    wagons.Add(passengers);
                    break;
            }
        }

        static void PassengersFitting(List<int> wagons, List<string> items, int maxCapacityOfWagon)
        {
            int passengers = int.Parse(items[0]);

            for (int i = 0; i < wagons.Count; i++)
            {
                if (passengers + wagons[i] <= maxCapacityOfWagon)
                {
                    wagons[i] += passengers;
                    break;
                }
            }
        }
    }
}
