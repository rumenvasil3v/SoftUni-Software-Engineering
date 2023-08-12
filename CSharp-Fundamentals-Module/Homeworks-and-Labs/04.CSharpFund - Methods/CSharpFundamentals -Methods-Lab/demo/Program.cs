using System;

namespace demo
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();

            if (dataType == "int")
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(firstNumber, secondNumber));
            }
            else if (dataType == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(firstChar, secondChar));
            }
            else if (dataType == "string")
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();
                Console.WriteLine(GetMax(firstString, secondString));
            }

        }

        static int GetMax(int firstNumber, int secondNumber)
        {
            int biggestInt = 0;

            if (firstNumber > secondNumber)
            {
                biggestInt = firstNumber;
            }
            else
            {
                biggestInt = secondNumber;
            }

            return biggestInt;
        }

        static char GetMax(char firstChar, char secondChar)
        {
            char biggestChar = '\0';

            if (firstChar > secondChar)
            {
                biggestChar = firstChar;
            }
            else
            {
                biggestChar = secondChar;
            }

            return biggestChar;
        }

        static string GetMax(string firstString, string secondString)
        {
            string biggestString = string.Empty;
            int firstStringSum = 0;
            int secondStringSum = 0;

            for (int i = 0; i < firstString.Length; i++)
            {
                firstStringSum += firstString[i];
            }

            for (int i = 0; i < secondString.Length; i++)
            {
                secondStringSum += secondString[i];
            }

            if (firstStringSum >= secondStringSum)
            {
                biggestString = firstString;
            }
            else
            {
                biggestString = secondString;
            }

            return biggestString;
        }
    }
}
