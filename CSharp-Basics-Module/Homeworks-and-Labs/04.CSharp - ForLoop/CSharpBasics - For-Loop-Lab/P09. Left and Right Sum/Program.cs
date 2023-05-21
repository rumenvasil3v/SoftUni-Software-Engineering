using System;

namespace P09._Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int sum2 = 0;

            for (int i = 0; i < n; i++)
            {
                int leftsum = int.Parse(Console.ReadLine());
                sum += leftsum;
            }
            
            for (int i = 0; i < n; i++)
            {
                int rightsum = int.Parse(Console.ReadLine());
                sum2 += rightsum;
            }
            if (sum == sum2)
            {
                Console.WriteLine($"Yes, sum = {sum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sum2 - sum)}");
            }
        }
    }
}
