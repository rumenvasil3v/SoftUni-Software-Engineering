/*
George Peter  
 */

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console
                .ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string firstString = words[0];
            string secondString = words[1];

            int sumOfStringCharacters = SumStringCharacters(firstString, secondString);

            Console.WriteLine(sumOfStringCharacters);
        }

        static int SumStringCharacters(string firstString, string secondString)
        {
            int sumOfStringCharacters = 0;

            int biggerLength = Math.Max(firstString.Length, secondString.Length);

            for (int s = 0; s < biggerLength; s++)
            {
                if (s < firstString.Length && s < secondString.Length)
                {
                    sumOfStringCharacters += firstString[s] * secondString[s];
                    continue;
                }

                if (s < firstString.Length)
                {
                    sumOfStringCharacters += firstString[s];
                }
                else
                {
                    sumOfStringCharacters += secondString[s];
                }
            }

            return sumOfStringCharacters;
        }
    }
}