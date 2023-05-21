using System;

namespace _02._Rectangle_of_N_x_N_Stars
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
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
