using System;
using System.Linq;

namespace _04._Password_Validator___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isValid = false;

            RuleForCharacters(password, isValid);
        }

        static void RuleForCharacters(string password, bool isValid)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                isValid = true;
            }
            else
            {
                isValid = false;
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            ContainLettersDigits(password, isValid);
        }

        static void ContainLettersDigits(string password, bool isValid)
        {
            char[] lettersAndDigits = password.ToArray();
            for (int i = 0; i < password.Length; i++)
            {
                if (lettersAndDigits[i] >= 48 && lettersAndDigits[i] <= 57
                    || lettersAndDigits[i] >= 65 && lettersAndDigits[i] <= 90
                    || lettersAndDigits[i] >= 97 && lettersAndDigits[i] <= 122)
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                    break;
                }
            }

            if (!isValid)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            ContainTwoDigits(password, isValid);
        }

        static void ContainTwoDigits(string password, bool isValid)
        {
            char[] twoDigits = password.ToArray();
            int digits = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (twoDigits[i] >= 48 && twoDigits[i] <= 57)
                {
                    digits++;
                }
            }

            if (digits >= 2)
            {
                isValid = true;
            }
            else
            {
                isValid = false;
                Console.WriteLine("Password must have at least 2 digits");
            }

            PrintResult(password, isValid);
        }

        static void PrintResult(string password, bool isValid)
        {
            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}

