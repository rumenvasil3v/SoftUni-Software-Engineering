using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> distancesToPokemons = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int sum = 0;
            while (distancesToPokemons.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int value = 0;

                if (index > distancesToPokemons.Count - 1)
                {
                    index = distancesToPokemons.Count - 1;
                    value = distancesToPokemons[index];
                    distancesToPokemons.RemoveAt(index);
                    distancesToPokemons.Add(distancesToPokemons[0]);
                }
                else if (index < 0)
                {
                    index = 0;
                    value = distancesToPokemons[index];
                    distancesToPokemons.RemoveAt(index);
                    distancesToPokemons.Insert(0, distancesToPokemons[distancesToPokemons.Count - 1]);
                }
                else
                {
                    value = distancesToPokemons[index];
                    distancesToPokemons.RemoveAt(index);
                }
                
                sum += value;
                
                for (int n = 0; n < distancesToPokemons.Count; n++)
                {
                    
                    if (distancesToPokemons[n] <= value)
                    {
                        distancesToPokemons[n] += value;
                    }
                    else
                    {
                        distancesToPokemons[n] -= value;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}