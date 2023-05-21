using System;

namespace _07._Christmas_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                Console.Write(new String(' ', n - i));
                Console.Write("  |");
                if (i == n)
                {
                    break;
                }
                Console.WriteLine();
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(new String(' ', n - i));
                    Console.Write("*");
                    Console.WriteLine();
                }
                
            }
            for (int j = 1; j <= n; j++)
            {
                Console.WriteLine("*");
            }
        }
    }
}
