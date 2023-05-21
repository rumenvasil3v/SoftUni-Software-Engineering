using System;

namespace _02._Football_Results
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wins = 0;
            int losses = 0;
            int draws = 0;

            for (int i = 1; i <= 3; i++)
            {
                string result = Console.ReadLine();

                char scoreOne = result[0];
                char scoreTwo = result[2];

                if (scoreOne > scoreTwo)
                {
                    wins++;
                }
                else if (scoreOne < scoreTwo)
                {
                    losses++;
                }
                else
                {
                    draws++;
                }
            }

            Console.WriteLine($"Team won {wins} games.");
            Console.WriteLine($"Team lost {losses} games.");
            Console.WriteLine($"Drawn games: {draws}");
        }
    }
}
