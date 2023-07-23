using System;
using System.Collections.Generic;
using System.Linq;
/*
 23 1 456 63 32 87 9 32

 */
namespace demo
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

            string input = Console.ReadLine();
            List<string> items = input.Split(' ').ToList();

            while (input != "end")
            {
                if (input == $"Add {int.Parse(items[1])}")
                {
                    numbers.Add(int.Parse(items[1]));
                }
                else if (input == $"Remove {int.Parse(items[1])}")
                {
                    numbers.Remove(int.Parse(items[1]));
                }
                else if (input == $"RemoveAt {int.Parse(items[1])}")
                {
                    numbers.RemoveAt(int.Parse(items[1]));
                }
                else if (input == $"Insert {int.Parse(items[1])} {int.Parse(items[2])}")
                {
                    numbers.Insert(int.Parse(items[2]), int.Parse(items[1]));
                }

                input = Console.ReadLine();
                items = input.Split(' ').ToList();
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
