using System;

namespace P02._Numbers_N.to1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read n -> Print numbers from 1 to n
            //Input
            int n = int.Parse(Console.ReadLine());
            //Actions + Output
            for (int i = n; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
