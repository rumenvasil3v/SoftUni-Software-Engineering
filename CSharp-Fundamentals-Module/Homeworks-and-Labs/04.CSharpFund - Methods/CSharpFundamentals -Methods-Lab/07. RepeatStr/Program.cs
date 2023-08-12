using System;

namespace _07._RepeatStr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string randomString = Console.ReadLine();
            int repeatString = int.Parse(Console.ReadLine());

            string newString = NewString(randomString, repeatString);
            Console.WriteLine(newString);
        }

        static string NewString(string randomString, int repeatString)
        {
            string newString = string.Empty;
            for (int i = 1; i <= repeatString; i++)
            {
                newString += randomString;
            }

            return newString;
        }
    }
}
