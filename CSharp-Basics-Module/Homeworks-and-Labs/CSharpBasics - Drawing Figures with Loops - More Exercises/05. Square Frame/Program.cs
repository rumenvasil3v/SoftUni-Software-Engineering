using System;

namespace _05._Square_Frame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int col = row; col <= n; col++)
                {
                    if (row == 1)
                    {
                        Console.Write("+ ");
                        for (int i = 1; i <= n - 2; i++)
                        {
                            Console.Write("- ");
                        }
                        Console.Write("+ ");
                        break;
                    }
                    else if (row == n)
                    {
                        Console.Write("+ ");
                        for (int i = 1; i <= n - 2; i++)
                        {
                            Console.Write("- ");
                        }
                        Console.Write("+ ");
                        break;
                    }
                    else
                    {
                        Console.Write("| ");
                        for (int i = 1; i <= n - 2; i++)
                        {
                            Console.Write("- ");
                        }
                        Console.Write("| ");
                        break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
