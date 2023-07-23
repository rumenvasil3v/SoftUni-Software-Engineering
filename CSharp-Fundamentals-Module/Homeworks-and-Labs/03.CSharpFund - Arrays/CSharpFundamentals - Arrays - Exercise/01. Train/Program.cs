using System;
using System.Linq;

/*
3
13
24
8

6
3
52
71
13
65
4

1
100
 */
namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfWagons = int.Parse(Console.ReadLine());

            int[] oneWagonPassengers = new int[countOfWagons];

            for (int i = 0; i < countOfWagons; i++)
            {
                int passengers = int.Parse(Console.ReadLine());
                oneWagonPassengers[i] = passengers;
            }

            Console.WriteLine(string.Join(' ', oneWagonPassengers));
            Console.WriteLine(oneWagonPassengers.Sum());
        }
    }
}
