using System;
using System.Collections.Generic;
/*
 5
Carrots
Artichokes
Beans
Eggplants
Peppers
 */
namespace _04._List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();
            for (int product = 1; product <= number; product++)
            {
                string lineOfProduct = Console.ReadLine();
                products.Add(lineOfProduct);
            }

            products.Sort();
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
        }
    }
}
