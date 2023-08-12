using System;
/*
 60
65

35
49
 */
namespace _05._Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());

            for (int characters = startIndex; characters <= endIndex; characters++)
            {
                char symbols = (char)characters;
                Console.Write($"{symbols} ");
            }
        }
    }
}
