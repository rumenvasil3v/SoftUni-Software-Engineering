using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstHand = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondHand = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (firstHand.Count > 0 && secondHand.Count > 0)
            {

                int firstPlayerCards = firstHand[0];
                int secondPlayerCards = secondHand[0];

                if (firstPlayerCards > secondPlayerCards)
                {
                    firstHand.RemoveAt(0);
                    secondHand.RemoveAt(0);
                    firstHand.Add(secondPlayerCards);
                    firstHand.Add(firstPlayerCards);
                }
                else if (firstPlayerCards < secondPlayerCards)
                {
                    firstHand.RemoveAt(0);
                    secondHand.RemoveAt(0);
                    secondHand.Add(firstPlayerCards);
                    secondHand.Add(secondPlayerCards);
                }
                else
                {
                    firstHand.RemoveAt(0);
                    secondHand.RemoveAt(0);
                }
            }

            if (firstHand.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {firstHand.Sum()}");
            }
            else if (secondHand.Count > 0)
            {
                Console.WriteLine($"Second player wins! Sum: {secondHand.Sum()}");
            }
        }
    }
}
