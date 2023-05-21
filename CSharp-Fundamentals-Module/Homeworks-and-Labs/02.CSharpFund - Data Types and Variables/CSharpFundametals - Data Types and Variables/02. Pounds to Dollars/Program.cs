using System;
/*
 39 
80
 */
namespace _02._Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal britishPounds = decimal.Parse(Console.ReadLine());
            decimal unitedStatesDollars = britishPounds * 1.31m;

            Console.WriteLine($"{unitedStatesDollars:f3}");
        }
    }
}
