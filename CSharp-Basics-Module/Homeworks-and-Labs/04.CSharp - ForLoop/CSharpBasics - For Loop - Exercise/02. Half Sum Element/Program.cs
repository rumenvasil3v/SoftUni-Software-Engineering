using System;

namespace _02._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Read n from the console
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int maxNum = int.MinValue;

            int num;
            //2. Create loop, which will execute from 1 to n
            for (int i = 1; i <= n; i++)
            {
                // How many times will row Loop with n
                num = int.Parse(Console.ReadLine());
                // Add the num to the sum of all numbers
                sum += num; // sum = sum + num
                // make loop whether is bigger than the other nums
                if (num > maxNum)
                {
                    maxNum = num;
                }
            }
            // Изваждаме сумата от най - голямото число 
            sum -= maxNum;
            //3. Condition whether the biggest numbers is == the sum of the other numbers
            // => True => print "Yes" and "Sum = {value}"
            if (sum == maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNum}");
            }
            //4. Else
            // => print "No" and "Diff = {calculate}"
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxNum - sum)}");
            }
        }
    }
}
