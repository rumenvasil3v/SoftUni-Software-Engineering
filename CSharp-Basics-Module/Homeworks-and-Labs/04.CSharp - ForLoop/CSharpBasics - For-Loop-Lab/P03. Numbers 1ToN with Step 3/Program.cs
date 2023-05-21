using System;

namespace P03._Numbers_1ToN_with_Step_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // Print numbers from 1 to N with step 3
            for (int i = 1;i <= n ;i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
