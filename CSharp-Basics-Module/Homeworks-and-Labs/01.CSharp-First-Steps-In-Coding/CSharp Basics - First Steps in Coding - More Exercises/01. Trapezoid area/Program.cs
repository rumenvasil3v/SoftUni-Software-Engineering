using System;
using System.Data;

namespace First_Steps_in_Coding___More_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double trapezoidArea = (b1 + b2) * h / 2;
            Console.WriteLine(Convert.ToDecimal(string.Format("{0:F2}", trapezoidArea)));
        }
    }
}
