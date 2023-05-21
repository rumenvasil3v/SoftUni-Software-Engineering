using System;

namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Read from the console budget(int), season(string) and number of fishermen(int)
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine(); //"Spring", "Summer", "Autumn", "Winter"
            int fishermen = int.Parse(Console.ReadLine());

            double price = 0;

            //2. Check what is the season -> what is the rent
            switch (season)
            {
                // spring - 3000 lv.
                case "Spring":
                    price = 3000;
                    break;
                // summer and autumn - 4200 lv.
                case "Summer":
                case "Autumn":
                    price = 4200;
                    break;
                // winter - 2600 lv.
                case "Winter":
                    price = 2600;
                    break;
            }

            //3. Check what is the discount that they will earn
            if (fishermen <= 6)
            {
                // if -> the group <= 6 - 10 %
                price = price - price * 0.1;
                // price -= price * 0.1
            }
            
            else if (fishermen <= 11)
            {
                // else if -> the group <= 11 - 15 %
                price = price - price * 0.15;
            }
            
            else
            {
                // else -> - 25 %
                price -= price * 0.25;
            }
            //4. Check if there is additional discount
            // -> if the fishermen are even number and it is not autumn 
            if (fishermen % 2 == 0 && season != "Autumn")
            {
                price -= price * 0.05;
            }
            //5. Check whether the budget will be enough
            if (budget >= price) 
            {
                // -> if it is enough: "Yes! You have {останалите пари} leva left."
                Console.WriteLine($"Yes! You have {budget - price:f2} leva left.");
            }
            else
            {
                // if its not enough: "Not enough money! You need {сумата, която не достига} leva."
                Console.WriteLine($"Not enough money! You need {price - budget:f2} leva.");
            }
        }
    }
}
