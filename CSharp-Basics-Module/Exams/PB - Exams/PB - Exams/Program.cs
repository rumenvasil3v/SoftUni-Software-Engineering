using System;

namespace PB___Exams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            double tax = double.Parse(Console.ReadLine());
            double lounge = double.Parse(Console.ReadLine());
            double umbrella = double.Parse(Console.ReadLine());

            double taxSum = people * tax;
            double umbrellaSum = Math.Ceiling(people * 0.5);
            umbrellaSum = umbrellaSum * umbrella;

            double loungeSum = Math.Ceiling(people * 0.75);
            loungeSum = loungeSum * lounge;

            double totalSum = taxSum + umbrellaSum + loungeSum;

            Console.WriteLine($"{totalSum:f2} lv.");
        }
    }
}
