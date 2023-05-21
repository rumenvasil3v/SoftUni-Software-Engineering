using System;

namespace _07._VendMachin
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

            while ((input = Console.ReadLine().ToLower()) != "end")
            {
                if (input == "nuts")
                {
                    acceptedCoins = acceptedCoins - 2.0;
                    if (acceptedCoins < 0)
                    {
                        acceptedCoins = acceptedCoins + 2.0;
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                }
                else if (input == "water")
                {
                    
                    acceptedCoins = acceptedCoins - 0.7;
                    if (acceptedCoins < 0)
                    {
                        acceptedCoins = acceptedCoins + 0.7;
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                }
                else if (input == "crisps")
                {
                    acceptedCoins = acceptedCoins - 1.5;
                    if (acceptedCoins < 0)
                    {
                        acceptedCoins = acceptedCoins + 1.5;
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                }
                else if (input == "soda")
                {
                    acceptedCoins = acceptedCoins - 0.8;
                    if (acceptedCoins < 0)
                    {
                        acceptedCoins = acceptedCoins + 0.8;
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                }
                else if (input == "coke")
                {
                    acceptedCoins = acceptedCoins - 1.0;
                    if (acceptedCoins < 0)
                    {
                        acceptedCoins = acceptedCoins + 1.0;
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
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

            }

            if (input == "end")
            {
                Console.WriteLine($"Change: {acceptedCoins:F2}");
            }
        }
    }
}
