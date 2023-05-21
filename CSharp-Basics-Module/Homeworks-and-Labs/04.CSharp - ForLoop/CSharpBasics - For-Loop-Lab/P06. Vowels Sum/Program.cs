using System;

namespace P06._Vowels_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            // Every character can be taken by its index
            // Character indexes are from 0 to Length - 1
            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char currentCharacted = text[i];
                
                switch (currentCharacted)
                {
                    case 'a':
                        sum += 1;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
