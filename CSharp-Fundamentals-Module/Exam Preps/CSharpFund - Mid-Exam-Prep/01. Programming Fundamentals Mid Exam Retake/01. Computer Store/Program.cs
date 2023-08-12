using System;

namespace _01._Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceWithoutTax = 0;

            string input = Console.ReadLine();
            while (input != "special" && input != "regular")
            {
                double partsWithOutTax = double.Parse(input);

                if (partsWithOutTax < 0)
                {
                    Console.WriteLine("Invalid price!");
                    input = Console.ReadLine();
                    continue;
                }

                priceWithoutTax += partsWithOutTax;
                input = Console.ReadLine();
            }

            double taxes = priceWithoutTax * 0.2;
            double totalPrice = taxes + priceWithoutTax;

            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }

            if (input == "special")
            {
                totalPrice = totalPrice * 0.9;
            }

            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {priceWithoutTax:F2}$");
            Console.WriteLine($"Taxes: {taxes:F2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {totalPrice:F2}$");
        }
    }
}
