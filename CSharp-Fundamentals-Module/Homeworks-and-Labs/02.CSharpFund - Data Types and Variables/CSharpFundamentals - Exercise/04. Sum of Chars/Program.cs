using System;
/*
 12
S
o
f
t
U
n
i
R
u
l
z
z

 */
namespace _04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte numberOfLines = byte.Parse(Console.ReadLine());

            int totalSum = 0;
            for (int charPerIteration = 1; charPerIteration <= numberOfLines; charPerIteration++)
            {
                char latinCharacters = char.Parse(Console.ReadLine());
                totalSum += latinCharacters;
            }

            Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
}
