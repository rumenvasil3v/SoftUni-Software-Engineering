using System;

namespace _07._School_Camp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string group = Console.ReadLine();
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());

            double priceNights = 0;
            string sport = string.Empty;

            if (group == "girls")
            {
                if (season == "Winter")
                {
                    sport = "Gymnastics";
                    priceNights = students * (nights * 9.60);
                }
                else if (season == "Spring")
                {
                    sport = "Athletics";
                    priceNights = students * (nights * 7.20);
                }
                else
                {
                    sport = "Volleyball";
                    priceNights = students * (nights * 15);
                }
            }
            else if (group == "boys")
            {
                if (season == "Winter")
                {
                    sport = "Judo";
                    priceNights = students * (nights * 9.60);
                }
                else if (season == "Spring")
                {
                    sport = "Tennis";
                    priceNights = students * (nights * 7.20);
                }
                else
                {
                    sport = "Football";
                    priceNights = students * (nights * 15);
                }
            }
            else
            {
                if (season == "Winter")
                {
                    sport = "Ski";
                    priceNights = students * (nights * 10);
                }
                else if (season == "Spring")
                {
                    sport = "Cycling";
                    priceNights = students * (nights * 9.50);
                }
                else
                {
                    sport = "Swimming";
                    priceNights = students * (nights * 20);
                }
            }

            if (students >= 10 && students < 20)
            {
                priceNights = priceNights - priceNights * 0.05;
            }
            else if (students >= 20 && students < 50)
            {
                priceNights =  priceNights - priceNights * 0.15;
            }
            else if (students >= 50)
            {
                priceNights = priceNights - priceNights * 0.5;
            }
            else
            {
                priceNights = priceNights;
            }

            Console.WriteLine($"{sport} {priceNights:f2} lv.");
        }
    }
}
