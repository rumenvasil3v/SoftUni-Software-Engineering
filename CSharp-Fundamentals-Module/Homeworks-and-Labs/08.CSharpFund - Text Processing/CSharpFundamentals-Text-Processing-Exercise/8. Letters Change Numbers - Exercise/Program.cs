﻿namespace _8._Letters_Change_Numbers___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;

            foreach (var substring in input)
            {
                char firstLetter = substring[0];

                char lastLetter = substring[substring.Length - 1];

                string numberStr = substring.Substring(1, substring.Length - 2);

                double number = double.Parse(numberStr);

                if (char.IsUpper(firstLetter))
                {
                    number /= firstLetter - 64;
                }
                else if (char.IsLower(firstLetter))
                {
                    number *= (firstLetter - 96);
                }

                if (char.IsUpper(lastLetter))
                {
                    number -= lastLetter - 64;
                }
                else if (char.IsLower(lastLetter))
                {
                    number += lastLetter - 96;
                }

                sum += number;
            }

            Console.WriteLine($"{sum:F2}");
        }
    }
}