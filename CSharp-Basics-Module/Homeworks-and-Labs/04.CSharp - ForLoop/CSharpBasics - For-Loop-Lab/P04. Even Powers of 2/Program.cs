using System;

namespace P04._Even_Powers_of_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //Raise 2 o nall even powers from 0 to n
            for (int pow = 0; pow <= n; pow += 2)
            {
                    Console.WriteLine(Math.Pow(2,pow));
            }
        }
    }
}
