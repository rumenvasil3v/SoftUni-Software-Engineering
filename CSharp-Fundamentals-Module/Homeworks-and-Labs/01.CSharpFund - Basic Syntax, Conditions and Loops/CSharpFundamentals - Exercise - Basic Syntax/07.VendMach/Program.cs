using System;

/*
1
1
0.5
0.5
Start

 */
namespace _07.VendMach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            double acceptedCoins = 0;

            while ((input = Console.ReadLine()) != "Start")
            {
                double coins = double.Parse(input);

                if (coins > 0.1 && coins < 0.2)
                {
                    Console.WriteLine($"Cannot accept {coins}");
                    continue;
                }
                else if (coins > 0.2 && coins < 0.5)
                {
                    Console.WriteLine($"Cannot accept {coins}");
                    continue;
                }
                else if (coins > 0.5 && coins < 1)
                {
                    Console.WriteLine($"Cannot accept {coins}");
                    continue;
                }
                else if (coins > 2)
                {
                    Console.WriteLine($"Cannot accept {coins}");
                    continue;
                }

                acceptedCoins += coins;
            }

            double change = 0;

            while ((input = Console.ReadLine().ToLower()) != "end")
            {
                if (input == "nuts")
                {
                    change = 2.0;
                    acceptedCoins -= 2.0;
                }
                else if (input == "water")
                {
                    change = 0.7;
                    acceptedCoins -= 0.7;
                }
                else if (input == "crisps")
                {
                    change =  1.5;
                    acceptedCoins -= 1.5;
                }
                else if (input == "soda")
                {
                    change = 0.8;
                    acceptedCoins -= 0.8;
                }
                else if (input == "coke")
                {
                    change = 1.0;
                    acceptedCoins -= 1.0;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    continue;
                }

                if (acceptedCoins >= 0)
                {
                    Console.WriteLine($"Purchased {input}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                    acceptedCoins += change;
                    continue;
                }
            }

            if (input == "end")
            {
                Console.WriteLine($"Change: {acceptedCoins:F2}");
            }
        }
    }
}
