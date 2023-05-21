using System;

namespace _01._Rectangle_of_10_x_10_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int rows = 1; rows <= 10; rows++)
            {
                for (int column = 1; column <= 10; column++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
