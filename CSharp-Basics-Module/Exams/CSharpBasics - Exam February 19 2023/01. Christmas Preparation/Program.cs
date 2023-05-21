using System;

namespace _01._Christmas_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rollsPaper = int.Parse(Console.ReadLine());
            int fabricRolls = int.Parse(Console.ReadLine());
            double glue = double.Parse(Console.ReadLine());
            double percentDiscount = double.Parse(Console.ReadLine()) / 100;

            double paperPrice = rollsPaper * 5.80;
            double fabricPrice = fabricRolls * 7.20;
            double gluePrice = glue * 1.20;

            double totalPrice = paperPrice + fabricPrice + gluePrice;
            totalPrice = totalPrice - totalPrice * percentDiscount;

            Console.WriteLine("{0:0.000}", totalPrice);
        }
    }
}
