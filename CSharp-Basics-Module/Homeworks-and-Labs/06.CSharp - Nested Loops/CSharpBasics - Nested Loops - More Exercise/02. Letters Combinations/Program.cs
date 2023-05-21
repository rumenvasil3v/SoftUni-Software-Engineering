using System;

namespace _02._Letters_Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char startLetter = char.Parse(Console.ReadLine());
            char endLetter = char.Parse(Console.ReadLine());
            char skipLetter = char.Parse(Console.ReadLine());
            int combinations = 0;

            for (char i = startLetter; i <= endLetter; i++)
            {
                for (char j = startLetter; j <= endLetter; j++)
                {
                    for (char s = startLetter; s <= endLetter; s++)
                    {
                        if (s == skipLetter || j == skipLetter || i == skipLetter)
                        {
                            continue;
                        }
                        else
                        {
                            Console.Write($"{i}{j}{s} ");
                            combinations++;
                        }
                    }
                }
            }
            Console.WriteLine(combinations);
        }
    }
}
