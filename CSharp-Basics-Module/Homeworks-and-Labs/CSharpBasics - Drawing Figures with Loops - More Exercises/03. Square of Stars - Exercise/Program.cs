using System;

namespace _03._Square_of_Stars___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int rows = 1; rows <= n; rows++)
            {
                for (int columns = 1; columns <= n; columns++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
