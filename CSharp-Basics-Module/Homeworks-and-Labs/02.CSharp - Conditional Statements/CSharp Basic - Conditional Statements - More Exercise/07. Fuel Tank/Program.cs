using System;
using System.Threading.Tasks;

namespace _07._Fuel_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            string exampleLower = fuel.ToLower();
            double litersFuel = double.Parse(Console.ReadLine());

            if (litersFuel >= 25)
            {
                if (fuel == "Diesel")
                    Console.WriteLine($"You have enough {exampleLower}.");
                else if (fuel == "Gasoline")
                {
                    Console.WriteLine($"You have enough {exampleLower}.");
                }
                else if (fuel == "Gas")
                {
                    Console.WriteLine($"You have enough {exampleLower}.");
                }
                else
                {
                    Console.WriteLine("Invalid fuel!");
                }
            }
            else if (litersFuel < 25)
            {
                if (fuel == "Diesel")
                    Console.WriteLine($"Fill your tank with {exampleLower}!");
                else if (fuel == "Gasoline")
                {
                    Console.WriteLine($"Fill your tank with {exampleLower}!");
                }
                else if (fuel == "Gas")
                {
                    Console.WriteLine($"Fill your tank with {exampleLower}!");
                }
                else
                {
                    Console.WriteLine("Invalid fuel!");
                }
            }
        }
    }
}
