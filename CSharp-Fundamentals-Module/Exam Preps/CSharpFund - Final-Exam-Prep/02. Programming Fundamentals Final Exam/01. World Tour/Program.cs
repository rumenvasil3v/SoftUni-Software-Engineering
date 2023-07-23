﻿using System;

namespace _01._World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();

            string input;
            while ((input = Console.ReadLine()) != "Travel")
            {
                string[] commands = input.Split(':');

                switch (commands[0])
                {
                    case "Add Stop":
                        int index = int.Parse(commands[1]);
                        string str = commands[2];
                        if (index >= 0 && index <= stops.Length - 1)
                        {
                            stops = stops.Insert(index, str);
                        }

                        Console.WriteLine(stops);
                        break;
                    case "Remove Stop":
                        int startIndex = int.Parse(commands[1]);
                        int endIndex = int.Parse(commands[2]);

                        if (startIndex >= 0 && startIndex <= stops.Length - 1
                            && endIndex >= startIndex && endIndex <= stops.Length - 1)
                        {
                            stops = stops.Remove(startIndex, endIndex - startIndex + 1);
                        }

                        Console.WriteLine(stops);
                        break;
                    case "Switch":
                        string oldString = commands[1];
                        string newString = commands[2];
                        if (stops.Contains(oldString))
                        {
                            stops = stops.Replace(oldString, newString);
                        }

                        Console.WriteLine(stops);
                        break;
                }
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}
