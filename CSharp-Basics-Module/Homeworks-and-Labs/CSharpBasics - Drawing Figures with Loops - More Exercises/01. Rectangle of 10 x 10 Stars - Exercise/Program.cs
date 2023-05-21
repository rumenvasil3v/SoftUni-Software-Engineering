using System;

namespace _01._Rectangle_of_10_x_10_Stars___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int rows = 1; rows <= 10; rows++)
            {
                for (int columns = 1; columns <= 10; columns++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
