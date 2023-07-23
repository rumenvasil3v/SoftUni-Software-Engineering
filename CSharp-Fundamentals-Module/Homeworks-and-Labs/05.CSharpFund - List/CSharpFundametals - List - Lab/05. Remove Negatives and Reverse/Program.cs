using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            bool isNegative = false;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers.RemoveAt(i);
                    i = -1;
                }
            }

            if (numbers.Count == 0)
            {
                isNegative = true;
            }

            numbers.Reverse();
            if (!isNegative)
            {
                Console.WriteLine(string.Join(' ', numbers));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
