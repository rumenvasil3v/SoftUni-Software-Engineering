using System;
using System.Linq;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            int rules = 0;
            rules = ContainSixToTenCharacters(password, rules);
            rules = ConsistOnlyLettersAndDigits(password, rules);
            rules = ContainAtLeastTwoDigits(password, rules);

            PrintResult(rules);
        }

        static int ContainSixToTenCharacters(string password, int rules)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                rules++;
            }
            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            return rules;
        }

        static int ConsistOnlyLettersAndDigits(string password, int rules)
        {
            bool isTrue = false;
            char[] onlyLettersAndDigits = password.ToArray();
            for (int i = 0; i < password.Length; i++)
            {
                if (onlyLettersAndDigits[i] >= 48 && onlyLettersAndDigits[i] <= 57
                    || onlyLettersAndDigits[i] >= 65 && onlyLettersAndDigits[i] <= 90
                    || onlyLettersAndDigits[i] >= 97 && onlyLettersAndDigits[i] <= 122)
                {
                    isTrue = true;
                }
                else
                {
                    isTrue = false;
                    break;
                }
            }

            if (isTrue)
            {
                rules++;
            }
            else
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            return rules;
        }

        static int ContainAtLeastTwoDigits(string password, int rules)
        {
            int digits = 0;
            char[] atLeastTwoDigits = password.ToArray();
            for (int i = 0; i < password.Length; i++)
            {
                if (atLeastTwoDigits[i] >= 48 && atLeastTwoDigits[i] <= 57)
                {
                    digits++;
                }
            }

            if (digits >= 2)
            {
                rules++;
            }
            else
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            return rules;
        }

        static void PrintResult(int rules)
        {
            if (rules == 3)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
