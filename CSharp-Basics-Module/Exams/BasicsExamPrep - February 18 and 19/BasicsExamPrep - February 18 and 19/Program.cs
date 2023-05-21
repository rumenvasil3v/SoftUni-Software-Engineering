using System;

namespace BasicsExamPrep___February_18_and_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tax = int.Parse(Console.ReadLine());

            double sneakers = tax * 0.6;
            double equipment = sneakers * 0.8;
            double ball = equipment * 0.25; 
            double accessories = ball * 0.2;

            double totalSum = tax + sneakers + equipment + ball + accessories;

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
