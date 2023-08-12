/*
>>Recliner<<<<!5
>>>>>>Rocking chair<<!5
Purchase

 */

using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<furnitureName>[A-Za-z]+)<<(?<price>\d+(\.\d+)*)\!(?<quantity>\d+)\b";

            List<decimal> furniturePrice = new List<decimal>();
            List<string> furnitureNames = new List<string>();
            Regex regex = new Regex(pattern);

            string input;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match match = regex.Match(input);
                if (!match.Success)
                {
                    continue;
                }

                string furnitureName = match.Groups["furnitureName"].Value;
                decimal price = decimal.Parse(match.Groups["price"].Value);
                int quantity = int.Parse(match.Groups["quantity"].Value);

                Furniture furniture = new Furniture(furnitureName, price, quantity);
                furnitureNames.Add(furnitureName);
                furniturePrice.Add(price * quantity);
            }

            Console.WriteLine("Bought furniture:");
            if (furnitureNames.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, furnitureNames));
            }
            Console.WriteLine($"Total money spend: {furniturePrice.Sum():f2}");
        }
    }

    public class Furniture
    {

        public Furniture(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public decimal TotalPrice
        {
            get
            {
                return this.Price * this.Quantity;
            }
        }
    }
}