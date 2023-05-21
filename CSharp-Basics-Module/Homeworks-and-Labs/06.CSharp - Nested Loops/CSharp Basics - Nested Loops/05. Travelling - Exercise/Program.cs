using System;

namespace _05._Travelling___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine();
            double budget;

            string destination;
            while (input != "End")
            {
                destination = input;
                budget = double.Parse(Console.ReadLine());
                while (budget > 0)
                {
                    budget -= double.Parse(Console.ReadLine());
                    if (budget <= 0)
                    {
                        Console.WriteLine($"Going to {destination}!");
                    }

                }
                input= Console.ReadLine();  
            }
        }
    }
}
