using System;
using System.Linq;

namespace Problem_2___Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] arguments = input.Split();

                switch (arguments[0])
                {
                    case "swap":
                        int indexOne = int.Parse(arguments[1]);
                        int indexTwo = int.Parse(arguments[2]);

                        int firsNumber = numbers[indexOne];
                        int secondNumber = numbers[indexTwo];

                        numbers[indexOne] = secondNumber;
                        numbers[indexTwo] = firsNumber;
                        break;
                    case "multiply":
                        int multiplyIndexOne = int.Parse(arguments[1]);
                        int multiplyIndexTwo = int.Parse(arguments[2]);

                        int firstMultiplyNumber = numbers[multiplyIndexOne];
                        int secondMultiplyNumber = numbers[multiplyIndexTwo];

                        numbers[multiplyIndexOne] = firstMultiplyNumber * secondMultiplyNumber;
                        break;
                    case "decrease":
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            numbers[i] -= 1;
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}