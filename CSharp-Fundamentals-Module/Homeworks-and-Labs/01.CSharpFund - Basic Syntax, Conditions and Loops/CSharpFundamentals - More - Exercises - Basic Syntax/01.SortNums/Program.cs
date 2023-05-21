using System;
using System.Linq;
/*

 */
namespace _01.SortNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = 0;
            int secondNum = 0;
            int thirdNum = 0;

            int[] arr = new int[] { firstNum = int.Parse(Console.ReadLine()), secondNum = int.Parse(Console.ReadLine()), thirdNum = int.Parse(Console.ReadLine()) };


            // Sort the arr in decreasing order
            // and return a array
            arr = arr.OrderByDescending(a => a).ToArray();

            // print all element of array
            foreach (int value in arr)
            {
                Console.WriteLine(value);
            }
        }
    }
}
