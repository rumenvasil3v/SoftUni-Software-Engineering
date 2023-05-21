using System;

namespace _06._Vowels_Sum___exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int a = 1;
            int e = 2;
            int i = 3;
            int o = 4;
            int u = 5;

            int sum = 0;
            for (int character = 0; character < text.Length; character++)
            {
                char currentCharacter = text[character];

                if (currentCharacter == 'a')
                {
                    sum += a;
                }
                else if (currentCharacter == 'e')
                {
                    sum += e;
                }
                else if (currentCharacter == 'i')
                {
                    sum += i;
                }
                else if (currentCharacter == 'o')
                {
                    sum += o;
                }
                else if (currentCharacter == 'u')
                {
                    sum += u;
                } 
            }
            Console.WriteLine(sum);
        }
    }
}
