using System;
/*
 5
2
3

10
5
2

45
9
4

32
5
3

42
7
3 
 */
namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distanceBetweenTargets = int.Parse(Console.ReadLine());
            byte exhaustionFactor = byte.Parse(Console.ReadLine());

            int countOfTargets = 0;
            int originalValueOfPokePower = pokePower;

            while (pokePower >= distanceBetweenTargets)
            {
                pokePower -= distanceBetweenTargets;

                countOfTargets++;

                if (pokePower == originalValueOfPokePower * 0.5)
                {
                    if (exhaustionFactor == 0)
                    {
                        continue;
                    }
                    pokePower = pokePower / exhaustionFactor;
                }
            }

            Console.WriteLine($"{pokePower}");
            Console.WriteLine($"{countOfTargets}");
        }
    }
}