using System;
using System.Linq;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            for (int i = 0; i < input.Length / 2; i++)
            {
                string firstChar = input[i];
                string lastChar = input[input.Length - 1 - i];

                input[i] = lastChar;
                input[input.Length - 1 - i] = firstChar;
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
