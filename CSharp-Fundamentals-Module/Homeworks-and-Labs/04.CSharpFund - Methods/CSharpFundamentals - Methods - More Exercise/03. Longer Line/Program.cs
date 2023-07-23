using System;

/*
2
3
-2
-3
2
-3
-2
3

 */
namespace _02._Center_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal x1 = decimal.Parse(Console.ReadLine());
            decimal y1 = decimal.Parse(Console.ReadLine());
            decimal x2 = decimal.Parse(Console.ReadLine());
            decimal y2 = decimal.Parse(Console.ReadLine());

            decimal x3 = decimal.Parse(Console.ReadLine());
            decimal y3 = decimal.Parse(Console.ReadLine());
            decimal x4 = decimal.Parse(Console.ReadLine());
            decimal y4 = decimal.Parse(Console.ReadLine());

            //double firstPair = Math.Abs(x1) + Math.Abs(y1) + Math.Abs(x2) + Math.Abs(y2);
            //double secondPair = Math.Abs(x3) + Math.Abs(y3) + Math.Abs(x4) + Math.Abs(y4);

            decimal firstPair = Math.Abs(x1 + y1 + x2 + y2);
            decimal secondPair = Math.Abs(x3 + y3 + x4 + y4);

            LongerLine(firstPair, secondPair, x1, y1, x2, y2, x3, y3, x4, y4);
            SameLines(firstPair, secondPair, x1, y1, x2, y2);
        }

        static void LongerLine(decimal firstPair, decimal secondPair, decimal x1, decimal y1, decimal x2, decimal y2, decimal x3, decimal y3, decimal x4, decimal y4)
        {
            if (firstPair > secondPair)
            {
                if (Math.Abs(x1) + Math.Abs(y1) < Math.Abs(x2) + Math.Abs(y2))
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else if (Math.Abs(x2) + Math.Abs(y2) < Math.Abs(x1) + Math.Abs(y1))
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else if (secondPair > firstPair)
            {
                if (Math.Abs(x3) + Math.Abs(y3) < Math.Abs(x4) + Math.Abs(y4))
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else if (Math.Abs(x4) + Math.Abs(y4) < Math.Abs(x3) + Math.Abs(y3))
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }

        }

        static void SameLines(decimal firstPair, decimal secondPair, decimal x1, decimal y1, decimal x2, decimal y2)
        {
            if (firstPair == secondPair)
            {
                if (Math.Abs(x1) + Math.Abs(y1) < Math.Abs(x2) + Math.Abs(y2))
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
                else if (Math.Abs(x2) + Math.Abs(y2) < Math.Abs(x1) + Math.Abs(y1))
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
                else if (Math.Abs(x1) + Math.Abs(y1) == Math.Abs(x2) + Math.Abs(y2))
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
            }
        }
    }
}