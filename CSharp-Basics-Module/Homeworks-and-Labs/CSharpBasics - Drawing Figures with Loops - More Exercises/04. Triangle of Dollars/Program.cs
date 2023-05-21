using System;

namespace _04._Triangle_of_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int rows = 1; rows <= n; rows++)
            {
                for (int i = 1; i <= rows; i++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }
        }
    }
}
