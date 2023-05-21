using System;

namespace _06._Rhombus_of_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                Console.Write(new String(' ', n - row));
                Console.Write("*");
                for (int row1 = 0; row1 < row - 1; row1++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            for (int row2 = n; row2 >= 1; row2--)
            {
                Console.Write(new String(' ', n - row2));
                for (int i = 0; i < row2 - 1; i++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine(); 
            }
        }
    }
}
