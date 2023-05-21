using System;

namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. We read from the console budget for holiday
            double budget = double.Parse(Console.ReadLine());
            //2. Read from the console season "summer" or "winter"
            string season = Console.ReadLine();
            //3. Create variable with value 0, because when we do the conditions the price need get another value
            double price = 0;
            //4. Variable for destination with Empty value, because the variable will get new value we do the conditions
            string destination = string.Empty;
            //5. Variable for campOrHotel with Empty value, because the variable will get new value we do the conditions
            string campOrHotel = string.Empty;
            //6. Make condition if the budget is less or equal to 100
            if (budget <= 100)
            {
                // if it is, the destination is Bulgaria
                destination = "Bulgaria";
                // make condition if the season is summer
                if (season == "summer")
                {
                    // if it is the person will be at Camp and the price is 30 % from the budget
                    campOrHotel = "Camp";
                    price = budget * 0.3;
                }
                // if the season is not summer, it is winter
                else
                {
                    // the person will be at Hotel and the price will be 70 % from the budget
                    campOrHotel = "Hotel";
                    price = budget * 0.7;
                }
            }
            //7. Make condition if the budget is less or equal to 1000
            else if (budget <= 1000)
            {
                // if it is, the destination is Balkans
                destination = "Balkans";
                // make condition if the season is summer
                if (season == "summer")
                {
                    // if it is the person will be at Camp and the price is 40 % from the budget
                    campOrHotel = "Camp";
                    price = budget * 0.4;
                }
                // if the season is not summer, it is winter
                else
                {
                    // the person will be at Hotel and the price will be 80 % from the budget
                    campOrHotel = "Hotel";
                    price = budget * 0.8;
                }
            }
            //8. If the conditions aren't true then the budget is more than 1000
            else
            {
                //destination is Europe
                destination = "Europe";
                //the season can be summer or winter and the person will be at Hotel
                if (season == "summer" || season == "winter")
                {
                    // the price will be 90 % from the budget
                    campOrHotel = "Hotel";
                    price = budget * 0.9;
                }
            }
            //9. Output "Somewhere in {destination}"
            // "{camp or hotel} - {price}"
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{campOrHotel} - {price:f2}");
        }
    }
}
