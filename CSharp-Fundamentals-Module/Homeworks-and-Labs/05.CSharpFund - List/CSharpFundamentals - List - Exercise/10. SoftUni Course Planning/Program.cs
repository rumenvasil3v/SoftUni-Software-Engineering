using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listOne = new List<int> { 1, 2, 3, 4, 5, 7 };
            var listTwo = new List<int> { 1, 2, 3, 4, 5, 7 };

            if (listOne.SequenceEqual(listTwo))
            {
                Console.WriteLine("Equal list");
            }
            else
            {
                Console.WriteLine("Not Equal list");
            }
        }
    }
}