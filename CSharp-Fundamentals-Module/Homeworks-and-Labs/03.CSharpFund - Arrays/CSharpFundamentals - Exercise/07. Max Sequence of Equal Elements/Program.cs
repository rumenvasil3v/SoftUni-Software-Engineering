using System;
using System.Linq;
/*
4 4 4 4
2 1 1 2 3 3 2 2 2 1 
1 1 1 2 3 1 3 3
0 1 1 5 2 2 6 3 3
*/
namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sequence = Console
                .ReadLine()
                .Split(' ');
                

            string currentSequence = string.Empty;

            string longestSequence = string.Empty;

            string leftOne;

            int current = 0;

            int longest = 0;

            for (int i = sequence.Length - 1; i > 0; i--)
            {
                if (sequence[i] == sequence[i - 1])
                {
                    currentSequence += sequence[i] + " ";
                    current++;
                    continue;
                }
                else
                {
                    currentSequence += sequence[i] + " ";
                    current++;
                }

                if (sequence[i] != sequence[i - 1])
                {
                    if (current > longest)
                    {
                        longestSequence = currentSequence;
                        longest = current;
                    }

                    if (current == longest)
                    {
                        leftOne = currentSequence;
                        longestSequence = leftOne;
                    }

                    currentSequence = string.Empty;
                    current = 0;

                    if (i - 1 == 0)
                    {
                        current++;
                        currentSequence += sequence[i - 1];
                        if (current == longest)
                        {
                            leftOne = currentSequence;
                            longestSequence = leftOne;
                        }
                    }
                }
            }

            if (sequence[0] == sequence[1])
            {
                currentSequence += sequence[0];
                current++;
                if (current > longest)
                {
                    longestSequence = currentSequence;
                }
                else if (current == longest)
                {
                    leftOne = currentSequence;
                    longestSequence = leftOne;
                }
            }

            Console.WriteLine(longestSequence);
        }
    }
}