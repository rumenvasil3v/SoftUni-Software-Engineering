using System;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string randomString = Console.ReadLine();

            NumberOfVowels(randomString);
        }

        static void NumberOfVowels(string randomString)
        {
            char[] vowels = new char[randomString.Length];
            int numberOfVowels = 0;

            for (int i = 0; i < randomString.Length; i++)
            {
                vowels[i] = randomString[i];

                if (vowels[i] == 'a' || vowels[i] == 'e' || vowels[i] == 'o'
                    || vowels[i] == 'i' || vowels[i] == 'u'
                    || vowels[i] == 'A' || vowels[i] == 'E'
                    || vowels[i] == 'O' || vowels[i] == 'U'
                    || vowels[i] == 'I')
                {
                    numberOfVowels++;
                }
            }

            Console.WriteLine(numberOfVowels);
        }
    }
}
