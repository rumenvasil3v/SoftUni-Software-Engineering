using System;

namespace _05._Best_Player
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            string topPlayer = string.Empty;
            int currentGoals = 0;

            while ((input = Console.ReadLine()) != "END")
            {
                string nameOfPlayer = input;
                int scoredGoals = int.Parse(Console.ReadLine());

                if (scoredGoals > currentGoals)
                {
                    currentGoals = scoredGoals;
                    topPlayer = nameOfPlayer;  
                }
                if (currentGoals >= 10)
                {
                    break;
                }
            }

            Console.WriteLine($"{topPlayer} is the best player!");

            if (currentGoals >= 3)
            {
                Console.WriteLine($"He has scored {currentGoals} goals and made a hat-trick !!!");
            }
            else 
            {
                Console.WriteLine($"He has scored {currentGoals} goals.");
            }
        }
    }
}
