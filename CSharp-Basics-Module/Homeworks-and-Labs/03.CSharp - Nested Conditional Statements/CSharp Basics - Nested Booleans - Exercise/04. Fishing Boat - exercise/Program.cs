using System;

namespace _04._Fishing_Boat___exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Read from the console budget of the groupe
            int budget = int.Parse(Console.ReadLine());
            //2. Read from the console the season
            string season = Console.ReadLine();
            //3. Read fro mthe console number fishermen
            int fishermen = int.Parse(Console.ReadLine());
            //4. Make variable for price with value 0.0
            double price = 0.0;
            //5. If the season is spring the price for boat is 3000 leva.
            if (season == "Spring")
            {
                price = 3000;
            }
            //6. If the season is summer and autumn the price for boat is 4200 leva.
            else if (season == "Summer" || season == "Autumn")
            {
                price = 4200;
            }
            //7. If the season is winter the price for boat is 2600 leva.
            else
            {
                price = 2600;
            }
            //7. Make check for the fishermen 
            switch (fishermen)
            {
                // if they are less or equal to 6, they have 10 % discount.
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    price = price - price * 0.1;
                    break;
                // if they are more 6 or equal to 11, they have 15 % discount.
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                    price = price - price * 0.15;
                    break;
                default:
                    // if they are more than 11, they have 25 % discount.
                    price = price - price * 0.25;
                    break;
            }
            //8. Make check if the number of the fishermen is even and the season is different from autumn
            // -> if it's true, fishermen have 5 % discount
            if (fishermen % 2 == 0 && season != "Autumn")
            {
                price = price - price * 0.05;
            }
            //9. if the budget is qual or more than the price
            // -> print "Yes! You have {leva} leva left."
            if (budget >= price)
            {
                Console.WriteLine($"Yes! You have {budget - price:f2} leva left.");
            }
            //10. if the budget is less than the price
            // -> print "Not enough money! You need {leva} leva."
            else
            {
                Console.WriteLine($"Not enough money! You need {price - budget:f2} leva.");
            }
        }
    }
}
