using System;
using System.Linq;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                char[] straightNumber = StraightNumber(input);
                char[] reverseNumber = ReverseNumber(input);

                PalindromeNumber(straightNumber, reverseNumber);

                input = Console.ReadLine();
            }
        }

        static char[] StraightNumber(string straight)
        {
            char[] straightNumber = straight.ToCharArray();

            for (int digit = 0; digit < straight.Length; digit++)
            {
                straightNumber[digit] = straight[digit];
            }

            return straightNumber;
        }

        static char[] ReverseNumber(string reverse)
        {
            char[] reverseNumber = reverse.ToCharArray();

            for (int digit = 0; digit < reverse.Length; digit++)
            {
                reverseNumber[digit] = reverse[reverse.Length - 1 - digit];
            }

            return reverseNumber;
        }

        static void PalindromeNumber(char[] straightNumber, char[] reverseNumber)
        {
            bool isValid = false;

            for (int i = 0; i < straightNumber.Length; i++)
            {
                if (straightNumber[i] == reverseNumber[i])
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                    break;
                }
            }


            Console.WriteLine(isValid.ToString().ToLower());
        }
    }
}
