using System;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal x1 = decimal.Parse(Console.ReadLine());
            decimal y1 = decimal.Parse(Console.ReadLine());

            decimal firstPoint = FirstPoint(x1, y1);

            decimal x2 = decimal.Parse(Console.ReadLine());
            decimal y2 = decimal.Parse(Console.ReadLine());

            decimal secondPoint = SecondPoint(x2, y2);

            ClosestPoint(firstPoint, secondPoint, x1, y1, x2, y2);
        }

        static decimal FirstPoint(decimal x1, decimal y1)
        {
            decimal firstPoint = x1 + y1;

            return firstPoint;
        }

        static decimal SecondPoint(decimal x2, decimal y2)
        {
            decimal secondPoint = x2 + y2;

            return secondPoint;
        }

        static void ClosestPoint(decimal firstPoint, decimal secondPoint, decimal x1, decimal y1, decimal x2, decimal y2)
        {
            if (firstPoint < secondPoint)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else if (firstPoint > secondPoint)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}