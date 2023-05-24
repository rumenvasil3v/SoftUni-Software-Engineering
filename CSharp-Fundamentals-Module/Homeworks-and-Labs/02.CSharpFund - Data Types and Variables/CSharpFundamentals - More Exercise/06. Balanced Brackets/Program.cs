using System;
/*
 6
(
)
(
)
(
123
 */
namespace _06._Balanced_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());

            int pairBrackets = 0;
            bool isValid = true;

            for (int i = 1; i <= n; i++)
            {
                string randomString = Console.ReadLine();

                if (randomString == "((" || randomString == "))")
                {
                    isValid = false;
                    break;
                }

                if (randomString == "(")
                {
                    pairBrackets++;
                }
                else if (randomString == ")")
                {
                    pairBrackets++;               
                }

                if (pairBrackets % 2 == 0 && randomString == "(")
                {
                    isValid = false;
                    break;
                }
                if (pairBrackets % 2 == 1 && randomString == ")")
                {
                    isValid = false;
                    break;
                }
            }

            if (pairBrackets % 2 == 1)
            {
                isValid = false;
            }

            if (isValid)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
