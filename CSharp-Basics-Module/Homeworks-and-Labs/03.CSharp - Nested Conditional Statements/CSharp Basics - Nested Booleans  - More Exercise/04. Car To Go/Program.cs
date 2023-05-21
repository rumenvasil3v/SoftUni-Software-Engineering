using System;

namespace _04._Car_To_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Read from the console budget and season.
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string clas = string.Empty;
            string type = string.Empty;
            double price = 0;

            if (budget <= 100)
            {
                clas = "Economy class";
                if (season == "Summer")
                {
                    type = "Cabrio";
                    price = budget * 0.35;
                }
                else
                {
                    type = "Jeep";
                    price = budget * 0.65;
                }
            }
            else if (budget <= 500)
            {
                clas = "Compact class";
                if (season == "Summer")
                {
                    type = "Cabrio";
                    price = budget * 0.45;
                }
                else
                {
                    type = "Jeep";
                    price =  budget * 0.80;
                }
            }
            else
            {
                clas = "Luxury class";
                if (season == "Summer" || season == "Winter")
                {
                    type = "Jeep";
                    price = budget * 0.9;
                }
            }

            Console.WriteLine(clas);
            Console.WriteLine($"{type} - {price:f2}");
        }
    }
}
