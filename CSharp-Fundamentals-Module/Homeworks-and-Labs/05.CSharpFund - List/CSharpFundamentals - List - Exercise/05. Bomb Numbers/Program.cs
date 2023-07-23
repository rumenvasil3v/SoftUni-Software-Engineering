using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> specialBombNumber = Console
                .ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int specialNumber = specialBombNumber[0];
            int power = specialBombNumber[1];

            bool detonate = false;

            for (int number = 0; number < numbers.Count; number++)
            {
                if (numbers[number] == specialNumber)
                {
                    detonate = true;
                }

                if (detonate)
                {
                    for (int i = 0; i < power; i++)
                    {
                        if (number - 1 - i < 0)
                        {
                            break;
                        }

                        numbers.RemoveAt(number - 1 - i);
                    }
                }

                detonate = false;
            }

            bool rightNumbers = false;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == specialNumber)
                {
                    rightNumbers = true;
                }

                if (rightNumbers)
                {
                    for (int j = 0; j < power; j++)
                    {
                        if (i + 1 >= numbers.Count)
                        {
                            break;
                        }

                        numbers.RemoveAt(i + 1);
                    }
                }

                rightNumbers = false;
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                numbers.Remove(specialNumber);
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
