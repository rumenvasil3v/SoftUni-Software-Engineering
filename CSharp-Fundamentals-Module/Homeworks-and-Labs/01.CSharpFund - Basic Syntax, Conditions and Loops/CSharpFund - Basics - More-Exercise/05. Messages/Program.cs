using System;

namespace demo___More_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            string words = string.Empty;
            char letters = 'a';

            for (int i = 1; i <= numbers; i++)
            {
                int mainNumber = int.Parse(Console.ReadLine());
                int number = mainNumber;

                if (mainNumber == 0)
                {
                    words = $"{words} ";
                    continue;
                }

                int numberOfDigits = 0;
                int mainDigit = mainNumber % 10;

                while (number > 0)
                {
                    numberOfDigits++;
                    number = number / 10;
                }

                int offSet = 0;
                offSet = (mainDigit - 2) * 3;
                if (mainDigit == 8)
                {
                    offSet++;
                }
                if (mainDigit == 9)
                {
                    offSet++;
                }
                int letterIndex = (int)(offSet + numberOfDigits - 1);
                letterIndex = Convert.ToChar(letterIndex);


                letters += (char)letterIndex;

                words += letters;
                letters = 'a';
            }

            Console.WriteLine(words);
        }
    }
}

