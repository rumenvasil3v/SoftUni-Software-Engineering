﻿using System;

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
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            double firstPoint = Math.Abs(x1) + Math.Abs(y1);

            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double secondPoint = Math.Abs(x2) + Math.Abs(y2);

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            double thirdPoint = Math.Abs(x3) + Math.Abs(y3);

            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double fourthPoint = Math.Abs(x4) + Math.Abs(y4);

            double firstPair = firstPoint + secondPoint;
            double secondPair = thirdPoint + fourthPoint;

            LongerLine(firstPair, secondPair, firstPoint, secondPoint, thirdPoint, fourthPoint, x1, y1, x2, y2, x3, y3, x4, y4);
            SameLines(firstPair, secondPair, firstPoint, secondPoint, thirdPoint, fourthPoint, x1, y1, x2, y2);
        }

        static void LongerLine(double firstPair, double secondPair, double firstPoint, double secondPoint, double thirdPoint, double fourthPoint, double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            if (firstPair > secondPair)
            {
                if (firstPoint > secondPoint)
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x2, y2, x1, y1);
                }
                else
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x1, y1, x2, y2);
                }
            }
            else if (secondPair > firstPair)
            {
                if (thirdPoint > fourthPoint)
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x4, y4, x3, y3);
                }
                else
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x3, y3, x4, y4);
                }
            }

        }

        static void SameLines(double firstPair, double secondPair, double firstPoint, double secondPoint, double thirdPoint, double fourthPoint, double x1, double y1, double x2, double y2)
        {
            if (firstPair == secondPair)
            {
                if (firstPoint > secondPoint)
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x2, y2, x1, y1);
                }
                else
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x1, y1, x2, y2);
                }
            }
        }
    }
}