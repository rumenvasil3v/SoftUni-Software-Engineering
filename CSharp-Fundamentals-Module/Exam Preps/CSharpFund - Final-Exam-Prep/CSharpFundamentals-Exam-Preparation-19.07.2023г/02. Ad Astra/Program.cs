/*
#Bread#19/03/21#4000#|Invalid|03/03.20||Apples|08/10/20|200||Carrots|06/08/20|500||Not right|6.8.20|5|
$$#@@%^&#Fish#24/12/20#8500#|#Incorrect#19.03.20#450|$5*(@!#IceCream#03/10/21#9000#^#@aswe|Milk|05/09/20|2000|
Hello|#Invalid food#19/03/20#450|$5*(@

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Ad_Astra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"(\||\#)(?<productName>[a-zA-Z\s]+)\1(?<expirationDate>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d+)\1";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            List<Food> foodList = new List<Food>();

            foreach (Match match in matches)
            {
                string foodName = match.Groups["productName"].Value;
                string expirationDate = match.Groups["expirationDate"].Value;
                int productCalories = int.Parse(match.Groups["calories"].Value);

                Food currentFood = new Food(foodName, expirationDate, productCalories);

                foodList.Add(currentFood);
            }

            int totalDays = foodList.Sum(x => x.Calories) / 2000;
            Console.WriteLine($"You have food to last you for: {totalDays} days!");
            foreach (Food product in foodList)
            {
                Console.WriteLine($"Item: {product.Name}, Best before: {product.ExpirationDate}, Nutrition: {product.Calories}");
            }
        }
    }

    public class Food
    {

        public Food(string name, string expirationDate, int calories)
        {
            Name = name;
            ExpirationDate = expirationDate;
            Calories = calories;
        }

        public string Name { get; set; }

        public string ExpirationDate { get; set; }

        public int Calories { get; set; }
    }
}