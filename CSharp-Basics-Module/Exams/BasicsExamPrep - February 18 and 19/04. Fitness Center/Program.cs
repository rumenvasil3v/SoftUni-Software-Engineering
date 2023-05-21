using System;

namespace _04._Fitness_Center
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int visitors = int.Parse(Console.ReadLine());

            int back = 0;
            int chest = 0;
            int legs = 0;
            int abs = 0;
            int proteinShake = 0;
            int proteinBar = 0;

            for (int i = 1; i <= visitors; i++)
            {
                string fitnessActivity = Console.ReadLine();

                if (fitnessActivity == "Back")
                {
                    back++;
                }
                else if (fitnessActivity == "Chest")
                {
                    chest++;
                }
                else if (fitnessActivity == "Legs")
                {
                    legs++;
                }
                else if (fitnessActivity == "Abs")
                {
                    abs++;
                }
                else if (fitnessActivity == "Protein shake")
                {
                    proteinShake++;
                }
                else 
                {
                    proteinBar++; 
                }
            }

            Console.WriteLine($"{back} - back");
            Console.WriteLine($"{chest} - chest");
            Console.WriteLine($"{legs} - legs");
            Console.WriteLine($"{abs} - abs");
            Console.WriteLine($"{proteinShake} - protein shake");
            Console.WriteLine($"{proteinBar} - protein bar");
            Console.WriteLine($"{(double)(back + chest + legs + abs) / visitors * 100:F2}% - work out");
            Console.WriteLine($"{(double)(proteinBar + proteinShake) / visitors * 100:F2}% - protein");
        }
    }
}
