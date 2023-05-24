using System;
/*
 Sofia
1286383
492

Kaliningrad
437456
223

 */
namespace _08._Town_Info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfTown = Console.ReadLine();
            uint population = uint.Parse(Console.ReadLine());
            ushort area = ushort.Parse(Console.ReadLine());

            Console.WriteLine($"Town {nameOfTown} has population of {population} and area {area} square km.");
        }
    }
}
