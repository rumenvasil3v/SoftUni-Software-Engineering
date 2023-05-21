using System;

namespace demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a1 = int.Parse(Console.ReadLine());
            //int a2 = int.Parse(Console.ReadLine());
            //
            //for (char i = (char)a1; i < (char)a2; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //
            // int x = int.Parse(Console.ReadLine());
            //
            // char x1 = (char)x;
            //
            // for (int i = 1; i <= 50; i++)
            // {
            //     Console.WriteLine(x1);
            //     x1++;
            // }

         
            int n = int.Parse(Console.ReadLine());

            int current = 1;
            bool isBigger = false;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{current} ");
                    current++;
                    if (current > n)
                    {
                        isBigger = true;
                        break;
                    }
                }
                if (isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
