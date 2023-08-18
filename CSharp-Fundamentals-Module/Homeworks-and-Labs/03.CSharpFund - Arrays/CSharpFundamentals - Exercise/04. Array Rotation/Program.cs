using System;
/*
 51 47 32 61 21
2

32 21 61 1
4

2 4 15 31
5

 */
namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] randomNumbers = Console
                .ReadLine()
                .Split(' ');

            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                string[] currentNumbers = new string[randomNumbers.Length];

                for (int j = 0; j < randomNumbers.Length; j++)
                {
                    currentNumbers[j] = randomNumbers[j];
                }

                for (int j = 0; j < randomNumbers.Length - 1; j++)
                {
                    randomNumbers[j] = currentNumbers[j + 1];
                }

                randomNumbers[randomNumbers.Length - 1] = currentNumbers[0];
            }

            Console.WriteLine(string.Join(' ', randomNumbers));
        }
    }
}