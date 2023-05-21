using System;

namespace _04._Vegetable_Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double euro = 1.94;

            double vegetablesPriceKg =  double.Parse(Console.ReadLine());
            double fruitPriceKg = double.Parse(Console.ReadLine());
            int totalKgVeg = int.Parse(Console.ReadLine());
            int totalKgFruits = int.Parse(Console.ReadLine());


            vegetablesPriceKg = vegetablesPriceKg * totalKgVeg;
            fruitPriceKg = fruitPriceKg * totalKgFruits;
            double totalSum = (vegetablesPriceKg + fruitPriceKg) / euro;
            Console.WriteLine("{0:F2}", totalSum);
        }
    }
}
