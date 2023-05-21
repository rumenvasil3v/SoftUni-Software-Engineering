﻿using System;

namespace _05._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Read from the console budget and season.
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double price = 0;
            string location = string.Empty;
            string place = string.Empty;

            if (budget <= 1000)
            {
                place = "Camp";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 0.65;
                }
                else
                {
                    location = "Morocco";
                    price = budget * 0.45;
                }
            }
            else if (budget <= 3000)
            {
                place = "Hut";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 0.8;
                }
                else
                {
                    location = "Morocco";
                    price = budget * 0.6;
                }
            }
            else
            {
                place = "Hotel";
                if (season == "Summer")
                {
                    location = "Alaska";
                }
                else
                {
                    location = "Morocco";
                }
                price = budget * 0.9;
            }

            Console.WriteLine($"{location} - {place} - {price:f2}");
        }
    }
}
