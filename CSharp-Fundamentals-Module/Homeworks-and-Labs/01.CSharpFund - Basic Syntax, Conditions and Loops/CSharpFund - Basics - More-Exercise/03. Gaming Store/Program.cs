using System;
using System.Security;
/*
120
RoverWatch
Honored 2
Game Time

19.99
Reimen origin
RoverWatch
Zplinter Zell
Game Time

79.99
OutFall 4
RoverWatch Origins Edition
Game Time
*/
namespace _03._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());

            double totalSpent = 0.0;
            double returnedMoney = 0.0;

            string game;
            while ((game = Console.ReadLine()) != "Game Time")
            {
                switch (game)
                {
                    case "OutFall 4":
                        returnedMoney = 39.99;
                        totalSpent += 39.99;
                        currentBalance -= 39.99;
                        break;
                    case "CS: OG":
                        returnedMoney = 15.99;
                        totalSpent += 15.99;
                        currentBalance -= 15.99;
                        break;
                    case "Zplinter Zell":
                        returnedMoney = 19.99;
                        totalSpent += 19.99;
                        currentBalance -= 19.99;
                        break;
                    case "Honored 2":
                        returnedMoney = 59.99;
                        totalSpent += 59.99;
                        currentBalance -= 59.99;
                        break;
                    case "RoverWatch":
                        returnedMoney = 29.99;
                        totalSpent += 29.99;
                        currentBalance -= 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        returnedMoney = 39.99;
                        totalSpent += 39.99;
                        currentBalance -= 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        continue;
                }

                if (currentBalance >= 0)
                {
                    Console.WriteLine($"Bought {game}");
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                    currentBalance += returnedMoney;
                    totalSpent -= returnedMoney;
                    continue;
                }

                if (currentBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
            }

            if (game == "Game Time")
            {
                Console.WriteLine($"Total spent: ${totalSpent:F2}. Remaining: ${currentBalance:F2}");
            }
        }
    }
}