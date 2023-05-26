using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] randomStrings = Console.ReadLine().Split(" ");

            for (int index = 0; index < randomStrings.Length / 2; index++)
            {
                string firstIndex = randomStrings[index];
                randomStrings[index] = randomStrings[randomStrings.Length - 1 - index];
                randomStrings[randomStrings.Length - 1 - index] = firstIndex;
            }

            Console.WriteLine(string.Join(' ', randomStrings));
        }
    }
}
