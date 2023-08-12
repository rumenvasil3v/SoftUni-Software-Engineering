using System;
using System.Linq;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var answers = new int[nums.Length];
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                answers[i] = 1;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] < nums[j] && answers[i] < 1 + answers[j])
                    {
                        answers[i] = 1 + answers[j];
                    }
                }
            }

            Console.WriteLine(string.Join(' ', answers));
        }
    }
}
